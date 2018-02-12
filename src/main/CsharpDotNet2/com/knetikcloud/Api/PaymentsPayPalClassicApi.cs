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
    public interface IPaymentsPayPalClassicApi
    {
        /// <summary>
        /// Create a PayPal Classic billing agreement for the user Returns the token that should be used to forward the user to PayPal so they can accept the agreement. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to create a PayPal billing agreement</param>
        /// <returns>string</returns>
        string CreatePayPalBillingAgreementUrl (CreateBillingAgreementRequest request);
        /// <summary>
        /// Create a payment token for PayPal express checkout Returns the token that should be used to forward the user to PayPal so they can complete the checkout. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to create a PayPal payment token</param>
        /// <returns>string</returns>
        string CreatePayPalExpressCheckout (CreatePayPalPaymentRequest request);
        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal Returns the ID of the new payment method created for the user for the billing agreement. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to finalize a PayPal billing agreement</param>
        /// <returns>int?</returns>
        int? FinalizePayPalBillingAgreement (FinalizeBillingAgreementRequest request);
        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal The invoice will be marked paid/failed by asynchronous IPN callback. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to finalize the payment</param>
        /// <returns></returns>
        void FinalizePayPalCheckout (FinalizePayPalPaymentRequest request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsPayPalClassicApi : IPaymentsPayPalClassicApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsPayPalClassicApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsPayPalClassicApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsPayPalClassicApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsPayPalClassicApi(String basePath)
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
        /// Create a PayPal Classic billing agreement for the user Returns the token that should be used to forward the user to PayPal so they can accept the agreement. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to create a PayPal billing agreement</param> 
        /// <returns>string</returns>            
        public string CreatePayPalBillingAgreementUrl (CreateBillingAgreementRequest request)
        {
            
    
            var path = "/payment/provider/paypal/classic/agreements/start";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePayPalBillingAgreementUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePayPalBillingAgreementUrl: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Create a payment token for PayPal express checkout Returns the token that should be used to forward the user to PayPal so they can complete the checkout. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to create a PayPal payment token</param> 
        /// <returns>string</returns>            
        public string CreatePayPalExpressCheckout (CreatePayPalPaymentRequest request)
        {
            
    
            var path = "/payment/provider/paypal/classic/checkout/start";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePayPalExpressCheckout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePayPalExpressCheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Finalizes a billing agreement after the user has accepted through PayPal Returns the ID of the new payment method created for the user for the billing agreement. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to finalize a PayPal billing agreement</param> 
        /// <returns>int?</returns>            
        public int? FinalizePayPalBillingAgreement (FinalizeBillingAgreementRequest request)
        {
            
    
            var path = "/payment/provider/paypal/classic/agreements/finish";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FinalizePayPalBillingAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FinalizePayPalBillingAgreement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Finalizes a payment after the user has completed checkout with PayPal The invoice will be marked paid/failed by asynchronous IPN callback. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; PAYPAL_CLASSIC_ADMIN or owner
        /// </summary>
        /// <param name="request">The request to finalize the payment</param> 
        /// <returns></returns>            
        public void FinalizePayPalCheckout (FinalizePayPalPaymentRequest request)
        {
            
    
            var path = "/payment/provider/paypal/classic/checkout/finish";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FinalizePayPalCheckout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FinalizePayPalCheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
