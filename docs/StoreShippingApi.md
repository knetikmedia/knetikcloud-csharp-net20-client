# com.knetikcloud..StoreShippingApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShippingItem**](StoreShippingApi.md#createshippingitem) | **POST** /store/shipping | Create a shipping item
[**CreateShippingTemplate**](StoreShippingApi.md#createshippingtemplate) | **POST** /store/shipping/templates | Create a shipping template
[**DeleteShippingItem**](StoreShippingApi.md#deleteshippingitem) | **DELETE** /store/shipping/{id} | Delete a shipping item
[**DeleteShippingTemplate**](StoreShippingApi.md#deleteshippingtemplate) | **DELETE** /store/shipping/templates/{id} | Delete a shipping template
[**GetShippingItem**](StoreShippingApi.md#getshippingitem) | **GET** /store/shipping/{id} | Get a single shipping item
[**GetShippingTemplate**](StoreShippingApi.md#getshippingtemplate) | **GET** /store/shipping/templates/{id} | Get a single shipping template
[**GetShippingTemplates**](StoreShippingApi.md#getshippingtemplates) | **GET** /store/shipping/templates | List and search shipping templates
[**UpdateShippingItem**](StoreShippingApi.md#updateshippingitem) | **PUT** /store/shipping/{id} | Update a shipping item
[**UpdateShippingTemplate**](StoreShippingApi.md#updateshippingtemplate) | **PUT** /store/shipping/templates/{id} | Update a shipping template


<a name="createshippingitem"></a>
# **CreateShippingItem**
> ModelShippingItem CreateShippingItem (bool? cascade, ModelShippingItem shippingItem)

Create a shipping item

A shipping item represents a shipping option and cost. SKUs have to be unique in the entire store.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateShippingItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var shippingItem = new ModelShippingItem(); // ModelShippingItem | The shipping item object (optional) 

            try
            {
                // Create a shipping item
                ModelShippingItem result = apiInstance.CreateShippingItem(cascade, shippingItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.CreateShippingItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **shippingItem** | [**ModelShippingItem**](ModelShippingItem.md)| The shipping item object | [optional] 

### Return type

[**ModelShippingItem**](ModelShippingItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshippingtemplate"></a>
# **CreateShippingTemplate**
> ModelItemTemplateResource CreateShippingTemplate (ModelItemTemplateResource shippingTemplateResource)

Create a shipping template

Shipping Templates define a type of shipping and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateShippingTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var shippingTemplateResource = new ModelItemTemplateResource(); // ModelItemTemplateResource | The new shipping template (optional) 

            try
            {
                // Create a shipping template
                ModelItemTemplateResource result = apiInstance.CreateShippingTemplate(shippingTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.CreateShippingTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shippingTemplateResource** | [**ModelItemTemplateResource**](ModelItemTemplateResource.md)| The new shipping template | [optional] 

### Return type

[**ModelItemTemplateResource**](ModelItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshippingitem"></a>
# **DeleteShippingItem**
> void DeleteShippingItem (int? id)

Delete a shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteShippingItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item

            try
            {
                // Delete a shipping item
                apiInstance.DeleteShippingItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.DeleteShippingItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshippingtemplate"></a>
# **DeleteShippingTemplate**
> void DeleteShippingTemplate (string id, string cascade)

Delete a shipping template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteShippingTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a shipping template
                apiInstance.DeleteShippingTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.DeleteShippingTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingitem"></a>
# **GetShippingItem**
> ModelShippingItem GetShippingItem (int? id)

Get a single shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetShippingItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item

            try
            {
                // Get a single shipping item
                ModelShippingItem result = apiInstance.GetShippingItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 

### Return type

[**ModelShippingItem**](ModelShippingItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingtemplate"></a>
# **GetShippingTemplate**
> ModelItemTemplateResource GetShippingTemplate (string id)

Get a single shipping template

Shipping Templates define a type of shipping and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetShippingTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single shipping template
                ModelItemTemplateResource result = apiInstance.GetShippingTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingTemplate: " + e.Message );
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

[**ModelItemTemplateResource**](ModelItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingtemplates"></a>
# **GetShippingTemplates**
> ModelPageResourceItemTemplateResource GetShippingTemplates (int? size, int? page, string order)

List and search shipping templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetShippingTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search shipping templates
                ModelPageResourceItemTemplateResource result = apiInstance.GetShippingTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.GetShippingTemplates: " + e.Message );
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

[**ModelPageResourceItemTemplateResource**](ModelPageResourceItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshippingitem"></a>
# **UpdateShippingItem**
> ModelShippingItem UpdateShippingItem (int? id, bool? cascade, ModelShippingItem shippingItem)

Update a shipping item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateShippingItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = 56;  // int? | The id of the shipping item
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var shippingItem = new ModelShippingItem(); // ModelShippingItem | The shipping item object (optional) 

            try
            {
                // Update a shipping item
                ModelShippingItem result = apiInstance.UpdateShippingItem(id, cascade, shippingItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.UpdateShippingItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the shipping item | 
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **shippingItem** | [**ModelShippingItem**](ModelShippingItem.md)| The shipping item object | [optional] 

### Return type

[**ModelShippingItem**](ModelShippingItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshippingtemplate"></a>
# **UpdateShippingTemplate**
> ModelItemTemplateResource UpdateShippingTemplate (string id, ModelItemTemplateResource shippingTemplateResource)

Update a shipping template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateShippingTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreShippingApi();
            var id = id_example;  // string | The id of the template
            var shippingTemplateResource = new ModelItemTemplateResource(); // ModelItemTemplateResource | The shipping template resource object (optional) 

            try
            {
                // Update a shipping template
                ModelItemTemplateResource result = apiInstance.UpdateShippingTemplate(id, shippingTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreShippingApi.UpdateShippingTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **shippingTemplateResource** | [**ModelItemTemplateResource**](ModelItemTemplateResource.md)| The shipping template resource object | [optional] 

### Return type

[**ModelItemTemplateResource**](ModelItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
