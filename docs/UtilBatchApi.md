# com.knetikcloud..UtilBatchApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendBatch**](UtilBatchApi.md#sendbatch) | **POST** /batch | Request to run API call given the method, content type, path url, and body of request


<a name="sendbatch"></a>
# **SendBatch**
> List<ModelBatchReturn> SendBatch (ModelBatch batch)

Request to run API call given the method, content type, path url, and body of request

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
            var batch = new ModelBatch(); // ModelBatch | The batch object (optional) 

            try
            {
                // Request to run API call given the method, content type, path url, and body of request
                List&lt;ModelBatchReturn&gt; result = apiInstance.SendBatch(batch);
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
 **batch** | [**ModelBatch**](ModelBatch.md)| The batch object | [optional] 

### Return type

[**List<ModelBatchReturn>**](ModelBatchReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

