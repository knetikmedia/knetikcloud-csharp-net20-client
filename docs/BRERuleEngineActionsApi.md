# com.knetikcloud..BRERuleEngineActionsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREActions**](BRERuleEngineActionsApi.md#getbreactions) | **GET** /bre/actions | Get a list of available actions


<a name="getbreactions"></a>
# **GetBREActions**
> List<ActionResource> GetBREActions (string filterCategory, string filterName)

Get a list of available actions

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREActionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineActionsApi();
            var filterCategory = filterCategory_example;  // string | Filter for actions that are within a specific category (optional) 
            var filterName = filterName_example;  // string | Filter for actions that have names containing the given string (optional) 

            try
            {
                // Get a list of available actions
                List&lt;ActionResource&gt; result = apiInstance.GetBREActions(filterCategory, filterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineActionsApi.GetBREActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for actions that are within a specific category | [optional] 
 **filterName** | **string**| Filter for actions that have names containing the given string | [optional] 

### Return type

[**List<ActionResource>**](ActionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

