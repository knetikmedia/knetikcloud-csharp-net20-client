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
    public interface IRule_Engine_RulesApi
    {
        /// <summary>
        /// Create a rule Rules define which actions to run when a given event verifies the specified condition. Full list of predicates and other type of expressions can be found at GET /bre/expressions/. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="breRule">The BRE rule object</param>
        /// <returns>BreRule</returns>
        BreRule CreateBRERule (BreRule breRule);
        /// <summary>
        /// Delete a rule May fail if there are existing rules against it. Cannot delete core rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param>
        /// <returns></returns>
        void DeleteBRERule (string id);
        /// <summary>
        /// Returns a string representation of the provided expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="expression">The expression</param>
        /// <returns>string</returns>
        string GetBREExpressionAsString (Expressionobject expression);
        /// <summary>
        /// Get a single rule &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param>
        /// <returns>BreRule</returns>
        BreRule GetBRERule (string id);
        /// <summary>
        /// List rules &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="filterName">Filter for rules containing the given name</param>
        /// <param name="filterEnabled">Filter for rules by active status, null for both</param>
        /// <param name="filterSystem">Filter for rules that are system rules when true, or not when false. Leave off for both mixed</param>
        /// <param name="filterTrigger">Filter for rules that are for the trigger with the given name</param>
        /// <param name="filterAction">Filter for rules that use the action with the given name</param>
        /// <param name="filterCondition">Filter for rules that have a condition containing the given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceBreRule</returns>
        PageResourceBreRule GetBRERules (string filterName, bool? filterEnabled, bool? filterSystem, string filterTrigger, string filterAction, string filterCondition, int? size, int? page);
        /// <summary>
        /// Enable or disable a rule This is helpful for turning off systems rules which cannot be deleted or modified otherwise. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param>
        /// <param name="enabled">The boolean value</param>
        /// <returns></returns>
        void SetBRERule (string id, BooleanResource enabled);
        /// <summary>
        /// Update a rule Cannot update system rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param>
        /// <param name="breRule">The BRE rule object</param>
        /// <returns>BreRule</returns>
        BreRule UpdateBRERule (string id, BreRule breRule);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Rule_Engine_RulesApi : IRule_Engine_RulesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_RulesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Rule_Engine_RulesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_RulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Rule_Engine_RulesApi(String basePath)
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
        /// Create a rule Rules define which actions to run when a given event verifies the specified condition. Full list of predicates and other type of expressions can be found at GET /bre/expressions/. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="breRule">The BRE rule object</param> 
        /// <returns>BreRule</returns>            
        public BreRule CreateBRERule (BreRule breRule)
        {
            
    
            var path = "/bre/rules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breRule); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRERule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRERule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreRule) ApiClient.Deserialize(response.Content, typeof(BreRule), response.Headers);
        }
    
        /// <summary>
        /// Delete a rule May fail if there are existing rules against it. Cannot delete core rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param> 
        /// <returns></returns>            
        public void DeleteBRERule (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBRERule");
            
    
            var path = "/bre/rules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRERule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRERule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns a string representation of the provided expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="expression">The expression</param> 
        /// <returns>string</returns>            
        public string GetBREExpressionAsString (Expressionobject expression)
        {
            
    
            var path = "/bre/rules/expression-as-string";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(expression); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpressionAsString: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpressionAsString: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get a single rule &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param> 
        /// <returns>BreRule</returns>            
        public BreRule GetBRERule (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBRERule");
            
    
            var path = "/bre/rules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRERule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRERule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreRule) ApiClient.Deserialize(response.Content, typeof(BreRule), response.Headers);
        }
    
        /// <summary>
        /// List rules &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="filterName">Filter for rules containing the given name</param> 
        /// <param name="filterEnabled">Filter for rules by active status, null for both</param> 
        /// <param name="filterSystem">Filter for rules that are system rules when true, or not when false. Leave off for both mixed</param> 
        /// <param name="filterTrigger">Filter for rules that are for the trigger with the given name</param> 
        /// <param name="filterAction">Filter for rules that use the action with the given name</param> 
        /// <param name="filterCondition">Filter for rules that have a condition containing the given string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceBreRule</returns>            
        public PageResourceBreRule GetBRERules (string filterName, bool? filterEnabled, bool? filterSystem, string filterTrigger, string filterAction, string filterCondition, int? size, int? page)
        {
            
    
            var path = "/bre/rules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterEnabled != null) queryParams.Add("filter_enabled", ApiClient.ParameterToString(filterEnabled)); // query parameter
 if (filterSystem != null) queryParams.Add("filter_system", ApiClient.ParameterToString(filterSystem)); // query parameter
 if (filterTrigger != null) queryParams.Add("filter_trigger", ApiClient.ParameterToString(filterTrigger)); // query parameter
 if (filterAction != null) queryParams.Add("filter_action", ApiClient.ParameterToString(filterAction)); // query parameter
 if (filterCondition != null) queryParams.Add("filter_condition", ApiClient.ParameterToString(filterCondition)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRERules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRERules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBreRule) ApiClient.Deserialize(response.Content, typeof(PageResourceBreRule), response.Headers);
        }
    
        /// <summary>
        /// Enable or disable a rule This is helpful for turning off systems rules which cannot be deleted or modified otherwise. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param> 
        /// <param name="enabled">The boolean value</param> 
        /// <returns></returns>            
        public void SetBRERule (string id, BooleanResource enabled)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetBRERule");
            
    
            var path = "/bre/rules/{id}/enabled";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(enabled); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetBRERule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetBRERule: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a rule Cannot update system rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_RULES_ADMIN
        /// </summary>
        /// <param name="id">The id of the rule</param> 
        /// <param name="breRule">The BRE rule object</param> 
        /// <returns>BreRule</returns>            
        public BreRule UpdateBRERule (string id, BreRule breRule)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBRERule");
            
    
            var path = "/bre/rules/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(breRule); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRERule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRERule: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreRule) ApiClient.Deserialize(response.Content, typeof(BreRule), response.Headers);
        }
    
    }
}
