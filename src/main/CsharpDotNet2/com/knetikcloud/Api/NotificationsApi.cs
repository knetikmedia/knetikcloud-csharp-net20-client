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
    public interface INotificationsApi
    {
        /// <summary>
        /// Create a notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="notificationType">notificationType</param>
        /// <returns>NotificationTypeResource</returns>
        NotificationTypeResource CreateNotificationType (NotificationTypeResource notificationType);
        /// <summary>
        /// Delete a notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        void DeleteNotificationType (string id);
        /// <summary>
        /// Get a single notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>NotificationTypeResource</returns>
        NotificationTypeResource GetNotificationType (string id);
        /// <summary>
        /// List and search notification types Get a list of notification type with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceNotificationTypeResource</returns>
        PageResourceNotificationTypeResource GetNotificationTypes (int? size, int? page, string order);
        /// <summary>
        /// View a user&#39;s notification settings for a type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="typeId">The id of the topic</param>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param>
        /// <returns>NotificationUserTypeResource</returns>
        NotificationUserTypeResource GetUserNotificationInfo (string typeId, string userId);
        /// <summary>
        /// View a user&#39;s notification settings &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceNotificationUserTypeResource</returns>
        PageResourceNotificationUserTypeResource GetUserNotificationInfoList (string userId, int? size, int? page, string order);
        /// <summary>
        /// Get notifications &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param>
        /// <param name="filterStatus">filter for notifications with a given status</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceUserNotificationResource</returns>
        PageResourceUserNotificationResource GetUserNotifications (string id, string filterStatus, int? size, int? page, string order);
        /// <summary>
        /// Send a notification &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="notification">notification</param>
        /// <returns>NotificationResource</returns>
        NotificationResource SendNotification (NotificationResource notification);
        /// <summary>
        /// Set notification status &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param>
        /// <param name="notificationId">The id of the notification</param>
        /// <param name="notification">status</param>
        /// <returns></returns>
        void SetUserNotificationStatus (string userId, string notificationId, UserNotificationStatusWrapper notification);
        /// <summary>
        /// Enable or disable direct notifications for a user Allows enabling or disabling messages for a given notification type when sent direct to the user. Notifications can still be retrieved by endpoint. For notifications broadcased to a topic, see the topic service to disable messages for the user there. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="typeId">The id of the topic</param>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param>
        /// <param name="silenced">silenced</param>
        /// <returns></returns>
        void SilenceDirectNotifications (string typeId, string userId, ValueWrapperboolean silenced);
        /// <summary>
        /// Update a notificationType &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="notificationType">notificationType</param>
        /// <returns>NotificationTypeResource</returns>
        NotificationTypeResource UpdateNotificationType (string id, NotificationTypeResource notificationType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationsApi : INotificationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi(String basePath)
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
        /// Create a notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="notificationType">notificationType</param> 
        /// <returns>NotificationTypeResource</returns>            
        public NotificationTypeResource CreateNotificationType (NotificationTypeResource notificationType)
        {
            
    
            var path = "/notifications/types";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(notificationType); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNotificationType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNotificationType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationTypeResource) ApiClient.Deserialize(response.Content, typeof(NotificationTypeResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns></returns>            
        public void DeleteNotificationType (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteNotificationType");
            
    
            var path = "/notifications/types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNotificationType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteNotificationType: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single notification type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>NotificationTypeResource</returns>            
        public NotificationTypeResource GetNotificationType (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNotificationType");
            
    
            var path = "/notifications/types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationTypeResource) ApiClient.Deserialize(response.Content, typeof(NotificationTypeResource), response.Headers);
        }
    
        /// <summary>
        /// List and search notification types Get a list of notification type with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceNotificationTypeResource</returns>            
        public PageResourceNotificationTypeResource GetNotificationTypes (int? size, int? page, string order)
        {
            
    
            var path = "/notifications/types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceNotificationTypeResource) ApiClient.Deserialize(response.Content, typeof(PageResourceNotificationTypeResource), response.Headers);
        }
    
        /// <summary>
        /// View a user&#39;s notification settings for a type &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="typeId">The id of the topic</param> 
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param> 
        /// <returns>NotificationUserTypeResource</returns>            
        public NotificationUserTypeResource GetUserNotificationInfo (string typeId, string userId)
        {
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling GetUserNotificationInfo");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserNotificationInfo");
            
    
            var path = "/users/{user_id}/notifications/types/{type_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_id" + "}", ApiClient.ParameterToString(typeId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotificationInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotificationInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationUserTypeResource) ApiClient.Deserialize(response.Content, typeof(NotificationUserTypeResource), response.Headers);
        }
    
        /// <summary>
        /// View a user&#39;s notification settings &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceNotificationUserTypeResource</returns>            
        public PageResourceNotificationUserTypeResource GetUserNotificationInfoList (string userId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserNotificationInfoList");
            
    
            var path = "/users/{user_id}/notifications/types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotificationInfoList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotificationInfoList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceNotificationUserTypeResource) ApiClient.Deserialize(response.Content, typeof(PageResourceNotificationUserTypeResource), response.Headers);
        }
    
        /// <summary>
        /// Get notifications &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="id">The id of the user or &#39;me&#39;</param> 
        /// <param name="filterStatus">filter for notifications with a given status</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceUserNotificationResource</returns>            
        public PageResourceUserNotificationResource GetUserNotifications (string id, string filterStatus, int? size, int? page, string order)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserNotifications");
            
    
            var path = "/users/{id}/notifications";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterStatus != null) queryParams.Add("filter_status", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotifications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserNotifications: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserNotificationResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserNotificationResource), response.Headers);
        }
    
        /// <summary>
        /// Send a notification &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="notification">notification</param> 
        /// <returns>NotificationResource</returns>            
        public NotificationResource SendNotification (NotificationResource notification)
        {
            
    
            var path = "/notifications";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(notification); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationResource) ApiClient.Deserialize(response.Content, typeof(NotificationResource), response.Headers);
        }
    
        /// <summary>
        /// Set notification status &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="userId">The id of the user or &#39;me&#39;</param> 
        /// <param name="notificationId">The id of the notification</param> 
        /// <param name="notification">status</param> 
        /// <returns></returns>            
        public void SetUserNotificationStatus (string userId, string notificationId, UserNotificationStatusWrapper notification)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetUserNotificationStatus");
            
            // verify the required parameter 'notificationId' is set
            if (notificationId == null) throw new ApiException(400, "Missing required parameter 'notificationId' when calling SetUserNotificationStatus");
            
    
            var path = "/users/{user_id}/notifications/{notification_id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "notification_id" + "}", ApiClient.ParameterToString(notificationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(notification); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserNotificationStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserNotificationStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Enable or disable direct notifications for a user Allows enabling or disabling messages for a given notification type when sent direct to the user. Notifications can still be retrieved by endpoint. For notifications broadcased to a topic, see the topic service to disable messages for the user there. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN or self
        /// </summary>
        /// <param name="typeId">The id of the topic</param> 
        /// <param name="userId">The id of the subscriber or &#39;me&#39;</param> 
        /// <param name="silenced">silenced</param> 
        /// <returns></returns>            
        public void SilenceDirectNotifications (string typeId, string userId, ValueWrapperboolean silenced)
        {
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling SilenceDirectNotifications");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SilenceDirectNotifications");
            
            // verify the required parameter 'silenced' is set
            if (silenced == null) throw new ApiException(400, "Missing required parameter 'silenced' when calling SilenceDirectNotifications");
            
    
            var path = "/users/{user_id}/notifications/types/{type_id}/silenced";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_id" + "}", ApiClient.ParameterToString(typeId));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(silenced); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SilenceDirectNotifications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SilenceDirectNotifications: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a notificationType &lt;b&gt;Permissions Needed:&lt;/b&gt; NOTIFICATIONS_ADMIN
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="notificationType">notificationType</param> 
        /// <returns>NotificationTypeResource</returns>            
        public NotificationTypeResource UpdateNotificationType (string id, NotificationTypeResource notificationType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateNotificationType");
            
    
            var path = "/notifications/types/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(notificationType); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NotificationTypeResource) ApiClient.Deserialize(response.Content, typeof(NotificationTypeResource), response.Headers);
        }
    
    }
}
