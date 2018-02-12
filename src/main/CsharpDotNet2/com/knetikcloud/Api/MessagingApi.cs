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
    public interface IMessagingApi
    {
        /// <summary>
        /// Compile a message template Processes a set of input data against the template and returnes the compiled result. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> CompileMessageTemplate (MessageTemplateBulkRequest request);
        /// <summary>
        /// Create a message template &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageTemplate">The new template email to be sent</param>
        /// <returns>MessageTemplateResource</returns>
        MessageTemplateResource CreateMessageTemplate (MessageTemplateResource messageTemplate);
        /// <summary>
        /// Delete an existing message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param>
        /// <returns></returns>
        void DeleteMessageTemplate (string id);
        /// <summary>
        /// Get a single message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param>
        /// <returns>MessageTemplateResource</returns>
        MessageTemplateResource GetMessageTemplate (string id);
        /// <summary>
        /// List and search message templates Get a list of message templates with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="filterTagset">Filter for message templates with at least one of a specified set of tags (separated by comma)</param>
        /// <param name="filterTagIntersection">Filter for message templates with all of a specified set of tags (separated by comma)</param>
        /// <param name="filterTagExclusion">Filter for message templates with none of a specified set of tags (separated by comma)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceMessageTemplateResource</returns>
        PageResourceMessageTemplateResource GetMessageTemplates (string filterTagset, string filterTagIntersection, string filterTagExclusion, int? size, int? page, string order);
        /// <summary>
        /// Send a message Sends a message with one or more formats to one or more users. Fill in any message formats desired (email, sms, websockets) and each user will recieve all valid formats. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageResource">The message to be sent</param>
        /// <returns></returns>
        void SendMessage1 (MessageResource messageResource);
        /// <summary>
        /// Send a raw email to one or more users &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawEmailResource">The new raw email to be sent</param>
        /// <returns></returns>
        void SendRawEmail (RawEmailResource rawEmailResource);
        /// <summary>
        /// Send a raw push notification Sends a raw push notification message to one or more users. User&#39;s without registered mobile device for the application will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawPushResource">The new raw push notification to be sent</param>
        /// <returns></returns>
        void SendRawPush (RawPushResource rawPushResource);
        /// <summary>
        /// Send a raw SMS Sends a raw SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawSMSResource">The new raw SMS to be sent</param>
        /// <returns></returns>
        void SendRawSMS (RawSMSResource rawSMSResource);
        /// <summary>
        /// Send a templated email to one or more users &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageResource">The new template email to be sent</param>
        /// <returns></returns>
        void SendTemplatedEmail (TemplateEmailResource messageResource);
        /// <summary>
        /// Send a templated push notification Sends a templated push notification message to one or more users. User&#39;s without registered mobile device for the application will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="templatePushResource">The new templated push notification to be sent</param>
        /// <returns></returns>
        void SendTemplatedPush (TemplatePushResource templatePushResource);
        /// <summary>
        /// Send a new templated SMS Sends a templated SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="templateSMSResource">The new template SMS to be sent</param>
        /// <returns></returns>
        void SendTemplatedSMS (TemplateSMSResource templateSMSResource);
        /// <summary>
        /// Send a websocket message Sends a websocket message to one or more users. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="websocketResource">The new websocket message to be sent</param>
        /// <returns></returns>
        void SendWebsocket (WebsocketMessageResource websocketResource);
        /// <summary>
        /// Update an existing message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param>
        /// <param name="messageTemplateResource">The message template</param>
        /// <returns>MessageTemplateResource</returns>
        MessageTemplateResource UpdateMessageTemplate (string id, MessageTemplateResource messageTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MessagingApi : IMessagingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MessagingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingApi(String basePath)
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
        /// Compile a message template Processes a set of input data against the template and returnes the compiled result. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="request">request</param> 
        /// <returns>Dictionary&lt;string, string&gt;</returns>            
        public Dictionary<string, string> CompileMessageTemplate (MessageTemplateBulkRequest request)
        {
            
    
            var path = "/messaging/templates/compilations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CompileMessageTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CompileMessageTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, string>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, string>), response.Headers);
        }
    
        /// <summary>
        /// Create a message template &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageTemplate">The new template email to be sent</param> 
        /// <returns>MessageTemplateResource</returns>            
        public MessageTemplateResource CreateMessageTemplate (MessageTemplateResource messageTemplate)
        {
            
    
            var path = "/messaging/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(messageTemplate); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMessageTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMessageTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MessageTemplateResource) ApiClient.Deserialize(response.Content, typeof(MessageTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param> 
        /// <returns></returns>            
        public void DeleteMessageTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteMessageTemplate");
            
    
            var path = "/messaging/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMessageTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMessageTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param> 
        /// <returns>MessageTemplateResource</returns>            
        public MessageTemplateResource GetMessageTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetMessageTemplate");
            
    
            var path = "/messaging/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMessageTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMessageTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MessageTemplateResource) ApiClient.Deserialize(response.Content, typeof(MessageTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search message templates Get a list of message templates with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="filterTagset">Filter for message templates with at least one of a specified set of tags (separated by comma)</param> 
        /// <param name="filterTagIntersection">Filter for message templates with all of a specified set of tags (separated by comma)</param> 
        /// <param name="filterTagExclusion">Filter for message templates with none of a specified set of tags (separated by comma)</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceMessageTemplateResource</returns>            
        public PageResourceMessageTemplateResource GetMessageTemplates (string filterTagset, string filterTagIntersection, string filterTagExclusion, int? size, int? page, string order)
        {
            
    
            var path = "/messaging/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterTagIntersection != null) queryParams.Add("filter_tag_intersection", ApiClient.ParameterToString(filterTagIntersection)); // query parameter
 if (filterTagExclusion != null) queryParams.Add("filter_tag_exclusion", ApiClient.ParameterToString(filterTagExclusion)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMessageTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMessageTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceMessageTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceMessageTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Send a message Sends a message with one or more formats to one or more users. Fill in any message formats desired (email, sms, websockets) and each user will recieve all valid formats. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageResource">The message to be sent</param> 
        /// <returns></returns>            
        public void SendMessage1 (MessageResource messageResource)
        {
            
    
            var path = "/messaging/message";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(messageResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendMessage1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendMessage1: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a raw email to one or more users &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawEmailResource">The new raw email to be sent</param> 
        /// <returns></returns>            
        public void SendRawEmail (RawEmailResource rawEmailResource)
        {
            
    
            var path = "/messaging/raw-email";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rawEmailResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a raw push notification Sends a raw push notification message to one or more users. User&#39;s without registered mobile device for the application will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawPushResource">The new raw push notification to be sent</param> 
        /// <returns></returns>            
        public void SendRawPush (RawPushResource rawPushResource)
        {
            
    
            var path = "/messaging/raw-push";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rawPushResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawPush: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawPush: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a raw SMS Sends a raw SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="rawSMSResource">The new raw SMS to be sent</param> 
        /// <returns></returns>            
        public void SendRawSMS (RawSMSResource rawSMSResource)
        {
            
    
            var path = "/messaging/raw-sms";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rawSMSResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawSMS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawSMS: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a templated email to one or more users &lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="messageResource">The new template email to be sent</param> 
        /// <returns></returns>            
        public void SendTemplatedEmail (TemplateEmailResource messageResource)
        {
            
    
            var path = "/messaging/templated-email";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(messageResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a templated push notification Sends a templated push notification message to one or more users. User&#39;s without registered mobile device for the application will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="templatePushResource">The new templated push notification to be sent</param> 
        /// <returns></returns>            
        public void SendTemplatedPush (TemplatePushResource templatePushResource)
        {
            
    
            var path = "/messaging/templated-push";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(templatePushResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedPush: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedPush: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a new templated SMS Sends a templated SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="templateSMSResource">The new template SMS to be sent</param> 
        /// <returns></returns>            
        public void SendTemplatedSMS (TemplateSMSResource templateSMSResource)
        {
            
    
            var path = "/messaging/templated-sms";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(templateSMSResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedSMS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedSMS: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a websocket message Sends a websocket message to one or more users. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; MESSAGING_ADMIN
        /// </summary>
        /// <param name="websocketResource">The new websocket message to be sent</param> 
        /// <returns></returns>            
        public void SendWebsocket (WebsocketMessageResource websocketResource)
        {
            
    
            var path = "/messaging/websocket-message";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(websocketResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendWebsocket: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendWebsocket: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing message template &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The message_template id</param> 
        /// <param name="messageTemplateResource">The message template</param> 
        /// <returns>MessageTemplateResource</returns>            
        public MessageTemplateResource UpdateMessageTemplate (string id, MessageTemplateResource messageTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateMessageTemplate");
            
    
            var path = "/messaging/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(messageTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMessageTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMessageTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MessageTemplateResource) ApiClient.Deserialize(response.Content, typeof(MessageTemplateResource), response.Headers);
        }
    
    }
}
