# com.knetikcloud..PaymentsXsollaApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateXsollaTokenUrl**](PaymentsXsollaApi.md#createxsollatokenurl) | **POST** /payment/provider/xsolla/payment | Create a payment token that should be used to forward the user to Xsolla so they can complete payment
[**ReceiveXsollaNotification**](PaymentsXsollaApi.md#receivexsollanotification) | **POST** /payment/provider/xsolla/notifications | Receives payment response from Xsolla


<a name="createxsollatokenurl"></a>
# **CreateXsollaTokenUrl**
> string CreateXsollaTokenUrl (ModelXsollaPaymentRequest request)

Create a payment token that should be used to forward the user to Xsolla so they can complete payment

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateXsollaTokenUrlExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsXsollaApi();
            var request = new ModelXsollaPaymentRequest(); // ModelXsollaPaymentRequest | The payment request to be sent to XSolla (optional) 

            try
            {
                // Create a payment token that should be used to forward the user to Xsolla so they can complete payment
                string result = apiInstance.CreateXsollaTokenUrl(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsXsollaApi.CreateXsollaTokenUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelXsollaPaymentRequest**](ModelXsollaPaymentRequest.md)| The payment request to be sent to XSolla | [optional] 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receivexsollanotification"></a>
# **ReceiveXsollaNotification**
> void ReceiveXsollaNotification ()

Receives payment response from Xsolla

Only used by Xsolla to call back to JSAPI after processing user payment action

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ReceiveXsollaNotificationExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsXsollaApi();

            try
            {
                // Receives payment response from Xsolla
                apiInstance.ReceiveXsollaNotification();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsXsollaApi.ReceiveXsollaNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

