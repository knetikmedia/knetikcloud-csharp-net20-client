# com.knetikcloud..ReportingUsageApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsageByDay**](ReportingUsageApi.md#getusagebyday) | **GET** /reporting/usage/day | Returns aggregated endpoint usage information by day
[**GetUsageByHour**](ReportingUsageApi.md#getusagebyhour) | **GET** /reporting/usage/hour | Returns aggregated endpoint usage information by hour
[**GetUsageByMinute**](ReportingUsageApi.md#getusagebyminute) | **GET** /reporting/usage/minute | Returns aggregated endpoint usage information by minute
[**GetUsageByMonth**](ReportingUsageApi.md#getusagebymonth) | **GET** /reporting/usage/month | Returns aggregated endpoint usage information by month
[**GetUsageByYear**](ReportingUsageApi.md#getusagebyyear) | **GET** /reporting/usage/year | Returns aggregated endpoint usage information by year
[**GetUsageEndpoints**](ReportingUsageApi.md#getusageendpoints) | **GET** /reporting/usage/endpoints | Returns list of endpoints called (method and url)


<a name="getusagebyday"></a>
# **GetUsageByDay**
> PageResourceUsageInfo GetUsageByDay (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)

Returns aggregated endpoint usage information by day

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByDayExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by day
                PageResourceUsageInfo result = apiInstance.GetUsageByDay(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyhour"></a>
# **GetUsageByHour**
> PageResourceUsageInfo GetUsageByHour (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)

Returns aggregated endpoint usage information by hour

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByHourExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by hour
                PageResourceUsageInfo result = apiInstance.GetUsageByHour(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByHour: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyminute"></a>
# **GetUsageByMinute**
> PageResourceUsageInfo GetUsageByMinute (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)

Returns aggregated endpoint usage information by minute

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByMinuteExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by minute
                PageResourceUsageInfo result = apiInstance.GetUsageByMinute(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByMinute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebymonth"></a>
# **GetUsageByMonth**
> PageResourceUsageInfo GetUsageByMonth (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)

Returns aggregated endpoint usage information by month

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByMonthExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoint. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by month
                PageResourceUsageInfo result = apiInstance.GetUsageByMonth(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByMonth: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoint. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusagebyyear"></a>
# **GetUsageByYear**
> PageResourceUsageInfo GetUsageByYear (long? startDate, long? endDate, bool? combineEndpoints, string method, string url, int? size, int? page)

Returns aggregated endpoint usage information by year

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageByYearExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds
            var combineEndpoints = true;  // bool? | Whether to combine counts from different endpoints. Removes the url and method from the result object (optional)  (default to false)
            var method = method_example;  // string | Filter for a certain endpoint method.  Must include url as well to work (optional) 
            var url = url_example;  // string | Filter for a certain endpoint.  Must include method as well to work (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns aggregated endpoint usage information by year
                PageResourceUsageInfo result = apiInstance.GetUsageByYear(startDate, endDate, combineEndpoints, method, url, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageByYear: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 
 **combineEndpoints** | **bool?**| Whether to combine counts from different endpoints. Removes the url and method from the result object | [optional] [default to false]
 **method** | **string**| Filter for a certain endpoint method.  Must include url as well to work | [optional] 
 **url** | **string**| Filter for a certain endpoint.  Must include method as well to work | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUsageInfo**](PageResourceUsageInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusageendpoints"></a>
# **GetUsageEndpoints**
> List<string> GetUsageEndpoints (long? startDate, long? endDate)

Returns list of endpoints called (method and url)

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsageEndpointsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportingUsageApi();
            var startDate = 789;  // long? | The beginning of the range being requested, unix timestamp in seconds
            var endDate = 789;  // long? | The ending of the range being requested, unix timestamp in seconds

            try
            {
                // Returns list of endpoints called (method and url)
                List&lt;string&gt; result = apiInstance.GetUsageEndpoints(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingUsageApi.GetUsageEndpoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **long?**| The beginning of the range being requested, unix timestamp in seconds | 
 **endDate** | **long?**| The ending of the range being requested, unix timestamp in seconds | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

