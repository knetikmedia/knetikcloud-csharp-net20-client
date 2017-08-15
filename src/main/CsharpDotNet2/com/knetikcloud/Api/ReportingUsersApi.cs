using System;
using System.Collections.Generic;
using RestSharp;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportingUsersApi
    {
        /// <summary>
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <param name="granularity">The time duration to aggregate by</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceAggregateCountResource</returns>
        PageResourceAggregateCountResource GetUserRegistrations (string granularity, long? startDate, long? endDate, int? size, int? page);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportingUsersApi : IReportingUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportingUsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingUsersApi(String basePath)
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
        /// Get user registration info Get user registration counts grouped by time range
        /// </summary>
        /// <param name="granularity">The time duration to aggregate by</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceAggregateCountResource</returns>            
        public PageResourceAggregateCountResource GetUserRegistrations (string granularity, long? startDate, long? endDate, int? size, int? page)
        {
            
    
            var path = "/reporting/users/registrations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (granularity != null) queryParams.Add("granularity", ApiClient.ParameterToString(granularity)); // query parameter
 if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRegistrations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRegistrations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceAggregateCountResource) ApiClient.Deserialize(response.Content, typeof(PageResourceAggregateCountResource), response.Headers);
        }
    
    }
}
