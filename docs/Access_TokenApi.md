# com.knetikcloud..Access_TokenApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOAuthToken**](Access_TokenApi.md#getoauthtoken) | **POST** /oauth/token | Get access token


<a name="getoauthtoken"></a>
# **GetOAuthToken**
> OAuth2Resource GetOAuthToken (string grantType, string clientId, string clientSecret, string username, string password, string token, string refreshToken)

Get access token

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetOAuthTokenExample
    {
        public void main()
        {
            
            var apiInstance = new Access_TokenApi();
            var grantType = grantType_example;  // string | Grant type (default to client_credentials)
            var clientId = clientId_example;  // string | The id of the client (default to knetik)
            var clientSecret = clientSecret_example;  // string | The secret key of the client.  Used only with a grant_type of client_credentials (optional) 
            var username = username_example;  // string | The username of the client. Used only with a grant_type of password (optional) 
            var password = password_example;  // string | The password of the client. Used only with a grant_type of password (optional) 
            var token = token_example;  // string | The 3rd party authentication token. Used only with a grant_type of facebook, google, etc (social plugins) (optional) 
            var refreshToken = refreshToken_example;  // string | The refresh token obtained during prior authentication. Used only with a grant_type of refresh_token (optional) 

            try
            {
                // Get access token
                OAuth2Resource result = apiInstance.GetOAuthToken(grantType, clientId, clientSecret, username, password, token, refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Access_TokenApi.GetOAuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| Grant type | [default to client_credentials]
 **clientId** | **string**| The id of the client | [default to knetik]
 **clientSecret** | **string**| The secret key of the client.  Used only with a grant_type of client_credentials | [optional] 
 **username** | **string**| The username of the client. Used only with a grant_type of password | [optional] 
 **password** | **string**| The password of the client. Used only with a grant_type of password | [optional] 
 **token** | **string**| The 3rd party authentication token. Used only with a grant_type of facebook, google, etc (social plugins) | [optional] 
 **refreshToken** | **string**| The refresh token obtained during prior authentication. Used only with a grant_type of refresh_token | [optional] 

### Return type

[**OAuth2Resource**](OAuth2Resource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

