# com.knetikcloud..MediaModerationApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFlag**](MediaModerationApi.md#addflag) | **POST** /moderation/flags | Add a flag
[**DeleteFlag**](MediaModerationApi.md#deleteflag) | **DELETE** /moderation/flags | Delete a flag
[**GetFlags**](MediaModerationApi.md#getflags) | **GET** /moderation/flags | Returns a page of flags
[**GetModerationReport**](MediaModerationApi.md#getmoderationreport) | **GET** /moderation/reports/{id} | Get a flag report
[**GetModerationReports**](MediaModerationApi.md#getmoderationreports) | **GET** /moderation/reports | Returns a page of flag reports
[**UpdateModerationReport**](MediaModerationApi.md#updatemoderationreport) | **PUT** /moderation/reports/{id} | Update a flag report


<a name="addflag"></a>
# **AddFlag**
> FlagResource AddFlag (FlagResource flagResource)

Add a flag

<b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddFlagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var flagResource = new FlagResource(); // FlagResource | The flag resource object (optional) 

            try
            {
                // Add a flag
                FlagResource result = apiInstance.AddFlag(flagResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.AddFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flagResource** | [**FlagResource**](FlagResource.md)| The flag resource object | [optional] 

### Return type

[**FlagResource**](FlagResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflag"></a>
# **DeleteFlag**
> void DeleteFlag (string contextName, string contextId, int? userId)

Delete a flag

<b>Permissions Needed:</b> MODERATION_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteFlagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var contextName = contextName_example;  // string | The name of the context (optional) 
            var contextId = contextId_example;  // string | The id of the context (optional) 
            var userId = 56;  // int? | The id of the user (optional) 

            try
            {
                // Delete a flag
                apiInstance.DeleteFlag(contextName, contextId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.DeleteFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextName** | **string**| The name of the context | [optional] 
 **contextId** | **string**| The id of the context | [optional] 
 **userId** | **int?**| The id of the user | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflags"></a>
# **GetFlags**
> PageResourceFlagResource GetFlags (string filterContext, string filterContextId, int? filterUserId, int? size, int? page)

Returns a page of flags

<b>Permissions Needed:</b> MODERATION_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetFlagsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var filterContext = filterContext_example;  // string | Filter by flag context (optional) 
            var filterContextId = filterContextId_example;  // string | Filter by flag context ID (optional) 
            var filterUserId = 56;  // int? | Filter by user ID (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of flags
                PageResourceFlagResource result = apiInstance.GetFlags(filterContext, filterContextId, filterUserId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.GetFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterContext** | **string**| Filter by flag context | [optional] 
 **filterContextId** | **string**| Filter by flag context ID | [optional] 
 **filterUserId** | **int?**| Filter by user ID | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceFlagResource**](PageResourceFlagResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmoderationreport"></a>
# **GetModerationReport**
> FlagReportResource GetModerationReport (long? id)

Get a flag report

<b>Permissions Needed:</b> MODERATION_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetModerationReportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var id = 789;  // long? | The flag report id

            try
            {
                // Get a flag report
                FlagReportResource result = apiInstance.GetModerationReport(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.GetModerationReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The flag report id | 

### Return type

[**FlagReportResource**](FlagReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmoderationreports"></a>
# **GetModerationReports**
> PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, string filterContextId, int? size, int? page)

Returns a page of flag reports

Context can be either a free-form string or a pre-defined context name. <br><br><b>Permissions Needed:</b> MODERATION_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetModerationReportsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var excludeResolved = true;  // bool? | Ignore resolved context (optional)  (default to true)
            var filterContext = filterContext_example;  // string | Filter by moderation context (optional) 
            var filterContextId = filterContextId_example;  // string | Filter by moderation context ID (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of flag reports
                PageResourceFlagReportResource result = apiInstance.GetModerationReports(excludeResolved, filterContext, filterContextId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.GetModerationReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeResolved** | **bool?**| Ignore resolved context | [optional] [default to true]
 **filterContext** | **string**| Filter by moderation context | [optional] 
 **filterContextId** | **string**| Filter by moderation context ID | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceFlagReportResource**](PageResourceFlagReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemoderationreport"></a>
# **UpdateModerationReport**
> void UpdateModerationReport (long? id, FlagReportResource flagReportResource)

Update a flag report

Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of 'banned' you will need to pass the reason. <br><br><b>Permissions Needed:</b> MODERATION_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateModerationReportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var id = 789;  // long? | The flag report id
            var flagReportResource = new FlagReportResource(); // FlagReportResource | The new flag report (optional) 

            try
            {
                // Update a flag report
                apiInstance.UpdateModerationReport(id, flagReportResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaModerationApi.UpdateModerationReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The flag report id | 
 **flagReportResource** | [**FlagReportResource**](FlagReportResource.md)| The new flag report | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

