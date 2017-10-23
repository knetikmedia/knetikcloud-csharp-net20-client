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
    public interface IPaymentsFattMerchantApi
    {
        /// <summary>
        /// Create or update a FattMerchant payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <param name="request">Request containing payment method information for user</param>
        /// <returns>PaymentMethodResource</returns>
        PaymentMethodResource CreateOrUpdateFattMerchantPaymentMethod (FattMerchantPaymentMethodRequest request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsFattMerchantApi : IPaymentsFattMerchantApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsFattMerchantApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsFattMerchantApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsFattMerchantApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsFattMerchantApi(String basePath)
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
        /// Create or update a FattMerchant payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <param name="request">Request containing payment method information for user</param> 
        /// <returns>PaymentMethodResource</returns>            
        public PaymentMethodResource CreateOrUpdateFattMerchantPaymentMethod (FattMerchantPaymentMethodRequest request)
        {
            
    
            var path = "/payment/provider/fattmerchant/payment-methods";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrUpdateFattMerchantPaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrUpdateFattMerchantPaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentMethodResource) ApiClient.Deserialize(response.Content, typeof(PaymentMethodResource), response.Headers);
        }
    
    }
}
