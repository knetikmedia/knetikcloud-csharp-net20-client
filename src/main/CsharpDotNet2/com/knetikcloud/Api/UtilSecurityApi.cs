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
    public interface IUtilSecurityApi
    {
        /// <summary>
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceLocationLogResource</returns>
        ModelPageResourceLocationLogResource GetUserLocationLog (int? userId, int? size, int? page, string order);
        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <returns>ModelTokenDetailsResource</returns>
        ModelTokenDetailsResource GetUserTokenDetails ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UtilSecurityApi : IUtilSecurityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilSecurityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UtilSecurityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilSecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilSecurityApi(String basePath)
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
        /// Returns the authentication log for a user A log entry is recorded everytime a user requests a new token. Standard pagination available
        /// </summary>
        /// <param name="userId">The user id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceLocationLogResource</returns>            
        public ModelPageResourceLocationLogResource GetUserLocationLog (int? userId, int? size, int? page, string order)
        {
            
    
            var path = "/security/country-log";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLocationLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLocationLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceLocationLogResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceLocationLogResource), response.Headers);
        }
    
        /// <summary>
        /// Returns the authentication token details. Use /users endpoint for detailed user&#39;s info 
        /// </summary>
        /// <returns>ModelTokenDetailsResource</returns>            
        public ModelTokenDetailsResource GetUserTokenDetails ()
        {
            
    
            var path = "/me";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTokenDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTokenDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTokenDetailsResource) ApiClient.Deserialize(response.Content, typeof(ModelTokenDetailsResource), response.Headers);
        }
    
    }
}
