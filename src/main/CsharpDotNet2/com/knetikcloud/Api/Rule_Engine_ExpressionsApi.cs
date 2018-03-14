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
    public interface IRule_Engine_ExpressionsApi
    {
        /// <summary>
        /// Lookup a specific expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param>
        /// <returns>ExpressionResource</returns>
        ExpressionResource GetBREExpression (string type);
        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions. Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="filterTypeGroup">Filter for expressions by type group</param>
        /// <returns>List&lt;ExpressionResource&gt;</returns>
        List<ExpressionResource> GetBREExpressions (string filterTypeGroup);
        /// <summary>
        /// Returns the textual representation of an expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="expression">The expression resource to be converted</param>
        /// <returns>StringWrapper</returns>
        StringWrapper GetExpressionAsText (ExpressionResource expression);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Rule_Engine_ExpressionsApi : IRule_Engine_ExpressionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_ExpressionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Rule_Engine_ExpressionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule_Engine_ExpressionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Rule_Engine_ExpressionsApi(String basePath)
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
        /// Lookup a specific expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="type">Specifiy the type of expression as returned by the listing endpoint</param> 
        /// <returns>ExpressionResource</returns>            
        public ExpressionResource GetBREExpression (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetBREExpression");
            
    
            var path = "/bre/expressions/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpression: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpression: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExpressionResource) ApiClient.Deserialize(response.Content, typeof(ExpressionResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of supported expressions to use in conditions or actions. Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="filterTypeGroup">Filter for expressions by type group</param> 
        /// <returns>List&lt;ExpressionResource&gt;</returns>            
        public List<ExpressionResource> GetBREExpressions (string filterTypeGroup)
        {
            
    
            var path = "/bre/expressions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTypeGroup != null) queryParams.Add("filter_type_group", ApiClient.ParameterToString(filterTypeGroup)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpressions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREExpressions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ExpressionResource>) ApiClient.Deserialize(response.Content, typeof(List<ExpressionResource>), response.Headers);
        }
    
        /// <summary>
        /// Returns the textual representation of an expression &lt;b&gt;Permissions Needed:&lt;/b&gt; BRE_RULE_ENGINE_EXPRESSIONS_USER
        /// </summary>
        /// <param name="expression">The expression resource to be converted</param> 
        /// <returns>StringWrapper</returns>            
        public StringWrapper GetExpressionAsText (ExpressionResource expression)
        {
            
    
            var path = "/bre/expressions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpressionAsText: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExpressionAsText: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StringWrapper) ApiClient.Deserialize(response.Content, typeof(StringWrapper), response.Headers);
        }
    
    }
}
