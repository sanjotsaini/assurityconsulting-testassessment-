using AssurityConsultingTestAssessment.ApiRequests;
using AssurityConsultingTestAssessment.Models;
using AssurityConsultingTestAssessment.Utilities;
using FluentAssertions;
using FluentAssertions.Equivalency;
using Newtonsoft.Json;
using NUnit.Framework.Internal;
using System;
using System.Linq;
using System.Security.Cryptography;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AssurityConsultingTestAssessment.Steps
{
    [Binding]
    public class SandboxCategoriesStepDefinitions : TestBase
    {
        private readonly GetCategoriesRequest _getCategoriesRequest;
        private readonly ResponseHelper _responseHelper;       
        public SandboxCategoriesStepDefinitions(ApiScenarioContextKeys apiScenarioContextKeys) :base(apiScenarioContextKeys)
        {         
            _getCategoriesRequest = new GetCategoriesRequest();
            this._apiScenarioContextKeys = apiScenarioContextKeys;
            this._responseHelper = new  ResponseHelper();
        }

        [When(@"I send the request to get categories with ""([^""]*)"" and ""([^""]*)"" to Sand box")]
        public void WhenISendTheRequestToGetCategoriesWithAndToSandBox(string id, string catolguue)
        {
            //Sending the Request and storing the response in api scenario context
             _apiScenarioContextKeys.restResponse = _getCategoriesRequest.getCategories(id, catolguue);
        }
        
        [Then(@"Verify the response status is succesfull")]
        public void ThenVerifyTheResponseStatusIsSuccesfull()
        {
            //verifying the response status
            _apiScenarioContextKeys.restResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

        [Then(@"The response body contains following fields")]
        public void ThenTheResponseBodyContainsFollowingFields(Table table)

        {      
            //Creating the instance of data table to use the values from feature file in steps to verify the response 
            var fields = table.CreateInstance<VerificationFields>();
            //Deserializing the api response content for verfication
            var responseBody = JsonConvert.DeserializeObject<CategoriesDeatils>(_apiScenarioContextKeys.restResponse.Content); 
            // Verifying the result with Jtoken method using Json Path 
            _responseHelper.GetValueFromResponseByGivenJsonPath(_apiScenarioContextKeys.restResponse.Content, "$.Name").ToString().Should().Be(fields.Name);
            _responseHelper.GetValueFromResponseByGivenJsonPath(_apiScenarioContextKeys.restResponse.Content, "$.CanRelist").ToString().Should().Be(fields.CanRelist);
            _responseHelper.GetValueFromResponseByGivenJsonPath(_apiScenarioContextKeys.restResponse.Content, "$.Promotions[1].Description").ToString().Should().Be(fields.PromotionDescription);
            // from teh response verifies where the Name is gallery check the description is Good position in category
            foreach (var promotion in responseBody.Promotions) {             
                if(promotion.Name == "Gallery")
                {
                    promotion.Description.Should().ContainEquivalentOf(fields.PromotionDescription);
                }            
            }
        }

        [Then(@"Verify the response status is Bad Request")]
        public void ThenVerifyTheResponseStatusIsBadRequest()
        {
            _apiScenarioContextKeys.restResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Then(@"The error message is ""([^""]*)""")]
        public void ThenTheErrorMessageIs(string errorMessage)
        {
            _responseHelper.GetValueFromResponseByGivenJsonPath(_apiScenarioContextKeys.restResponse.Content, "$.ErrorDescription").ToString().Should().Be(errorMessage);
        }

    }
}
