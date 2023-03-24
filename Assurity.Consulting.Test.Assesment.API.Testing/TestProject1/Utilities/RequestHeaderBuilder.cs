using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.Utilities
{
    public class RequestHeaderBuilder
    {
        /// <summary>
        /// This Helps to add teh Header to the Request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestRequest SetRequestHeadersWithoutAuth(RestRequest request)
        {
            var restRequest = request;
            return restRequest;
        }
    }
}
