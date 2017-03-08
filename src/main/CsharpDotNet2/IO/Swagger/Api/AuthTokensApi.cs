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
    public interface IAuthTokensApi
    {
        /// <summary>
        /// Delete a token by username and client id 
        /// </summary>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns></returns>
        void DeleteToken (string username, string clientId);
        /// <summary>
        /// Delete all tokens by username 
        /// </summary>
        /// <param name="username">The username of the user</param>
        /// <returns></returns>
        void DeleteTokens (string username);
        /// <summary>
        /// Get a single token by username and client id 
        /// </summary>
        /// <param name="username">The username of the user</param>
        /// <param name="clientId">The id of the client</param>
        /// <returns>OauthAccessTokenResource</returns>
        OauthAccessTokenResource GetToken (string username, string clientId);
        /// <summary>
        /// List usernames and client ids Token value not shown
        /// </summary>
        /// <param name="filterClientId">Filters for token whose client id matches provided string</param>
        /// <param name="filterUsername">Filters for token whose username matches provided string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceOauthAccessTokenResource</returns>
        PageResourceOauthAccessTokenResource GetTokens (string filterClientId, string filterUsername, int? size, int? page, string order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthTokensApi : IAuthTokensApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokensApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthTokensApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthTokensApi(String basePath)
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
        /// Delete a token by username and client id 
        /// </summary>
        /// <param name="username">The username of the user</param> 
        /// <param name="clientId">The id of the client</param> 
        /// <returns></returns>            
        public void DeleteToken (string username, string clientId)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling DeleteToken");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling DeleteToken");
            
    
            var path = "/auth/tokens/{username}/{client_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete all tokens by username 
        /// </summary>
        /// <param name="username">The username of the user</param> 
        /// <returns></returns>            
        public void DeleteTokens (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling DeleteTokens");
            
    
            var path = "/auth/tokens/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single token by username and client id 
        /// </summary>
        /// <param name="username">The username of the user</param> 
        /// <param name="clientId">The id of the client</param> 
        /// <returns>OauthAccessTokenResource</returns>            
        public OauthAccessTokenResource GetToken (string username, string clientId)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling GetToken");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetToken");
            
    
            var path = "/auth/tokens/{username}/{client_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "client_id" + "}", ApiClient.ParameterToString(clientId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OauthAccessTokenResource) ApiClient.Deserialize(response.Content, typeof(OauthAccessTokenResource), response.Headers);
        }
    
        /// <summary>
        /// List usernames and client ids Token value not shown
        /// </summary>
        /// <param name="filterClientId">Filters for token whose client id matches provided string</param> 
        /// <param name="filterUsername">Filters for token whose username matches provided string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceOauthAccessTokenResource</returns>            
        public PageResourceOauthAccessTokenResource GetTokens (string filterClientId, string filterUsername, int? size, int? page, string order)
        {
            
    
            var path = "/auth/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterClientId != null) queryParams.Add("filter_client_id", ApiClient.ParameterToString(filterClientId)); // query parameter
 if (filterUsername != null) queryParams.Add("filter_username", ApiClient.ParameterToString(filterUsername)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTokens: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceOauthAccessTokenResource) ApiClient.Deserialize(response.Content, typeof(PageResourceOauthAccessTokenResource), response.Headers);
        }
    
    }
}
