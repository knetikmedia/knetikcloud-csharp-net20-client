# com.knetikcloud..ContentArticlesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateArticle**](ContentArticlesApi.md#createarticle) | **POST** /content/articles | Create a new article
[**CreateArticleTemplate**](ContentArticlesApi.md#createarticletemplate) | **POST** /content/articles/templates | Create an article template
[**DeleteArticle**](ContentArticlesApi.md#deletearticle) | **DELETE** /content/articles/{id} | Delete an existing article
[**DeleteArticleTemplate**](ContentArticlesApi.md#deletearticletemplate) | **DELETE** /content/articles/templates/{id} | Delete an article template
[**GetArticle**](ContentArticlesApi.md#getarticle) | **GET** /content/articles/{id} | Get a single article
[**GetArticleTemplate**](ContentArticlesApi.md#getarticletemplate) | **GET** /content/articles/templates/{id} | Get a single article template
[**GetArticleTemplates**](ContentArticlesApi.md#getarticletemplates) | **GET** /content/articles/templates | List and search article templates
[**GetArticles**](ContentArticlesApi.md#getarticles) | **GET** /content/articles | List and search articles
[**UpdateArticle**](ContentArticlesApi.md#updatearticle) | **PUT** /content/articles/{id} | Update an existing article
[**UpdateArticleTemplate**](ContentArticlesApi.md#updatearticletemplate) | **PUT** /content/articles/templates/{id} | Update an article template


<a name="createarticle"></a>
# **CreateArticle**
> ModelArticleResource CreateArticle (ModelArticleResource articleResource)

Create a new article

Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateArticleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var articleResource = new ModelArticleResource(); // ModelArticleResource | The new article (optional) 

            try
            {
                // Create a new article
                ModelArticleResource result = apiInstance.CreateArticle(articleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.CreateArticle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **articleResource** | [**ModelArticleResource**](ModelArticleResource.md)| The new article | [optional] 

### Return type

[**ModelArticleResource**](ModelArticleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createarticletemplate"></a>
# **CreateArticleTemplate**
> ModelTemplateResource CreateArticleTemplate (ModelTemplateResource articleTemplateResource)

Create an article template

Article Templates define a type of article and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateArticleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var articleTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The article template resource object (optional) 

            try
            {
                // Create an article template
                ModelTemplateResource result = apiInstance.CreateArticleTemplate(articleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.CreateArticleTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **articleTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The article template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletearticle"></a>
# **DeleteArticle**
> void DeleteArticle (string id)

Delete an existing article

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteArticleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id

            try
            {
                // Delete an existing article
                apiInstance.DeleteArticle(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.DeleteArticle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletearticletemplate"></a>
# **DeleteArticleTemplate**
> void DeleteArticleTemplate (string id, string cascade)

Delete an article template

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
    public class DeleteArticleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an article template
                apiInstance.DeleteArticleTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.DeleteArticleTemplate: " + e.Message );
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

<a name="getarticle"></a>
# **GetArticle**
> ModelArticleResource GetArticle (string id)

Get a single article

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetArticleExample
    {
        public void main()
        {
            
            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id

            try
            {
                // Get a single article
                ModelArticleResource result = apiInstance.GetArticle(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 

### Return type

[**ModelArticleResource**](ModelArticleResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarticletemplate"></a>
# **GetArticleTemplate**
> ModelTemplateResource GetArticleTemplate (string id)

Get a single article template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetArticleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single article template
                ModelTemplateResource result = apiInstance.GetArticleTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticleTemplate: " + e.Message );
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

<a name="getarticletemplates"></a>
# **GetArticleTemplates**
> ModelPageResourceTemplateResource GetArticleTemplates (int? size, int? page, string order)

List and search article templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetArticleTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search article templates
                ModelPageResourceTemplateResource result = apiInstance.GetArticleTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticleTemplates: " + e.Message );
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

<a name="getarticles"></a>
# **GetArticles**
> ModelPageResourceArticleResource GetArticles (string filterCategory, string filterTagset, string filterTitle, int? size, int? page, string order)

List and search articles

Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use 'Get a single article' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetArticlesExample
    {
        public void main()
        {
            
            var apiInstance = new ContentArticlesApi();
            var filterCategory = filterCategory_example;  // string | Filter for articles from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for articles with specified tags (separated by comma) (optional) 
            var filterTitle = filterTitle_example;  // string | Filter for articles whose title contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search articles
                ModelPageResourceArticleResource result = apiInstance.GetArticles(filterCategory, filterTagset, filterTitle, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.GetArticles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for articles from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for articles with specified tags (separated by comma) | [optional] 
 **filterTitle** | **string**| Filter for articles whose title contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceArticleResource**](ModelPageResourceArticleResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatearticle"></a>
# **UpdateArticle**
> ModelArticleResource UpdateArticle (string id, ModelArticleResource articleResource)

Update an existing article

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateArticleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The article id
            var articleResource = new ModelArticleResource(); // ModelArticleResource | The article object (optional) 

            try
            {
                // Update an existing article
                ModelArticleResource result = apiInstance.UpdateArticle(id, articleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.UpdateArticle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The article id | 
 **articleResource** | [**ModelArticleResource**](ModelArticleResource.md)| The article object | [optional] 

### Return type

[**ModelArticleResource**](ModelArticleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatearticletemplate"></a>
# **UpdateArticleTemplate**
> ModelTemplateResource UpdateArticleTemplate (string id, ModelTemplateResource articleTemplateResource)

Update an article template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateArticleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentArticlesApi();
            var id = id_example;  // string | The id of the template
            var articleTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The article template resource object (optional) 

            try
            {
                // Update an article template
                ModelTemplateResource result = apiInstance.UpdateArticleTemplate(id, articleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentArticlesApi.UpdateArticleTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **articleTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The article template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

