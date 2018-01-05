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
    public interface IUsersGroupsApi
    {
        /// <summary>
        /// Adds a new member to the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="user">The id and status for a user to add to the group</param>
        /// <returns>GroupMemberResource</returns>
        GroupMemberResource AddMemberToGroup (string uniqueName, GroupMemberResource user);
        /// <summary>
        /// Adds multiple members to the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="users">The id and status for a list of users to add to the group</param>
        /// <returns>List&lt;GroupMemberResource&gt;</returns>
        List<GroupMemberResource> AddMembersToGroup (string uniqueName, List<GroupMemberResource> users);
        /// <summary>
        /// Create a group 
        /// </summary>
        /// <param name="groupResource">The new group</param>
        /// <returns>GroupResource</returns>
        GroupResource CreateGroup (GroupResource groupResource);
        /// <summary>
        /// Create an group member template GroupMember Templates define a type of group member and the properties they have
        /// </summary>
        /// <param name="groupMemberTemplateResource">The group member template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateGroupMemberTemplate (TemplateResource groupMemberTemplateResource);
        /// <summary>
        /// Create a group template Group Templates define a type of group and the properties they have
        /// </summary>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateGroupTemplate (TemplateResource groupTemplateResource);
        /// <summary>
        /// Removes a group from the system All groups listing this as the parent are also removed and users are in turn removed from this and those groups. This may result in users no longer being in this group&#39;s parent if they were not added to it directly as well.
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <returns></returns>
        void DeleteGroup (string uniqueName);
        /// <summary>
        /// Delete an group member template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteGroupMemberTemplate (string id, string cascade);
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
        /// Get group ancestors Returns a list of ancestor groups in reverse order (parent, then grandparent, etc
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <returns>List&lt;GroupResource&gt;</returns>
        List<GroupResource> GetGroupAncestors (string uniqueName);
        /// <summary>
        /// Get a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user</param>
        /// <returns>GroupMemberResource</returns>
        GroupMemberResource GetGroupMember (string uniqueName, int? userId);
        /// <summary>
        /// Get a single group member template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetGroupMemberTemplate (string id);
        /// <summary>
        /// List and search group member templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetGroupMemberTemplates (int? size, int? page, string order);
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
        /// <param name="filterChildren">Whether to limit group list to children of groups only. If true, shows only groups with parents. If false, shows only groups with no parent.</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetGroupsForUser (int? userId, bool? filterChildren);
        /// <summary>
        /// List and search groups 
        /// </summary>
        /// <param name="filterTemplate">Filter for groups using a specific template, by id</param>
        /// <param name="filterMemberCount">Filters groups by member count. Multiple values possible for range search. Format: filter_member_count&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_member_count&#x3D;GT,14,LT,17</param>
        /// <param name="filterName">Filter for groups with names starting with the given string</param>
        /// <param name="filterUniqueName">Filter for groups whose unique_name starts with provided string</param>
        /// <param name="filterParent">Filter for groups with a specific parent, by unique name</param>
        /// <param name="filterStatus">Filter for groups with a certain status</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceGroupResource</returns>
        PageResourceGroupResource ListGroups (string filterTemplate, string filterMemberCount, string filterName, string filterUniqueName, string filterParent, string filterStatus, int? size, int? page, string order);
        /// <summary>
        /// Removes a user from a group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The id of the user to remove</param>
        /// <returns></returns>
        void RemoveGroupMember (string uniqueName, int? userId);
        /// <summary>
        /// Update a group If adding/removing/changing parent, user membership in group/new parent groups may be modified. The parent being removed will remove members from this sub group unless they were added explicitly to the parent and the new parent will gain members unless they were already a part of it.
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="groupResource">The updated group</param>
        /// <returns></returns>
        void UpdateGroup (string uniqueName, GroupResource groupResource);
        /// <summary>
        /// Change a user&#39;s order 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The user id of the member to modify</param>
        /// <param name="order">The new order for the membership</param>
        /// <returns></returns>
        void UpdateGroupMemberProperties (string uniqueName, int? userId, StringWrapper order);
        /// <summary>
        /// Change a user&#39;s membership properties 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The user id of the member to modify</param>
        /// <param name="properties">The new properties for the membership</param>
        /// <returns></returns>
        void UpdateGroupMemberProperties1 (string uniqueName, int? userId, Object properties);
        /// <summary>
        /// Change a user&#39;s status 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param>
        /// <param name="userId">The user id of the member to modify</param>
        /// <param name="status">The new status for the user</param>
        /// <returns></returns>
        void UpdateGroupMemberStatus (string uniqueName, int? userId, string status);
        /// <summary>
        /// Update an group member template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="groupMemberTemplateResource">The group member template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateGroupMemberTemplate (string id, TemplateResource groupMemberTemplateResource);
        /// <summary>
        /// Update a group template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="groupTemplateResource">The group template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateGroupTemplate (string id, TemplateResource groupTemplateResource);
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
        /// <param name="user">The id and status for a user to add to the group</param> 
        /// <returns>GroupMemberResource</returns>            
        public GroupMemberResource AddMemberToGroup (string uniqueName, GroupMemberResource user)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling AddMemberToGroup");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AddMemberToGroup");
            
    
            var path = "/users/groups/{unique_name}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(user); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMemberToGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMemberToGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupMemberResource) ApiClient.Deserialize(response.Content, typeof(GroupMemberResource), response.Headers);
        }
    
        /// <summary>
        /// Adds multiple members to the group 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="users">The id and status for a list of users to add to the group</param> 
        /// <returns>List&lt;GroupMemberResource&gt;</returns>            
        public List<GroupMemberResource> AddMembersToGroup (string uniqueName, List<GroupMemberResource> users)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling AddMembersToGroup");
            
            // verify the required parameter 'users' is set
            if (users == null) throw new ApiException(400, "Missing required parameter 'users' when calling AddMembersToGroup");
            
    
            var path = "/users/groups/{unique_name}/members/batch-add";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(users); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersToGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersToGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupMemberResource>) ApiClient.Deserialize(response.Content, typeof(List<GroupMemberResource>), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupResource) ApiClient.Deserialize(response.Content, typeof(GroupResource), response.Headers);
        }
    
        /// <summary>
        /// Create an group member template GroupMember Templates define a type of group member and the properties they have
        /// </summary>
        /// <param name="groupMemberTemplateResource">The group member template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateGroupMemberTemplate (TemplateResource groupMemberTemplateResource)
        {
            
    
            var path = "/users/groups/members/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupMemberTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupMemberTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupMemberTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Removes a group from the system All groups listing this as the parent are also removed and users are in turn removed from this and those groups. This may result in users no longer being in this group&#39;s parent if they were not added to it directly as well.
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an group member template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteGroupMemberTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGroupMemberTemplate");
            
    
            var path = "/users/groups/members/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupMemberTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGroupMemberTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupResource) ApiClient.Deserialize(response.Content, typeof(GroupResource), response.Headers);
        }
    
        /// <summary>
        /// Get group ancestors Returns a list of ancestor groups in reverse order (parent, then grandparent, etc
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <returns>List&lt;GroupResource&gt;</returns>            
        public List<GroupResource> GetGroupAncestors (string uniqueName)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling GetGroupAncestors");
            
    
            var path = "/users/groups/{unique_name}/ancestors";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupAncestors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupAncestors: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupResource>) ApiClient.Deserialize(response.Content, typeof(List<GroupResource>), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GroupMemberResource) ApiClient.Deserialize(response.Content, typeof(GroupMemberResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single group member template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetGroupMemberTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGroupMemberTemplate");
            
    
            var path = "/users/groups/members/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMemberTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMemberTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search group member templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetGroupMemberTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/users/groups/members/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMemberTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupMemberTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
        /// <param name="filterChildren">Whether to limit group list to children of groups only. If true, shows only groups with parents. If false, shows only groups with no parent.</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetGroupsForUser (int? userId, bool? filterChildren)
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
    
             if (filterChildren != null) queryParams.Add("filter_children", ApiClient.ParameterToString(filterChildren)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGroupsForUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// List and search groups 
        /// </summary>
        /// <param name="filterTemplate">Filter for groups using a specific template, by id</param> 
        /// <param name="filterMemberCount">Filters groups by member count. Multiple values possible for range search. Format: filter_member_count&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_member_count&#x3D;GT,14,LT,17</param> 
        /// <param name="filterName">Filter for groups with names starting with the given string</param> 
        /// <param name="filterUniqueName">Filter for groups whose unique_name starts with provided string</param> 
        /// <param name="filterParent">Filter for groups with a specific parent, by unique name</param> 
        /// <param name="filterStatus">Filter for groups with a certain status</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceGroupResource</returns>            
        public PageResourceGroupResource ListGroups (string filterTemplate, string filterMemberCount, string filterName, string filterUniqueName, string filterParent, string filterStatus, int? size, int? page, string order)
        {
            
    
            var path = "/users/groups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTemplate != null) queryParams.Add("filter_template", ApiClient.ParameterToString(filterTemplate)); // query parameter
 if (filterMemberCount != null) queryParams.Add("filter_member_count", ApiClient.ParameterToString(filterMemberCount)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterUniqueName != null) queryParams.Add("filter_unique_name", ApiClient.ParameterToString(filterUniqueName)); // query parameter
 if (filterParent != null) queryParams.Add("filter_parent", ApiClient.ParameterToString(filterParent)); // query parameter
 if (filterStatus != null) queryParams.Add("filter_status", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceGroupResource) ApiClient.Deserialize(response.Content, typeof(PageResourceGroupResource), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveGroupMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveGroupMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a group If adding/removing/changing parent, user membership in group/new parent groups may be modified. The parent being removed will remove members from this sub group unless they were added explicitly to the parent and the new parent will gain members unless they were already a part of it.
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change a user&#39;s order 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="userId">The user id of the member to modify</param> 
        /// <param name="order">The new order for the membership</param> 
        /// <returns></returns>            
        public void UpdateGroupMemberProperties (string uniqueName, int? userId, StringWrapper order)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling UpdateGroupMemberProperties");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateGroupMemberProperties");
            
            // verify the required parameter 'order' is set
            if (order == null) throw new ApiException(400, "Missing required parameter 'order' when calling UpdateGroupMemberProperties");
            
    
            var path = "/users/groups/{unique_name}/members/{user_id}/order";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(order); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change a user&#39;s membership properties 
        /// </summary>
        /// <param name="uniqueName">The group unique name</param> 
        /// <param name="userId">The user id of the member to modify</param> 
        /// <param name="properties">The new properties for the membership</param> 
        /// <returns></returns>            
        public void UpdateGroupMemberProperties1 (string uniqueName, int? userId, Object properties)
        {
            
            // verify the required parameter 'uniqueName' is set
            if (uniqueName == null) throw new ApiException(400, "Missing required parameter 'uniqueName' when calling UpdateGroupMemberProperties1");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateGroupMemberProperties1");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateGroupMemberProperties1");
            
    
            var path = "/users/groups/{unique_name}/members/{user_id}/properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "unique_name" + "}", ApiClient.ParameterToString(uniqueName));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(properties); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberProperties1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberProperties1: " + response.ErrorMessage, response.ErrorMessage);
    
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an group member template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="groupMemberTemplateResource">The group member template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateGroupMemberTemplate (string id, TemplateResource groupMemberTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateGroupMemberTemplate");
            
    
            var path = "/users/groups/members/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(groupMemberTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupMemberTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGroupTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
