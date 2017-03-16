# com.knetikcloud..AmazonWebServicesS3Api

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSignedS3URL**](AmazonWebServicesS3Api.md#getsigneds3url) | **GET** /amazon/s3/signedposturl | Get a signed S3 URL


<a name="getsigneds3url"></a>
# **GetSignedS3URL**
> AmazonS3Activity GetSignedS3URL (string filename, string contentType)

Get a signed S3 URL

Requires the file name and file content type (i.e., 'video/mpeg')

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSignedS3URLExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmazonWebServicesS3Api();
            var filename = filename_example;  // string | The file name (optional) 
            var contentType = contentType_example;  // string | The content type (optional) 

            try
            {
                // Get a signed S3 URL
                AmazonS3Activity result = apiInstance.GetSignedS3URL(filename, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonWebServicesS3Api.GetSignedS3URL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | **string**| The file name | [optional] 
 **contentType** | **string**| The content type | [optional] 

### Return type

[**AmazonS3Activity**](AmazonS3Activity.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

