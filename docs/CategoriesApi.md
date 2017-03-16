# com.knetikcloud..CategoriesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategory**](CategoriesApi.md#createcategory) | **POST** /categories | Create a new category
[**CreateCategoryTemplate**](CategoriesApi.md#createcategorytemplate) | **POST** /categories/templates | Create a category template
[**DeleteCategory**](CategoriesApi.md#deletecategory) | **DELETE** /categories/{id} | Delete an existing category
[**DeleteCategoryTemplate**](CategoriesApi.md#deletecategorytemplate) | **DELETE** /categories/templates/{id} | Delete a category template
[**GetCategories**](CategoriesApi.md#getcategories) | **GET** /categories | List and search categories with optional filters
[**GetCategory**](CategoriesApi.md#getcategory) | **GET** /categories/{id} | Get a single category
[**GetCategoryTemplate**](CategoriesApi.md#getcategorytemplate) | **GET** /categories/templates/{id} | Get a single category template
[**GetCategoryTemplates**](CategoriesApi.md#getcategorytemplates) | **GET** /categories/templates | List and search category templates
[**GetTags**](CategoriesApi.md#gettags) | **GET** /tags | List all trivia tags in the system
[**UpdateCategory**](CategoriesApi.md#updatecategory) | **PUT** /categories/{id} | Update an existing category
[**UpdateCategoryTemplate**](CategoriesApi.md#updatecategorytemplate) | **PUT** /categories/templates/{id} | Update a category template


<a name="createcategory"></a>
# **CreateCategory**
> ModelCategoryResource CreateCategory (ModelCategoryResource category)

Create a new category

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var category = new ModelCategoryResource(); // ModelCategoryResource | The category to create (optional) 

            try
            {
                // Create a new category
                ModelCategoryResource result = apiInstance.CreateCategory(category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**ModelCategoryResource**](ModelCategoryResource.md)| The category to create | [optional] 

### Return type

[**ModelCategoryResource**](ModelCategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcategorytemplate"></a>
# **CreateCategoryTemplate**
> ModelTemplateResource CreateCategoryTemplate (ModelTemplateResource template)

Create a category template

Templates define a type of category and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCategoryTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var template = new ModelTemplateResource(); // ModelTemplateResource | The template to create (optional) 

            try
            {
                // Create a category template
                ModelTemplateResource result = apiInstance.CreateCategoryTemplate(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategoryTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**ModelTemplateResource**](ModelTemplateResource.md)| The template to create | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecategory"></a>
# **DeleteCategory**
> void DeleteCategory (string id)

Delete an existing category

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category to be deleted

            try
            {
                // Delete an existing category
                apiInstance.DeleteCategory(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category to be deleted | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecategorytemplate"></a>
# **DeleteCategoryTemplate**
> void DeleteCategoryTemplate (string id, string cascade)

Delete a category template

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
    public class DeleteCategoryTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a category template
                apiInstance.DeleteCategoryTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategoryTemplate: " + e.Message );
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

<a name="getcategories"></a>
# **GetCategories**
> ModelPageResourceCategoryResource GetCategories (string filterSearch, bool? filterActive, int? size, int? page, string order)

List and search categories with optional filters

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCategoriesExample
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var filterSearch = filterSearch_example;  // string | Filter for categories whose names begin with provided string (optional) 
            var filterActive = true;  // bool? | Filter for categories that are specifically active or inactive (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search categories with optional filters
                ModelPageResourceCategoryResource result = apiInstance.GetCategories(filterSearch, filterActive, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for categories whose names begin with provided string | [optional] 
 **filterActive** | **bool?**| Filter for categories that are specifically active or inactive | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceCategoryResource**](ModelPageResourceCategoryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategory"></a>
# **GetCategory**
> ModelCategoryResource GetCategory (string id)

Get a single category

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCategoryExample
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category to retrieve

            try
            {
                // Get a single category
                ModelCategoryResource result = apiInstance.GetCategory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category to retrieve | 

### Return type

[**ModelCategoryResource**](ModelCategoryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorytemplate"></a>
# **GetCategoryTemplate**
> ModelTemplateResource GetCategoryTemplate (string id)

Get a single category template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCategoryTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single category template
                ModelTemplateResource result = apiInstance.GetCategoryTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTemplate: " + e.Message );
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

<a name="getcategorytemplates"></a>
# **GetCategoryTemplates**
> ModelPageResourceTemplateResource GetCategoryTemplates (int? size, int? page, string order)

List and search category templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCategoryTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search category templates
                ModelPageResourceTemplateResource result = apiInstance.GetCategoryTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetCategoryTemplates: " + e.Message );
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

<a name="gettags"></a>
# **GetTags**
> ModelPageResourcestring GetTags (int? size, int? page)

List all trivia tags in the system

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTagsExample
    {
        public void main()
        {
            
            var apiInstance = new CategoriesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List all trivia tags in the system
                ModelPageResourcestring result = apiInstance.GetTags(size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetTags: " + e.Message );
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

### Return type

[**ModelPageResourcestring**](ModelPageResourcestring.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategory"></a>
# **UpdateCategory**
> ModelCategoryResource UpdateCategory (string id, ModelCategoryResource category)

Update an existing category

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the category
            var category = new ModelCategoryResource(); // ModelCategoryResource | The category to update (optional) 

            try
            {
                // Update an existing category
                ModelCategoryResource result = apiInstance.UpdateCategory(id, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the category | 
 **category** | [**ModelCategoryResource**](ModelCategoryResource.md)| The category to update | [optional] 

### Return type

[**ModelCategoryResource**](ModelCategoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategorytemplate"></a>
# **UpdateCategoryTemplate**
> ModelTemplateResource UpdateCategoryTemplate (string id, ModelTemplateResource template)

Update a category template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCategoryTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | The id of the template
            var template = new ModelTemplateResource(); // ModelTemplateResource | The updated template information (optional) 

            try
            {
                // Update a category template
                ModelTemplateResource result = apiInstance.UpdateCategoryTemplate(id, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategoryTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**ModelTemplateResource**](ModelTemplateResource.md)| The updated template information | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

