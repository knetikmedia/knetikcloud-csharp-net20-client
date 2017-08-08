# com.knetikcloud..PaymentsFattMerchantApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateFattMerchantPaymentMethod**](PaymentsFattMerchantApi.md#createorupdatefattmerchantpaymentmethod) | **PUT** /payment/provider/fattmerchant/payment-methods | Create or update a FattMerchant payment method for a user


<a name="createorupdatefattmerchantpaymentmethod"></a>
# **CreateOrUpdateFattMerchantPaymentMethod**
> PaymentMethodResource CreateOrUpdateFattMerchantPaymentMethod (FattMerchantPaymentMethodRequest request)

Create or update a FattMerchant payment method for a user

Stores customer information and creates a payment method that can be used to pay invoices through the payments endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateOrUpdateFattMerchantPaymentMethodExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsFattMerchantApi();
            var request = new FattMerchantPaymentMethodRequest(); // FattMerchantPaymentMethodRequest | Request containing payment method information for user (optional) 

            try
            {
                // Create or update a FattMerchant payment method for a user
                PaymentMethodResource result = apiInstance.CreateOrUpdateFattMerchantPaymentMethod(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsFattMerchantApi.CreateOrUpdateFattMerchantPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**FattMerchantPaymentMethodRequest**](FattMerchantPaymentMethodRequest.md)| Request containing payment method information for user | [optional] 

### Return type

[**PaymentMethodResource**](PaymentMethodResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

