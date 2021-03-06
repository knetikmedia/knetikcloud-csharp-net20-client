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
    public interface IRule_Engine_TriggersApi
    {
        /// <summary>
        /// Create a trigger Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="breTriggerResource">The BRE trigger resource object</param>
        /// <returns>BreTriggerResource</returns>
        BreTriggerResource CreateBRETrigger (BreTriggerResource breTriggerResource);
        /// <summary>
        /// Delete a trigger May fail if there are existing rules against it. Cannot delete core triggers. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="eventName">The trigger event name</param>
        /// <returns></returns>
        void DeleteBRETrigger (string eventName);
        /// <summary>
        /// Get a single trigger &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_USER
        /// </summary>
        /// <param name="eventName">The trigger event name</param>
        /// <returns>BreTriggerResource</returns>
        BreTriggerResource GetBRETrigger (string eventName);
        /// <summary>
        /// List triggers &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_USER
        /// </summary>
        /// <param name="filterSystem">Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed</param>
        /// <param name="filterCategory">Filter for triggers that are within a specific category</param>
        /// <param name="filterTags">Filter for triggers that have all of the given tags (comma separated list)</param>
        /// <param name="filterName">Filter for triggers that have names containing the given string</param>
        /// <param name="filterSearch">Filter for triggers containing the given words somewhere within name, description and tags</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceBreTriggerResource</returns>
        PageResourceBreTriggerResource GetBRETriggers (bool? filterSystem, string filterCategory, string filterTags, string filterName, string filterSearch, int? size, int? page);
        /// <summary>
        /// Update a trigger May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="eventName">The trigger event name</param>
        /// <param name="breTriggerResource">The BRE trigger resource object</param>
        /// <returns>BreTriggerResource</returns>
        BreTriggerResource UpdateBRETrigger (string eventName, BreTriggerResource breTriggerResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Rule_Engine_TriggersApi : IRule_Engine_TriggersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_TriggersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Rule_Engine_TriggersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_TriggersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Rule_Engine_TriggersApi(String basePath)
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
        /// Create a trigger Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="breTriggerResource">The BRE trigger resource object</param> 
        /// <returns>BreTriggerResource</returns>            
        public BreTriggerResource CreateBRETrigger (BreTriggerResource breTriggerResource)
        {
            
    
            var path = "/bre/triggers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breTriggerResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRETrigger: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRETrigger: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreTriggerResource) ApiClient.Deserialize(response.Content, typeof(BreTriggerResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a trigger May fail if there are existing rules against it. Cannot delete core triggers. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="eventName">The trigger event name</param> 
        /// <returns></returns>            
        public void DeleteBRETrigger (string eventName)
        {
            
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling DeleteBRETrigger");
            
    
            var path = "/bre/triggers/{event_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "event_name" + "}", ApiClient.ParameterToString(eventName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRETrigger: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRETrigger: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single trigger &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_USER
        /// </summary>
        /// <param name="eventName">The trigger event name</param> 
        /// <returns>BreTriggerResource</returns>            
        public BreTriggerResource GetBRETrigger (string eventName)
        {
            
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling GetBRETrigger");
            
    
            var path = "/bre/triggers/{event_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "event_name" + "}", ApiClient.ParameterToString(eventName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRETrigger: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRETrigger: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreTriggerResource) ApiClient.Deserialize(response.Content, typeof(BreTriggerResource), response.Headers);
        }
    
        /// <summary>
        /// List triggers &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_USER
        /// </summary>
        /// <param name="filterSystem">Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed</param> 
        /// <param name="filterCategory">Filter for triggers that are within a specific category</param> 
        /// <param name="filterTags">Filter for triggers that have all of the given tags (comma separated list)</param> 
        /// <param name="filterName">Filter for triggers that have names containing the given string</param> 
        /// <param name="filterSearch">Filter for triggers containing the given words somewhere within name, description and tags</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceBreTriggerResource</returns>            
        public PageResourceBreTriggerResource GetBRETriggers (bool? filterSystem, string filterCategory, string filterTags, string filterName, string filterSearch, int? size, int? page)
        {
            
    
            var path = "/bre/triggers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSystem != null) queryParams.Add("filter_system", ApiClient.ParameterToString(filterSystem)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTags != null) queryParams.Add("filter_tags", ApiClient.ParameterToString(filterTags)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRETriggers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRETriggers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBreTriggerResource) ApiClient.Deserialize(response.Content, typeof(PageResourceBreTriggerResource), response.Headers);
        }
    
        /// <summary>
        /// Update a trigger May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_TRIGGERS_ADMIN
        /// </summary>
        /// <param name="eventName">The trigger event name</param> 
        /// <param name="breTriggerResource">The BRE trigger resource object</param> 
        /// <returns>BreTriggerResource</returns>            
        public BreTriggerResource UpdateBRETrigger (string eventName, BreTriggerResource breTriggerResource)
        {
            
            // verify the required parameter 'eventName' is set
            if (eventName == null) throw new ApiException(400, "Missing required parameter 'eventName' when calling UpdateBRETrigger");
            
    
            var path = "/bre/triggers/{event_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "event_name" + "}", ApiClient.ParameterToString(eventName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breTriggerResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRETrigger: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRETrigger: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreTriggerResource) ApiClient.Deserialize(response.Content, typeof(BreTriggerResource), response.Headers);
        }
    
    }
}
