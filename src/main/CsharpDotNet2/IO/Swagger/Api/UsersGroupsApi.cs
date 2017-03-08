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
    public interface IUsersGroupsApi
    {
        /// <summary>
        /// Adds a new member to the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="username">The username of a user to add to the group</param>
        /// <returns>GroupMemberResource</returns>
        GroupMemberResource AddMemberToGroup (string uniqueName, GroupMemberResource username);
        /// <summary>
        /// Create a group 
        /// </summary>
        /// <param name="groupResource">The new group</param>
        /// <returns>GroupResource</returns>
        GroupResource CreateGroup (GroupResource groupResource);
        /// <summary>
        /// Create a group template Group Templates define a type of group and the properties they have
        /// </summary>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateGroupTemplate (TemplateResource groupTemplateResource);
        /// <summary>
        /// Removes a group from the system IF no resources are attached to it 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <returns></returns>
        void DeleteGroup (string uniqueName);
        /// <summary>
        /// Delete a group template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteGroupTemplate (string id, string cascade);
        /// <summary>
        /// Loads a specific group&#39;s details 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <returns>GroupResource</returns>
        GroupResource GetGroup (string uniqueName);
        /// <summary>
        /// Get a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user</param>
        /// <returns>GroupMemberResource</returns>
        GroupMemberResource GetGroupMember (string uniqueName, int? userId);
        /// <summary>
        /// Lists members of the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceGroupMemberResource</returns>
        PageResourceGroupMemberResource GetGroupMembers (string uniqueName, int? size, int? page, string order);
        /// <summary>
        /// Get a single group template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetGroupTemplate (string id);
        /// <summary>
        /// List and search group templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetGroupTemplates (int? size, int? page, string order);
        /// <summary>
        /// List groups a user is in 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetGroupsForUser (int? userId);
        /// <summary>
        /// Removes a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user to remove</param>
        /// <returns></returns>
        void RemoveGroupMember (string uniqueName, int? userId);
        /// <summary>
        /// Update a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="groupResource">The updated group</param>
        /// <returns></returns>
        void UpdateGroup (string uniqueName, GroupResource groupResource);
        /// <summary>
        /// Change a user&#39;s status 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The user id of the member to modify</param>
        /// <param name="status">The new status for the user</param>
        /// <returns></returns>
        void UpdateGroupMemberStatus (string uniqueName, int? userId, string status);
        /// <summary>
        /// Update a group template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateGroupTemplate (string id, TemplateResource groupTemplateResource);
        /// <summary>
        /// List and search groups 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceGroupResource</returns>
        PageResourceGroupResource UpdateGroups (int? size, int? page, string order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersGroupsApi : IUsersGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersGroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersGroupsApi(String basePath)
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
        /// Adds a new member to the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="username">The username of a user to add to the group</param> 
        /// <returns>GroupMemberResource</returns>            
        public GroupMemberResource AddMemberToGroup (string uniqueName, GroupMemberResource username)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling AddMemberToGroup");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling AddMemberToGroup");
            
    
            var path = "/users/groups/{unique_name}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(username); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMemberToGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMemberToGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupMemberResource) ApiClient.Deserialize(response.Content, typeof(GroupMemberResource), response.Headers);
        }
    
        /// <summary>
        /// Create a group 
        /// </summary>
        /// <param name="groupResource">The new group</param> 
        /// <returns>GroupResource</returns>            
        public GroupResource CreateGroup (GroupResource groupResource)
        {
            
    
            var path = "/users/groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupResource) ApiClient.Deserialize(response.Content, typeof(GroupResource), response.Headers);
        }
    
        /// <summary>
        /// Create a group template Group Templates define a type of group and the properties they have
        /// </summary>
        /// <param name="groupTemplateResource">The group template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateGroupTemplate (TemplateResource groupTemplateResource)
        {
            
    
            var path = "/users/groups/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Removes a group from the system IF no resources are attached to it 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <returns></returns>            
        public void DeleteGroup (string uniqueName)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling DeleteGroup");
            
    
            var path = "/users/groups/{unique_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a group template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteGroupTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGroupTemplate");
            
    
            var path = "/users/groups/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Loads a specific group&#39;s details 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <returns>GroupResource</returns>            
        public GroupResource GetGroup (string uniqueName)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling GetGroup");
            
    
            var path = "/users/groups/{unique_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupResource) ApiClient.Deserialize(response.Content, typeof(GroupResource), response.Headers);
        }
    
        /// <summary>
        /// Get a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="userId">The id of the user</param> 
        /// <returns>GroupMemberResource</returns>            
        public GroupMemberResource GetGroupMember (string uniqueName, int? userId)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling GetGroupMember");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetGroupMember");
            
    
            var path = "/users/groups/{unique_name}/members/{user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupMemberResource) ApiClient.Deserialize(response.Content, typeof(GroupMemberResource), response.Headers);
        }
    
        /// <summary>
        /// Lists members of the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceGroupMemberResource</returns>            
        public PageResourceGroupMemberResource GetGroupMembers (string uniqueName, int? size, int? page, string order)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling GetGroupMembers");
            
    
            var path = "/users/groups/{unique_name}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceGroupMemberResource) ApiClient.Deserialize(response.Content, typeof(PageResourceGroupMemberResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single group template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetGroupTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGroupTemplate");
            
    
            var path = "/users/groups/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search group templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetGroupTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/users/groups/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List groups a user is in 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetGroupsForUser (int? userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetGroupsForUser");
            
    
            var path = "/users/{user_id}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupsForUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Removes a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="userId">The id of the user to remove</param> 
        /// <returns></returns>            
        public void RemoveGroupMember (string uniqueName, int? userId)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling RemoveGroupMember");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveGroupMember");
            
    
            var path = "/users/groups/{unique_name}/members/{user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveGroupMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveGroupMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="groupResource">The updated group</param> 
        /// <returns></returns>            
        public void UpdateGroup (string uniqueName, GroupResource groupResource)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling UpdateGroup");
            
    
            var path = "/users/groups/{unique_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change a user&#39;s status 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="userId">The user id of the member to modify</param> 
        /// <param name="status">The new status for the user</param> 
        /// <returns></returns>            
        public void UpdateGroupMemberStatus (string uniqueName, int? userId, string status)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling UpdateGroupMemberStatus");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateGroupMemberStatus");
            
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling UpdateGroupMemberStatus");
            
    
            var path = "/users/groups/{unique_name}/members/{user_id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(status); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a group template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="groupTemplateResource">The group template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateGroupTemplate (string id, TemplateResource groupTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateGroupTemplate");
            
    
            var path = "/users/groups/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search groups 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceGroupResource</returns>            
        public PageResourceGroupResource UpdateGroups (int? size, int? page, string order)
        {
            
    
            var path = "/users/groups";
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceGroupResource) ApiClient.Deserialize(response.Content, typeof(PageResourceGroupResource), response.Headers);
        }
    
    }
}
