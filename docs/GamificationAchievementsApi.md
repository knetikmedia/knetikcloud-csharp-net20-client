# com.knetikcloud..GamificationAchievementsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAchievement**](GamificationAchievementsApi.md#createachievement) | **POST** /achievements | Create a new achievement definition
[**CreateAchievementTemplate**](GamificationAchievementsApi.md#createachievementtemplate) | **POST** /achievements/templates | Create an achievement template
[**DeleteAchievement**](GamificationAchievementsApi.md#deleteachievement) | **DELETE** /achievements/{name} | Delete an achievement definition
[**DeleteAchievementTemplate**](GamificationAchievementsApi.md#deleteachievementtemplate) | **DELETE** /achievements/templates/{id} | Delete an achievement template
[**GetAchievement**](GamificationAchievementsApi.md#getachievement) | **GET** /achievements/{name} | Get a single achievement definition
[**GetAchievementTemplate**](GamificationAchievementsApi.md#getachievementtemplate) | **GET** /achievements/templates/{id} | Get a single achievement template
[**GetAchievementTemplates**](GamificationAchievementsApi.md#getachievementtemplates) | **GET** /achievements/templates | List and search achievement templates
[**GetAchievementTriggers**](GamificationAchievementsApi.md#getachievementtriggers) | **GET** /achievements/triggers | Get the list of triggers that can be used to trigger an achievement progress update
[**GetAchievements**](GamificationAchievementsApi.md#getachievements) | **GET** /achievements | Get all achievement definitions in the system
[**GetDerivedAchievements**](GamificationAchievementsApi.md#getderivedachievements) | **GET** /achievements/derived/{name} | Get a list of derived achievements
[**GetUserAchievementProgress**](GamificationAchievementsApi.md#getuserachievementprogress) | **GET** /users/{user_id}/achievements/{achievement_name} | Retrieve progress on a given achievement for a given user
[**GetUserAchievementsProgress**](GamificationAchievementsApi.md#getuserachievementsprogress) | **GET** /users/{user_id}/achievements | Retrieve progress on achievements for a given user
[**GetUsersAchievementProgress**](GamificationAchievementsApi.md#getusersachievementprogress) | **GET** /users/achievements/{achievement_name} | Retrieve progress on a given achievement for all users
[**GetUsersAchievementsProgress**](GamificationAchievementsApi.md#getusersachievementsprogress) | **GET** /users/achievements | Retrieve progress on achievements for all users
[**IncrementAchievementProgress**](GamificationAchievementsApi.md#incrementachievementprogress) | **POST** /users/{user_id}/achievements/{achievement_name}/progress | Increment an achievement progress record for a user
[**SetAchievementProgress**](GamificationAchievementsApi.md#setachievementprogress) | **PUT** /users/{user_id}/achievements/{achievement_name}/progress | Set an achievement progress record for a user
[**UpdateAchievement**](GamificationAchievementsApi.md#updateachievement) | **PUT** /achievements/{name} | Update an achievement definition
[**UpdateAchievementTemplate**](GamificationAchievementsApi.md#updateachievementtemplate) | **PUT** /achievements/templates/{id} | Update an achievement template


<a name="createachievement"></a>
# **CreateAchievement**
> ModelAchievementDefinitionResource CreateAchievement (ModelAchievementDefinitionResource achievement)

Create a new achievement definition

If the definition contains a trigger event name, a BRE rule is created, so that tracking logic is executed when the triggering event occurs. If no trigger event name is specified, the user's achievement status must manually be updated via the API.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateAchievementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var achievement = new ModelAchievementDefinitionResource(); // ModelAchievementDefinitionResource | The achievement definition (optional) 

            try
            {
                // Create a new achievement definition
                ModelAchievementDefinitionResource result = apiInstance.CreateAchievement(achievement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.CreateAchievement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **achievement** | [**ModelAchievementDefinitionResource**](ModelAchievementDefinitionResource.md)| The achievement definition | [optional] 

### Return type

[**ModelAchievementDefinitionResource**](ModelAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createachievementtemplate"></a>
# **CreateAchievementTemplate**
> ModelTemplateResource CreateAchievementTemplate (ModelTemplateResource template)

Create an achievement template

Achievement templates define a type of achievement and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateAchievementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var template = new ModelTemplateResource(); // ModelTemplateResource | The achievement template to be created (optional) 

            try
            {
                // Create an achievement template
                ModelTemplateResource result = apiInstance.CreateAchievementTemplate(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.CreateAchievementTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**ModelTemplateResource**](ModelTemplateResource.md)| The achievement template to be created | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteachievement"></a>
# **DeleteAchievement**
> void DeleteAchievement (string name)

Delete an achievement definition

Will also disable the associated generated rule, if any.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteAchievementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement

            try
            {
                // Delete an achievement definition
                apiInstance.DeleteAchievement(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.DeleteAchievement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteachievementtemplate"></a>
# **DeleteAchievementTemplate**
> void DeleteAchievementTemplate (string id, string cascade)

Delete an achievement template

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
    public class DeleteAchievementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an achievement template
                apiInstance.DeleteAchievementTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.DeleteAchievementTemplate: " + e.Message );
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

<a name="getachievement"></a>
# **GetAchievement**
> ModelAchievementDefinitionResource GetAchievement (string name)

Get a single achievement definition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAchievementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement

            try
            {
                // Get a single achievement definition
                ModelAchievementDefinitionResource result = apiInstance.GetAchievement(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 

### Return type

[**ModelAchievementDefinitionResource**](ModelAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievementtemplate"></a>
# **GetAchievementTemplate**
> ModelTemplateResource GetAchievementTemplate (string id)

Get a single achievement template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAchievementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single achievement template
                ModelTemplateResource result = apiInstance.GetAchievementTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementTemplate: " + e.Message );
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

<a name="getachievementtemplates"></a>
# **GetAchievementTemplates**
> ModelPageResourceTemplateResource GetAchievementTemplates (int? size, int? page, string order)

List and search achievement templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAchievementTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search achievement templates
                ModelPageResourceTemplateResource result = apiInstance.GetAchievementTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementTemplates: " + e.Message );
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

<a name="getachievementtriggers"></a>
# **GetAchievementTriggers**
> List<ModelBreTriggerResource> GetAchievementTriggers ()

Get the list of triggers that can be used to trigger an achievement progress update

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAchievementTriggersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();

            try
            {
                // Get the list of triggers that can be used to trigger an achievement progress update
                List&lt;ModelBreTriggerResource&gt; result = apiInstance.GetAchievementTriggers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievementTriggers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelBreTriggerResource>**](ModelBreTriggerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getachievements"></a>
# **GetAchievements**
> ModelPageResourceAchievementDefinitionResource GetAchievements (string filterTagset, string filterName, bool? filterHidden, bool? filterDerived, int? size, int? page, string order)

Get all achievement definitions in the system

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAchievementsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var filterTagset = filterTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterName = filterName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var filterHidden = true;  // bool? | Filter for achievements that are hidden or not (optional) 
            var filterDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // Get all achievement definitions in the system
                ModelPageResourceAchievementDefinitionResource result = apiInstance.GetAchievements(filterTagset, filterName, filterHidden, filterDerived, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetAchievements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **filterHidden** | **bool?**| Filter for achievements that are hidden or not | [optional] 
 **filterDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**ModelPageResourceAchievementDefinitionResource**](ModelPageResourceAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getderivedachievements"></a>
# **GetDerivedAchievements**
> List<ModelAchievementDefinitionResource> GetDerivedAchievements (string name)

Get a list of derived achievements

Used by other services that depend on achievements

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDerivedAchievementsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the derived achievement

            try
            {
                // Get a list of derived achievements
                List&lt;ModelAchievementDefinitionResource&gt; result = apiInstance.GetDerivedAchievements(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetDerivedAchievements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the derived achievement | 

### Return type

[**List<ModelAchievementDefinitionResource>**](ModelAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserachievementprogress"></a>
# **GetUserAchievementProgress**
> ModelUserAchievementGroupResource GetUserAchievementProgress (int? userId, string achievementName)

Retrieve progress on a given achievement for a given user

Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserAchievementProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var achievementName = achievementName_example;  // string | The achievement's name

            try
            {
                // Retrieve progress on a given achievement for a given user
                ModelUserAchievementGroupResource result = apiInstance.GetUserAchievementProgress(userId, achievementName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUserAchievementProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **achievementName** | **string**| The achievement&#39;s name | 

### Return type

[**ModelUserAchievementGroupResource**](ModelUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserachievementsprogress"></a>
# **GetUserAchievementsProgress**
> ModelPageResourceUserAchievementGroupResource GetUserAchievementsProgress (int? userId, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)

Retrieve progress on achievements for a given user

Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserAchievementsProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementName = filterAchievementName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on achievements for a given user
                ModelPageResourceUserAchievementGroupResource result = apiInstance.GetUserAchievementsProgress(userId, filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUserAchievementsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceUserAchievementGroupResource**](ModelPageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersachievementprogress"></a>
# **GetUsersAchievementProgress**
> ModelPageResourceUserAchievementGroupResource GetUsersAchievementProgress (string achievementName, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)

Retrieve progress on a given achievement for all users

Assets will not be filled in on the resources returned. Use 'Get single achievement progress for user' to retrieve the full resource with assets for a given user as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsersAchievementProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var achievementName = achievementName_example;  // string | The achievement's name
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementName = filterAchievementName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on a given achievement for all users
                ModelPageResourceUserAchievementGroupResource result = apiInstance.GetUsersAchievementProgress(achievementName, filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUsersAchievementProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **achievementName** | **string**| The achievement&#39;s name | 
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceUserAchievementGroupResource**](ModelPageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersachievementsprogress"></a>
# **GetUsersAchievementsProgress**
> ModelPageResourceUserAchievementGroupResource GetUsersAchievementsProgress (bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)

Retrieve progress on achievements for all users

Assets will not be filled in on the resources returned. Use 'Get single achievement progress for user' to retrieve the full resource with assets for a given user as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsersAchievementsProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var filterAchievementDerived = true;  // bool? | Filter for achievements that are derived from other services (optional) 
            var filterAchievementTagset = filterAchievementTagset_example;  // string | Filter for achievements with specified tags (separated by comma) (optional) 
            var filterAchievementName = filterAchievementName_example;  // string | Filter for achievements whose name contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieve progress on achievements for all users
                ModelPageResourceUserAchievementGroupResource result = apiInstance.GetUsersAchievementsProgress(filterAchievementDerived, filterAchievementTagset, filterAchievementName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.GetUsersAchievementsProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterAchievementDerived** | **bool?**| Filter for achievements that are derived from other services | [optional] 
 **filterAchievementTagset** | **string**| Filter for achievements with specified tags (separated by comma) | [optional] 
 **filterAchievementName** | **string**| Filter for achievements whose name contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceUserAchievementGroupResource**](ModelPageResourceUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="incrementachievementprogress"></a>
# **IncrementAchievementProgress**
> ModelUserAchievementGroupResource IncrementAchievementProgress (int? userId, string achievementName, int? progress)

Increment an achievement progress record for a user

If no progress record yet exists for the user, it will be created. Otherwise it will be updated and the provided value added to the existing progress. May be negative. If progress meets or exceeds the achievement's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class IncrementAchievementProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var achievementName = achievementName_example;  // string | The achievement's name
            var progress = 56;  // int? | The amount to add to the progress value (optional) 

            try
            {
                // Increment an achievement progress record for a user
                ModelUserAchievementGroupResource result = apiInstance.IncrementAchievementProgress(userId, achievementName, progress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.IncrementAchievementProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **achievementName** | **string**| The achievement&#39;s name | 
 **progress** | **int?**| The amount to add to the progress value | [optional] 

### Return type

[**ModelUserAchievementGroupResource**](ModelUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setachievementprogress"></a>
# **SetAchievementProgress**
> ModelUserAchievementGroupResource SetAchievementProgress (int? userId, string achievementName, int? progress)

Set an achievement progress record for a user

If no progress record yet exists for the user, it will be created. Otherwise it will be updated and progress set to the provided value. If progress meets or exceeds the achievement's max_value it will be marked as earned and a BRE event will be triggered for the <code>BreAchievementEarnedTrigger</code>.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetAchievementProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var userId = 56;  // int? | The user's id
            var achievementName = achievementName_example;  // string | The achievement's name
            var progress = 56;  // int? | The new progress value (optional) 

            try
            {
                // Set an achievement progress record for a user
                ModelUserAchievementGroupResource result = apiInstance.SetAchievementProgress(userId, achievementName, progress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.SetAchievementProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **achievementName** | **string**| The achievement&#39;s name | 
 **progress** | **int?**| The new progress value | [optional] 

### Return type

[**ModelUserAchievementGroupResource**](ModelUserAchievementGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateachievement"></a>
# **UpdateAchievement**
> ModelAchievementDefinitionResource UpdateAchievement (string name, ModelAchievementDefinitionResource achievement)

Update an achievement definition

The existing generated rule, if any, will be deleted. A new rule will be created if a trigger event name is specified in the new version.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateAchievementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var name = name_example;  // string | The name of the achievement
            var achievement = new ModelAchievementDefinitionResource(); // ModelAchievementDefinitionResource | The achievement definition (optional) 

            try
            {
                // Update an achievement definition
                ModelAchievementDefinitionResource result = apiInstance.UpdateAchievement(name, achievement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.UpdateAchievement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the achievement | 
 **achievement** | [**ModelAchievementDefinitionResource**](ModelAchievementDefinitionResource.md)| The achievement definition | [optional] 

### Return type

[**ModelAchievementDefinitionResource**](ModelAchievementDefinitionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateachievementtemplate"></a>
# **UpdateAchievementTemplate**
> ModelTemplateResource UpdateAchievementTemplate (string id, ModelTemplateResource template)

Update an achievement template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateAchievementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationAchievementsApi();
            var id = id_example;  // string | The id of the template
            var template = new ModelTemplateResource(); // ModelTemplateResource | The updated template (optional) 

            try
            {
                // Update an achievement template
                ModelTemplateResource result = apiInstance.UpdateAchievementTemplate(id, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationAchievementsApi.UpdateAchievementTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**ModelTemplateResource**](ModelTemplateResource.md)| The updated template | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
