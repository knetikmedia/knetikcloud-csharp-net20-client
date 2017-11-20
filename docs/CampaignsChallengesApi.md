# com.knetikcloud..CampaignsChallengesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChallenge**](CampaignsChallengesApi.md#createchallenge) | **POST** /challenges | Create a challenge
[**CreateChallengeActivity**](CampaignsChallengesApi.md#createchallengeactivity) | **POST** /challenges/{challenge_id}/activities | Create a challenge activity
[**CreateChallengeActivityTemplate**](CampaignsChallengesApi.md#createchallengeactivitytemplate) | **POST** /challenge-activities/templates | Create a challenge activity template
[**CreateChallengeTemplate**](CampaignsChallengesApi.md#createchallengetemplate) | **POST** /challenges/templates | Create a challenge template
[**DeleteChallenge**](CampaignsChallengesApi.md#deletechallenge) | **DELETE** /challenges/{id} | Delete a challenge
[**DeleteChallengeActivity**](CampaignsChallengesApi.md#deletechallengeactivity) | **DELETE** /challenges/{challenge_id}/activities/{id} | Delete a challenge activity
[**DeleteChallengeActivityTemplate**](CampaignsChallengesApi.md#deletechallengeactivitytemplate) | **DELETE** /challenge-activities/templates/{id} | Delete a challenge activity template
[**DeleteChallengeEvent**](CampaignsChallengesApi.md#deletechallengeevent) | **DELETE** /challenges/events/{id} | Delete a challenge event
[**DeleteChallengeTemplate**](CampaignsChallengesApi.md#deletechallengetemplate) | **DELETE** /challenges/templates/{id} | Delete a challenge template
[**GetChallenge**](CampaignsChallengesApi.md#getchallenge) | **GET** /challenges/{id} | Retrieve a challenge
[**GetChallengeActivities**](CampaignsChallengesApi.md#getchallengeactivities) | **GET** /challenges/{challenge_id}/activities | List and search challenge activities
[**GetChallengeActivity**](CampaignsChallengesApi.md#getchallengeactivity) | **GET** /challenges/{challenge_id}/activities/{id} | Get a single challenge activity
[**GetChallengeActivityTemplate**](CampaignsChallengesApi.md#getchallengeactivitytemplate) | **GET** /challenge-activities/templates/{id} | Get a single challenge activity template
[**GetChallengeActivityTemplates**](CampaignsChallengesApi.md#getchallengeactivitytemplates) | **GET** /challenge-activities/templates | List and search challenge activity templates
[**GetChallengeEvent**](CampaignsChallengesApi.md#getchallengeevent) | **GET** /challenges/events/{id} | Retrieve a single challenge event details
[**GetChallengeEvents**](CampaignsChallengesApi.md#getchallengeevents) | **GET** /challenges/events | Retrieve a list of challenge events
[**GetChallengeTemplate**](CampaignsChallengesApi.md#getchallengetemplate) | **GET** /challenges/templates/{id} | Get a single challenge template
[**GetChallengeTemplates**](CampaignsChallengesApi.md#getchallengetemplates) | **GET** /challenges/templates | List and search challenge templates
[**GetChallenges**](CampaignsChallengesApi.md#getchallenges) | **GET** /challenges | Retrieve a list of challenges
[**UpdateChallenge**](CampaignsChallengesApi.md#updatechallenge) | **PUT** /challenges/{id} | Update a challenge
[**UpdateChallengeActivity**](CampaignsChallengesApi.md#updatechallengeactivity) | **PUT** /challenges/{challenge_id}/activities/{id} | Update a challenge activity
[**UpdateChallengeActivityTemplate**](CampaignsChallengesApi.md#updatechallengeactivitytemplate) | **PUT** /challenge-activities/templates/{id} | Update an challenge activity template
[**UpdateChallengeTemplate**](CampaignsChallengesApi.md#updatechallengetemplate) | **PUT** /challenges/templates/{id} | Update a challenge template


<a name="createchallenge"></a>
# **CreateChallenge**
> ChallengeResource CreateChallenge (ChallengeResource challengeResource)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Create a challenge
                ChallengeResource result = apiInstance.CreateChallenge(challengeResource);
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
 **challengeResource** | [**ChallengeResource**](ChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ChallengeResource**](ChallengeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengeactivity"></a>
# **CreateChallengeActivity**
> ChallengeActivityResource CreateChallengeActivity (long? challengeId, ChallengeActivityResource challengeActivityResource, bool? validateSettings)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 
            var validateSettings = true;  // bool? | Whether to validate the settings being sent against the available settings on the base activity. (optional)  (default to false)

            try
            {
                // Create a challenge activity
                ChallengeActivityResource result = apiInstance.CreateChallengeActivity(challengeId, challengeActivityResource, validateSettings);
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
 **challengeActivityResource** | [**ChallengeActivityResource**](ChallengeActivityResource.md)| The challenge activity resource object | [optional] 
 **validateSettings** | **bool?**| Whether to validate the settings being sent against the available settings on the base activity. | [optional] [default to false]

### Return type

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengeactivitytemplate"></a>
# **CreateChallengeActivityTemplate**
> TemplateResource CreateChallengeActivityTemplate (TemplateResource challengeActivityTemplateResource)

Create a challenge activity template

Challenge Activity Templates define a type of challenge activity and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateChallengeActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeActivityTemplateResource = new TemplateResource(); // TemplateResource | The challengeActivity template resource object (optional) 

            try
            {
                // Create a challenge activity template
                TemplateResource result = apiInstance.CreateChallengeActivityTemplate(challengeActivityTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.CreateChallengeActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **challengeActivityTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challengeActivity template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchallengetemplate"></a>
# **CreateChallengeTemplate**
> TemplateResource CreateChallengeTemplate (TemplateResource challengeTemplateResource)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Create a challenge template
                TemplateResource result = apiInstance.CreateChallengeTemplate(challengeTemplateResource);
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
 **challengeTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challenge template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeactivity"></a>
# **DeleteChallengeActivity**
> void DeleteChallengeActivity (long? id, long? challengeId)

Delete a challenge activity

A challenge can have multiple instances of the same activity and thus the id used is of the specific entry within the challenge

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge_activity id
            var challengeId = 789;  // long? | The challenge id

            try
            {
                // Delete a challenge activity
                apiInstance.DeleteChallengeActivity(id, challengeId);
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
 **id** | **long?**| The challenge_activity id | 
 **challengeId** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechallengeactivitytemplate"></a>
# **DeleteChallengeActivityTemplate**
> void DeleteChallengeActivityTemplate (string id, string cascade)

Delete a challenge activity template

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
    public class DeleteChallengeActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a challenge activity template
                apiInstance.DeleteChallengeActivityTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.DeleteChallengeActivityTemplate: " + e.Message );
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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallenge"></a>
# **GetChallenge**
> ChallengeResource GetChallenge (long? id)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id

            try
            {
                // Retrieve a challenge
                ChallengeResource result = apiInstance.GetChallenge(id);
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

[**ChallengeResource**](ChallengeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivities"></a>
# **GetChallengeActivities**
> PageResourceBareChallengeActivityResource GetChallengeActivities (long? challengeId, int? size, int? page, string order)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var challengeId = 789;  // long? | The challenge id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge activities
                PageResourceBareChallengeActivityResource result = apiInstance.GetChallengeActivities(challengeId, size, page, order);
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

[**PageResourceBareChallengeActivityResource**](PageResourceBareChallengeActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivity"></a>
# **GetChallengeActivity**
> ChallengeActivityResource GetChallengeActivity (long? id, long? challengeId)

Get a single challenge activity

A challenge can have multiple instances of the same activity and thus the id used is of the specific entry within the challenge

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge_activity id
            var challengeId = 789;  // long? | The challenge id

            try
            {
                // Get a single challenge activity
                ChallengeActivityResource result = apiInstance.GetChallengeActivity(id, challengeId);
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
 **id** | **long?**| The challenge_activity id | 
 **challengeId** | **long?**| The challenge id | 

### Return type

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivitytemplate"></a>
# **GetChallengeActivityTemplate**
> TemplateResource GetChallengeActivityTemplate (string id)

Get a single challenge activity template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single challenge activity template
                TemplateResource result = apiInstance.GetChallengeActivityTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivityTemplate: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeactivitytemplates"></a>
# **GetChallengeActivityTemplates**
> PageResourceTemplateResource GetChallengeActivityTemplates (int? size, int? page, string order)

List and search challenge activity templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetChallengeActivityTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge activity templates
                PageResourceTemplateResource result = apiInstance.GetChallengeActivityTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.GetChallengeActivityTemplates: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeevent"></a>
# **GetChallengeEvent**
> ChallengeEventResource GetChallengeEvent (long? id)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge event id

            try
            {
                // Retrieve a single challenge event details
                ChallengeEventResource result = apiInstance.GetChallengeEvent(id);
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

[**ChallengeEventResource**](ChallengeEventResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeevents"></a>
# **GetChallengeEvents**
> PageResourceChallengeEventResource GetChallengeEvents (string filterStartDate, string filterEndDate, bool? filterCampaigns, long? filterChallenge, int? size, int? page, string order)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
                PageResourceChallengeEventResource result = apiInstance.GetChallengeEvents(filterStartDate, filterEndDate, filterCampaigns, filterChallenge, size, page, order);
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

[**PageResourceChallengeEventResource**](PageResourceChallengeEventResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengetemplate"></a>
# **GetChallengeTemplate**
> TemplateResource GetChallengeTemplate (string id)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single challenge template
                TemplateResource result = apiInstance.GetChallengeTemplate(id);
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

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengetemplates"></a>
# **GetChallengeTemplates**
> PageResourceTemplateResource GetChallengeTemplates (int? size, int? page, string order)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search challenge templates
                PageResourceTemplateResource result = apiInstance.GetChallengeTemplates(size, page, order);
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

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallenges"></a>
# **GetChallenges**
> PageResourceChallengeResource GetChallenges (bool? filterActiveCampaign, string filterStartDate, string filterEndDate, int? size, int? page, string order)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var filterActiveCampaign = true;  // bool? | Filter for challenges that are tied to active campaigns (optional) 
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the challenge start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterEndDate = filterEndDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the challenge end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve a list of challenges
                PageResourceChallengeResource result = apiInstance.GetChallenges(filterActiveCampaign, filterStartDate, filterEndDate, size, page, order);
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
 **filterActiveCampaign** | **bool?**| Filter for challenges that are tied to active campaigns | [optional] 
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the challenge start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterEndDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the challenge end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceChallengeResource**](PageResourceChallengeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallenge"></a>
# **UpdateChallenge**
> ChallengeResource UpdateChallenge (long? id, ChallengeResource challengeResource)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge id
            var challengeResource = new ChallengeResource(); // ChallengeResource | The challenge resource object (optional) 

            try
            {
                // Update a challenge
                ChallengeResource result = apiInstance.UpdateChallenge(id, challengeResource);
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
 **challengeResource** | [**ChallengeResource**](ChallengeResource.md)| The challenge resource object | [optional] 

### Return type

[**ChallengeResource**](ChallengeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeactivity"></a>
# **UpdateChallengeActivity**
> ChallengeActivityResource UpdateChallengeActivity (long? id, long? challengeId, ChallengeActivityResource challengeActivityResource, bool? validateSettings)

Update a challenge activity

A challenge can have multiple instances of the same activity and thus the id used is of the specific entry within the challenge

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = 789;  // long? | The challenge_activity id
            var challengeId = 789;  // long? | The challenge id
            var challengeActivityResource = new ChallengeActivityResource(); // ChallengeActivityResource | The challenge activity resource object (optional) 
            var validateSettings = true;  // bool? | Whether to validate the settings being sent against the available settings on the base activity. (optional)  (default to false)

            try
            {
                // Update a challenge activity
                ChallengeActivityResource result = apiInstance.UpdateChallengeActivity(id, challengeId, challengeActivityResource, validateSettings);
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
 **id** | **long?**| The challenge_activity id | 
 **challengeId** | **long?**| The challenge id | 
 **challengeActivityResource** | [**ChallengeActivityResource**](ChallengeActivityResource.md)| The challenge activity resource object | [optional] 
 **validateSettings** | **bool?**| Whether to validate the settings being sent against the available settings on the base activity. | [optional] [default to false]

### Return type

[**ChallengeActivityResource**](ChallengeActivityResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengeactivitytemplate"></a>
# **UpdateChallengeActivityTemplate**
> TemplateResource UpdateChallengeActivityTemplate (string id, TemplateResource challengeActivityTemplateResource)

Update an challenge activity template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateChallengeActivityTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var challengeActivityTemplateResource = new TemplateResource(); // TemplateResource | The challengeActivity template resource object (optional) 

            try
            {
                // Update an challenge activity template
                TemplateResource result = apiInstance.UpdateChallengeActivityTemplate(id, challengeActivityTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsChallengesApi.UpdateChallengeActivityTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **challengeActivityTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challengeActivity template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechallengetemplate"></a>
# **UpdateChallengeTemplate**
> TemplateResource UpdateChallengeTemplate (string id, TemplateResource challengeTemplateResource)

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsChallengesApi();
            var id = id_example;  // string | The id of the template
            var challengeTemplateResource = new TemplateResource(); // TemplateResource | The challenge template resource object (optional) 

            try
            {
                // Update a challenge template
                TemplateResource result = apiInstance.UpdateChallengeTemplate(id, challengeTemplateResource);
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
 **challengeTemplateResource** | [**TemplateResource**](TemplateResource.md)| The challenge template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

