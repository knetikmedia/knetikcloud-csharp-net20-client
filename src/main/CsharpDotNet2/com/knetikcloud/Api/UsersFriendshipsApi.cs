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
    public interface IUsersFriendshipsApi
    {
        /// <summary>
        /// Add a friend As a user, either creates or confirm a pending request. As an admin, call this endpoint twice while inverting the IDs to create a confirmed friendship.
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="id">The id of the user to befriend</param>
        /// <returns></returns>
        void AddFriend (string userId, int? id);
        /// <summary>
        /// Get friends list 
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceSimpleUserResource</returns>
        PageResourceSimpleUserResource GetFriends (string userId, int? size, int? page);
        /// <summary>
        /// Returns the invite token This is a unique invite token that allows direct connection to the request user.  Exposing that token presents privacy issues if the token is leaked. Use friend request flow instead if confirmation is required
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <returns>string</returns>
        string GetInviteToken (string userId);
        /// <summary>
        /// Get pending invites Invites that the specified user received
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceSimpleUserResource</returns>
        PageResourceSimpleUserResource GetInvites (string userId, int? size, int? page);
        /// <summary>
        /// Redeem friendship token Immediately connects the requested user with the user mapped by the provided invite token
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="token">The invite token</param>
        /// <returns></returns>
        void RedeemFriendshipToken (string userId, string token);
        /// <summary>
        /// Remove or decline a friend 
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param>
        /// <param name="id">The id of the user to befriend</param>
        /// <returns></returns>
        void RemoveOrDeclineFriend (string userId, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersFriendshipsApi : IUsersFriendshipsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersFriendshipsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersFriendshipsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersFriendshipsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersFriendshipsApi(String basePath)
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
        /// Add a friend As a user, either creates or confirm a pending request. As an admin, call this endpoint twice while inverting the IDs to create a confirmed friendship.
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param> 
        /// <param name="id">The id of the user to befriend</param> 
        /// <returns></returns>            
        public void AddFriend (string userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling AddFriend");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddFriend");
            
    
            var path = "/users/{user_id}/friends/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFriend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFriend: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get friends list 
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceSimpleUserResource</returns>            
        public PageResourceSimpleUserResource GetFriends (string userId, int? size, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetFriends");
            
    
            var path = "/users/{user_id}/friends";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFriends: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFriends: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSimpleUserResource) ApiClient.Deserialize(response.Content, typeof(PageResourceSimpleUserResource), response.Headers);
        }
    
        /// <summary>
        /// Returns the invite token This is a unique invite token that allows direct connection to the request user.  Exposing that token presents privacy issues if the token is leaked. Use friend request flow instead if confirmation is required
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param> 
        /// <returns>string</returns>            
        public string GetInviteToken (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetInviteToken");
            
    
            var path = "/users/{user_id}/invite-token";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInviteToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInviteToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get pending invites Invites that the specified user received
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceSimpleUserResource</returns>            
        public PageResourceSimpleUserResource GetInvites (string userId, int? size, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetInvites");
            
    
            var path = "/users/{user_id}/invites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvites: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvites: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSimpleUserResource) ApiClient.Deserialize(response.Content, typeof(PageResourceSimpleUserResource), response.Headers);
        }
    
        /// <summary>
        /// Redeem friendship token Immediately connects the requested user with the user mapped by the provided invite token
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param> 
        /// <param name="token">The invite token</param> 
        /// <returns></returns>            
        public void RedeemFriendshipToken (string userId, string token)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RedeemFriendshipToken");
            
    
            var path = "/users/{user_id}/friends/tokens";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(token); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RedeemFriendshipToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RedeemFriendshipToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove or decline a friend 
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39; if logged in</param> 
        /// <param name="id">The id of the user to befriend</param> 
        /// <returns></returns>            
        public void RemoveOrDeclineFriend (string userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveOrDeclineFriend");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveOrDeclineFriend");
            
    
            var path = "/users/{user_id}/friends/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveOrDeclineFriend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveOrDeclineFriend: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
