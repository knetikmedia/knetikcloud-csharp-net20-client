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
    public interface IAuth_PermissionsApi
    {
        /// <summary>
        /// Create a new permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permissionResource">The permission resource object</param>
        /// <returns>PermissionResource</returns>
        PermissionResource CreatePermission (PermissionResource permissionResource);
        /// <summary>
        /// Delete a permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param>
        /// <param name="force">If true, removes permission assigned to roles</param>
        /// <returns></returns>
        void DeletePermission (string permission, bool? force);
        /// <summary>
        /// Get a single permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param>
        /// <returns>PermissionResource</returns>
        PermissionResource GetPermission (string permission);
        /// <summary>
        /// List and search permissions &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourcePermissionResource</returns>
        PageResourcePermissionResource GetPermissions (int? size, int? page, string order);
        /// <summary>
        /// Update a permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param>
        /// <param name="permissionResource">The permission resource object</param>
        /// <returns>PermissionResource</returns>
        PermissionResource UpdatePermission (string permission, PermissionResource permissionResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Auth_PermissionsApi : IAuth_PermissionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth_PermissionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Auth_PermissionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth_PermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Auth_PermissionsApi(String basePath)
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
        /// Create a new permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permissionResource">The permission resource object</param> 
        /// <returns>PermissionResource</returns>            
        public PermissionResource CreatePermission (PermissionResource permissionResource)
        {
            
    
            var path = "/auth/permissions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(permissionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PermissionResource) ApiClient.Deserialize(response.Content, typeof(PermissionResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param> 
        /// <param name="force">If true, removes permission assigned to roles</param> 
        /// <returns></returns>            
        public void DeletePermission (string permission, bool? force)
        {
            
            // verify the required parameter 'permission' is set
            if (permission == null) throw new ApiException(400, "Missing required parameter 'permission' when calling DeletePermission");
            
    
            var path = "/auth/permissions/{permission}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "permission" + "}", ApiClient.ParameterToString(permission));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param> 
        /// <returns>PermissionResource</returns>            
        public PermissionResource GetPermission (string permission)
        {
            
            // verify the required parameter 'permission' is set
            if (permission == null) throw new ApiException(400, "Missing required parameter 'permission' when calling GetPermission");
            
    
            var path = "/auth/permissions/{permission}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "permission" + "}", ApiClient.ParameterToString(permission));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PermissionResource) ApiClient.Deserialize(response.Content, typeof(PermissionResource), response.Headers);
        }
    
        /// <summary>
        /// List and search permissions &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourcePermissionResource</returns>            
        public PageResourcePermissionResource GetPermissions (int? size, int? page, string order)
        {
            
    
            var path = "/auth/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermissions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPermissions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourcePermissionResource) ApiClient.Deserialize(response.Content, typeof(PageResourcePermissionResource), response.Headers);
        }
    
        /// <summary>
        /// Update a permission &lt;b&gt;Permissions Needed:&lt;/b&gt; PERMISSIONS_ADMIN
        /// </summary>
        /// <param name="permission">The permission value</param> 
        /// <param name="permissionResource">The permission resource object</param> 
        /// <returns>PermissionResource</returns>            
        public PermissionResource UpdatePermission (string permission, PermissionResource permissionResource)
        {
            
            // verify the required parameter 'permission' is set
            if (permission == null) throw new ApiException(400, "Missing required parameter 'permission' when calling UpdatePermission");
            
    
            var path = "/auth/permissions/{permission}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "permission" + "}", ApiClient.ParameterToString(permission));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(permissionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PermissionResource) ApiClient.Deserialize(response.Content, typeof(PermissionResource), response.Headers);
        }
    
    }
}
