# com.knetikcloud.client..MediaArtistsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddArtist**](MediaArtistsApi.md#addartist) | **POST** /media/artists | Adds a new artist in the system
[**CreateArtistTemplate**](MediaArtistsApi.md#createartisttemplate) | **POST** /media/artists/templates | Create an artist template
[**DeleteArtist**](MediaArtistsApi.md#deleteartist) | **DELETE** /media/artists/{id} | Removes an artist from the system IF no resources are attached to it
[**DeleteArtistTemplate**](MediaArtistsApi.md#deleteartisttemplate) | **DELETE** /media/artists/templates/{id} | Delete an artist template
[**GetArtist**](MediaArtistsApi.md#getartist) | **GET** /media/artists/{id} | Loads a specific artist details
[**GetArtistTemplate**](MediaArtistsApi.md#getartisttemplate) | **GET** /media/artists/templates/{id} | Get a single artist template
[**GetArtistTemplates**](MediaArtistsApi.md#getartisttemplates) | **GET** /media/artists/templates | List and search artist templates
[**GetArtists**](MediaArtistsApi.md#getartists) | **GET** /media/artists | Search for artists
[**UpdateArtist**](MediaArtistsApi.md#updateartist) | **PUT** /media/artists/{id} | Modifies an artist details
[**UpdateArtistTemplate**](MediaArtistsApi.md#updateartisttemplate) | **PUT** /media/artists/templates/{id} | Update an artist template


<a name="addartist"></a>
# **AddArtist**
> ArtistResource AddArtist (ArtistResource artistResource)

Adds a new artist in the system

Adds a new artist in the system. Use specific media contributions endpoint to add contributions

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class AddArtistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var artistResource = new ArtistResource(); // ArtistResource | The new artist (optional) 

            try
            {
                // Adds a new artist in the system
                ArtistResource result = apiInstance.AddArtist(artistResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.AddArtist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **artistResource** | [**ArtistResource**](ArtistResource.md)| The new artist | [optional] 

### Return type

[**ArtistResource**](ArtistResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createartisttemplate"></a>
# **CreateArtistTemplate**
> TemplateResource CreateArtistTemplate (TemplateResource artistTemplateResource)

Create an artist template

Artist Templates define a type of artist and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class CreateArtistTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var artistTemplateResource = new TemplateResource(); // TemplateResource | The artist template resource object (optional) 

            try
            {
                // Create an artist template
                TemplateResource result = apiInstance.CreateArtistTemplate(artistTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.CreateArtistTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **artistTemplateResource** | [**TemplateResource**](TemplateResource.md)| The artist template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteartist"></a>
# **DeleteArtist**
> void DeleteArtist (long? id)

Removes an artist from the system IF no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class DeleteArtistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id

            try
            {
                // Removes an artist from the system IF no resources are attached to it
                apiInstance.DeleteArtist(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.DeleteArtist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteartisttemplate"></a>
# **DeleteArtistTemplate**
> void DeleteArtistTemplate (string id, string cascade)

Delete an artist template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class DeleteArtistTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an artist template
                apiInstance.DeleteArtistTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.DeleteArtistTemplate: " + e.Message );
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

<a name="getartist"></a>
# **GetArtist**
> ArtistResource GetArtist (long? id, int? showContributions)

Loads a specific artist details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetArtistExample
    {
        public void main()
        {
            
            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id
            var showContributions = 56;  // int? | The number of contributions to show fetch (optional) 

            try
            {
                // Loads a specific artist details
                ArtistResource result = apiInstance.GetArtist(id, showContributions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 
 **showContributions** | **int?**| The number of contributions to show fetch | [optional] 

### Return type

[**ArtistResource**](ArtistResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getartisttemplate"></a>
# **GetArtistTemplate**
> TemplateResource GetArtistTemplate (string id)

Get a single artist template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetArtistTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single artist template
                TemplateResource result = apiInstance.GetArtistTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtistTemplate: " + e.Message );
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

<a name="getartisttemplates"></a>
# **GetArtistTemplates**
> PageResourceTemplateResource GetArtistTemplates (int? size, int? page, string order)

List and search artist templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetArtistTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search artist templates
                PageResourceTemplateResource result = apiInstance.GetArtistTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtistTemplates: " + e.Message );
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

<a name="getartists"></a>
# **GetArtists**
> PageResourceArtistResource GetArtists (string filterArtistsByName, int? size, int? page, string order)

Search for artists

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetArtistsExample
    {
        public void main()
        {
            
            var apiInstance = new MediaArtistsApi();
            var filterArtistsByName = filterArtistsByName_example;  // string | Filter for artists which name *STARTS* with the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Search for artists
                PageResourceArtistResource result = apiInstance.GetArtists(filterArtistsByName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.GetArtists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterArtistsByName** | **string**| Filter for artists which name *STARTS* with the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceArtistResource**](PageResourceArtistResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartist"></a>
# **UpdateArtist**
> void UpdateArtist (long? id, ArtistResource artistResource)

Modifies an artist details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class UpdateArtistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = 789;  // long? | The artist id
            var artistResource = new ArtistResource(); // ArtistResource | The new artist (optional) 

            try
            {
                // Modifies an artist details
                apiInstance.UpdateArtist(id, artistResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.UpdateArtist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The artist id | 
 **artistResource** | [**ArtistResource**](ArtistResource.md)| The new artist | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateartisttemplate"></a>
# **UpdateArtistTemplate**
> TemplateResource UpdateArtistTemplate (string id, TemplateResource artistTemplateResource)

Update an artist template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class UpdateArtistTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaArtistsApi();
            var id = id_example;  // string | The id of the template
            var artistTemplateResource = new TemplateResource(); // TemplateResource | The artist template resource object (optional) 

            try
            {
                // Update an artist template
                TemplateResource result = apiInstance.UpdateArtistTemplate(id, artistTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaArtistsApi.UpdateArtistTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **artistTemplateResource** | [**TemplateResource**](TemplateResource.md)| The artist template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

