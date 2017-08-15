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
    public interface IBRERuleEngineActionsApi
    {
        /// <summary>
        /// Get a list of available actions 
        /// </summary>
        /// <param name="filterCategory">Filter for actions that are within a specific category</param>
        /// <param name="filterName">Filter for actions that have names containing the given string</param>
        /// <param name="filterTags">Filter for actions that have all of the given tags (comma separated list)</param>
        /// <param name="filterSearch">Filter for actions containing the given words somewhere within name, description and tags</param>
        /// <returns>List&lt;ActionResource&gt;</returns>
        List<ActionResource> GetBREActions (string filterCategory, string filterName, string filterTags, string filterSearch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BRERuleEngineActionsApi : IBRERuleEngineActionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineActionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BRERuleEngineActionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BRERuleEngineActionsApi(String basePath)
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
        /// Get a list of available actions 
        /// </summary>
        /// <param name="filterCategory">Filter for actions that are within a specific category</param> 
        /// <param name="filterName">Filter for actions that have names containing the given string</param> 
        /// <param name="filterTags">Filter for actions that have all of the given tags (comma separated list)</param> 
        /// <param name="filterSearch">Filter for actions containing the given words somewhere within name, description and tags</param> 
        /// <returns>List&lt;ActionResource&gt;</returns>            
        public List<ActionResource> GetBREActions (string filterCategory, string filterName, string filterTags, string filterSearch)
        {
            
    
            var path = "/bre/actions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterTags != null) queryParams.Add("filter_tags", ApiClient.ParameterToString(filterTags)); // query parameter
 if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ActionResource>) ApiClient.Deserialize(response.Content, typeof(List<ActionResource>), response.Headers);
        }
    
    }
}
