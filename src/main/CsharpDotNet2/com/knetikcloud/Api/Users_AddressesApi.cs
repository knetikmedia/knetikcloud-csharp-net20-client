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
    public interface IUsers_AddressesApi
    {
        /// <summary>
        /// Create a new address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="savedAddressResource">The new address</param>
        /// <returns>SavedAddressResource</returns>
        SavedAddressResource CreateAddress (string userId, SavedAddressResource savedAddressResource);
        /// <summary>
        /// Delete an address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <returns></returns>
        void DeleteAddress (string userId, int? id);
        /// <summary>
        /// Get a single address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <returns>SavedAddressResource</returns>
        SavedAddressResource GetAddress (string userId, int? id);
        /// <summary>
        /// List and search addresses &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceSavedAddressResource</returns>
        PageResourceSavedAddressResource GetAddresses (string userId, int? size, int? page, string order);
        /// <summary>
        /// Update an address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the address</param>
        /// <param name="savedAddressResource">The saved address resource object</param>
        /// <returns>SavedAddressResource</returns>
        SavedAddressResource UpdateAddress (string userId, int? id, SavedAddressResource savedAddressResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Users_AddressesApi : IUsers_AddressesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Users_AddressesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Users_AddressesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Users_AddressesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Users_AddressesApi(String basePath)
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
        /// Create a new address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="savedAddressResource">The new address</param> 
        /// <returns>SavedAddressResource</returns>            
        public SavedAddressResource CreateAddress (string userId, SavedAddressResource savedAddressResource)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreateAddress");
            
    
            var path = "/users/{user_id}/addresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(savedAddressResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SavedAddressResource) ApiClient.Deserialize(response.Content, typeof(SavedAddressResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="id">The id of the address</param> 
        /// <returns></returns>            
        public void DeleteAddress (string userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteAddress");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAddress");
            
    
            var path = "/users/{user_id}/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="id">The id of the address</param> 
        /// <returns>SavedAddressResource</returns>            
        public SavedAddressResource GetAddress (string userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetAddress");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAddress");
            
    
            var path = "/users/{user_id}/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SavedAddressResource) ApiClient.Deserialize(response.Content, typeof(SavedAddressResource), response.Headers);
        }
    
        /// <summary>
        /// List and search addresses &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceSavedAddressResource</returns>            
        public PageResourceSavedAddressResource GetAddresses (string userId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetAddresses");
            
    
            var path = "/users/{user_id}/addresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSavedAddressResource) ApiClient.Deserialize(response.Content, typeof(PageResourceSavedAddressResource), response.Headers);
        }
    
        /// <summary>
        /// Update an address &lt;b&gt;Permissions Needed:&lt;/b&gt; USERS_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="id">The id of the address</param> 
        /// <param name="savedAddressResource">The saved address resource object</param> 
        /// <returns>SavedAddressResource</returns>            
        public SavedAddressResource UpdateAddress (string userId, int? id, SavedAddressResource savedAddressResource)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateAddress");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAddress");
            
    
            var path = "/users/{user_id}/addresses/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(savedAddressResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SavedAddressResource) ApiClient.Deserialize(response.Content, typeof(SavedAddressResource), response.Headers);
        }
    
    }
}
