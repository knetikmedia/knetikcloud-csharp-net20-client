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
    public interface IStoreSubscriptionsApi
    {
        /// <summary>
        /// Creates a subscription item and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="subscriptionResource">The subscription to be created</param>
        /// <returns>SubscriptionResource</returns>
        SubscriptionResource CreateSubscription (SubscriptionResource subscriptionResource);
        /// <summary>
        /// Create a subscription template Subscription Templates define a type of subscription and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="subscriptionTemplateResource">The new subscription template</param>
        /// <returns>SubscriptionTemplateResource</returns>
        SubscriptionTemplateResource CreateSubscriptionTemplate (SubscriptionTemplateResource subscriptionTemplateResource);
        /// <summary>
        /// Delete a subscription plan Must not be locked or a migration target. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        /// <param name="planId">The id of the plan</param>
        /// <returns></returns>
        void DeleteSubscription (int? id, string planId);
        /// <summary>
        /// Delete a subscription template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <returns></returns>
        void DeleteSubscriptionTemplate (string id, string cascade);
        /// <summary>
        /// Retrieve a single subscription item and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        /// <returns>SubscriptionResource</returns>
        SubscriptionResource GetSubscription (int? id);
        /// <summary>
        /// Get a single subscription template Subscription Templates define a type of subscription and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>SubscriptionTemplateResource</returns>
        SubscriptionTemplateResource GetSubscriptionTemplate (string id);
        /// <summary>
        /// List and search subscription templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceSubscriptionTemplateResource</returns>
        PageResourceSubscriptionTemplateResource GetSubscriptionTemplates (int? size, int? page, string order);
        /// <summary>
        /// List available subscription items and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceSubscriptionResource</returns>
        PageResourceSubscriptionResource GetSubscriptions (int? size, int? page, string order);
        /// <summary>
        /// Processes subscriptions and charge dues &lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <returns></returns>
        void ProcessSubscriptions ();
        /// <summary>
        /// Updates a subscription item and associated plans Will not remove plans left out. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="id">The id of the subscription</param>
        /// <param name="subscriptionResource">The subscription resource object</param>
        /// <returns></returns>
        void UpdateSubscription (int? id, SubscriptionResource subscriptionResource);
        /// <summary>
        /// Update a subscription template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="subscriptionTemplateResource">The subscription template resource object</param>
        /// <returns>SubscriptionTemplateResource</returns>
        SubscriptionTemplateResource UpdateSubscriptionTemplate (string id, SubscriptionTemplateResource subscriptionTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreSubscriptionsApi : IStoreSubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreSubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreSubscriptionsApi(String basePath)
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
        /// Creates a subscription item and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="subscriptionResource">The subscription to be created</param> 
        /// <returns>SubscriptionResource</returns>            
        public SubscriptionResource CreateSubscription (SubscriptionResource subscriptionResource)
        {
            
    
            var path = "/subscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscriptionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionResource) ApiClient.Deserialize(response.Content, typeof(SubscriptionResource), response.Headers);
        }
    
        /// <summary>
        /// Create a subscription template Subscription Templates define a type of subscription and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="subscriptionTemplateResource">The new subscription template</param> 
        /// <returns>SubscriptionTemplateResource</returns>            
        public SubscriptionTemplateResource CreateSubscriptionTemplate (SubscriptionTemplateResource subscriptionTemplateResource)
        {
            
    
            var path = "/subscriptions/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscriptionTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscriptionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionTemplateResource) ApiClient.Deserialize(response.Content, typeof(SubscriptionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a subscription plan Must not be locked or a migration target. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="id">The id of the subscription</param> 
        /// <param name="planId">The id of the plan</param> 
        /// <returns></returns>            
        public void DeleteSubscription (int? id, string planId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSubscription");
            
            // verify the required parameter 'planId' is set
            if (planId == null) throw new ApiException(400, "Missing required parameter 'planId' when calling DeleteSubscription");
            
    
            var path = "/subscriptions/{id}/plans/{plan_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "plan_id" + "}", ApiClient.ParameterToString(planId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a subscription template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param> 
        /// <returns></returns>            
        public void DeleteSubscriptionTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSubscriptionTemplate");
            
    
            var path = "/subscriptions/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscriptionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscriptionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve a single subscription item and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The id of the subscription</param> 
        /// <returns>SubscriptionResource</returns>            
        public SubscriptionResource GetSubscription (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSubscription");
            
    
            var path = "/subscriptions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionResource) ApiClient.Deserialize(response.Content, typeof(SubscriptionResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single subscription template Subscription Templates define a type of subscription and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>SubscriptionTemplateResource</returns>            
        public SubscriptionTemplateResource GetSubscriptionTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSubscriptionTemplate");
            
    
            var path = "/subscriptions/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionTemplateResource) ApiClient.Deserialize(response.Content, typeof(SubscriptionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search subscription templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceSubscriptionTemplateResource</returns>            
        public PageResourceSubscriptionTemplateResource GetSubscriptionTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/subscriptions/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSubscriptionTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceSubscriptionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List available subscription items and associated plans &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceSubscriptionResource</returns>            
        public PageResourceSubscriptionResource GetSubscriptions (int? size, int? page, string order)
        {
            
    
            var path = "/subscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSubscriptionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceSubscriptionResource), response.Headers);
        }
    
        /// <summary>
        /// Processes subscriptions and charge dues &lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <returns></returns>            
        public void ProcessSubscriptions ()
        {
            
    
            var path = "/subscriptions/process";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProcessSubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProcessSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates a subscription item and associated plans Will not remove plans left out. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SUBSCRIPTIONS_ADMIN
        /// </summary>
        /// <param name="id">The id of the subscription</param> 
        /// <param name="subscriptionResource">The subscription resource object</param> 
        /// <returns></returns>            
        public void UpdateSubscription (int? id, SubscriptionResource subscriptionResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateSubscription");
            
    
            var path = "/subscriptions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscriptionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a subscription template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="subscriptionTemplateResource">The subscription template resource object</param> 
        /// <returns>SubscriptionTemplateResource</returns>            
        public SubscriptionTemplateResource UpdateSubscriptionTemplate (string id, SubscriptionTemplateResource subscriptionTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateSubscriptionTemplate");
            
    
            var path = "/subscriptions/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscriptionTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscriptionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscriptionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionTemplateResource) ApiClient.Deserialize(response.Content, typeof(SubscriptionTemplateResource), response.Headers);
        }
    
    }
}
