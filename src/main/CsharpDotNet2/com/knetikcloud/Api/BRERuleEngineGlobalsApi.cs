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
    public interface IBRERuleEngineGlobalsApi
    {
        /// <summary>
        /// Create a global definition Once created you can then use in a custom rule. Note that global definitions cannot be modified or deleted if in use. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="breGlobalResource">The BRE global resource object</param>
        /// <returns>BreGlobalResource</returns>
        BreGlobalResource CreateBREGlobal (BreGlobalResource breGlobalResource);
        /// <summary>
        /// Delete a global May fail if there are existing rules against it. Cannot delete core globals. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="id">The id of the global definition</param>
        /// <returns></returns>
        void DeleteBREGlobal (string id);
        /// <summary>
        /// Get a single global definition &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_USER
        /// </summary>
        /// <param name="id">The id of the global definition</param>
        /// <returns>BreGlobalResource</returns>
        BreGlobalResource GetBREGlobal (string id);
        /// <summary>
        /// List global definitions &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_USER
        /// </summary>
        /// <param name="filterSystem">Filter for globals that are system globals when true, or not when false. Leave off for both mixed</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceBreGlobalResource</returns>
        PageResourceBreGlobalResource GetBREGlobals (bool? filterSystem, int? size, int? page);
        /// <summary>
        /// Update a global definition May fail if new parameters mismatch requirements of existing rules. Cannot update core globals. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="id">The id of the global definition</param>
        /// <param name="breGlobalResource">The BRE global resource object</param>
        /// <returns>BreGlobalResource</returns>
        BreGlobalResource UpdateBREGlobal (string id, BreGlobalResource breGlobalResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BRERuleEngineGlobalsApi : IBRERuleEngineGlobalsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineGlobalsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BRERuleEngineGlobalsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineGlobalsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BRERuleEngineGlobalsApi(String basePath)
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
        /// Create a global definition Once created you can then use in a custom rule. Note that global definitions cannot be modified or deleted if in use. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="breGlobalResource">The BRE global resource object</param> 
        /// <returns>BreGlobalResource</returns>            
        public BreGlobalResource CreateBREGlobal (BreGlobalResource breGlobalResource)
        {
            
    
            var path = "/bre/globals/definitions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breGlobalResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBREGlobal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBREGlobal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreGlobalResource) ApiClient.Deserialize(response.Content, typeof(BreGlobalResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a global May fail if there are existing rules against it. Cannot delete core globals. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="id">The id of the global definition</param> 
        /// <returns></returns>            
        public void DeleteBREGlobal (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBREGlobal");
            
    
            var path = "/bre/globals/definitions/{id}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBREGlobal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBREGlobal: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single global definition &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_USER
        /// </summary>
        /// <param name="id">The id of the global definition</param> 
        /// <returns>BreGlobalResource</returns>            
        public BreGlobalResource GetBREGlobal (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBREGlobal");
            
    
            var path = "/bre/globals/definitions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREGlobal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREGlobal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreGlobalResource) ApiClient.Deserialize(response.Content, typeof(BreGlobalResource), response.Headers);
        }
    
        /// <summary>
        /// List global definitions &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_USER
        /// </summary>
        /// <param name="filterSystem">Filter for globals that are system globals when true, or not when false. Leave off for both mixed</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceBreGlobalResource</returns>            
        public PageResourceBreGlobalResource GetBREGlobals (bool? filterSystem, int? size, int? page)
        {
            
    
            var path = "/bre/globals/definitions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSystem != null) queryParams.Add("filter_system", ApiClient.ParameterToString(filterSystem)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREGlobals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREGlobals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBreGlobalResource) ApiClient.Deserialize(response.Content, typeof(PageResourceBreGlobalResource), response.Headers);
        }
    
        /// <summary>
        /// Update a global definition May fail if new parameters mismatch requirements of existing rules. Cannot update core globals. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_GLOBALS_ADMIN
        /// </summary>
        /// <param name="id">The id of the global definition</param> 
        /// <param name="breGlobalResource">The BRE global resource object</param> 
        /// <returns>BreGlobalResource</returns>            
        public BreGlobalResource UpdateBREGlobal (string id, BreGlobalResource breGlobalResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBREGlobal");
            
    
            var path = "/bre/globals/definitions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breGlobalResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBREGlobal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBREGlobal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreGlobalResource) ApiClient.Deserialize(response.Content, typeof(BreGlobalResource), response.Headers);
        }
    
    }
}
