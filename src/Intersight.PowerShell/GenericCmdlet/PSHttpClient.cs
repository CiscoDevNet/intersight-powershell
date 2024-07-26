using Intersight.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Intersight.PowerShell
{
    public class PSHttpClient
    {
        public PSHttpClient(Configuration configuration)
        {
            ContentType = "application/json";
        }

        public string Uri { get; set; }

        public string Method { get; set; }

        public string Path { get; set; }

        public string BasePath { get; set; }

        public string ContentType { get; set; }

        public string Execute(RequestOptions requestOption)
        {
            try
            {
                string responseBody = string.Empty;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GetUrl(requestOption));
                httpWebRequest.Method = Method;
                httpWebRequest.ContentType = ContentType;

                var signedHeaders = CmdletBase.Config.HttpSigningConfiguration.GetHttpSignedHeader(BasePath, Method, Path, requestOption);
                foreach (var item in signedHeaders)
                {
                    httpWebRequest.Headers.Add(item.Key, item.Value);
                }

                if (requestOption.Data != null)
                {
                    var serializerSettings = new JsonSerializerSettings();
                    var requestBody = JsonConvert.SerializeObject(requestOption.Data, serializerSettings);
                    var bytes = GetBytes(requestBody);
                    httpWebRequest.ContentLength = bytes.Length;
                    Stream stream = httpWebRequest.GetRequestStream();
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();

                }

                if (CmdletBase.SkipCertificateCheck)
                {
                    httpWebRequest.ServerCertificateValidationCallback = delegate { return true; };
                }

                if (CmdletBase.Config.Proxy != null)
                {
                    httpWebRequest.Proxy = CmdletBase.Config.Proxy;
                }

                HttpWebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = webResponse.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                responseBody = reader.ReadToEnd();

                if (!((webResponse.StatusCode == HttpStatusCode.OK) ||
                    (webResponse.StatusCode == HttpStatusCode.Created) ||
                    (webResponse.StatusCode == HttpStatusCode.Accepted) ||
                    (webResponse.StatusCode == HttpStatusCode.NoContent) ||
                    (webResponse.StatusCode == HttpStatusCode.AlreadyReported) ||
                    (webResponse.StatusCode == HttpStatusCode.NonAuthoritativeInformation) ||
                    (webResponse.StatusCode == HttpStatusCode.PartialContent) ||
                    (webResponse.StatusCode == HttpStatusCode.ResetContent)))
                {
                    throw new Exception(string.Format("{0} : {1}", webResponse.StatusCode, responseBody));
                }

                return responseBody;
            }
            catch (Exception ex)
            {
                WebException webExp = ex as WebException;
                if (webExp != null)
                {
                    string reqStr = string.Empty;
                    using (StreamReader sr = new StreamReader(webExp.Response.GetResponseStream()))
                    {
                        reqStr = sr.ReadToEnd();
                        throw new Exception(string.Format("{0}\n{1}", ex.Message, reqStr));
                    }
                }
                throw ex;
            }
        }

        private byte[] GetBytes(string str)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        private string GetUrl(RequestOptions requestOption)
        {
            var result = string.Empty;
            UriBuilder uri = new UriBuilder(BasePath);
            var path = Path;

            foreach (var item in requestOption.PathParameters)
            {
                var tempPath = path.Replace(item.Key, "0");
                path = string.Format(tempPath, item.Value);
            }

            uri.Path = path;
            var queryString = string.Empty;
            if (requestOption.QueryParameters.Count > 0)
            {
                var queryParam = HttpUtility.ParseQueryString(string.Empty);
                foreach (var item in requestOption.QueryParameters)
                {
                    if (item.Value.Count > 1)
                    { // array
                        foreach (var value in item.Value)
                        {
                            queryParam.Add(HttpUtility.UrlEncode(item.Key) + "[]", value);
                        }
                    }
                    else
                    {
                        queryParam.Add(HttpUtility.UrlEncode(item.Key), item.Value[0]);
                    }
                }
                uri.Query = queryParam.ToString().Replace("+", "%20");
            }
            return uri.Uri.ToString();
        }
    }
}
