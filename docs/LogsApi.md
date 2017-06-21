# com.knetikcloud..LogsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserLog**](LogsApi.md#adduserlog) | **POST** /audit/logs | Add a user log entry
[**GetBREEventLog**](LogsApi.md#getbreeventlog) | **GET** /bre/logs/event-log/{id} | Get an existing BRE event log entry by id
[**GetBREEventLogs**](LogsApi.md#getbreeventlogs) | **GET** /bre/logs/event-log | Returns a list of BRE event log entries
[**GetBREForwardLog**](LogsApi.md#getbreforwardlog) | **GET** /bre/logs/forward-log/{id} | Get an existing forward log entry by id
[**GetBREForwardLogs**](LogsApi.md#getbreforwardlogs) | **GET** /bre/logs/forward-log | Returns a list of forward log entries
[**GetUserLog**](LogsApi.md#getuserlog) | **GET** /audit/logs/{id} | Returns a user log entry by id
[**GetUserLogs**](LogsApi.md#getuserlogs) | **GET** /audit/logs | Returns a page of user logs entries


<a name="adduserlog"></a>
# **AddUserLog**
> void AddUserLog (ModelUserActionLog logEntry)

Add a user log entry

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddUserLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var logEntry = new ModelUserActionLog(); // ModelUserActionLog | The user log entry to be added (optional) 

            try
            {
                // Add a user log entry
                apiInstance.AddUserLog(logEntry);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.AddUserLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logEntry** | [**ModelUserActionLog**](ModelUserActionLog.md)| The user log entry to be added | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreeventlog"></a>
# **GetBREEventLog**
> ModelBreEventLog GetBREEventLog (string id)

Get an existing BRE event log entry by id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREEventLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var id = id_example;  // string | The BRE event log entry id

            try
            {
                // Get an existing BRE event log entry by id
                ModelBreEventLog result = apiInstance.GetBREEventLog(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetBREEventLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The BRE event log entry id | 

### Return type

[**ModelBreEventLog**](ModelBreEventLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreeventlogs"></a>
# **GetBREEventLogs**
> ModelPageResourceBreEventLog GetBREEventLogs (string filterStartDate, string filterEventName, string filterEventId, int? size, int? page, string order)

Returns a list of BRE event log entries

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREEventLogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the event log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterEventName = filterEventName_example;  // string | Filter event logs by event name (optional) 
            var filterEventId = filterEventId_example;  // string | Filter event logs by request id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:DESC)

            try
            {
                // Returns a list of BRE event log entries
                ModelPageResourceBreEventLog result = apiInstance.GetBREEventLogs(filterStartDate, filterEventName, filterEventId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetBREEventLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the event log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterEventName** | **string**| Filter event logs by event name | [optional] 
 **filterEventId** | **string**| Filter event logs by request id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:DESC]

### Return type

[**ModelPageResourceBreEventLog**](ModelPageResourceBreEventLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreforwardlog"></a>
# **GetBREForwardLog**
> ModelForwardLog GetBREForwardLog (string id)

Get an existing forward log entry by id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREForwardLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var id = id_example;  // string | The forward log entry id

            try
            {
                // Get an existing forward log entry by id
                ModelForwardLog result = apiInstance.GetBREForwardLog(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetBREForwardLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The forward log entry id | 

### Return type

[**ModelForwardLog**](ModelForwardLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreforwardlogs"></a>
# **GetBREForwardLogs**
> ModelPageResourceForwardLog GetBREForwardLogs (string filterStartDate, string filterEndDate, int? filterStatusCode, int? size, int? page, string order)

Returns a list of forward log entries

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREForwardLogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterEndDate = filterEndDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterStatusCode = 56;  // int? | Filter forward logs by http status code (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:DESC)

            try
            {
                // Returns a list of forward log entries
                ModelPageResourceForwardLog result = apiInstance.GetBREForwardLogs(filterStartDate, filterEndDate, filterStatusCode, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetBREForwardLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterEndDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterStatusCode** | **int?**| Filter forward logs by http status code | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:DESC]

### Return type

[**ModelPageResourceForwardLog**](ModelPageResourceForwardLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlog"></a>
# **GetUserLog**
> ModelUserActionLog GetUserLog (string id)

Returns a user log entry by id

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var id = id_example;  // string | The user log entry id

            try
            {
                // Returns a user log entry by id
                ModelUserActionLog result = apiInstance.GetUserLog(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetUserLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The user log entry id | 

### Return type

[**ModelUserActionLog**](ModelUserActionLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlogs"></a>
# **GetUserLogs**
> ModelPageResourceUserActionLog GetUserLogs (int? filterUser, string filterActionName, int? size, int? page, string order)

Returns a page of user logs entries

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserLogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LogsApi();
            var filterUser = 56;  // int? | Filter for actions taken by a specific user by id (optional) 
            var filterActionName = filterActionName_example;  // string | Filter for actions of a specific name (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to timestamp:DESC)

            try
            {
                // Returns a page of user logs entries
                ModelPageResourceUserActionLog result = apiInstance.GetUserLogs(filterUser, filterActionName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.GetUserLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterUser** | **int?**| Filter for actions taken by a specific user by id | [optional] 
 **filterActionName** | **string**| Filter for actions of a specific name | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to timestamp:DESC]

### Return type

[**ModelPageResourceUserActionLog**](ModelPageResourceUserActionLog.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

