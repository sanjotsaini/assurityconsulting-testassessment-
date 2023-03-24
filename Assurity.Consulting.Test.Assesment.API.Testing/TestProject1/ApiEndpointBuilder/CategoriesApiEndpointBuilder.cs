using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.ApiEndpointBuilder
{
    /// <summary>
    /// In this class Endpoint is built and use in Api Request to create the request
    /// </summary>
    public  class CategoriesApiEndpointBuilder : SettingsValues
    {
        protected String GetCategoriesUri(string id, string catlogue) => String.Format(GetSettingsValues("endpoint"), id, catlogue);
    }
}
