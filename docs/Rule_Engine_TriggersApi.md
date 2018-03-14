# com.knetikcloud..Rule_Engine_TriggersApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBRETrigger**](Rule_Engine_TriggersApi.md#createbretrigger) | **POST** /bre/triggers | Create a trigger
[**DeleteBRETrigger**](Rule_Engine_TriggersApi.md#deletebretrigger) | **DELETE** /bre/triggers/{event_name} | Delete a trigger
[**GetBRETrigger**](Rule_Engine_TriggersApi.md#getbretrigger) | **GET** /bre/triggers/{event_name} | Get a single trigger
[**GetBRETriggers**](Rule_Engine_TriggersApi.md#getbretriggers) | **GET** /bre/triggers | List triggers
[**UpdateBRETrigger**](Rule_Engine_TriggersApi.md#updatebretrigger) | **PUT** /bre/triggers/{event_name} | Update a trigger


<a name="createbretrigger"></a>
# **CreateBRETrigger**
> BreTriggerResource CreateBRETrigger (BreTriggerResource breTriggerResource)

Create a trigger

Customer added triggers will not be fired automatically or have rules associated with them by default. Custom rules must be added to get use from the trigger and it must then be fired from the outside. See the Bre Event services. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_TRIGGERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_TriggersApi();
            var breTriggerResource = new BreTriggerResource(); // BreTriggerResource | The BRE trigger resource object (optional) 

            try
            {
                // Create a trigger
                BreTriggerResource result = apiInstance.CreateBRETrigger(breTriggerResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_TriggersApi.CreateBRETrigger: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebretrigger"></a>
# **DeleteBRETrigger**
> void DeleteBRETrigger (string eventName)

Delete a trigger

May fail if there are existing rules against it. Cannot delete core triggers. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_TRIGGERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_TriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Delete a trigger
                apiInstance.DeleteBRETrigger(eventName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_TriggersApi.DeleteBRETrigger: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbretrigger"></a>
# **GetBRETrigger**
> BreTriggerResource GetBRETrigger (string eventName)

Get a single trigger

<b>Permissions Needed:</b> BRE_RULE_ENGINE_TRIGGERS_USER

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_TriggersApi();
            var eventName = eventName_example;  // string | The trigger event name

            try
            {
                // Get a single trigger
                BreTriggerResource result = apiInstance.GetBRETrigger(eventName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_TriggersApi.GetBRETrigger: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbretriggers"></a>
# **GetBRETriggers**
> PageResourceBreTriggerResource GetBRETriggers (bool? filterSystem, string filterCategory, string filterTags, string filterName, string filterSearch, int? size, int? page)

List triggers

<b>Permissions Needed:</b> BRE_RULE_ENGINE_TRIGGERS_USER

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRETriggersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_TriggersApi();
            var filterSystem = true;  // bool? | Filter for triggers that are system triggers when true, or not when false. Leave off for both mixed (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for triggers that are within a specific category (optional) 
            var filterTags = filterTags_example;  // string | Filter for triggers that have all of the given tags (comma separated list) (optional) 
            var filterName = filterName_example;  // string | Filter for triggers that have names containing the given string (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for triggers containing the given words somewhere within name, description and tags (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List triggers
                PageResourceBreTriggerResource result = apiInstance.GetBRETriggers(filterSystem, filterCategory, filterTags, filterName, filterSearch, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Rule_Engine_TriggersApi.GetBRETriggers: " + e.Message );
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
 **filterTags** | **string**| Filter for triggers that have all of the given tags (comma separated list) | [optional] 
 **filterName** | **string**| Filter for triggers that have names containing the given string | [optional] 
 **filterSearch** | **string**| Filter for triggers containing the given words somewhere within name, description and tags | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreTriggerResource**](PageResourceBreTriggerResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebretrigger"></a>
# **UpdateBRETrigger**
> BreTriggerResource UpdateBRETrigger (string eventName, BreTriggerResource breTriggerResource)

Update a trigger

May fail if new parameters mismatch requirements of existing rules. Cannot update core triggers. <br><br><b>Permissions Needed:</b> BRE_RULE_ENGINE_TRIGGERS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBRETriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Rule_Engine_TriggersApi();
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
                Debug.Print("Exception when calling Rule_Engine_TriggersApi.UpdateBRETrigger: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

