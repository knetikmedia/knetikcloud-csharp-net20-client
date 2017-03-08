# com.knetikcloud..AuthTokensApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteToken**](AuthTokensApi.md#deletetoken) | **DELETE** /auth/tokens/{username}/{client_id} | Delete a token by username and client id
[**DeleteTokens**](AuthTokensApi.md#deletetokens) | **DELETE** /auth/tokens/{username} | Delete all tokens by username
[**GetToken**](AuthTokensApi.md#gettoken) | **GET** /auth/tokens/{username}/{client_id} | Get a single token by username and client id
[**GetTokens**](AuthTokensApi.md#gettokens) | **GET** /auth/tokens | List usernames and client ids


<a name="deletetoken"></a>
# **DeleteToken**
> void DeleteToken (string username, string clientId)

Delete a token by username and client id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user
            var clientId = clientId_example;  // string | The id of the client

            try
            {
                // Delete a token by username and client id
                apiInstance.DeleteToken(username, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.DeleteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 
 **clientId** | **string**| The id of the client | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetokens"></a>
# **DeleteTokens**
> void DeleteTokens (string username)

Delete all tokens by username

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteTokensExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user

            try
            {
                // Delete all tokens by username
                apiInstance.DeleteTokens(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.DeleteTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettoken"></a>
# **GetToken**
> OauthAccessTokenResource GetToken (string username, string clientId)

Get a single token by username and client id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var username = username_example;  // string | The username of the user
            var clientId = clientId_example;  // string | The id of the client

            try
            {
                // Get a single token by username and client id
                OauthAccessTokenResource result = apiInstance.GetToken(username, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The username of the user | 
 **clientId** | **string**| The id of the client | 

### Return type

[**OauthAccessTokenResource**](OauthAccessTokenResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokens"></a>
# **GetTokens**
> PageResourceOauthAccessTokenResource GetTokens (string filterClientId, string filterUsername, int? size, int? page, string order)

List usernames and client ids

Token value not shown

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTokensExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthTokensApi();
            var filterClientId = filterClientId_example;  // string | Filters for token whose client id matches provided string (optional) 
            var filterUsername = filterUsername_example;  // string | Filters for token whose username matches provided string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to username:ASC)

            try
            {
                // List usernames and client ids
                PageResourceOauthAccessTokenResource result = apiInstance.GetTokens(filterClientId, filterUsername, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthTokensApi.GetTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterClientId** | **string**| Filters for token whose client id matches provided string | [optional] 
 **filterUsername** | **string**| Filters for token whose username matches provided string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to username:ASC]

### Return type

[**PageResourceOauthAccessTokenResource**](PageResourceOauthAccessTokenResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

