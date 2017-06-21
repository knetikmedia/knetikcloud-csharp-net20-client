# com.knetikcloud..ReportingUsersApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserRegistrations**](ReportingUsersApi.md#getuserregistrations) | **GET** /reporting/users/registrations | Get user registration info


<a name="getuserregistrations"></a>
# **GetUserRegistrations**
> ModelPageResourceAggregateCountResource GetUserRegistrations (string granularity, long? startDate, long? endDate, int? size, int? page)

Get user registration info

Get user registration counts grouped by time range

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserRegistrationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingUsersApi();
            var granularity = granularity_example;  // string | The time duration to aggregate by (optional)  (default to day)
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get user registration info
                ModelPageResourceAggregateCountResource result = apiInstance.GetUserRegistrations(granularity, startDate, endDate, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsersApi.GetUserRegistrations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **granularity** | **string**| The time duration to aggregate by | [optional] [default to day]
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceAggregateCountResource**](ModelPageResourceAggregateCountResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

