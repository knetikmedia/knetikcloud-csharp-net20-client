# com.knetikcloud..UtilSecurityApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserLocationLog**](UtilSecurityApi.md#getuserlocationlog) | **GET** /security/country-log | Returns the authentication log for a user
[**GetUserTokenDetails**](UtilSecurityApi.md#getusertokendetails) | **GET** /me | Returns the authentication token details. Use /users endpoint for detailed user&#39;s info


<a name="getuserlocationlog"></a>
# **GetUserLocationLog**
> ModelPageResourceLocationLogResource GetUserLocationLog (int? userId)

Returns the authentication log for a user

A log entry is recorded everytime a user requests a new token. Standard pagination available

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserLocationLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilSecurityApi();
            var userId = 56;  // int? | The user id (optional) 

            try
            {
                // Returns the authentication log for a user
                ModelPageResourceLocationLogResource result = apiInstance.GetUserLocationLog(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilSecurityApi.GetUserLocationLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user id | [optional] 

### Return type

[**ModelPageResourceLocationLogResource**](ModelPageResourceLocationLogResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertokendetails"></a>
# **GetUserTokenDetails**
> ModelTokenDetailsResource GetUserTokenDetails ()

Returns the authentication token details. Use /users endpoint for detailed user's info

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserTokenDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilSecurityApi();

            try
            {
                // Returns the authentication token details. Use /users endpoint for detailed user's info
                ModelTokenDetailsResource result = apiInstance.GetUserTokenDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilSecurityApi.GetUserTokenDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelTokenDetailsResource**](ModelTokenDetailsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
