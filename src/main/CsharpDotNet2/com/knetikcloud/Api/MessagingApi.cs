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
        /// Send a raw email to one or more users 
        /// </summary>
        /// <param name="rawEmailResource">The new raw email to be sent</param>
        /// <returns></returns>
        void SendRawEmail (ModelRawEmailResource rawEmailResource);
        /// <summary>
        /// Send a raw SMS Sends a raw SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped.
        /// </summary>
        /// <param name="rawSMSResource">The new raw SMS to be sent</param>
        /// <returns></returns>
        void SendRawSMS (ModelRawSMSResource rawSMSResource);
        /// <summary>
        /// Send a templated email to one or more users 
        /// </summary>
        /// <param name="messageResource">The new template email to be sent</param>
        /// <returns></returns>
        void SendTemplatedEmail (ModelTemplateEmailResource messageResource);
        /// <summary>
        /// Send a new templated SMS Sends a templated SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped.
        /// </summary>
        /// <param name="templateSMSResource">The new template SMS to be sent</param>
        /// <returns></returns>
        void SendTemplatedSMS (ModelTemplateSMSResource templateSMSResource);
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
        /// Send a raw email to one or more users 
        /// </summary>
        /// <param name="rawEmailResource">The new raw email to be sent</param> 
        /// <returns></returns>            
        public void SendRawEmail (ModelRawEmailResource rawEmailResource)
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a raw SMS Sends a raw SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped.
        /// </summary>
        /// <param name="rawSMSResource">The new raw SMS to be sent</param> 
        /// <returns></returns>            
        public void SendRawSMS (ModelRawSMSResource rawSMSResource)
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawSMS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendRawSMS: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a templated email to one or more users 
        /// </summary>
        /// <param name="messageResource">The new template email to be sent</param> 
        /// <returns></returns>            
        public void SendTemplatedEmail (ModelTemplateEmailResource messageResource)
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send a new templated SMS Sends a templated SMS text message to one or more users. User&#39;s without registered mobile numbers will be skipped.
        /// </summary>
        /// <param name="templateSMSResource">The new template SMS to be sent</param> 
        /// <returns></returns>            
        public void SendTemplatedSMS (ModelTemplateSMSResource templateSMSResource)
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedSMS: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendTemplatedSMS: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
