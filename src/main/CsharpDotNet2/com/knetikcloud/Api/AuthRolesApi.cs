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
    public interface IAuthRolesApi
    {
        /// <summary>
        /// Create a new role 
        /// </summary>
        /// <param name="roleResource">The role resource object</param>
        /// <returns>RoleResource</returns>
        RoleResource CreateRole (RoleResource roleResource);
        /// <summary>
        /// Delete a role 
        /// </summary>
        /// <param name="role">The role value</param>
        /// <param name="force">If true, removes role from users/clients</param>
        /// <returns></returns>
        void DeleteRole (string role, bool? force);
        /// <summary>
        /// Get roles for a client 
        /// </summary>
        /// <param name="clientKey">The client key</param>
        /// <returns>List&lt;RoleResource&gt;</returns>
        List<RoleResource> GetClientRoles (string clientKey);
        /// <summary>
        /// Get a single role 
        /// </summary>
        /// <param name="role">The role value</param>
        /// <returns>RoleResource</returns>
        RoleResource GetRole (string role);
        /// <summary>
        /// List and search roles 
        /// </summary>
        /// <param name="filterName">Filter for roles that have a name starting with specified string</param>
        /// <param name="filterRole">Filter for roles that have a role starting with specified string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceRoleResource</returns>
        PageResourceRoleResource GetRoles (string filterName, string filterRole, int? size, int? page, string order);
        /// <summary>
        /// Get roles for a user 
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <returns>List&lt;RoleResource&gt;</returns>
        List<RoleResource> GetUserRoles (int? userId);
        /// <summary>
        /// Set roles for a client 
        /// </summary>
        /// <param name="clientKey">The client key</param>
        /// <param name="rolesList">The list of unique roles</param>
        /// <returns>ClientResource</returns>
        ClientResource SetClientRoles (string clientKey, List<string> rolesList);
        /// <summary>
        /// Set permissions for a role 
        /// </summary>
        /// <param name="role">The role value</param>
        /// <param name="permissionsList">The list of unique permissions</param>
        /// <returns>RoleResource</returns>
        RoleResource SetPermissionsForRole (string role, List<string> permissionsList);
        /// <summary>
        /// Set roles for a user 
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="rolesList">The list of unique roles</param>
        /// <returns>UserResource</returns>
        UserResource SetUserRoles (int? userId, List<string> rolesList);
        /// <summary>
        /// Update a role 
        /// </summary>
        /// <param name="role">The role value</param>
        /// <param name="roleResource">The role resource object</param>
        /// <returns>RoleResource</returns>
        RoleResource UpdateRole (string role, RoleResource roleResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthRolesApi : IAuthRolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRolesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthRolesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthRolesApi(String basePath)
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
        /// Create a new role 
        /// </summary>
        /// <param name="roleResource">The role resource object</param> 
        /// <returns>RoleResource</returns>            
        public RoleResource CreateRole (RoleResource roleResource)
        {
            
    
            var path = "/auth/roles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(roleResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleResource) ApiClient.Deserialize(response.Content, typeof(RoleResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a role 
        /// </summary>
        /// <param name="role">The role value</param> 
        /// <param name="force">If true, removes role from users/clients</param> 
        /// <returns></returns>            
        public void DeleteRole (string role, bool? force)
        {
            
            // verify the required parameter 'role' is set
            if (role == null) throw new ApiException(400, "Missing required parameter 'role' when calling DeleteRole");
            
    
            var path = "/auth/roles/{role}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "role" + "}", ApiClient.ParameterToString(role));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (force != null) queryParams.Add("force", ApiClient.ParameterToString(force)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get roles for a client 
        /// </summary>
        /// <param name="clientKey">The client key</param> 
        /// <returns>List&lt;RoleResource&gt;</returns>            
        public List<RoleResource> GetClientRoles (string clientKey)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling GetClientRoles");
            
    
            var path = "/auth/clients/{client_key}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleResource>) ApiClient.Deserialize(response.Content, typeof(List<RoleResource>), response.Headers);
        }
    
        /// <summary>
        /// Get a single role 
        /// </summary>
        /// <param name="role">The role value</param> 
        /// <returns>RoleResource</returns>            
        public RoleResource GetRole (string role)
        {
            
            // verify the required parameter 'role' is set
            if (role == null) throw new ApiException(400, "Missing required parameter 'role' when calling GetRole");
            
    
            var path = "/auth/roles/{role}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "role" + "}", ApiClient.ParameterToString(role));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleResource) ApiClient.Deserialize(response.Content, typeof(RoleResource), response.Headers);
        }
    
        /// <summary>
        /// List and search roles 
        /// </summary>
        /// <param name="filterName">Filter for roles that have a name starting with specified string</param> 
        /// <param name="filterRole">Filter for roles that have a role starting with specified string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceRoleResource</returns>            
        public PageResourceRoleResource GetRoles (string filterName, string filterRole, int? size, int? page, string order)
        {
            
    
            var path = "/auth/roles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterRole != null) queryParams.Add("filter_role", ApiClient.ParameterToString(filterRole)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceRoleResource) ApiClient.Deserialize(response.Content, typeof(PageResourceRoleResource), response.Headers);
        }
    
        /// <summary>
        /// Get roles for a user 
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <returns>List&lt;RoleResource&gt;</returns>            
        public List<RoleResource> GetUserRoles (int? userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserRoles");
            
    
            var path = "/auth/users/{user_id}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RoleResource>) ApiClient.Deserialize(response.Content, typeof(List<RoleResource>), response.Headers);
        }
    
        /// <summary>
        /// Set roles for a client 
        /// </summary>
        /// <param name="clientKey">The client key</param> 
        /// <param name="rolesList">The list of unique roles</param> 
        /// <returns>ClientResource</returns>            
        public ClientResource SetClientRoles (string clientKey, List<string> rolesList)
        {
            
            // verify the required parameter 'clientKey' is set
            if (clientKey == null) throw new ApiException(400, "Missing required parameter 'clientKey' when calling SetClientRoles");
            
    
            var path = "/auth/clients/{client_key}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "client_key" + "}", ApiClient.ParameterToString(clientKey));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rolesList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetClientRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClientResource) ApiClient.Deserialize(response.Content, typeof(ClientResource), response.Headers);
        }
    
        /// <summary>
        /// Set permissions for a role 
        /// </summary>
        /// <param name="role">The role value</param> 
        /// <param name="permissionsList">The list of unique permissions</param> 
        /// <returns>RoleResource</returns>            
        public RoleResource SetPermissionsForRole (string role, List<string> permissionsList)
        {
            
            // verify the required parameter 'role' is set
            if (role == null) throw new ApiException(400, "Missing required parameter 'role' when calling SetPermissionsForRole");
            
    
            var path = "/auth/roles/{role}/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "role" + "}", ApiClient.ParameterToString(role));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(permissionsList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPermissionsForRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPermissionsForRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleResource) ApiClient.Deserialize(response.Content, typeof(RoleResource), response.Headers);
        }
    
        /// <summary>
        /// Set roles for a user 
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <param name="rolesList">The list of unique roles</param> 
        /// <returns>UserResource</returns>            
        public UserResource SetUserRoles (int? userId, List<string> rolesList)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetUserRoles");
            
    
            var path = "/auth/users/{user_id}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rolesList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResource) ApiClient.Deserialize(response.Content, typeof(UserResource), response.Headers);
        }
    
        /// <summary>
        /// Update a role 
        /// </summary>
        /// <param name="role">The role value</param> 
        /// <param name="roleResource">The role resource object</param> 
        /// <returns>RoleResource</returns>            
        public RoleResource UpdateRole (string role, RoleResource roleResource)
        {
            
            // verify the required parameter 'role' is set
            if (role == null) throw new ApiException(400, "Missing required parameter 'role' when calling UpdateRole");
            
    
            var path = "/auth/roles/{role}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "role" + "}", ApiClient.ParameterToString(role));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(roleResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRole: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleResource) ApiClient.Deserialize(response.Content, typeof(RoleResource), response.Headers);
        }
    
    }
}
