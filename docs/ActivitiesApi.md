# com.knetikcloud..ActivitiesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUser**](ActivitiesApi.md#adduser) | **POST** /activity-occurrences/{activity_occurrence_id}/users | Add a user to an occurrence
[**CreateActivity**](ActivitiesApi.md#createactivity) | **POST** /activities | Create an activity
[**CreateActivityOccurrence**](ActivitiesApi.md#createactivityoccurrence) | **POST** /activity-occurrences | Create a new activity occurrence. Ex: start a game
[**CreateActivityTemplate**](ActivitiesApi.md#createactivitytemplate) | **POST** /activities/templates | Create a activity template
[**DeleteActivity**](ActivitiesApi.md#deleteactivity) | **DELETE** /activities/{id} | Delete an activity
[**DeleteActivityTemplate**](ActivitiesApi.md#deleteactivitytemplate) | **DELETE** /activities/templates/{id} | Delete a activity template
[**GetActivities**](ActivitiesApi.md#getactivities) | **GET** /activities | List activity definitions
[**GetActivity**](ActivitiesApi.md#getactivity) | **GET** /activities/{id} | Get a single activity
[**GetActivityOccurrenceDetails**](ActivitiesApi.md#getactivityoccurrencedetails) | **GET** /activity-occurrences/{activity_occurrence_id} | Load a single activity occurrence details
[**GetActivityTemplate**](ActivitiesApi.md#getactivitytemplate) | **GET** /activities/templates/{id} | Get a single activity template
[**GetActivityTemplates**](ActivitiesApi.md#getactivitytemplates) | **GET** /activities/templates | List and search activity templates
[**ListActivityOccurrences**](ActivitiesApi.md#listactivityoccurrences) | **GET** /activity-occurrences | List activity occurrences
[**RemoveUser**](ActivitiesApi.md#removeuser) | **DELETE** /activity-occurrences/{activity_occurrence_id}/users/{user_id} | Remove a user from an occurrence
[**SetActivityOccurrenceResults**](ActivitiesApi.md#setactivityoccurrenceresults) | **POST** /activity-occurrences/{activity_occurrence_id}/results | Sets the status of an activity occurrence to FINISHED and logs metrics
[**SetActivityOccurrenceSettings**](ActivitiesApi.md#setactivityoccurrencesettings) | **PUT** /activity-occurrences/{activity_occurrence_id}/settings | Sets the settings of an activity occurrence
[**SetUserStatus**](ActivitiesApi.md#setuserstatus) | **PUT** /activity-occurrences/{activity_occurrence_id}/users/{user_id}/status | Set a user&#39;s status within an occurrence
[**UpdateActivity**](ActivitiesApi.md#updateactivity) | **PUT** /activities/{id} | Update an activity
[**UpdateActivityOccurrenceStatus**](ActivitiesApi.md#updateactivityoccurrencestatus) | **PUT** /activity-occurrences/{activity_occurrence_id}/status | Update the status of an activity occurrence
[**UpdateActivityTemplate**](ActivitiesApi.md#updateactivitytemplate) | **PUT** /activities/templates/{id} | Update an activity template


<a name="adduser"></a>
# **AddUser**
> ActivityOccurrenceResource AddUser (long? activityOccurrenceId, bool? test, bool? bypassRestrictions, IntWrapper userId)

Add a user to an occurrence

If called with no body, defaults to the user making the call.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var test = true;  // bool? | if true, indicates that the user should NOT be added. This can be used to test for eligibility (optional)  (default to false)
            var bypassRestrictions = true;  // bool? | if true, indicates that restrictions such as max player count should be ignored. Can only be used with ACTIVITIES_ADMIN (optional)  (default to false)
            var userId = new IntWrapper(); // IntWrapper | The id of the user, or null for 'caller' (optional) 

            try
            {
                // Add a user to an occurrence
                ActivityOccurrenceResource result = apiInstance.AddUser(activityOccurrenceId, test, bypassRestrictions, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **test** | **bool?**| if true, indicates that the user should NOT be added. This can be used to test for eligibility | [optional] [default to false]
 **bypassRestrictions** | **bool?**| if true, indicates that restrictions such as max player count should be ignored. Can only be used with ACTIVITIES_ADMIN | [optional] [default to false]
 **userId** | [**IntWrapper**](IntWrapper.md)| The id of the user, or null for &#39;caller&#39; | [optional] 

### Return type

[**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivity"></a>
# **CreateActivity**
> ActivityResource CreateActivity (ActivityResource activityResource)

Create an activity

<b>Permissions Needed:</b> ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityResource = new ActivityResource(); // ActivityResource | The activity resource object (optional) 

            try
            {
                // Create an activity
                ActivityResource result = apiInstance.CreateActivity(activityResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityResource** | [**ActivityResource**](ActivityResource.md)| The activity resource object | [optional] 

### Return type

[**ActivityResource**](ActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivityoccurrence"></a>
# **CreateActivityOccurrence**
> ActivityOccurrenceResource CreateActivityOccurrence (bool? test, CreateActivityOccurrenceRequest activityOccurrenceResource)

Create a new activity occurrence. Ex: start a game

Has to enforce extra rules if not used as an admin. <br><br><b>Permissions Needed:</b> ACTIVITIES_USER or ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateActivityOccurrenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var test = true;  // bool? | if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings (optional)  (default to false)
            var activityOccurrenceResource = new CreateActivityOccurrenceRequest(); // CreateActivityOccurrenceRequest | The activity occurrence object (optional) 

            try
            {
                // Create a new activity occurrence. Ex: start a game
                ActivityOccurrenceResource result = apiInstance.CreateActivityOccurrence(test, activityOccurrenceResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivityOccurrence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **test** | **bool?**| if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings | [optional] [default to false]
 **activityOccurrenceResource** | [**CreateActivityOccurrenceRequest**](CreateActivityOccurrenceRequest.md)| The activity occurrence object | [optional] 

### Return type

[**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivitytemplate"></a>
# **CreateActivityTemplate**
> TemplateResource CreateActivityTemplate (TemplateResource activityTemplateResource)

Create a activity template

Activity Templates define a type of activity and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityTemplateResource = new TemplateResource(); // TemplateResource | The activity template resource object (optional) 

            try
            {
                // Create a activity template
                TemplateResource result = apiInstance.CreateActivityTemplate(activityTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.CreateActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityTemplateResource** | [**TemplateResource**](TemplateResource.md)| The activity template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactivity"></a>
# **DeleteActivity**
> void DeleteActivity (long? id)

Delete an activity

<b>Permissions Needed:</b> ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity

            try
            {
                // Delete an activity
                apiInstance.DeleteActivity(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.DeleteActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactivitytemplate"></a>
# **DeleteActivityTemplate**
> void DeleteActivityTemplate (string id, string cascade)

Delete a activity template

If cascade = 'detach', it will force delete the template even if it's attached to other objects. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a activity template
                apiInstance.DeleteActivityTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.DeleteActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivities"></a>
# **GetActivities**
> PageResourceBareActivityResource GetActivities (bool? filterTemplate, string filterName, string filterId, int? size, int? page, string order)

List activity definitions

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
    public class GetActivitiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var filterTemplate = true;  // bool? | Filter for activities that are templates, or specifically not if false (optional) 
            var filterName = filterName_example;  // string | Filter for activities that have a name starting with specified string (optional) 
            var filterId = filterId_example;  // string | Filter for activities with an id in the given comma separated list of ids (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List activity definitions
                PageResourceBareActivityResource result = apiInstance.GetActivities(filterTemplate, filterName, filterId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTemplate** | **bool?**| Filter for activities that are templates, or specifically not if false | [optional] 
 **filterName** | **string**| Filter for activities that have a name starting with specified string | [optional] 
 **filterId** | **string**| Filter for activities with an id in the given comma separated list of ids | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceBareActivityResource**](PageResourceBareActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivity"></a>
# **GetActivity**
> ActivityResource GetActivity (long? id)

Get a single activity

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
    public class GetActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity

            try
            {
                // Get a single activity
                ActivityResource result = apiInstance.GetActivity(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 

### Return type

[**ActivityResource**](ActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivityoccurrencedetails"></a>
# **GetActivityOccurrenceDetails**
> ActivityOccurrenceResource GetActivityOccurrenceDetails (long? activityOccurrenceId)

Load a single activity occurrence details

<b>Permissions Needed:</b> ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetActivityOccurrenceDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence

            try
            {
                // Load a single activity occurrence details
                ActivityOccurrenceResource result = apiInstance.GetActivityOccurrenceDetails(activityOccurrenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivityOccurrenceDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 

### Return type

[**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitytemplate"></a>
# **GetActivityTemplate**
> TemplateResource GetActivityTemplate (string id)

Get a single activity template

<b>Permissions Needed:</b> TEMPLATE_ADMIN or ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single activity template
                TemplateResource result = apiInstance.GetActivityTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivitytemplates"></a>
# **GetActivityTemplates**
> PageResourceTemplateResource GetActivityTemplates (int? size, int? page, string order)

List and search activity templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetActivityTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search activity templates
                PageResourceTemplateResource result = apiInstance.GetActivityTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivityTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactivityoccurrences"></a>
# **ListActivityOccurrences**
> PageResourceActivityOccurrenceResource ListActivityOccurrences (string filterActivity, string filterStatus, int? filterEvent, int? filterChallenge, int? size, int? page, string order)

List activity occurrences

<b>Permissions Needed:</b> ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ListActivityOccurrencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var filterActivity = filterActivity_example;  // string | Filter for occurrences of the given activity ID (optional) 
            var filterStatus = filterStatus_example;  // string | Filter for occurrences in the given status (optional) 
            var filterEvent = 56;  // int? | Filter for occurrences played during the given event (optional) 
            var filterChallenge = 56;  // int? | Filter for occurrences played within the given challenge (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List activity occurrences
                PageResourceActivityOccurrenceResource result = apiInstance.ListActivityOccurrences(filterActivity, filterStatus, filterEvent, filterChallenge, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ListActivityOccurrences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterActivity** | **string**| Filter for occurrences of the given activity ID | [optional] 
 **filterStatus** | **string**| Filter for occurrences in the given status | [optional] 
 **filterEvent** | **int?**| Filter for occurrences played during the given event | [optional] 
 **filterChallenge** | **int?**| Filter for occurrences played within the given challenge | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceActivityOccurrenceResource**](PageResourceActivityOccurrenceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuser"></a>
# **RemoveUser**
> void RemoveUser (long? activityOccurrenceId, string userId, bool? ban, bool? bypassRestrictions)

Remove a user from an occurrence

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var userId = userId_example;  // string | The id of the user, or 'me'
            var ban = true;  // bool? | if true, indicates that the user should not be allowed to re-join. Can only be set by host or admin (optional)  (default to false)
            var bypassRestrictions = true;  // bool? | if true, indicates that restrictions such as current status should be ignored. Can only be used with ACTIVITIES_ADMIN (optional)  (default to false)

            try
            {
                // Remove a user from an occurrence
                apiInstance.RemoveUser(activityOccurrenceId, userId, ban, bypassRestrictions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.RemoveUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **userId** | **string**| The id of the user, or &#39;me&#39; | 
 **ban** | **bool?**| if true, indicates that the user should not be allowed to re-join. Can only be set by host or admin | [optional] [default to false]
 **bypassRestrictions** | **bool?**| if true, indicates that restrictions such as current status should be ignored. Can only be used with ACTIVITIES_ADMIN | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setactivityoccurrenceresults"></a>
# **SetActivityOccurrenceResults**
> ActivityOccurrenceResults SetActivityOccurrenceResults (long? activityOccurrenceId, ActivityOccurrenceResultsResource activityOccurrenceResults)

Sets the status of an activity occurrence to FINISHED and logs metrics

In addition to user permissions requirements there is security based on the core_settings.results_trust setting.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetActivityOccurrenceResultsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityOccurrenceResults = new ActivityOccurrenceResultsResource(); // ActivityOccurrenceResultsResource | The activity occurrence object (optional) 

            try
            {
                // Sets the status of an activity occurrence to FINISHED and logs metrics
                ActivityOccurrenceResults result = apiInstance.SetActivityOccurrenceResults(activityOccurrenceId, activityOccurrenceResults);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.SetActivityOccurrenceResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **activityOccurrenceResults** | [**ActivityOccurrenceResultsResource**](ActivityOccurrenceResultsResource.md)| The activity occurrence object | [optional] 

### Return type

[**ActivityOccurrenceResults**](ActivityOccurrenceResults.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setactivityoccurrencesettings"></a>
# **SetActivityOccurrenceSettings**
> ActivityOccurrenceResource SetActivityOccurrenceSettings (long? activityOccurrenceId, ActivityOccurrenceSettingsResource settings)

Sets the settings of an activity occurrence

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetActivityOccurrenceSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var settings = new ActivityOccurrenceSettingsResource(); // ActivityOccurrenceSettingsResource | The new settings (optional) 

            try
            {
                // Sets the settings of an activity occurrence
                ActivityOccurrenceResource result = apiInstance.SetActivityOccurrenceSettings(activityOccurrenceId, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.SetActivityOccurrenceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **settings** | [**ActivityOccurrenceSettingsResource**](ActivityOccurrenceSettingsResource.md)| The new settings | [optional] 

### Return type

[**ActivityOccurrenceResource**](ActivityOccurrenceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserstatus"></a>
# **SetUserStatus**
> ActivityUserResource SetUserStatus (long? activityOccurrenceId, string userId, string status)

Set a user's status within an occurrence

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var userId = userId_example;  // string | The id of the user
            var status = status_example;  // string | The new status (optional) 

            try
            {
                // Set a user's status within an occurrence
                ActivityUserResource result = apiInstance.SetUserStatus(activityOccurrenceId, userId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.SetUserStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **userId** | **string**| The id of the user | 
 **status** | **string**| The new status | [optional] 

### Return type

[**ActivityUserResource**](ActivityUserResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivity"></a>
# **UpdateActivity**
> ActivityResource UpdateActivity (long? id, ActivityResource activityResource)

Update an activity

<b>Permissions Needed:</b> ACTIVITIES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity
            var activityResource = new ActivityResource(); // ActivityResource | The activity resource object (optional) 

            try
            {
                // Update an activity
                ActivityResource result = apiInstance.UpdateActivity(id, activityResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the activity | 
 **activityResource** | [**ActivityResource**](ActivityResource.md)| The activity resource object | [optional] 

### Return type

[**ActivityResource**](ActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivityoccurrencestatus"></a>
# **UpdateActivityOccurrenceStatus**
> void UpdateActivityOccurrenceStatus (long? activityOccurrenceId, ValueWrapperstring activityOccurrenceStatus)

Update the status of an activity occurrence

If setting to 'FINISHED' reward will be run based on current metrics that have been recorded already. Alternatively, see results endpoint to finish and record all metrics at once. Can be called by non-host participants if non_host_status_control is true

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateActivityOccurrenceStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityOccurrenceStatus = new ValueWrapperstring(); // ValueWrapperstring | The activity occurrence status object (optional) 

            try
            {
                // Update the status of an activity occurrence
                apiInstance.UpdateActivityOccurrenceStatus(activityOccurrenceId, activityOccurrenceStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivityOccurrenceStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **activityOccurrenceStatus** | [**ValueWrapperstring**](ValueWrapperstring.md)| The activity occurrence status object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivitytemplate"></a>
# **UpdateActivityTemplate**
> TemplateResource UpdateActivityTemplate (string id, TemplateResource activityTemplateResource)

Update an activity template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = id_example;  // string | The id of the template
            var activityTemplateResource = new TemplateResource(); // TemplateResource | The activity template resource object (optional) 

            try
            {
                // Update an activity template
                TemplateResource result = apiInstance.UpdateActivityTemplate(id, activityTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **activityTemplateResource** | [**TemplateResource**](TemplateResource.md)| The activity template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

