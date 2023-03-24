using AssurityConsultingTestAssessment.Utilities;
using NUnit.Framework.Internal;
using RestSharp;
using AssurityConsultingTestAssessment.ApiEndpointBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.ApiRequests
{

    /// <summary>
    /// This class is to create the request for any endpoint. Here whole request is builded and used in step defination file 
    /// </summary>
     class GetCategoriesRequest : CategoriesApiEndpointBuilder
    {
        private readonly RequestContextBuilder _requestContextBuilder;
    

        public GetCategoriesRequest() 
        {            
            _requestContextBuilder = new RequestContextBuilder();
        }

        public RestResponse getCategories( string id, string catlogue)
        {
            return _requestContextBuilder.GetRequest(SettingsValues.GetSettingsValues("BaseURL"), GetCategoriesUri(id, catlogue));
        }
    }
}
