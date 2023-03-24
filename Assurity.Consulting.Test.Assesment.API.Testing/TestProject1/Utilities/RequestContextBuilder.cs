using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using RestSharp;

namespace AssurityConsultingTestAssessment.Utilities
{
    public class RequestContextBuilder : RequestHelper
    {
        private readonly RequestHeaderBuilder _restHeaderBuilder;  
        public RequestContextBuilder()
        {
            this._restHeaderBuilder = new RequestHeaderBuilder();   
            
        }

        /// <summary>
        /// Get function to call teh Api
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="resource"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public RestResponse GetRequest(string baseUrl, string resource,
           IEnumerable<KeyValuePair<string, string>> headers = null)
        {
           // var client = ConfigureRestClient(host);
            var request = new RestRequest(resource, Method.Get);
            request = SetRequestHeadersWithoutAuth(request);
            LogRequestDetails("GET", baseUrl + resource);
            return Execute(ConfigureRestClient(baseUrl), request);
        }


        /// <summary>
        /// Logs the Request on the console for debugging 
        /// </summary>
        /// <param name="apiMethod"></param>
        /// <param name="URL"></param>
        /// <param name="body"></param>
        /// <param name="header"></param>
        private void LogRequestDetails(string apiMethod, string URL, string body = null, string header = null)
        {
            Console.WriteLine("");
            Console.WriteLine("Outgoing Message ----> " + apiMethod + " : " + URL);
            if (header != null)
            {
                Console.WriteLine("Message Body : " + body);
            }
            if (body != null)
            {
                Console.WriteLine("Message Body : " + body);
            }
            Console.WriteLine("");
        }

    }
}
