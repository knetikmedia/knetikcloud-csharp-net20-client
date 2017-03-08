using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportingUsageApi
    {
        /// <summary>
        /// Returns aggregated endpoint usage information by day 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUsageInfo</returns>
        PageResourceUsageInfo GetUsageByDay (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page);
        /// <summary>
        /// Returns aggregated endpoint usage information by hour 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUsageInfo</returns>
        PageResourceUsageInfo GetUsageByHour (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page);
        /// <summary>
        /// Returns aggregated endpoint usage information by minute 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUsageInfo</returns>
        PageResourceUsageInfo GetUsageByMinute (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page);
        /// <summary>
        /// Returns aggregated endpoint usage information by month 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUsageInfo</returns>
        PageResourceUsageInfo GetUsageByMonth (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page);
        /// <summary>
        /// Returns aggregated endpoint usage information by year 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <param name="combineEndpoints">Whether to combine counts from different endpoints. Removes the url and method from the result object</param>
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param>
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUsageInfo</returns>
        PageResourceUsageInfo GetUsageByYear (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page);
        /// <summary>
        /// Returns list of endpoints called (method and url) 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param>
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetUsageEndpoints (long? startDate, long? endDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportingUsageApi : IReportingUsageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportingUsageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingUsageApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Returns aggregated endpoint usage information by day 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param> 
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param> 
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUsageInfo</returns>            
        public PageResourceUsageInfo GetUsageByDay (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageByDay");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageByDay");
            
    
            var path = "/reporting/usage/day";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (combineEndpoints != null) queryParams.Add("combine_endpoints", ApiClient.ParameterToString(combineEndpoints)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByDay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByDay: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUsageInfo) ApiClient.Deserialize(response.Content, typeof(PageResourceUsageInfo), response.Headers);
        }
    
        /// <summary>
        /// Returns aggregated endpoint usage information by hour 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param> 
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param> 
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUsageInfo</returns>            
        public PageResourceUsageInfo GetUsageByHour (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageByHour");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageByHour");
            
    
            var path = "/reporting/usage/hour";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (combineEndpoints != null) queryParams.Add("combine_endpoints", ApiClient.ParameterToString(combineEndpoints)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByHour: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByHour: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUsageInfo) ApiClient.Deserialize(response.Content, typeof(PageResourceUsageInfo), response.Headers);
        }
    
        /// <summary>
        /// Returns aggregated endpoint usage information by minute 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param> 
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param> 
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUsageInfo</returns>            
        public PageResourceUsageInfo GetUsageByMinute (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageByMinute");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageByMinute");
            
    
            var path = "/reporting/usage/minute";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (combineEndpoints != null) queryParams.Add("combine_endpoints", ApiClient.ParameterToString(combineEndpoints)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByMinute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByMinute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUsageInfo) ApiClient.Deserialize(response.Content, typeof(PageResourceUsageInfo), response.Headers);
        }
    
        /// <summary>
        /// Returns aggregated endpoint usage information by month 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <param name="combineEndpoints">Whether to combine counts from different endpoint. Removes the url and method from the result object</param> 
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param> 
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUsageInfo</returns>            
        public PageResourceUsageInfo GetUsageByMonth (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageByMonth");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageByMonth");
            
    
            var path = "/reporting/usage/month";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (combineEndpoints != null) queryParams.Add("combine_endpoints", ApiClient.ParameterToString(combineEndpoints)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByMonth: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByMonth: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUsageInfo) ApiClient.Deserialize(response.Content, typeof(PageResourceUsageInfo), response.Headers);
        }
    
        /// <summary>
        /// Returns aggregated endpoint usage information by year 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <param name="combineEndpoints">Whether to combine counts from different endpoints. Removes the url and method from the result object</param> 
        /// <param name="method">Filter for a certain endpoint method.  Must include url as well to work</param> 
        /// <param name="url">Filter for a certain endpoint.  Must include method as well to work</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUsageInfo</returns>            
        public PageResourceUsageInfo GetUsageByYear (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageByYear");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageByYear");
            
    
            var path = "/reporting/usage/year";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (combineEndpoints != null) queryParams.Add("combine_endpoints", ApiClient.ParameterToString(combineEndpoints)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByYear: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageByYear: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUsageInfo) ApiClient.Deserialize(response.Content, typeof(PageResourceUsageInfo), response.Headers);
        }
    
        /// <summary>
        /// Returns list of endpoints called (method and url) 
        /// </summary>
        /// <param name="startDate">The beginning of the range being requested, unix timestamp in seconds</param> 
        /// <param name="endDate">The ending of the range being requested, unix timestamp in seconds</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetUsageEndpoints (long? startDate, long? endDate)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling GetUsageEndpoints");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling GetUsageEndpoints");
            
    
            var path = "/reporting/usage/endpoints";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageEndpoints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsageEndpoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
    }
}
