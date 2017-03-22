# com.knetikcloud..PaymentsPayPalClassicApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePayPalBillingAgreementUrl**](PaymentsPayPalClassicApi.md#createpaypalbillingagreementurl) | **POST** /payment/provider/paypal/classic/agreements/start | Create a PayPal Classic billing agreement for the user
[**CreatePayPalExpressCheckout**](PaymentsPayPalClassicApi.md#createpaypalexpresscheckout) | **POST** /payment/provider/paypal/classic/checkout/start | Create a payment token for PayPal express checkout
[**FinalizePayPalBillingAgreement**](PaymentsPayPalClassicApi.md#finalizepaypalbillingagreement) | **POST** /payment/provider/paypal/classic/agreements/finish | Finalizes a billing agreement after the user has accepted through PayPal
[**FinalizePayPalCheckout**](PaymentsPayPalClassicApi.md#finalizepaypalcheckout) | **POST** /payment/provider/paypal/classic/checkout/finish | Finalizes a payment after the user has completed checkout with PayPal


<a name="createpaypalbillingagreementurl"></a>
# **CreatePayPalBillingAgreementUrl**
> string CreatePayPalBillingAgreementUrl (ModelCreateBillingAgreementRequest request)

Create a PayPal Classic billing agreement for the user

Returns the token that should be used to forward the user to PayPal so they can accept the agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreatePayPalBillingAgreementUrlExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsPayPalClassicApi();
            var request = new ModelCreateBillingAgreementRequest(); // ModelCreateBillingAgreementRequest | The request to create a PayPal billing agreement (optional) 

            try
            {
                // Create a PayPal Classic billing agreement for the user
                string result = apiInstance.CreatePayPalBillingAgreementUrl(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsPayPalClassicApi.CreatePayPalBillingAgreementUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelCreateBillingAgreementRequest**](ModelCreateBillingAgreementRequest.md)| The request to create a PayPal billing agreement | [optional] 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaypalexpresscheckout"></a>
# **CreatePayPalExpressCheckout**
> string CreatePayPalExpressCheckout (ModelCreatePayPalPaymentRequest request)

Create a payment token for PayPal express checkout

Returns the token that should be used to forward the user to PayPal so they can complete the checkout.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreatePayPalExpressCheckoutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsPayPalClassicApi();
            var request = new ModelCreatePayPalPaymentRequest(); // ModelCreatePayPalPaymentRequest | The request to create a PayPal payment token (optional) 

            try
            {
                // Create a payment token for PayPal express checkout
                string result = apiInstance.CreatePayPalExpressCheckout(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsPayPalClassicApi.CreatePayPalExpressCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelCreatePayPalPaymentRequest**](ModelCreatePayPalPaymentRequest.md)| The request to create a PayPal payment token | [optional] 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finalizepaypalbillingagreement"></a>
# **FinalizePayPalBillingAgreement**
> int? FinalizePayPalBillingAgreement (ModelFinalizeBillingAgreementRequest request)

Finalizes a billing agreement after the user has accepted through PayPal

Returns the ID of the new payment method created for the user for the billing agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class FinalizePayPalBillingAgreementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsPayPalClassicApi();
            var request = new ModelFinalizeBillingAgreementRequest(); // ModelFinalizeBillingAgreementRequest | The request to finalize a PayPal billing agreement (optional) 

            try
            {
                // Finalizes a billing agreement after the user has accepted through PayPal
                int? result = apiInstance.FinalizePayPalBillingAgreement(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsPayPalClassicApi.FinalizePayPalBillingAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelFinalizeBillingAgreementRequest**](ModelFinalizeBillingAgreementRequest.md)| The request to finalize a PayPal billing agreement | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finalizepaypalcheckout"></a>
# **FinalizePayPalCheckout**
> void FinalizePayPalCheckout (ModelFinalizePayPalPaymentRequest request)

Finalizes a payment after the user has completed checkout with PayPal

The invoice will be marked paid/failed by asynchronous IPN callback.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class FinalizePayPalCheckoutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsPayPalClassicApi();
            var request = new ModelFinalizePayPalPaymentRequest(); // ModelFinalizePayPalPaymentRequest | The request to finalize the payment (optional) 

            try
            {
                // Finalizes a payment after the user has completed checkout with PayPal
                apiInstance.FinalizePayPalCheckout(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsPayPalClassicApi.FinalizePayPalCheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelFinalizePayPalPaymentRequest**](ModelFinalizePayPalPaymentRequest.md)| The request to finalize the payment | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

