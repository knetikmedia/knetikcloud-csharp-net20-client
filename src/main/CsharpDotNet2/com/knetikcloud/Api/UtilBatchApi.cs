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
    public interface IUtilBatchApi
    {
        /// <summary>
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <param name="token">token</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        List<BatchReturn> GetBatch (string token);
        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <param name="batch">The batch object</param>
        /// <returns>List&lt;BatchReturn&gt;</returns>
        List<BatchReturn> SendBatch (Batch batch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UtilBatchApi : IUtilBatchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilBatchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UtilBatchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilBatchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UtilBatchApi(String basePath)
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
        /// Get batch result with token Tokens expire in 24 hours
        /// </summary>
        /// <param name="token">token</param> 
        /// <returns>List&lt;BatchReturn&gt;</returns>            
        public List<BatchReturn> GetBatch (string token)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBatch");
            
    
            var path = "/batch/{token}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "token" + "}", ApiClient.ParameterToString(token));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BatchReturn>) ApiClient.Deserialize(response.Content, typeof(List<BatchReturn>), response.Headers);
        }
    
        /// <summary>
        /// Request to run API call given the method, content type, path url, and body of request Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service
        /// </summary>
        /// <param name="batch">The batch object</param> 
        /// <returns>List&lt;BatchReturn&gt;</returns>            
        public List<BatchReturn> SendBatch (Batch batch)
        {
            
    
            var path = "/batch";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(batch); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BatchReturn>) ApiClient.Deserialize(response.Content, typeof(List<BatchReturn>), response.Headers);
        }
    
    }
}
