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
    public interface IPaymentsApi
    {
        /// <summary>
        /// Create a new payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being created</param>
        /// <param name="paymentMethod">Payment method being created</param>
        /// <returns>ModelPaymentMethodResource</returns>
        ModelPaymentMethodResource CreatePaymentMethod (int? userId, ModelPaymentMethodResource paymentMethod);
        /// <summary>
        /// Delete an existing payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being updated</param>
        /// <param name="id">ID of the payment method being deleted</param>
        /// <returns></returns>
        void DeletePaymentMethod (int? userId, int? id);
        /// <summary>
        /// Get a single payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being retrieved</param>
        /// <param name="id">ID of the payment method being retrieved</param>
        /// <returns>ModelPaymentMethodResource</returns>
        ModelPaymentMethodResource GetPaymentMethod (int? userId, int? id);
        /// <summary>
        /// Get all payment methods for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment methods are being retrieved</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>List&lt;ModelPaymentMethodResource&gt;</returns>
        List<ModelPaymentMethodResource> GetPaymentMethods (int? userId, int? size, int? page, string order);
        /// <summary>
        /// Authorize payment of an invoice for later capture 
        /// </summary>
        /// <param name="request">Payment authorization request</param>
        /// <returns>ModelPaymentAuthorizationResource</returns>
        ModelPaymentAuthorizationResource PaymentAuthorization (ModelPaymentAuthorizationResource request);
        /// <summary>
        /// Capture an existing invoice payment authorization 
        /// </summary>
        /// <param name="id">ID of the payment authorization to capture</param>
        /// <returns></returns>
        void PaymentCapture (int? id);
        /// <summary>
        /// Update an existing payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being updated</param>
        /// <param name="id">ID of the payment method being updated</param>
        /// <param name="paymentMethod">The updated payment method data</param>
        /// <returns>ModelPaymentMethodResource</returns>
        ModelPaymentMethodResource UpdatePaymentMethod (int? userId, int? id, ModelPaymentMethodResource paymentMethod);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsApi : IPaymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
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
        /// Create a new payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being created</param> 
        /// <param name="paymentMethod">Payment method being created</param> 
        /// <returns>ModelPaymentMethodResource</returns>            
        public ModelPaymentMethodResource CreatePaymentMethod (int? userId, ModelPaymentMethodResource paymentMethod)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CreatePaymentMethod");
            
    
            var path = "/users/{user_id}/payment-methods";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(paymentMethod); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPaymentMethodResource) ApiClient.Deserialize(response.Content, typeof(ModelPaymentMethodResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being updated</param> 
        /// <param name="id">ID of the payment method being deleted</param> 
        /// <returns></returns>            
        public void DeletePaymentMethod (int? userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeletePaymentMethod");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePaymentMethod");
            
    
            var path = "/users/{user_id}/payment-methods/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being retrieved</param> 
        /// <param name="id">ID of the payment method being retrieved</param> 
        /// <returns>ModelPaymentMethodResource</returns>            
        public ModelPaymentMethodResource GetPaymentMethod (int? userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetPaymentMethod");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPaymentMethod");
            
    
            var path = "/users/{user_id}/payment-methods/{id}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPaymentMethodResource) ApiClient.Deserialize(response.Content, typeof(ModelPaymentMethodResource), response.Headers);
        }
    
        /// <summary>
        /// Get all payment methods for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment methods are being retrieved</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>List&lt;ModelPaymentMethodResource&gt;</returns>            
        public List<ModelPaymentMethodResource> GetPaymentMethods (int? userId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetPaymentMethods");
            
    
            var path = "/users/{user_id}/payment-methods";
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentMethods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentMethods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelPaymentMethodResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelPaymentMethodResource>), response.Headers);
        }
    
        /// <summary>
        /// Authorize payment of an invoice for later capture 
        /// </summary>
        /// <param name="request">Payment authorization request</param> 
        /// <returns>ModelPaymentAuthorizationResource</returns>            
        public ModelPaymentAuthorizationResource PaymentAuthorization (ModelPaymentAuthorizationResource request)
        {
            
    
            var path = "/payment/authorizations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentAuthorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentAuthorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPaymentAuthorizationResource) ApiClient.Deserialize(response.Content, typeof(ModelPaymentAuthorizationResource), response.Headers);
        }
    
        /// <summary>
        /// Capture an existing invoice payment authorization 
        /// </summary>
        /// <param name="id">ID of the payment authorization to capture</param> 
        /// <returns></returns>            
        public void PaymentCapture (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentCapture");
            
    
            var path = "/payment/authorizations/{id}/capture";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentCapture: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentCapture: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing payment method for a user 
        /// </summary>
        /// <param name="userId">ID of the user for whom the payment method is being updated</param> 
        /// <param name="id">ID of the payment method being updated</param> 
        /// <param name="paymentMethod">The updated payment method data</param> 
        /// <returns>ModelPaymentMethodResource</returns>            
        public ModelPaymentMethodResource UpdatePaymentMethod (int? userId, int? id, ModelPaymentMethodResource paymentMethod)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdatePaymentMethod");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePaymentMethod");
            
    
            var path = "/users/{user_id}/payment-methods/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(paymentMethod); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPaymentMethodResource) ApiClient.Deserialize(response.Content, typeof(ModelPaymentMethodResource), response.Headers);
        }
    
    }
}
