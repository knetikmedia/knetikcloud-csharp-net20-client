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
    public interface IAuthClientsApi
    {
        /// <summary>
        /// Create a new client 
        /// </summary>
        /// <param name="clientResource">The client resource object</param>
        /// <returns>ModelClientResource</returns>
        ModelClientResource CreateClient (ModelClientResource clientResource);
        /// <summary>
        /// Delete a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param>
        /// <returns></returns>
        void DeleteClient (string clientKey);
        /// <summary>
        /// Get a single client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param>
        /// <returns>ModelClientResource</returns>
        ModelClientResource GetClient (string clientKey);
        /// <summary>
        /// List available client grant types 
        /// </summary>
        /// <returns>List&lt;ModelGrantTypeResource&gt;</returns>
        List<ModelGrantTypeResource> GetClientGrantTypes ();
        /// <summary>
        /// List and search clients 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceClientResource</returns>
        ModelPageResourceClientResource GetClients (int? size, int? page, string order);
        /// <summary>
        /// Set grant types for a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param>
        /// <param name="grantList">A list of unique grant types</param>
        /// <returns></returns>
        void SetClientGrantTypes (string clientKey, List<string> grantList);
        /// <summary>
        /// Set redirect uris for a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param>
        /// <param name="redirectList">A list of unique redirect uris</param>
        /// <returns></returns>
        void SetClientRedirectUris (string clientKey, List<string> redirectList);
        /// <summary>
        /// Update a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param>
        /// <param name="clientResource">The client resource object</param>
        /// <returns>ModelClientResource</returns>
        ModelClientResource UpdateClient (string clientKey, ModelClientResource clientResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthClientsApi : IAuthClientsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthClientsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthClientsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthClientsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthClientsApi(String basePath)
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
        /// Create a new client 
        /// </summary>
        /// <param name="clientResource">The client resource object</param> 
        /// <returns>ModelClientResource</returns>            
        public ModelClientResource CreateClient (ModelClientResource clientResource)
        {
            
    
            var path = "/auth/clients";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(clientResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelClientResource) ApiClient.Deserialize(response.Content, typeof(ModelClientResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param> 
        /// <returns></returns>            
        public void DeleteClient (string clientKey)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling DeleteClient");
            
    
            var path = "/auth/clients/{client_key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param> 
        /// <returns>ModelClientResource</returns>            
        public ModelClientResource GetClient (string clientKey)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling GetClient");
            
    
            var path = "/auth/clients/{client_key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelClientResource) ApiClient.Deserialize(response.Content, typeof(ModelClientResource), response.Headers);
        }
    
        /// <summary>
        /// List available client grant types 
        /// </summary>
        /// <returns>List&lt;ModelGrantTypeResource&gt;</returns>            
        public List<ModelGrantTypeResource> GetClientGrantTypes ()
        {
            
    
            var path = "/auth/clients/grant-types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientGrantTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientGrantTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelGrantTypeResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelGrantTypeResource>), response.Headers);
        }
    
        /// <summary>
        /// List and search clients 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceClientResource</returns>            
        public ModelPageResourceClientResource GetClients (int? size, int? page, string order)
        {
            
    
            var path = "/auth/clients";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClients: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClients: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceClientResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceClientResource), response.Headers);
        }
    
        /// <summary>
        /// Set grant types for a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param> 
        /// <param name="grantList">A list of unique grant types</param> 
        /// <returns></returns>            
        public void SetClientGrantTypes (string clientKey, List<string> grantList)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling SetClientGrantTypes");
            
    
            var path = "/auth/clients/{client_key}/grant-types";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(grantList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientGrantTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientGrantTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set redirect uris for a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param> 
        /// <param name="redirectList">A list of unique redirect uris</param> 
        /// <returns></returns>            
        public void SetClientRedirectUris (string clientKey, List<string> redirectList)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling SetClientRedirectUris");
            
    
            var path = "/auth/clients/{client_key}/redirect-uris";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(redirectList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientRedirectUris: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientRedirectUris: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a client 
        /// </summary>
        /// <param name="clientKey">The key of the client</param> 
        /// <param name="clientResource">The client resource object</param> 
        /// <returns>ModelClientResource</returns>            
        public ModelClientResource UpdateClient (string clientKey, ModelClientResource clientResource)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling UpdateClient");
            
    
            var path = "/auth/clients/{client_key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(clientResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClient: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClient: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelClientResource) ApiClient.Deserialize(response.Content, typeof(ModelClientResource), response.Headers);
        }
    
    }
}
