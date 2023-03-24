using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.Utilities
{
    public class ResponseHelper
    {
        /// <summary>
        /// Helps to find the value from json response by using the path of json response
        /// </summary>
        /// <param name="responseContent"></param>
        /// <param name="jsonPath"></param>
        /// <returns></returns>
        public JToken GetValueFromResponseByGivenJsonPath(string responseContent, string jsonPath)
        {
            try
            {
                var responseObject = GetResponseInDeserializedJsonObject(responseContent);
                return responseObject.SelectToken(jsonPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("--- Exception: Error while retrieving jsonpath ---");
                Console.WriteLine($"--- Stacktrace: {ex} ---");
                return null;
            }
        }

        /// <summary>
        /// Deserialize the json response
        /// </summary>
        /// <param name="responseContent"></param>
        /// <returns></returns>
        public JObject GetResponseInDeserializedJsonObject(string responseContent)
        {
            try
            {
                return JsonConvert.DeserializeObject<JObject>(responseContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("--- Exception: Error while deserializing response to JObject ---");
                Console.WriteLine($"--- Stacktrace: {ex} ---");
                return null;
            }
        }

        
       

     

      

       
    }
}
