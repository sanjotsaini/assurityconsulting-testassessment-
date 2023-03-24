using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.Steps
{
    // This class is to declare rest client and rest reponse once and used multiple times 
    public class ApiScenarioContextKeys
    {
        public RestClient restClient;
        public RestResponse restResponse;
    }
}
