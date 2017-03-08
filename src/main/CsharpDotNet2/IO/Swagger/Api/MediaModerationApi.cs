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
    public interface IMediaModerationApi
    {
        /// <summary>
        /// Get a flag report 
        /// </summary>
        /// <param name="id">The flag report id</param>
        /// <returns>FlagReportResource</returns>
        FlagReportResource GetModerationReport (long? id);
        /// <summary>
        /// Returns a page of flag reports Context can be either a free-form string or a pre-defined context name
        /// </summary>
        /// <param name="excludeResolved">Ignore resolved context</param>
        /// <param name="filterContext">Filter by moderation context</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceFlagReportResource</returns>
        PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, int? size, int? page);
        /// <summary>
        /// Update a flag report Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of &#39;banned&#39; you will need to pass the reason.
        /// </summary>
        /// <param name="id">The flag report id</param>
        /// <param name="flagReportResource">The new flag report</param>
        /// <returns></returns>
        void UpdateModerationReport (long? id, FlagReportResource flagReportResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MediaModerationApi : IMediaModerationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaModerationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MediaModerationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaModerationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaModerationApi(String basePath)
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
        /// Get a flag report 
        /// </summary>
        /// <param name="id">The flag report id</param> 
        /// <returns>FlagReportResource</returns>            
        public FlagReportResource GetModerationReport (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetModerationReport");
            
    
            var path = "/moderation/reports/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlagReportResource) ApiClient.Deserialize(response.Content, typeof(FlagReportResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of flag reports Context can be either a free-form string or a pre-defined context name
        /// </summary>
        /// <param name="excludeResolved">Ignore resolved context</param> 
        /// <param name="filterContext">Filter by moderation context</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceFlagReportResource</returns>            
        public PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, int? size, int? page)
        {
            
    
            var path = "/moderation/reports";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (excludeResolved != null) queryParams.Add("exclude_resolved", ApiClient.ParameterToString(excludeResolved)); // query parameter
 if (filterContext != null) queryParams.Add("filter_context", ApiClient.ParameterToString(filterContext)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceFlagReportResource) ApiClient.Deserialize(response.Content, typeof(PageResourceFlagReportResource), response.Headers);
        }
    
        /// <summary>
        /// Update a flag report Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of &#39;banned&#39; you will need to pass the reason.
        /// </summary>
        /// <param name="id">The flag report id</param> 
        /// <param name="flagReportResource">The new flag report</param> 
        /// <returns></returns>            
        public void UpdateModerationReport (long? id, FlagReportResource flagReportResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateModerationReport");
            
    
            var path = "/moderation/reports/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(flagReportResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateModerationReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateModerationReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
