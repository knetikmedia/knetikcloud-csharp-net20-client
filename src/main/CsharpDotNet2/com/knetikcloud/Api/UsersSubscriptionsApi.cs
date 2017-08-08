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
    public interface IUsersSubscriptionsApi
    {
        /// <summary>
        /// Get details about a user&#39;s subscription 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <returns>InventorySubscriptionResource</returns>
        InventorySubscriptionResource GetUserSubscriptionDetails (int? userId, int? inventoryId);
        /// <summary>
        /// Get details about a user&#39;s subscriptions 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <returns>List&lt;InventorySubscriptionResource&gt;</returns>
        List<InventorySubscriptionResource> GetUsersSubscriptionDetails (int? userId);
        /// <summary>
        /// Reactivate a subscription and charge fee 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="reactivateSubscriptionRequest">The reactivate subscription request object inventory</param>
        /// <returns>InvoiceResource</returns>
        InvoiceResource ReactivateUserSubscription (int? userId, int? inventoryId, ReactivateSubscriptionRequest reactivateSubscriptionRequest);
        /// <summary>
        /// Set a new date to bill a subscription on 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="billDate">The new bill date. Unix timestamp in seconds</param>
        /// <returns></returns>
        void SetSubscriptionBillDate (int? userId, int? inventoryId, long? billDate);
        /// <summary>
        /// Set the payment method to use for a subscription May send null to use floating default
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="paymentMethodId">The id of the payment method</param>
        /// <returns></returns>
        void SetSubscriptionPaymentMethod (int? userId, int? inventoryId, IntWrapper paymentMethodId);
        /// <summary>
        /// Set the status of a subscription Note that the new status may be blocked if the system is not configured to allow the current status to be changed to the new, to enforce proper flow. The default options for statuses are shown below but may be altered for special use cases
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="status">The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: (&#39;current&#39;, &#39;canceled&#39;, &#39;stopped&#39;, &#39;payment_failed&#39;, &#39;suspended&#39;)</param>
        /// <returns></returns>
        void SetSubscriptionStatus (int? userId, int? inventoryId, StringWrapper status);
        /// <summary>
        /// Set a new subscription plan for a user 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="planId">The id of the new plan. Must be from the same subscription</param>
        /// <returns></returns>
        void SetUserSubscriptionPlan (int? userId, int? inventoryId, StringWrapper planId);
        /// <summary>
        /// Set a new subscription price for a user This new price will be what the user is charged at the begining of each new period. This override is specific to the current subscription and will not carry over if they end and later re-subscribe. It will persist if the plan is changed using the setUserSubscriptionPlan endpoint.
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="inventoryId">The id of the user&#39;s inventory</param>
        /// <param name="theOverrideDetails">override</param>
        /// <returns></returns>
        void SetUserSubscriptionPrice (int? userId, int? inventoryId, SubscriptionPriceOverrideRequest theOverrideDetails);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersSubscriptionsApi : IUsersSubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersSubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersSubscriptionsApi(String basePath)
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
        /// Get details about a user&#39;s subscription 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <returns>InventorySubscriptionResource</returns>            
        public InventorySubscriptionResource GetUserSubscriptionDetails (int? userId, int? inventoryId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserSubscriptionDetails");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling GetUserSubscriptionDetails");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSubscriptionDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserSubscriptionDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InventorySubscriptionResource) ApiClient.Deserialize(response.Content, typeof(InventorySubscriptionResource), response.Headers);
        }
    
        /// <summary>
        /// Get details about a user&#39;s subscriptions 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <returns>List&lt;InventorySubscriptionResource&gt;</returns>            
        public List<InventorySubscriptionResource> GetUsersSubscriptionDetails (int? userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUsersSubscriptionDetails");
            
    
            var path = "/users/{user_id}/subscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersSubscriptionDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersSubscriptionDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InventorySubscriptionResource>) ApiClient.Deserialize(response.Content, typeof(List<InventorySubscriptionResource>), response.Headers);
        }
    
        /// <summary>
        /// Reactivate a subscription and charge fee 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="reactivateSubscriptionRequest">The reactivate subscription request object inventory</param> 
        /// <returns>InvoiceResource</returns>            
        public InvoiceResource ReactivateUserSubscription (int? userId, int? inventoryId, ReactivateSubscriptionRequest reactivateSubscriptionRequest)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ReactivateUserSubscription");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling ReactivateUserSubscription");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/reactivate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(reactivateSubscriptionRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactivateUserSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactivateUserSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceResource) ApiClient.Deserialize(response.Content, typeof(InvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// Set a new date to bill a subscription on 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="billDate">The new bill date. Unix timestamp in seconds</param> 
        /// <returns></returns>            
        public void SetSubscriptionBillDate (int? userId, int? inventoryId, long? billDate)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetSubscriptionBillDate");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling SetSubscriptionBillDate");
            
            // verify the required parameter 'billDate' is set
            if (billDate == null) throw new ApiException(400, "Missing required parameter 'billDate' when calling SetSubscriptionBillDate");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/bill-date";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(billDate); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionBillDate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionBillDate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the payment method to use for a subscription May send null to use floating default
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="paymentMethodId">The id of the payment method</param> 
        /// <returns></returns>            
        public void SetSubscriptionPaymentMethod (int? userId, int? inventoryId, IntWrapper paymentMethodId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetSubscriptionPaymentMethod");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling SetSubscriptionPaymentMethod");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/payment-method";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(paymentMethodId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the status of a subscription Note that the new status may be blocked if the system is not configured to allow the current status to be changed to the new, to enforce proper flow. The default options for statuses are shown below but may be altered for special use cases
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="status">The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: (&#39;current&#39;, &#39;canceled&#39;, &#39;stopped&#39;, &#39;payment_failed&#39;, &#39;suspended&#39;)</param> 
        /// <returns></returns>            
        public void SetSubscriptionStatus (int? userId, int? inventoryId, StringWrapper status)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetSubscriptionStatus");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling SetSubscriptionStatus");
            
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling SetSubscriptionStatus");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscriptionStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a new subscription plan for a user 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="planId">The id of the new plan. Must be from the same subscription</param> 
        /// <returns></returns>            
        public void SetUserSubscriptionPlan (int? userId, int? inventoryId, StringWrapper planId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetUserSubscriptionPlan");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling SetUserSubscriptionPlan");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/plan";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(planId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserSubscriptionPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserSubscriptionPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a new subscription price for a user This new price will be what the user is charged at the begining of each new period. This override is specific to the current subscription and will not carry over if they end and later re-subscribe. It will persist if the plan is changed using the setUserSubscriptionPlan endpoint.
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="inventoryId">The id of the user&#39;s inventory</param> 
        /// <param name="theOverrideDetails">override</param> 
        /// <returns></returns>            
        public void SetUserSubscriptionPrice (int? userId, int? inventoryId, SubscriptionPriceOverrideRequest theOverrideDetails)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetUserSubscriptionPrice");
            
            // verify the required parameter 'inventoryId' is set
            if (inventoryId == null) throw new ApiException(400, "Missing required parameter 'inventoryId' when calling SetUserSubscriptionPrice");
            
    
            var path = "/users/{user_id}/subscriptions/{inventory_id}/price-override";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "inventory_id" + "}", ApiClient.ParameterToString(inventoryId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(theOverrideDetails); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserSubscriptionPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserSubscriptionPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
