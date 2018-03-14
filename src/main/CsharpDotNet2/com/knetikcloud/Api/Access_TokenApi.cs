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
    public interface IAccess_TokenApi
    {
        /// <summary>
        /// Get access token 
        /// </summary>
        /// <param name="grantType">Grant type</param>
        /// <param name="clientId">The id of the client</param>
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials</param>
        /// <param name="username">The username of the client. Used only with a grant_type of password</param>
        /// <param name="password">The password of the client. Used only with a grant_type of password</param>
        /// <param name="token">The 3rd party authentication token. Used only with a grant_type of facebook, google, etc (social plugins)</param>
        /// <param name="refreshToken">The refresh token obtained during prior authentication. Used only with a grant_type of refresh_token</param>
        /// <returns>OAuth2Resource</returns>
        OAuth2Resource GetOAuthToken (string grantType, string clientId, string clientSecret, string username, string password, string token, string refreshToken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Access_TokenApi : IAccess_TokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Access_TokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Access_TokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Access_TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Access_TokenApi(String basePath)
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
        /// Get access token 
        /// </summary>
        /// <param name="grantType">Grant type</param> 
        /// <param name="clientId">The id of the client</param> 
        /// <param name="clientSecret">The secret key of the client.  Used only with a grant_type of client_credentials</param> 
        /// <param name="username">The username of the client. Used only with a grant_type of password</param> 
        /// <param name="password">The password of the client. Used only with a grant_type of password</param> 
        /// <param name="token">The 3rd party authentication token. Used only with a grant_type of facebook, google, etc (social plugins)</param> 
        /// <param name="refreshToken">The refresh token obtained during prior authentication. Used only with a grant_type of refresh_token</param> 
        /// <returns>OAuth2Resource</returns>            
        public OAuth2Resource GetOAuthToken (string grantType, string clientId, string clientSecret, string username, string password, string token, string refreshToken)
        {
            
            // verify the required parameter 'grantType' is set
            if (grantType == null) throw new ApiException(400, "Missing required parameter 'grantType' when calling GetOAuthToken");
            
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetOAuthToken");
            
    
            var path = "/oauth/token";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (grantType != null) formParams.Add("grant_type", ApiClient.ParameterToString(grantType)); // form parameter
if (clientId != null) formParams.Add("client_id", ApiClient.ParameterToString(clientId)); // form parameter
if (clientSecret != null) formParams.Add("client_secret", ApiClient.ParameterToString(clientSecret)); // form parameter
if (username != null) formParams.Add("username", ApiClient.ParameterToString(username)); // form parameter
if (password != null) formParams.Add("password", ApiClient.ParameterToString(password)); // form parameter
if (token != null) formParams.Add("token", ApiClient.ParameterToString(token)); // form parameter
if (refreshToken != null) formParams.Add("refresh_token", ApiClient.ParameterToString(refreshToken)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OAuth2Resource) ApiClient.Deserialize(response.Content, typeof(OAuth2Resource), response.Headers);
        }
    
    }
}
