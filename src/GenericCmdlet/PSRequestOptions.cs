using System;
using System.Collections.Generic;
using System.Text;

namespace Intersight.PowerShell
{
    public class PSRequestOptions
    {
        public PSRequestOptions()
        {
            QueryParameters = new Dictionary<string, string>();
            PathParameters = new Dictionary<string, string>();
            HeaderParameters = new Dictionary<string, string>();
            ContentType = "application/json";
        }

        internal string Method { get; set; }

        internal string BasePath { get; set; }
        internal string Path { get; set; }
        internal Dictionary<string, string> QueryParameters { get; set; }

        internal Dictionary<string, string> PathParameters { get; set; }

        internal Dictionary<string, string> HeaderParameters { get; set; }

        internal object RequestBody { get; set; }

        internal string RequestData { get; set; } = string.Empty;

        internal string ContentType { get; set; }
    }
}
