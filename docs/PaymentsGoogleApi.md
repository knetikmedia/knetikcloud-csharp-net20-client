# com.knetikcloud..PaymentsGoogleApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleGooglePayment**](PaymentsGoogleApi.md#handlegooglepayment) | **POST** /payment/provider/google/payments | Mark an invoice paid with Google


<a name="handlegooglepayment"></a>
# **HandleGooglePayment**
> int? HandleGooglePayment (ModelGooglePaymentRequest request)

Mark an invoice paid with Google

Mark an invoice paid with Google. Verifies signature from Google and treats the developerPayload field inside the json payload as the id of the invoice to pay. Returns the transaction ID if successful.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class HandleGooglePaymentExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsGoogleApi();
            var request = new ModelGooglePaymentRequest(); // ModelGooglePaymentRequest | The request for paying an invoice through a Google in-app payment (optional) 

            try
            {
                // Mark an invoice paid with Google
                int? result = apiInstance.HandleGooglePayment(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsGoogleApi.HandleGooglePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelGooglePaymentRequest**](ModelGooglePaymentRequest.md)| The request for paying an invoice through a Google in-app payment | [optional] 

### Return type

**int?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

