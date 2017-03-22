# com.knetikcloud..CampaignsChallengesApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChallenge**](CampaignsChallengesApi.md#createchallenge) | **POST** /challenges | Create a challenge
[**CreateChallengeActivity**](CampaignsChallengesApi.md#createchallengeactivity) | **POST** /challenges/{challenge_id}/activities | Create a challenge activity
[**CreateChallengeTemplate**](CampaignsChallengesApi.md#createchallengetemplate) | **POST** /challenges/templates | Create a challenge template
[**DeleteChallenge**](CampaignsChallengesApi.md#deletechallenge) | **DELETE** /challenges/{id} | Delete a challenge
[**DeleteChallengeActivity**](CampaignsChallengesApi.md#deletechallengeactivity) | **DELETE** /challenges/{challenge_id}/activities/{activity_id} | Delete a challenge activity
[**DeleteChallengeEvent**](CampaignsChallengesApi.md#deletechallengeevent) | **DELETE** /challenges/events/{id} | Delete a challenge event
[**DeleteChallengeTemplate**](CampaignsChallengesApi.md#deletechallengetemplate) | **DELETE** /challenges/templates/{id} | Delete a challenge template
[**GetChallenge**](CampaignsChallengesApi.md#getchallenge) | **GET** /challenges/{id} | Retrieve a challenge
[**GetChallengeActivities**](CampaignsChallengesApi.md#getchallengeactivities) | **GET** /challenges/{challenge_id}/activities | List and search challenge activities
[**GetChallengeActivity**](CampaignsChallengesApi.md#getchallengeactivity) | **GET** /challenges/{challenge_id}/activities/{activity_id} | Get a single challenge activity
[**GetChallengeEvent**](CampaignsChallengesApi.md#getchallengeevent) | **GET** /challenges/events/{id} | Retrieve a single challenge event details
[**GetChallengeEvents**](CampaignsChallengesApi.md#getchallengeevents) | **GET** /challenges/events | Retrieve a list of challenge events
[**GetChallengeTemplate**](CampaignsChallengesApi.md#getchallengetemplate) | **GET** /challenges/templates/{id} | Get a single challenge template
[**GetChallengeTemplates**](CampaignsChallengesApi.md#getchallengetemplates) | **GET** /challenges/templates | List and search challenge templates
[**GetChallenges**](CampaignsChallengesApi.md#getchallenges) | **GET** /challenges | Retrieve a list of challenges
[**UpdateChallenge**](CampaignsChallengesApi.md#updatechallenge) | **PUT** /challenges/{id} | Update a challenge
[**UpdateChallengeActivity**](CampaignsChallengesApi.md#updatechallengeactivity) | **PUT** /challenges/{challenge_id}/activities/{activity_id} | Update a challenge activity
[**UpdateChallengeTemplate**](CampaignsChallengesApi.md#updatechallengetemplate) | **PUT** /challenges/templates/{id} | Update a challenge template


<a name="createchallenge"></a>
# **CreateChallenge**
> ModelChallengeResource CreateChallenge (ModelChallengeResource challengeResource)

Create a challenge

Challenges do not run on their own.  They must be added to a campaign before events will spawn.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeResource = new ModelChallengeResource(); // ModelChallengeResource | The challenge resource object (optional) 

            try
            {
                // Create a challenge
                ModelChallengeResource result = apiInstance.CreateChallenge(challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallenge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeResource** | [**ModelChallengeResource**](ModelChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ModelChallengeResource**](ModelChallengeResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengeactivity"></a>
# **CreateChallengeActivity**
> ModelChallengeActivityResource CreateChallengeActivity (long? challengeId, ModelChallengeActivityResource challengeActivityResource, bool? validateSettings)

Create a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ModelChallengeActivityResource(); // ModelChallengeActivityResource | The challenge activity resource object (optional) 
            var validateSettings = true;  // bool? | Whether to validate the settings being sent against the available settings on the base activity. (optional)  (default to false)

            try
            {
                // Create a challenge activity
                ModelChallengeActivityResource result = apiInstance.CreateChallengeActivity(challengeId, challengeActivityResource, validateSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeId** | **long?**| The challenge id | 
 **challengeActivityResource** | [**ModelChallengeActivityResource**](ModelChallengeActivityResource.md)| The challenge activity resource object | [optional] 
 **validateSettings** | **bool?**| Whether to validate the settings being sent against the available settings on the base activity. | [optional] [default to false]

### Return type

[**ModelChallengeActivityResource**](ModelChallengeActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengetemplate"></a>
# **CreateChallengeTemplate**
> ModelTemplateResource CreateChallengeTemplate (ModelTemplateResource challengeTemplateResource)

Create a challenge template

Challenge Templates define a type of challenge and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The challenge template resource object (optional) 

            try
            {
                // Create a challenge template
                ModelTemplateResource result = apiInstance.CreateChallengeTemplate(challengeTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The challenge template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallenge"></a>
# **DeleteChallenge**
> void DeleteChallenge (long? id)

Delete a challenge

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge
                apiInstance.DeleteChallenge(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallenge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeactivity"></a>
# **DeleteChallengeActivity**
> void DeleteChallengeActivity (long? activityId, long? challengeId)

Delete a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge activity
                apiInstance.DeleteChallengeActivity(activityId, challengeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 
 **challengeId** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeevent"></a>
# **DeleteChallengeEvent**
> void DeleteChallengeEvent (long? id)

Delete a challenge event

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Delete a challenge event
                apiInstance.DeleteChallengeEvent(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge event id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengetemplate"></a>
# **DeleteChallengeTemplate**
> void DeleteChallengeTemplate (string id, string cascade)

Delete a challenge template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a challenge template
                apiInstance.DeleteChallengeTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeTemplate: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallenge"></a>
# **GetChallenge**
> ModelChallengeResource GetChallenge (long? id)

Retrieve a challenge

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Retrieve a challenge
                ModelChallengeResource result = apiInstance.GetChallenge(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallenge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 

### Return type

[**ModelChallengeResource**](ModelChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivities"></a>
# **GetChallengeActivities**
> ModelPageResourceBareChallengeActivityResource GetChallengeActivities (long? challengeId, int? size, int? page, string order)

List and search challenge activities

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivitiesExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge activities
                ModelPageResourceBareChallengeActivityResource result = apiInstance.GetChallengeActivities(challengeId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeId** | **long?**| The challenge id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceBareChallengeActivityResource**](ModelPageResourceBareChallengeActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivity"></a>
# **GetChallengeActivity**
> ModelChallengeActivityResource GetChallengeActivity (long? activityId)

Get a single challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivityExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id

            try
            {
                // Get a single challenge activity
                ModelChallengeActivityResource result = apiInstance.GetChallengeActivity(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 

### Return type

[**ModelChallengeActivityResource**](ModelChallengeActivityResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeevent"></a>
# **GetChallengeEvent**
> ModelChallengeEventResource GetChallengeEvent (long? id)

Retrieve a single challenge event details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Retrieve a single challenge event details
                ModelChallengeEventResource result = apiInstance.GetChallengeEvent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge event id | 

### Return type

[**ModelChallengeEventResource**](ModelChallengeEventResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeevents"></a>
# **GetChallengeEvents**
> ModelPageResourceChallengeEventResource GetChallengeEvents (string filterStartDate, string filterEndDate, bool? filterCampaigns, long? filterChallenge, int? size, int? page, string order)

Retrieve a list of challenge events

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeEventsExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterEndDate = filterEndDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterCampaigns = true;  // bool? | check only for events from currently running campaigns (optional) 
            var filterChallenge = 789;  // long? | check only for events from the challenge specified by id (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve a list of challenge events
                ModelPageResourceChallengeEventResource result = apiInstance.GetChallengeEvents(filterStartDate, filterEndDate, filterCampaigns, filterChallenge, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterEndDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterCampaigns** | **bool?**| check only for events from currently running campaigns | [optional] 
 **filterChallenge** | **long?**| check only for events from the challenge specified by id | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceChallengeEventResource**](ModelPageResourceChallengeEventResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengetemplate"></a>
# **GetChallengeTemplate**
> ModelTemplateResource GetChallengeTemplate (string id)

Get a single challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single challenge template
                ModelTemplateResource result = apiInstance.GetChallengeTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplate: " + e.Message );
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

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengetemplates"></a>
# **GetChallengeTemplates**
> ModelPageResourceTemplateResource GetChallengeTemplates (int? size, int? page, string order)

List and search challenge templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge templates
                ModelPageResourceTemplateResource result = apiInstance.GetChallengeTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeTemplates: " + e.Message );
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

[**ModelPageResourceTemplateResource**](ModelPageResourceTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallenges"></a>
# **GetChallenges**
> ModelPageResourceChallengeResource GetChallenges (bool? filterTemplate, bool? filterActiveCampaign)

Retrieve a list of challenges

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengesExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsChallengesApi();
            var filterTemplate = true;  // bool? | Filter for challenges that are not tied to campaigns (templates) (optional) 
            var filterActiveCampaign = true;  // bool? | Filter for challenges that are tied to active campaigns (optional) 

            try
            {
                // Retrieve a list of challenges
                ModelPageResourceChallengeResource result = apiInstance.GetChallenges(filterTemplate, filterActiveCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallenges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTemplate** | **bool?**| Filter for challenges that are not tied to campaigns (templates) | [optional] 
 **filterActiveCampaign** | **bool?**| Filter for challenges that are tied to active campaigns | [optional] 

### Return type

[**ModelPageResourceChallengeResource**](ModelPageResourceChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallenge"></a>
# **UpdateChallenge**
> ModelChallengeResource UpdateChallenge (long? id, ModelChallengeResource challengeResource)

Update a challenge

If the challenge is a copy, changes will propagate to all the related challenges

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id
            var challengeResource = new ModelChallengeResource(); // ModelChallengeResource | The challenge resource object (optional) 

            try
            {
                // Update a challenge
                ModelChallengeResource result = apiInstance.UpdateChallenge(id, challengeResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallenge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The challenge id | 
 **challengeResource** | [**ModelChallengeResource**](ModelChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ModelChallengeResource**](ModelChallengeResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeactivity"></a>
# **UpdateChallengeActivity**
> ModelChallengeActivityResource UpdateChallengeActivity (long? activityId, long? challengeId, ModelChallengeActivityResource challengeActivityResource)

Update a challenge activity

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var activityId = 789;  // long? | The activity id
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ModelChallengeActivityResource(); // ModelChallengeActivityResource | The challenge activity resource object (optional) 

            try
            {
                // Update a challenge activity
                ModelChallengeActivityResource result = apiInstance.UpdateChallengeActivity(activityId, challengeId, challengeActivityResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The activity id | 
 **challengeId** | **long?**| The challenge id | 
 **challengeActivityResource** | [**ModelChallengeActivityResource**](ModelChallengeActivityResource.md)| The challenge activity resource object | [optional] 

### Return type

[**ModelChallengeActivityResource**](ModelChallengeActivityResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengetemplate"></a>
# **UpdateChallengeTemplate**
> ModelTemplateResource UpdateChallengeTemplate (string id, ModelTemplateResource challengeTemplateResource)

Update a challenge template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var challengeTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The challenge template resource object (optional) 

            try
            {
                // Update a challenge template
                ModelTemplateResource result = apiInstance.UpdateChallengeTemplate(id, challengeTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **challengeTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The challenge template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

