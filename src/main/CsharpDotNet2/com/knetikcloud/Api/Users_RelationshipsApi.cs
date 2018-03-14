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
    public interface IUsers_RelationshipsApi
    {
        /// <summary>
        /// Create a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="relationship">The new relationship</param>
        /// <returns>UserRelationshipResource</returns>
        UserRelationshipResource CreateUserRelationship (UserRelationshipResource relationship);
        /// <summary>
        /// Delete a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param>
        /// <returns></returns>
        void DeleteUserRelationship (long? id);
        /// <summary>
        /// Get a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_USER or RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param>
        /// <returns>UserRelationshipResource</returns>
        UserRelationshipResource GetUserRelationship (long? id);
        /// <summary>
        /// Get a list of user relationships &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_USER or RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceUserRelationshipResource</returns>
        PageResourceUserRelationshipResource GetUserRelationships (int? size, int? page, string order);
        /// <summary>
        /// Update a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param>
        /// <param name="relationship">The new relationship</param>
        /// <returns>UserRelationshipResource</returns>
        UserRelationshipResource UpdateUserRelationship (long? id, UserRelationshipResource relationship);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Users_RelationshipsApi : IUsers_RelationshipsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Users_RelationshipsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Users_RelationshipsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Users_RelationshipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Users_RelationshipsApi(String basePath)
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
        /// Create a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="relationship">The new relationship</param> 
        /// <returns>UserRelationshipResource</returns>            
        public UserRelationshipResource CreateUserRelationship (UserRelationshipResource relationship)
        {
            
    
            var path = "/users/relationships";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(relationship); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUserRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUserRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRelationshipResource) ApiClient.Deserialize(response.Content, typeof(UserRelationshipResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param> 
        /// <returns></returns>            
        public void DeleteUserRelationship (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUserRelationship");
            
    
            var path = "/users/relationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_USER or RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param> 
        /// <returns>UserRelationshipResource</returns>            
        public UserRelationshipResource GetUserRelationship (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserRelationship");
            
    
            var path = "/users/relationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRelationshipResource) ApiClient.Deserialize(response.Content, typeof(UserRelationshipResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of user relationships &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_USER or RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceUserRelationshipResource</returns>            
        public PageResourceUserRelationshipResource GetUserRelationships (int? size, int? page, string order)
        {
            
    
            var path = "/users/relationships";
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRelationships: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserRelationshipResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserRelationshipResource), response.Headers);
        }
    
        /// <summary>
        /// Update a user relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; RELATIONSHIPS_ADMIN
        /// </summary>
        /// <param name="id">The id of the relationship</param> 
        /// <param name="relationship">The new relationship</param> 
        /// <returns>UserRelationshipResource</returns>            
        public UserRelationshipResource UpdateUserRelationship (long? id, UserRelationshipResource relationship)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUserRelationship");
            
    
            var path = "/users/relationships/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(relationship); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRelationshipResource) ApiClient.Deserialize(response.Content, typeof(UserRelationshipResource), response.Headers);
        }
    
    }
}
