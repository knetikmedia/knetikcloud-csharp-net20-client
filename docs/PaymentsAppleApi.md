# com.knetikcloud..PaymentsAppleApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyAppleReceipt**](PaymentsAppleApi.md#verifyapplereceipt) | **POST** /payment/provider/apple/receipt | Pay invoice with Apple receipt


<a name="verifyapplereceipt"></a>
# **VerifyAppleReceipt**
> string VerifyAppleReceipt (ModelApplyPaymentRequest request)

Pay invoice with Apple receipt

Mark an invoice paid using Apple payment receipt. A receipt will only be accepted once and the details of the transaction must match the invoice, including the product_id matching the sku text of the item in the invoice. Returns the transaction ID if successful.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class VerifyAppleReceiptExample
    {
        public void main()
        {
            
            var apiInstance = new PaymentsAppleApi();
            var request = new ModelApplyPaymentRequest(); // ModelApplyPaymentRequest | The request for paying an invoice through an Apple receipt (optional) 

            try
            {
                // Pay invoice with Apple receipt
                string result = apiInstance.VerifyAppleReceipt(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsAppleApi.VerifyAppleReceipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ModelApplyPaymentRequest**](ModelApplyPaymentRequest.md)| The request for paying an invoice through an Apple receipt | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

