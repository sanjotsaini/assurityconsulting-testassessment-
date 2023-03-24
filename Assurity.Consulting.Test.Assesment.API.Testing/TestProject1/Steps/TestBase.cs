using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace AssurityConsultingTestAssessment.Steps
{
    public class TestBase
    {
        /*
         This base clas to use the response in another steps 
         */
        protected ApiScenarioContextKeys _apiScenarioContextKeys;
        public TestBase(ApiScenarioContextKeys apiScenarioContextKeys)
        {
            _apiScenarioContextKeys = apiScenarioContextKeys;
        }

    }
}
