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
    public interface IBRERuleEngineVariablesApi
    {
        /// <summary>
        /// Get a list of variable types available Types include integer, string, user and invoice. These are used to qualify trigger parameters and action variables with strong typing.
        /// </summary>
        /// <returns>List&lt;VariableTypeResource&gt;</returns>
        List<VariableTypeResource> GetBREVariableTypes ();
        /// <summary>
        /// List valid values for a type Used to lookup users to fill in a user constant for example. Only types marked as enumerable are suppoorted here.
        /// </summary>
        /// <param name="name">The name of the type</param>
        /// <param name="filterName">Filter results by those with names starting with this string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceSimpleReferenceResourceobject</returns>
        PageResourceSimpleReferenceResourceobject GetBREVariableValues (string name, string filterName, int? size, int? page);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BRERuleEngineVariablesApi : IBRERuleEngineVariablesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineVariablesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BRERuleEngineVariablesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineVariablesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BRERuleEngineVariablesApi(String basePath)
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
        /// Get a list of variable types available Types include integer, string, user and invoice. These are used to qualify trigger parameters and action variables with strong typing.
        /// </summary>
        /// <returns>List&lt;VariableTypeResource&gt;</returns>            
        public List<VariableTypeResource> GetBREVariableTypes ()
        {
            
    
            var path = "/bre/variable-types";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREVariableTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREVariableTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VariableTypeResource>) ApiClient.Deserialize(response.Content, typeof(List<VariableTypeResource>), response.Headers);
        }
    
        /// <summary>
        /// List valid values for a type Used to lookup users to fill in a user constant for example. Only types marked as enumerable are suppoorted here.
        /// </summary>
        /// <param name="name">The name of the type</param> 
        /// <param name="filterName">Filter results by those with names starting with this string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceSimpleReferenceResourceobject</returns>            
        public PageResourceSimpleReferenceResourceobject GetBREVariableValues (string name, string filterName, int? size, int? page)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetBREVariableValues");
            
    
            var path = "/bre/variable-types/{name}/values";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREVariableValues: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREVariableValues: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSimpleReferenceResourceobject) ApiClient.Deserialize(response.Content, typeof(PageResourceSimpleReferenceResourceobject), response.Headers);
        }
    
    }
}
