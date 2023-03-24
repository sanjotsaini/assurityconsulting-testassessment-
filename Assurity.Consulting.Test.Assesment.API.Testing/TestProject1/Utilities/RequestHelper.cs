using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.Utilities
{
    public class RequestHelper : RequestHeaderBuilder
    {
        /// <summary>
        /// This Methode intialise the Rest Cleint which helps to send the rest request
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public RestClient ConfigureRestClient(string baseUrl)
        {
            RestClient restClient = new RestClient(baseUrl);           
            return restClient;
        }


        /// <summary>
        /// This method helps to Execute the request and returns the respons in Rest Response
        /// </summary>
        /// <param name="restClient"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestResponse Execute(RestClient restClient, RestRequest request)
        {          
            return restClient.Execute(request);
        }
    }
}
