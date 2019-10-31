using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RESTAPIAutomation.Helpers
{
    public class RESTAPIHelper
    {
        public static RestClient restClient;
        public static RestRequest restRequest;
        public static string baseUrl = "http://api.zippopotam.us/";

        public static RestClient SetupURL(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            return restClient = new RestClient(baseUrl);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        public static RestRequest CreateRequestWithResource(string resource)
        {
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetRestResponse()
        {
            return restClient.Execute(restRequest);
        }
    }

}
