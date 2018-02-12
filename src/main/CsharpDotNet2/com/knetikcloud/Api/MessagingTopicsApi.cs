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
    public interface IMessagingTopicsApi
    {
        /// <summary>
        /// Enable or disable messages for a user Useful for opt-out options on a single topic. Consider multiple topics for multiple opt-out options.
        /// </summary>
        /// <param name="id">The id of the topic</param>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param>
        /// <param name="disabled">disabled</param>
        /// <returns></returns>
        void DisableTopicSubscriber (string id, string userId, ValueWrapperboolean disabled);
        /// <summary>
        /// Get a subscriber to a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the topic</param>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param>
        /// <returns>TopicSubscriberResource</returns>
        TopicSubscriberResource GetTopicSubscriber (string id, string userId);
        /// <summary>
        /// Get all subscribers to a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the topic</param>
        /// <returns>PageResourceTopicSubscriberResource</returns>
        PageResourceTopicSubscriberResource GetTopicSubscribers (string id);
        /// <summary>
        /// Get all messaging topics for a given user &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <returns>PageResourceTopicResource</returns>
        PageResourceTopicResource GetUserTopics (string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagingTopicsApi : IMessagingTopicsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTopicsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MessagingTopicsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingTopicsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingTopicsApi(String basePath)
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
        /// Enable or disable messages for a user Useful for opt-out options on a single topic. Consider multiple topics for multiple opt-out options.
        /// </summary>
        /// <param name="id">The id of the topic</param> 
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param> 
        /// <param name="disabled">disabled</param> 
        /// <returns></returns>            
        public void DisableTopicSubscriber (string id, string userId, ValueWrapperboolean disabled)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DisableTopicSubscriber");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DisableTopicSubscriber");
            
            // verify the required parameter 'disabled' is set
            if (disabled == null) throw new ApiException(400, "Missing required parameter 'disabled' when calling DisableTopicSubscriber");
            
    
            var path = "/messaging/topics/{id}/subscribers/{user_id}/disabled";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(disabled); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DisableTopicSubscriber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DisableTopicSubscriber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a subscriber to a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the topic</param> 
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param> 
        /// <returns>TopicSubscriberResource</returns>            
        public TopicSubscriberResource GetTopicSubscriber (string id, string userId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTopicSubscriber");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetTopicSubscriber");
            
    
            var path = "/messaging/topics/{id}/subscribers/{user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicSubscriber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicSubscriber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TopicSubscriberResource) ApiClient.Deserialize(response.Content, typeof(TopicSubscriberResource), response.Headers);
        }
    
        /// <summary>
        /// Get all subscribers to a topic &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the topic</param> 
        /// <returns>PageResourceTopicSubscriberResource</returns>            
        public PageResourceTopicSubscriberResource GetTopicSubscribers (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTopicSubscribers");
            
    
            var path = "/messaging/topics/{id}/subscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicSubscribers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTopicSubscribers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTopicSubscriberResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTopicSubscriberResource), response.Headers);
        }
    
        /// <summary>
        /// Get all messaging topics for a given user &lt;b&gt;Permissions Needed:&lt;/b&gt; TOPICS_ADMIN
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param> 
        /// <returns>PageResourceTopicResource</returns>            
        public PageResourceTopicResource GetUserTopics (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserTopics");
            
    
            var path = "/users/{id}/topics";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTopics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserTopics: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTopicResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTopicResource), response.Headers);
        }
    
    }
}
