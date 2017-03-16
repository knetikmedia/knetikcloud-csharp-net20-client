# com.knetikcloud..ActivitiesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateActivity**](ActivitiesApi.md#createactivity) | **POST** /activities | Create an activity
[**CreateActivityOccurrence**](ActivitiesApi.md#createactivityoccurrence) | **POST** /activity-occurrences | Create a new activity occurrence
[**DeleteActivity**](ActivitiesApi.md#deleteactivity) | **DELETE** /activities/{id} | Delete an activity
[**GetActivities**](ActivitiesApi.md#getactivities) | **GET** /activities | List activity definitions
[**GetActivity**](ActivitiesApi.md#getactivity) | **GET** /activities/{id} | Get a single activity
[**SetActivityOccurrenceResults**](ActivitiesApi.md#setactivityoccurrenceresults) | **POST** /activity-occurrences/{activity_occurrence_id}/results | Sets the status of an activity occurrence to FINISHED and logs metrics
[**UpdateActivity**](ActivitiesApi.md#updateactivity) | **PUT** /activities/{id} | Update an activity
[**UpdateActivityOccurrence**](ActivitiesApi.md#updateactivityoccurrence) | **PUT** /activity-occurrences/{activity_occurrence_id}/status | Updated the status of an activity occurrence


<a name="createactivity"></a>
# **CreateActivity**
> ModelActivityResource CreateActivity (ModelActivityResource activityResource)

Create an activity

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityResource = new ModelActivityResource(); // ModelActivityResource | The activity resource object (optional) 

            try
            {
                // Create an activity
                ModelActivityResource result = apiInstance.CreateActivity(activityResource);
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
 **activityResource** | [**ModelActivityResource**](ModelActivityResource.md)| The activity resource object | [optional] 

### Return type

[**ModelActivityResource**](ModelActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createactivityoccurrence"></a>
# **CreateActivityOccurrence**
> ModelActivityOccurrenceResource CreateActivityOccurrence (bool? test, ModelActivityOccurrenceResource activityOccurrenceResource)

Create a new activity occurrence

Has to enforce extra rules if not used as an admin

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var test = true;  // bool? | if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings (optional)  (default to false)
            var activityOccurrenceResource = new ModelActivityOccurrenceResource(); // ModelActivityOccurrenceResource | The activity occurrence object (optional) 

            try
            {
                // Create a new activity occurrence
                ModelActivityOccurrenceResource result = apiInstance.CreateActivityOccurrence(test, activityOccurrenceResource);
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
 **activityOccurrenceResource** | [**ModelActivityOccurrenceResource**](ModelActivityOccurrenceResource.md)| The activity occurrence object | [optional] 

### Return type

[**ModelActivityOccurrenceResource**](ModelActivityOccurrenceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteactivity"></a>
# **DeleteActivity**
> void DeleteActivity (long? id)

Delete an activity

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
            
            // Configure OAuth2 access token for authorization: OAuth2
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivities"></a>
# **GetActivities**
> ModelPageResourceBareActivityResource GetActivities (bool? filterTemplate, string filterName, string filterId, int? size, int? page, string order)

List activity definitions

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
                ModelPageResourceBareActivityResource result = apiInstance.GetActivities(filterTemplate, filterName, filterId, size, page, order);
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

[**ModelPageResourceBareActivityResource**](ModelPageResourceBareActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getactivity"></a>
# **GetActivity**
> ModelActivityResource GetActivity (long? id)

Get a single activity

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
            
            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity

            try
            {
                // Get a single activity
                ModelActivityResource result = apiInstance.GetActivity(id);
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

[**ModelActivityResource**](ModelActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setactivityoccurrenceresults"></a>
# **SetActivityOccurrenceResults**
> ModelActivityOccurrenceResults SetActivityOccurrenceResults (long? activityOccurrenceId, ModelActivityOccurrenceResults activityOccurrenceResults)

Sets the status of an activity occurrence to FINISHED and logs metrics

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityOccurrenceResults = new ModelActivityOccurrenceResults(); // ModelActivityOccurrenceResults | The activity occurrence object (optional) 

            try
            {
                // Sets the status of an activity occurrence to FINISHED and logs metrics
                ModelActivityOccurrenceResults result = apiInstance.SetActivityOccurrenceResults(activityOccurrenceId, activityOccurrenceResults);
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
 **activityOccurrenceResults** | [**ModelActivityOccurrenceResults**](ModelActivityOccurrenceResults.md)| The activity occurrence object | [optional] 

### Return type

[**ModelActivityOccurrenceResults**](ModelActivityOccurrenceResults.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivity"></a>
# **UpdateActivity**
> ModelActivityResource UpdateActivity (long? id, ModelActivityResource activityResource)

Update an activity

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var id = 789;  // long? | The id of the activity
            var activityResource = new ModelActivityResource(); // ModelActivityResource | The activity resource object (optional) 

            try
            {
                // Update an activity
                ModelActivityResource result = apiInstance.UpdateActivity(id, activityResource);
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
 **activityResource** | [**ModelActivityResource**](ModelActivityResource.md)| The activity resource object | [optional] 

### Return type

[**ModelActivityResource**](ModelActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateactivityoccurrence"></a>
# **UpdateActivityOccurrence**
> void UpdateActivityOccurrence (long? activityOccurrenceId, string activityCccurrenceStatus)

Updated the status of an activity occurrence

If setting to 'FINISHED' you must POST to /results instead to record the metrics and get synchronous reward results

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateActivityOccurrenceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActivitiesApi();
            var activityOccurrenceId = 789;  // long? | The id of the activity occurrence
            var activityCccurrenceStatus = activityCccurrenceStatus_example;  // string | The activity occurrence status object (optional) 

            try
            {
                // Updated the status of an activity occurrence
                apiInstance.UpdateActivityOccurrence(activityOccurrenceId, activityCccurrenceStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.UpdateActivityOccurrence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityOccurrenceId** | **long?**| The id of the activity occurrence | 
 **activityCccurrenceStatus** | **string**| The activity occurrence status object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

