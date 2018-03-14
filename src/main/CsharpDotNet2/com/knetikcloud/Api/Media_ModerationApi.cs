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
    public interface IMedia_ModerationApi
    {
        /// <summary>
        /// Add a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="flagResource">The flag resource object</param>
        /// <returns>FlagResource</returns>
        FlagResource AddFlag (FlagResource flagResource);
        /// <summary>
        /// Delete a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN or owner
        /// </summary>
        /// <param name="contextName">The name of the context</param>
        /// <param name="contextId">The id of the context</param>
        /// <param name="userId">The id of the user</param>
        /// <returns></returns>
        void DeleteFlag (string contextName, string contextId, int? userId);
        /// <summary>
        /// Returns a page of flags &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN or owner
        /// </summary>
        /// <param name="filterContext">Filter by flag context</param>
        /// <param name="filterContextId">Filter by flag context ID</param>
        /// <param name="filterUserId">Filter by user ID</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceFlagResource</returns>
        PageResourceFlagResource GetFlags (string filterContext, string filterContextId, int? filterUserId, int? size, int? page);
        /// <summary>
        /// Get a flag report &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
        /// </summary>
        /// <param name="id">The flag report id</param>
        /// <returns>FlagReportResource</returns>
        FlagReportResource GetModerationReport (long? id);
        /// <summary>
        /// Returns a page of flag reports Context can be either a free-form string or a pre-defined context name. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
        /// </summary>
        /// <param name="excludeResolved">Ignore resolved context</param>
        /// <param name="filterContext">Filter by moderation context</param>
        /// <param name="filterContextId">Filter by moderation context ID</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceFlagReportResource</returns>
        PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, string filterContextId, int? size, int? page, string order);
        /// <summary>
        /// Update a flag report Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of &#39;banned&#39; you will need to pass the reason. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
        /// </summary>
        /// <param name="id">The flag report id</param>
        /// <param name="flagReportResource">The new flag report</param>
        /// <returns></returns>
        void UpdateModerationReport (long? id, FlagReportResource flagReportResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Media_ModerationApi : IMedia_ModerationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Media_ModerationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Media_ModerationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Media_ModerationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Media_ModerationApi(String basePath)
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
        /// Add a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="flagResource">The flag resource object</param> 
        /// <returns>FlagResource</returns>            
        public FlagResource AddFlag (FlagResource flagResource)
        {
            
    
            var path = "/moderation/flags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(flagResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlagResource) ApiClient.Deserialize(response.Content, typeof(FlagResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN or owner
        /// </summary>
        /// <param name="contextName">The name of the context</param> 
        /// <param name="contextId">The id of the context</param> 
        /// <param name="userId">The id of the user</param> 
        /// <returns></returns>            
        public void DeleteFlag (string contextName, string contextId, int? userId)
        {
            
    
            var path = "/moderation/flags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contextName != null) queryParams.Add("context_name", ApiClient.ParameterToString(contextName)); // query parameter
 if (contextId != null) queryParams.Add("context_id", ApiClient.ParameterToString(contextId)); // query parameter
 if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns a page of flags &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN or owner
        /// </summary>
        /// <param name="filterContext">Filter by flag context</param> 
        /// <param name="filterContextId">Filter by flag context ID</param> 
        /// <param name="filterUserId">Filter by user ID</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceFlagResource</returns>            
        public PageResourceFlagResource GetFlags (string filterContext, string filterContextId, int? filterUserId, int? size, int? page)
        {
            
    
            var path = "/moderation/flags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterContext != null) queryParams.Add("filter_context", ApiClient.ParameterToString(filterContext)); // query parameter
 if (filterContextId != null) queryParams.Add("filter_context_id", ApiClient.ParameterToString(filterContextId)); // query parameter
 if (filterUserId != null) queryParams.Add("filter_user_id", ApiClient.ParameterToString(filterUserId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFlags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceFlagResource) ApiClient.Deserialize(response.Content, typeof(PageResourceFlagResource), response.Headers);
        }
    
        /// <summary>
        /// Get a flag report &lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlagReportResource) ApiClient.Deserialize(response.Content, typeof(FlagReportResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of flag reports Context can be either a free-form string or a pre-defined context name. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
        /// </summary>
        /// <param name="excludeResolved">Ignore resolved context</param> 
        /// <param name="filterContext">Filter by moderation context</param> 
        /// <param name="filterContextId">Filter by moderation context ID</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceFlagReportResource</returns>            
        public PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, string filterContextId, int? size, int? page, string order)
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
 if (filterContextId != null) queryParams.Add("filter_context_id", ApiClient.ParameterToString(filterContextId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetModerationReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceFlagReportResource) ApiClient.Deserialize(response.Content, typeof(PageResourceFlagReportResource), response.Headers);
        }
    
        /// <summary>
        /// Update a flag report Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of &#39;banned&#39; you will need to pass the reason. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MODERATION_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
