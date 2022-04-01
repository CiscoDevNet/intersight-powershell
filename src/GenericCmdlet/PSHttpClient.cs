using Intersight.Client;
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
            var httpSignConf = configuration.HttpSigningConfiguration;
            HttpSigningAuthConfig = new HttpSigningAuth()
            {
                KeyId = httpSignConf.KeyId,
                KeyFilePath = httpSignConf.KeyFilePath,
                HttpSigningHeader = httpSignConf.HttpSigningHeader,
                KeyPassPhrase = httpSignConf.KeyPassPhrase,
                SignatureValidityPeriod = httpSignConf.SignatureValidityPeriod,
                SigningAlgorithm = httpSignConf.SigningAlgorithm
            };
        }

        public string Uri { get; set; }

        public HttpSigningAuth HttpSigningAuthConfig { get; set; }

        public string Execute(PSRequestOptions requestOption)
        {
            try
            {
                string responseBody = string.Empty;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GetUrl(requestOption));
                httpWebRequest.Method = requestOption.Method;
                httpWebRequest.ContentType = requestOption.ContentType;

                var signedHeaders = HttpSigningAuthConfig.GetHttpSignedHeader(requestOption);
                foreach (var item in signedHeaders)
                {
                    httpWebRequest.Headers.Add(item.Key, item.Value);
                }

                if (!string.IsNullOrEmpty(requestOption.RequestData))
                {
                    var bytes = GetBytes(requestOption.RequestData);
                    httpWebRequest.ContentLength = bytes.Length;
                    Stream stream = httpWebRequest.GetRequestStream();
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();

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

        private string GetUrl(PSRequestOptions requestOption)
        {
            var result = string.Empty;
            UriBuilder uri = new UriBuilder(requestOption.BasePath);
            var path = requestOption.Path;

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
                    queryParam.Add(HttpUtility.UrlEncode(item.Key), item.Value);
                }
                uri.Query = queryParam.ToString().Replace("+", "%20");
            }
            return uri.Uri.ToString();
        }
    }
}
