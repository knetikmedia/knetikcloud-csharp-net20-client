# com.knetikcloud..UtilBatchApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatch**](UtilBatchApi.md#getbatch) | **GET** /batch/{token} | Get batch result with token
[**SendBatch**](UtilBatchApi.md#sendbatch) | **POST** /batch | Request to run API call given the method, content type, path url, and body of request


<a name="getbatch"></a>
# **GetBatch**
> List<BatchReturn> GetBatch (string token)

Get batch result with token

Tokens expire in 24 hours

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBatchExample
    {
        public void main()
        {
            
            var apiInstance = new UtilBatchApi();
            var token = token_example;  // string | token

            try
            {
                // Get batch result with token
                List&lt;BatchReturn&gt; result = apiInstance.GetBatch(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilBatchApi.GetBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| token | 

### Return type

[**List<BatchReturn>**](BatchReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendbatch"></a>
# **SendBatch**
> List<BatchReturn> SendBatch (Batch batch)

Request to run API call given the method, content type, path url, and body of request

Should the request take longer than one of the alloted timeout parameters, a token will be returned instead, which can be used on the token endpoint in this service

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendBatchExample
    {
        public void main()
        {
            
            var apiInstance = new UtilBatchApi();
            var batch = new Batch(); // Batch | The batch object (optional) 

            try
            {
                // Request to run API call given the method, content type, path url, and body of request
                List&lt;BatchReturn&gt; result = apiInstance.SendBatch(batch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilBatchApi.SendBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch** | [**Batch**](Batch.md)| The batch object | [optional] 

### Return type

[**List<BatchReturn>**](BatchReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

