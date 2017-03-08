# com.knetikcloud.client..BRERuleEngineTriggersApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBRETrigger**](BRERuleEngineTriggersApi.md#createbretrigger) | **POST** /bre/triggers | Create a trigger
[**DeleteBRETrigger**](BRERuleEngineTriggersApi.md#deletebretrigger) | **DELETE** /bre/triggers/{event_name} | Delete a trigger
[**GetBRETrigger**](BRERuleEngineTriggersApi.md#getbretrigger) | **GET** /bre/triggers/{event_name} | Get a single trigger
[**GetBRETriggers**](BRERuleEngineTriggersApi.md#getbretriggers) | **GET** /bre/triggers | List triggers
[**UpdateBRETrigger**](BRERuleEngineTriggersApi.md#updatebretrigger) | **PUT** /bre/triggers/{event_name} | Update a trigger


<a name="createbretrigger"></a>
# **CreateBRETrigger**
> BreTriggerResource CreateBRETrigger (BreTriggerResource breTriggerResource)

Create a trigger

Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class CreateBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var breTriggerResource = new BreTriggerResource(); // BreTriggerResource | The BRE trigger resource object (optional) 

            try
            {
                // Create a trigger
                BreTriggerResource result = apiInstance.CreateBRETrigger(breTriggerResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.CreateBRETrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breTriggerResource** | [**BreTriggerResource**](BreTriggerResource.md)| The BRE trigger resource object | [optional] 

### Return type

[**BreTriggerResource**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebretrigger"></a>
# **DeleteBRETrigger**
> void DeleteBRETrigger (string eventName)

Delete a trigger

May fail if there are existing rules against it. Cannot delete core triggers

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class DeleteBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Delete a trigger
                apiInstance.DeleteBRETrigger(eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.DeleteBRETrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbretrigger"></a>
# **GetBRETrigger**
> BreTriggerResource GetBRETrigger (string eventName)

Get a single trigger

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Get a single trigger
                BreTriggerResource result = apiInstance.GetBRETrigger(eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.GetBRETrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 

### Return type

[**BreTriggerResource**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbretriggers"></a>
# **GetBRETriggers**
> PageResourceBreTriggerResource GetBRETriggers (bool? filterSystem, string filterCategory, string filterName, int? size, int? page)

List triggers

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetBRETriggersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var filterSystem = true;  // bool? | Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for triggers that are within a specific category (optional) 
            var filterName = filterName_example;  // string | Filter for triggers that have names containing the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List triggers
                PageResourceBreTriggerResource result = apiInstance.GetBRETriggers(filterSystem, filterCategory, filterName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.GetBRETriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSystem** | **bool?**| Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed | [optional] 
 **filterCategory** | **string**| Filter for triggers that are within a specific category | [optional] 
 **filterName** | **string**| Filter for triggers that have names containing the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreTriggerResource**](PageResourceBreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebretrigger"></a>
# **UpdateBRETrigger**
> BreTriggerResource UpdateBRETrigger (string eventName, BreTriggerResource breTriggerResource)

Update a trigger

May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class UpdateBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineTriggersApi();
            var eventName = eventName_example;  // string | The trigger event name
            var breTriggerResource = new BreTriggerResource(); // BreTriggerResource | The BRE trigger resource object (optional) 

            try
            {
                // Update a trigger
                BreTriggerResource result = apiInstance.UpdateBRETrigger(eventName, breTriggerResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineTriggersApi.UpdateBRETrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventName** | **string**| The trigger event name | 
 **breTriggerResource** | [**BreTriggerResource**](BreTriggerResource.md)| The BRE trigger resource object | [optional] 

### Return type

[**BreTriggerResource**](BreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

