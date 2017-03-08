using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsStripeApi
    {
        /// <summary>
        /// Create a Stripe payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <param name="request">The request to create a Stripe customer with payment info</param>
        /// <returns>PaymentMethodResource</returns>
        PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request);
        /// <summary>
        /// Pay with a single use token 
        /// </summary>
        /// <param name="request">The request to pay an invoice</param>
        /// <returns></returns>
        void PayStripeInvoice (StripePaymentRequest request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsStripeApi : IPaymentsStripeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsStripeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsStripeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsStripeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsStripeApi(String basePath)
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
        /// Create a Stripe payment method for a user Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.
        /// </summary>
        /// <param name="request">The request to create a Stripe customer with payment info</param> 
        /// <returns>PaymentMethodResource</returns>            
        public PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request)
        {
            
    
            var path = "/payment/provider/stripe/payment-methods";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStripePaymentMethod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStripePaymentMethod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentMethodResource) ApiClient.Deserialize(response.Content, typeof(PaymentMethodResource), response.Headers);
        }
    
        /// <summary>
        /// Pay with a single use token 
        /// </summary>
        /// <param name="request">The request to pay an invoice</param> 
        /// <returns></returns>            
        public void PayStripeInvoice (StripePaymentRequest request)
        {
            
    
            var path = "/payment/provider/stripe/payments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PayStripeInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PayStripeInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
