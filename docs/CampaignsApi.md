# com.knetikcloud..CampaignsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChallengeToCampaign**](CampaignsApi.md#addchallengetocampaign) | **POST** /campaigns/{id}/challenges | Add a challenge to a campaign
[**CreateCampaign**](CampaignsApi.md#createcampaign) | **POST** /campaigns | Create a campaign
[**CreateCampaignTemplate**](CampaignsApi.md#createcampaigntemplate) | **POST** /campaigns/templates | Create a campaign template
[**DeleteCampaign**](CampaignsApi.md#deletecampaign) | **DELETE** /campaigns/{id} | Delete a campaign
[**DeleteCampaignTemplate**](CampaignsApi.md#deletecampaigntemplate) | **DELETE** /campaigns/templates/{id} | Delete a campaign template
[**GetCampaign**](CampaignsApi.md#getcampaign) | **GET** /campaigns/{id} | Returns a single campaign
[**GetCampaignChallenges**](CampaignsApi.md#getcampaignchallenges) | **GET** /campaigns/{id}/challenges | List the challenges associated with a campaign
[**GetCampaignTemplate**](CampaignsApi.md#getcampaigntemplate) | **GET** /campaigns/templates/{id} | Get a single campaign template
[**GetCampaignTemplates**](CampaignsApi.md#getcampaigntemplates) | **GET** /campaigns/templates | List and search campaign templates
[**GetCampaigns**](CampaignsApi.md#getcampaigns) | **GET** /campaigns | List and search campaigns
[**RemoveChallengeFromCampaign**](CampaignsApi.md#removechallengefromcampaign) | **DELETE** /campaigns/{campaign_id}/challenges/{id} | Remove a challenge from a campaign
[**UpdateCampaign**](CampaignsApi.md#updatecampaign) | **PUT** /campaigns/{id} | Update a campaign
[**UpdateCampaignTemplate**](CampaignsApi.md#updatecampaigntemplate) | **PUT** /campaigns/templates/{id} | Update an campaign template


<a name="addchallengetocampaign"></a>
# **AddChallengeToCampaign**
> void AddChallengeToCampaign (long? id, long? challengeId)

Add a challenge to a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddChallengeToCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The id of the campaign
            var challengeId = 789;  // long? | The id of the challenge (optional) 

            try
            {
                // Add a challenge to a campaign
                apiInstance.AddChallengeToCampaign(id, challengeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.AddChallengeToCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the campaign | 
 **challengeId** | **long?**| The id of the challenge | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcampaign"></a>
# **CreateCampaign**
> CampaignResource CreateCampaign (CampaignResource campaignResource)

Create a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignResource = new CampaignResource(); // CampaignResource | The campaign resource object (optional) 

            try
            {
                // Create a campaign
                CampaignResource result = apiInstance.CreateCampaign(campaignResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignResource** | [**CampaignResource**](CampaignResource.md)| The campaign resource object | [optional] 

### Return type

[**CampaignResource**](CampaignResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcampaigntemplate"></a>
# **CreateCampaignTemplate**
> TemplateResource CreateCampaignTemplate (TemplateResource campaignTemplateResource)

Create a campaign template

Campaign Templates define a type of campaign and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCampaignTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignTemplateResource = new TemplateResource(); // TemplateResource | The campaign template resource object (optional) 

            try
            {
                // Create a campaign template
                TemplateResource result = apiInstance.CreateCampaignTemplate(campaignTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CreateCampaignTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignTemplateResource** | [**TemplateResource**](TemplateResource.md)| The campaign template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaign"></a>
# **DeleteCampaign**
> void DeleteCampaign (long? id)

Delete a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // Delete a campaign
                apiInstance.DeleteCampaign(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaigntemplate"></a>
# **DeleteCampaignTemplate**
> void DeleteCampaignTemplate (string id, string cascade)

Delete a campaign template

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
    public class DeleteCampaignTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a campaign template
                apiInstance.DeleteCampaignTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaignTemplate: " + e.Message );
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

<a name="getcampaign"></a>
# **GetCampaign**
> CampaignResource GetCampaign (long? id)

Returns a single campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCampaignExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // Returns a single campaign
                CampaignResource result = apiInstance.GetCampaign(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

[**CampaignResource**](CampaignResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaignchallenges"></a>
# **GetCampaignChallenges**
> PageResourceChallengeResource GetCampaignChallenges (long? id)

List the challenges associated with a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCampaignChallengesExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id

            try
            {
                // List the challenges associated with a campaign
                PageResourceChallengeResource result = apiInstance.GetCampaignChallenges(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignChallenges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 

### Return type

[**PageResourceChallengeResource**](PageResourceChallengeResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigntemplate"></a>
# **GetCampaignTemplate**
> TemplateResource GetCampaignTemplate (string id)

Get a single campaign template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCampaignTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single campaign template
                TemplateResource result = apiInstance.GetCampaignTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignTemplate: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigntemplates"></a>
# **GetCampaignTemplates**
> PageResourceTemplateResource GetCampaignTemplates (int? size, int? page, string order)

List and search campaign templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCampaignTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search campaign templates
                PageResourceTemplateResource result = apiInstance.GetCampaignTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaignTemplates: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcampaigns"></a>
# **GetCampaigns**
> PageResourceCampaignResource GetCampaigns (bool? filterActive, int? size, int? page, string order)

List and search campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCampaignsExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsApi();
            var filterActive = true;  // bool? | Filter for campaigns that are active (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search campaigns
                PageResourceCampaignResource result = apiInstance.GetCampaigns(filterActive, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterActive** | **bool?**| Filter for campaigns that are active | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceCampaignResource**](PageResourceCampaignResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removechallengefromcampaign"></a>
# **RemoveChallengeFromCampaign**
> void RemoveChallengeFromCampaign (long? campaignId, long? id)

Remove a challenge from a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveChallengeFromCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var campaignId = 789;  // long? | The campaign id
            var id = 789;  // long? | The challenge id

            try
            {
                // Remove a challenge from a campaign
                apiInstance.RemoveChallengeFromCampaign(campaignId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.RemoveChallengeFromCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| The campaign id | 
 **id** | **long?**| The challenge id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaign"></a>
# **UpdateCampaign**
> CampaignResource UpdateCampaign (long? id, CampaignResource campaignResource)

Update a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCampaignExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = 789;  // long? | The campaign id
            var campaignResource = new CampaignResource(); // CampaignResource | The campaign resource object (optional) 

            try
            {
                // Update a campaign
                CampaignResource result = apiInstance.UpdateCampaign(id, campaignResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The campaign id | 
 **campaignResource** | [**CampaignResource**](CampaignResource.md)| The campaign resource object | [optional] 

### Return type

[**CampaignResource**](CampaignResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaigntemplate"></a>
# **UpdateCampaignTemplate**
> TemplateResource UpdateCampaignTemplate (string id, TemplateResource campaignTemplateResource)

Update an campaign template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCampaignTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var id = id_example;  // string | The id of the template
            var campaignTemplateResource = new TemplateResource(); // TemplateResource | The campaign template resource object (optional) 

            try
            {
                // Update an campaign template
                TemplateResource result = apiInstance.UpdateCampaignTemplate(id, campaignTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.UpdateCampaignTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **campaignTemplateResource** | [**TemplateResource**](TemplateResource.md)| The campaign template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

