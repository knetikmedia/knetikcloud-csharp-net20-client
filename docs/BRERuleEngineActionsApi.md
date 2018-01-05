# com.knetikcloud..BRERuleEngineActionsApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREActions**](BRERuleEngineActionsApi.md#getbreactions) | **GET** /bre/actions | Get a list of available actions


<a name="getbreactions"></a>
# **GetBREActions**
> List<ActionResource> GetBREActions (string filterCategory, string filterName, string filterTags, string filterSearch)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineActionsApi();
            var filterCategory = filterCategory_example;  // string | Filter for actions that are within a specific category (optional) 
            var filterName = filterName_example;  // string | Filter for actions that have names containing the given string (optional) 
            var filterTags = filterTags_example;  // string | Filter for actions that have all of the given tags (comma separated list) (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for actions containing the given words somewhere within name, description and tags (optional) 

            try
            {
                // Get a list of available actions
                List&lt;ActionResource&gt; result = apiInstance.GetBREActions(filterCategory, filterName, filterTags, filterSearch);
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
 **filterTags** | **string**| Filter for actions that have all of the given tags (comma separated list) | [optional] 
 **filterSearch** | **string**| Filter for actions containing the given words somewhere within name, description and tags | [optional] 

### Return type

[**List<ActionResource>**](ActionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

