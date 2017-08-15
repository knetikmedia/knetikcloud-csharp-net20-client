# com.knetikcloud..SocialFacebookApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LinkAccounts**](SocialFacebookApi.md#linkaccounts) | **POST** /social/facebook/users | Link facebook account


<a name="linkaccounts"></a>
# **LinkAccounts**
> void LinkAccounts (FacebookToken facebookToken)

Link facebook account

Links the current user account to a facebook account, using the acccess token from facebook. Can also be used to update the access token after it has expired.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class LinkAccountsExample
    {
        public void main()
        {
            
            var apiInstance = new SocialFacebookApi();
            var facebookToken = new FacebookToken(); // FacebookToken | The token from facebook (optional) 

            try
            {
                // Link facebook account
                apiInstance.LinkAccounts(facebookToken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialFacebookApi.LinkAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facebookToken** | [**FacebookToken**](FacebookToken.md)| The token from facebook | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

