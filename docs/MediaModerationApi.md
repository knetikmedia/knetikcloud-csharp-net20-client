# com.knetikcloud..MediaModerationApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetModerationReport**](MediaModerationApi.md#getmoderationreport) | **GET** /moderation/reports/{id} | Get a flag report
[**GetModerationReports**](MediaModerationApi.md#getmoderationreports) | **GET** /moderation/reports | Returns a page of flag reports
[**UpdateModerationReport**](MediaModerationApi.md#updatemoderationreport) | **PUT** /moderation/reports/{id} | Update a flag report


<a name="getmoderationreport"></a>
# **GetModerationReport**
> FlagReportResource GetModerationReport (long? id)

Get a flag report

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
            
            // Configure OAuth2 access token for authorization: OAuth2
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmoderationreports"></a>
# **GetModerationReports**
> PageResourceFlagReportResource GetModerationReports (bool? excludeResolved, string filterContext, int? size, int? page)

Returns a page of flag reports

Context can be either a free-form string or a pre-defined context name

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaModerationApi();
            var excludeResolved = true;  // bool? | Ignore resolved context (optional)  (default to true)
            var filterContext = filterContext_example;  // string | Filter by moderation context (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of flag reports
                PageResourceFlagReportResource result = apiInstance.GetModerationReports(excludeResolved, filterContext, size, page);
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
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceFlagReportResource**](PageResourceFlagReportResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemoderationreport"></a>
# **UpdateModerationReport**
> void UpdateModerationReport (long? id, FlagReportResource flagReportResource)

Update a flag report

Lets you set the resolution of a report. Resolution types is {banned,ignore} in case of 'banned' you will need to pass the reason.

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
            
            // Configure OAuth2 access token for authorization: OAuth2
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

