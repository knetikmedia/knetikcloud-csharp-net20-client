# com.knetikcloud..PaymentsStripeApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStripePaymentMethod**](PaymentsStripeApi.md#createstripepaymentmethod) | **POST** /payment/provider/stripe/payment-methods | Create a Stripe payment method for a user
[**PayStripeInvoice**](PaymentsStripeApi.md#paystripeinvoice) | **POST** /payment/provider/stripe/payments | Pay with a single use token


<a name="createstripepaymentmethod"></a>
# **CreateStripePaymentMethod**
> PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request)

Create a Stripe payment method for a user

Obtain a token from Stripe, following their examples and documentation. Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints. Ensure that Stripe itself has been configured with the webhook so that invoices are marked paid.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateStripePaymentMethodExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsStripeApi();
            var request = new StripeCreatePaymentMethod(); // StripeCreatePaymentMethod | The request to create a Stripe customer with payment info (optional) 

            try
            {
                // Create a Stripe payment method for a user
                PaymentMethodResource result = apiInstance.CreateStripePaymentMethod(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsStripeApi.CreateStripePaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StripeCreatePaymentMethod**](StripeCreatePaymentMethod.md)| The request to create a Stripe customer with payment info | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paystripeinvoice"></a>
# **PayStripeInvoice**
> void PayStripeInvoice (StripePaymentRequest request)

Pay with a single use token

Obtain a token from Stripe, following their examples and documentation. Pays an invoice without creating a payment method. Ensure that Stripe itself has been configured with the webhook so that invoices are marked paid.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PayStripeInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsStripeApi();
            var request = new StripePaymentRequest(); // StripePaymentRequest | The request to pay an invoice (optional) 

            try
            {
                // Pay with a single use token
                apiInstance.PayStripeInvoice(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsStripeApi.PayStripeInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StripePaymentRequest**](StripePaymentRequest.md)| The request to pay an invoice | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

