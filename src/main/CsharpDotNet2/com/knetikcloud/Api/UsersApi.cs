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
    public interface IUsersApi
    {
        /// <summary>
        /// Add a tag to a user 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="tag">tag</param>
        /// <returns></returns>
        void AddUserTag (int? userId, string tag);
        /// <summary>
        /// Create a user template User Templates define a type of user and the properties they have
        /// </summary>
        /// <param name="userTemplateResource">The user template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateUserTemplate (TemplateResource userTemplateResource);
        /// <summary>
        /// Delete a user template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteUserTemplate (string id, string cascade);
        /// <summary>
        /// Get a single user Additional private info is included as USERS_ADMIN
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <returns>UserResource</returns>
        UserResource GetUser (string id);
        /// <summary>
        /// List tags for a user 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetUserTags (int? userId);
        /// <summary>
        /// Get a single user template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetUserTemplate (string id);
        /// <summary>
        /// List and search user templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetUserTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search users Additional private info is included as USERS_ADMIN
        /// </summary>
        /// <param name="filterDisplayname">Filter for users whose display name starts with provided string.</param>
        /// <param name="filterEmail">Filter for users whose email starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterFirstname">Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterFullname">Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterLastname">Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterUsername">Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission</param>
        /// <param name="filterTag">Filter for users who have a given tag</param>
        /// <param name="filterGroup">Filter for users in a given group, by unique name</param>
        /// <param name="filterRole">Filter for users with a given role</param>
        /// <param name="filterSearch">Filter for users whose display_name starts with the provided string, or username if display_name is null</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceUserBaseResource</returns>
        PageResourceUserBaseResource GetUsers (string filterDisplayname, string filterEmail, string filterFirstname, string filterFullname, string filterLastname, string filterUsername, string filterTag, string filterGroup, string filterRole, string filterSearch, int? size, int? page, string order);
        /// <summary>
        /// Choose a new password after a reset Finish resetting a user&#39;s password using the secret provided from the password-reset endpoint.  Password should be in plain text and will be encrypted on receipt. Use SSL for security.
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <param name="newPasswordRequest">The new password request object</param>
        /// <returns></returns>
        void PasswordReset (int? id, NewPasswordRequest newPasswordRequest);
        /// <summary>
        /// Register a new user Password should be in plain text and will be encrypted on receipt. Use SSL for security
        /// </summary>
        /// <param name="userResource">The user resource object</param>
        /// <returns>UserResource</returns>
        UserResource RegisterUser (UserResource userResource);
        /// <summary>
        /// Remove a tag from a user 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="tag">The tag to remove</param>
        /// <returns></returns>
        void RemoveUserTag (int? userId, string tag);
        /// <summary>
        /// Set a user&#39;s password Password should be in plain text and will be encrypted on receipt. Use SSL for security.
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <param name="password">The new plain text password</param>
        /// <returns></returns>
        void SetPassword (int? id, string password);
        /// <summary>
        /// Reset a user&#39;s password A reset code will be generated and a &#39;forgot_password&#39; BRE event will be fired with that code; this can be routed to the user as needed and submitted to the &#39;choose a new password&#39; endpoint.
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <returns></returns>
        void StartPasswordReset (int? id);
        /// <summary>
        /// Update a user Password will not be edited on this endpoint, use password specific endpoints.
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <param name="userResource">The user resource object</param>
        /// <returns></returns>
        void UpdateUser (string id, UserResource userResource);
        /// <summary>
        /// Update a user template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="userTemplateResource">The user template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateUserTemplate (string id, TemplateResource userTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Add a tag to a user 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="tag">tag</param> 
        /// <returns></returns>            
        public void AddUserTag (int? userId, string tag)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling AddUserTag");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling AddUserTag");
            
    
            var path = "/users/{user_id}/tags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tag); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserTag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserTag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a user template User Templates define a type of user and the properties they have
        /// </summary>
        /// <param name="userTemplateResource">The user template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateUserTemplate (TemplateResource userTemplateResource)
        {
            
    
            var path = "/users/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUserTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUserTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a user template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteUserTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUserTemplate");
            
    
            var path = "/users/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single user Additional private info is included as USERS_ADMIN
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param> 
        /// <returns>UserResource</returns>            
        public UserResource GetUser (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path = "/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResource) ApiClient.Deserialize(response.Content, typeof(UserResource), response.Headers);
        }
    
        /// <summary>
        /// List tags for a user 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetUserTags (int? userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserTags");
            
    
            var path = "/users/{user_id}/tags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Get a single user template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetUserTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserTemplate");
            
    
            var path = "/users/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search user templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetUserTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/users/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search users Additional private info is included as USERS_ADMIN
        /// </summary>
        /// <param name="filterDisplayname">Filter for users whose display name starts with provided string.</param> 
        /// <param name="filterEmail">Filter for users whose email starts with provided string. Requires USERS_ADMIN permission</param> 
        /// <param name="filterFirstname">Filter for users whose first name starts with provided string. Requires USERS_ADMIN permission</param> 
        /// <param name="filterFullname">Filter for users whose full name starts with provided string. Requires USERS_ADMIN permission</param> 
        /// <param name="filterLastname">Filter for users whose last name starts with provided string. Requires USERS_ADMIN permission</param> 
        /// <param name="filterUsername">Filter for users whose username starts with the provided string. Requires USERS_ADMIN permission</param> 
        /// <param name="filterTag">Filter for users who have a given tag</param> 
        /// <param name="filterGroup">Filter for users in a given group, by unique name</param> 
        /// <param name="filterRole">Filter for users with a given role</param> 
        /// <param name="filterSearch">Filter for users whose display_name starts with the provided string, or username if display_name is null</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceUserBaseResource</returns>            
        public PageResourceUserBaseResource GetUsers (string filterDisplayname, string filterEmail, string filterFirstname, string filterFullname, string filterLastname, string filterUsername, string filterTag, string filterGroup, string filterRole, string filterSearch, int? size, int? page, string order)
        {
            
    
            var path = "/users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterDisplayname != null) queryParams.Add("filter_displayname", ApiClient.ParameterToString(filterDisplayname)); // query parameter
 if (filterEmail != null) queryParams.Add("filter_email", ApiClient.ParameterToString(filterEmail)); // query parameter
 if (filterFirstname != null) queryParams.Add("filter_firstname", ApiClient.ParameterToString(filterFirstname)); // query parameter
 if (filterFullname != null) queryParams.Add("filter_fullname", ApiClient.ParameterToString(filterFullname)); // query parameter
 if (filterLastname != null) queryParams.Add("filter_lastname", ApiClient.ParameterToString(filterLastname)); // query parameter
 if (filterUsername != null) queryParams.Add("filter_username", ApiClient.ParameterToString(filterUsername)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterGroup != null) queryParams.Add("filter_group", ApiClient.ParameterToString(filterGroup)); // query parameter
 if (filterRole != null) queryParams.Add("filter_role", ApiClient.ParameterToString(filterRole)); // query parameter
 if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserBaseResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserBaseResource), response.Headers);
        }
    
        /// <summary>
        /// Choose a new password after a reset Finish resetting a user&#39;s password using the secret provided from the password-reset endpoint.  Password should be in plain text and will be encrypted on receipt. Use SSL for security.
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <param name="newPasswordRequest">The new password request object</param> 
        /// <returns></returns>            
        public void PasswordReset (int? id, NewPasswordRequest newPasswordRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PasswordReset");
            
    
            var path = "/users/{id}/password-reset";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(newPasswordRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PasswordReset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PasswordReset: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register a new user Password should be in plain text and will be encrypted on receipt. Use SSL for security
        /// </summary>
        /// <param name="userResource">The user resource object</param> 
        /// <returns>UserResource</returns>            
        public UserResource RegisterUser (UserResource userResource)
        {
            
    
            var path = "/users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserResource) ApiClient.Deserialize(response.Content, typeof(UserResource), response.Headers);
        }
    
        /// <summary>
        /// Remove a tag from a user 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="tag">The tag to remove</param> 
        /// <returns></returns>            
        public void RemoveUserTag (int? userId, string tag)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveUserTag");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling RemoveUserTag");
            
    
            var path = "/users/{user_id}/tags/{tag}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserTag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserTag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a user&#39;s password Password should be in plain text and will be encrypted on receipt. Use SSL for security.
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <param name="password">The new plain text password</param> 
        /// <returns></returns>            
        public void SetPassword (int? id, string password)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetPassword");
            
    
            var path = "/users/{id}/password";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(password); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPassword: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPassword: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Reset a user&#39;s password A reset code will be generated and a &#39;forgot_password&#39; BRE event will be fired with that code; this can be routed to the user as needed and submitted to the &#39;choose a new password&#39; endpoint.
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <returns></returns>            
        public void StartPasswordReset (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StartPasswordReset");
            
    
            var path = "/users/{id}/password-reset";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StartPasswordReset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StartPasswordReset: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a user Password will not be edited on this endpoint, use password specific endpoints.
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param> 
        /// <param name="userResource">The user resource object</param> 
        /// <returns></returns>            
        public void UpdateUser (string id, UserResource userResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUser");
            
    
            var path = "/users/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a user template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="userTemplateResource">The user template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateUserTemplate (string id, TemplateResource userTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUserTemplate");
            
    
            var path = "/users/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
