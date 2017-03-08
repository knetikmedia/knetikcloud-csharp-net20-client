# com.knetikcloud.client..PaymentsStripeApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStripePaymentMethod**](PaymentsStripeApi.md#createstripepaymentmethod) | **POST** /payment/provider/stripe/payment-methods | Create a Stripe payment method for a user
[**PayStripeInvoice**](PaymentsStripeApi.md#paystripeinvoice) | **POST** /payment/provider/stripe/payments | Pay with a single use token


<a name="createstripepaymentmethod"></a>
# **CreateStripePaymentMethod**
> PaymentMethodResource CreateStripePaymentMethod (StripeCreatePaymentMethod request)

Create a Stripe payment method for a user

Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class CreateStripePaymentMethodExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paystripeinvoice"></a>
# **PayStripeInvoice**
> void PayStripeInvoice (StripePaymentRequest request)

Pay with a single use token

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class PayStripeInvoiceExample
    {
        public void main()
        {
            
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

