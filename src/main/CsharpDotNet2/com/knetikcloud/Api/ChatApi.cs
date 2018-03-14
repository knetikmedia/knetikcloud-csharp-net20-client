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
    public interface IChatApi
    {
        /// <summary>
        /// Acknowledge number of messages in a thread &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The thread id</param>
        /// <param name="readCount">The amount of messages read</param>
        /// <returns></returns>
        void AcknowledgeChatMessage (string id, int? readCount);
        /// <summary>
        /// Add a user to a chat message blacklist &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="blacklistedUserId">The user id to blacklist</param>
        /// <param name="id">The user id or &#39;me&#39;</param>
        /// <returns></returns>
        void AddChatMessageBlacklist (int? blacklistedUserId, string id);
        /// <summary>
        /// Delete a message &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The message id</param>
        /// <returns></returns>
        void DeleteChatMessage (string id);
        /// <summary>
        /// Edit your message &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The message id</param>
        /// <param name="chatMessageResource">The chat message resource</param>
        /// <returns></returns>
        void EditChatMessage (string id, ChatMessageResource chatMessageResource);
        /// <summary>
        /// Get a message &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The message id</param>
        /// <returns>ChatMessageResource</returns>
        ChatMessageResource GetChatMessage (string id);
        /// <summary>
        /// Get a list of blocked users for chat messaging &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The user id or &#39;me&#39;</param>
        /// <returns>List&lt;ChatBlacklistResource&gt;</returns>
        List<ChatBlacklistResource> GetChatMessageBlacklist (string id);
        /// <summary>
        /// List your threads &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceChatUserThreadResource</returns>
        PageResourceChatUserThreadResource GetChatThreads (int? size, int? page, string order);
        /// <summary>
        /// List messages with a user &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The user id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceChatMessageResource</returns>
        PageResourceChatMessageResource GetDirectMessages (int? id, int? size, int? page, string order);
        /// <summary>
        /// List messages in a thread &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The thread id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceChatMessageResource</returns>
        PageResourceChatMessageResource GetThreadMessages (string id, int? size, int? page, string order);
        /// <summary>
        /// List messages in a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The topic id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceChatMessageResource</returns>
        PageResourceChatMessageResource GetTopicMessages (string id, int? size, int? page, string order);
        /// <summary>
        /// Remove a user from a blacklist &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="blacklistedUserId">The user id to blacklist</param>
        /// <param name="id">The user id or &#39;me&#39;</param>
        /// <returns></returns>
        void RemoveChatBlacklist (int? blacklistedUserId, string id);
        /// <summary>
        /// Send a message &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="chatMessageResource">The chat message resource</param>
        /// <returns>ChatMessageResource</returns>
        ChatMessageResource SendChatMessage (ChatMessageResource chatMessageResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChatApi : IChatApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ChatApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChatApi(String basePath)
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
        /// Acknowledge number of messages in a thread &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The thread id</param> 
        /// <param name="readCount">The amount of messages read</param> 
        /// <returns></returns>            
        public void AcknowledgeChatMessage (string id, int? readCount)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AcknowledgeChatMessage");
            
    
            var path = "/chat/threads/{id}/acknowledge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(readCount); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AcknowledgeChatMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AcknowledgeChatMessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a user to a chat message blacklist &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="blacklistedUserId">The user id to blacklist</param> 
        /// <param name="id">The user id or &#39;me&#39;</param> 
        /// <returns></returns>            
        public void AddChatMessageBlacklist (int? blacklistedUserId, string id)
        {
            
            // verify the required parameter 'blacklistedUserId' is set
            if (blacklistedUserId == null) throw new ApiException(400, "Missing required parameter 'blacklistedUserId' when calling AddChatMessageBlacklist");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddChatMessageBlacklist");
            
    
            var path = "/chat/users/{id}/blacklist/{blacklisted_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "blacklisted_user_id" + "}", ApiClient.ParameterToString(blacklistedUserId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddChatMessageBlacklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddChatMessageBlacklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a message &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The message id</param> 
        /// <returns></returns>            
        public void DeleteChatMessage (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteChatMessage");
            
    
            var path = "/chat/messages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChatMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChatMessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit your message &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The message id</param> 
        /// <param name="chatMessageResource">The chat message resource</param> 
        /// <returns></returns>            
        public void EditChatMessage (string id, ChatMessageResource chatMessageResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditChatMessage");
            
    
            var path = "/chat/messages/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(chatMessageResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditChatMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditChatMessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a message &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The message id</param> 
        /// <returns>ChatMessageResource</returns>            
        public ChatMessageResource GetChatMessage (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetChatMessage");
            
    
            var path = "/chat/messages/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatMessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChatMessageResource) ApiClient.Deserialize(response.Content, typeof(ChatMessageResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of blocked users for chat messaging &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The user id or &#39;me&#39;</param> 
        /// <returns>List&lt;ChatBlacklistResource&gt;</returns>            
        public List<ChatBlacklistResource> GetChatMessageBlacklist (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetChatMessageBlacklist");
            
    
            var path = "/chat/users/{id}/blacklist";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatMessageBlacklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatMessageBlacklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ChatBlacklistResource>) ApiClient.Deserialize(response.Content, typeof(List<ChatBlacklistResource>), response.Headers);
        }
    
        /// <summary>
        /// List your threads &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceChatUserThreadResource</returns>            
        public PageResourceChatUserThreadResource GetChatThreads (int? size, int? page, string order)
        {
            
    
            var path = "/chat/threads";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatThreads: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChatThreads: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChatUserThreadResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChatUserThreadResource), response.Headers);
        }
    
        /// <summary>
        /// List messages with a user &lt;b&gt;Permissions Needed:&lt;/b&gt; owner
        /// </summary>
        /// <param name="id">The user id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceChatMessageResource</returns>            
        public PageResourceChatMessageResource GetDirectMessages (int? id, int? size, int? page, string order)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDirectMessages");
            
    
            var path = "/chat/users/{id}/messages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDirectMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDirectMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChatMessageResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChatMessageResource), response.Headers);
        }
    
        /// <summary>
        /// List messages in a thread &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The thread id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceChatMessageResource</returns>            
        public PageResourceChatMessageResource GetThreadMessages (string id, int? size, int? page, string order)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetThreadMessages");
            
    
            var path = "/chat/threads/{id}/messages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetThreadMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetThreadMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChatMessageResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChatMessageResource), response.Headers);
        }
    
        /// <summary>
        /// List messages in a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="id">The topic id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceChatMessageResource</returns>            
        public PageResourceChatMessageResource GetTopicMessages (string id, int? size, int? page, string order)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTopicMessages");
            
    
            var path = "/chat/topics/{id}/messages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicMessages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChatMessageResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChatMessageResource), response.Headers);
        }
    
        /// <summary>
        /// Remove a user from a blacklist &lt;b&gt;Permissions Needed:&lt;/b&gt; CHAT_ADMIN or owner
        /// </summary>
        /// <param name="blacklistedUserId">The user id to blacklist</param> 
        /// <param name="id">The user id or &#39;me&#39;</param> 
        /// <returns></returns>            
        public void RemoveChatBlacklist (int? blacklistedUserId, string id)
        {
            
            // verify the required parameter 'blacklistedUserId' is set
            if (blacklistedUserId == null) throw new ApiException(400, "Missing required parameter 'blacklistedUserId' when calling RemoveChatBlacklist");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveChatBlacklist");
            
    
            var path = "/chat/users/{id}/blacklist/{blacklisted_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "blacklisted_user_id" + "}", ApiClient.ParameterToString(blacklistedUserId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveChatBlacklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveChatBlacklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a message &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="chatMessageResource">The chat message resource</param> 
        /// <returns>ChatMessageResource</returns>            
        public ChatMessageResource SendChatMessage (ChatMessageResource chatMessageResource)
        {
            
    
            var path = "/chat/messages";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(chatMessageResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendChatMessage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendChatMessage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChatMessageResource) ApiClient.Deserialize(response.Content, typeof(ChatMessageResource), response.Headers);
        }
    
    }
}
