# com.knetikcloud..StoreBundlesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBundleItem**](StoreBundlesApi.md#createbundleitem) | **POST** /store/bundles | Create a bundle item
[**CreateBundleTemplate**](StoreBundlesApi.md#createbundletemplate) | **POST** /store/bundles/templates | Create a bundle template
[**DeleteBundleItem**](StoreBundlesApi.md#deletebundleitem) | **DELETE** /store/bundles/{id} | Delete a bundle item
[**DeleteBundleTemplate**](StoreBundlesApi.md#deletebundletemplate) | **DELETE** /store/bundles/templates/{id} | Delete a bundle template
[**GetBundleItem**](StoreBundlesApi.md#getbundleitem) | **GET** /store/bundles/{id} | Get a single bundle item
[**GetBundleTemplate**](StoreBundlesApi.md#getbundletemplate) | **GET** /store/bundles/templates/{id} | Get a single bundle template
[**GetBundleTemplates**](StoreBundlesApi.md#getbundletemplates) | **GET** /store/bundles/templates | List and search bundle templates
[**UpdateBundleItem**](StoreBundlesApi.md#updatebundleitem) | **PUT** /store/bundles/{id} | Update a bundle item
[**UpdateBundleTemplate**](StoreBundlesApi.md#updatebundletemplate) | **PUT** /store/bundles/templates/{id} | Update a bundle template


<a name="createbundleitem"></a>
# **CreateBundleItem**
> BundleItem CreateBundleItem (bool? cascade, BundleItem bundleItem)

Create a bundle item

The SKU for the bundle itself must be unique and there can only be one SKU.  Extra notes for price_override:  The price of all the items (multiplied by the quantity) must equal the price of the bundle.  With individual prices set, items will be processed individually and can be refunded as such.  However, if all prices are set to null, the price of the bundle will be used and will be treated as one item.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateBundleItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var bundleItem = new BundleItem(); // BundleItem | The bundle item object (optional) 

            try
            {
                // Create a bundle item
                BundleItem result = apiInstance.CreateBundleItem(cascade, bundleItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.CreateBundleItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **bundleItem** | [**BundleItem**](BundleItem.md)| The bundle item object | [optional] 

### Return type

[**BundleItem**](BundleItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbundletemplate"></a>
# **CreateBundleTemplate**
> ItemTemplateResource CreateBundleTemplate (ItemTemplateResource bundleTemplateResource)

Create a bundle template

Bundle Templates define a type of bundle and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateBundleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var bundleTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The new bundle template (optional) 

            try
            {
                // Create a bundle template
                ItemTemplateResource result = apiInstance.CreateBundleTemplate(bundleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.CreateBundleTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bundleTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The new bundle template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebundleitem"></a>
# **DeleteBundleItem**
> void DeleteBundleItem (int? id)

Delete a bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteBundleItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle

            try
            {
                // Delete a bundle item
                apiInstance.DeleteBundleItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.DeleteBundleItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebundletemplate"></a>
# **DeleteBundleTemplate**
> void DeleteBundleTemplate (string id, string cascade)

Delete a bundle template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteBundleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a bundle template
                apiInstance.DeleteBundleTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.DeleteBundleTemplate: " + e.Message );
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

<a name="getbundleitem"></a>
# **GetBundleItem**
> BundleItem GetBundleItem (int? id)

Get a single bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBundleItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle

            try
            {
                // Get a single bundle item
                BundleItem result = apiInstance.GetBundleItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetBundleItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 

### Return type

[**BundleItem**](BundleItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbundletemplate"></a>
# **GetBundleTemplate**
> ItemTemplateResource GetBundleTemplate (string id)

Get a single bundle template

Bundle Templates define a type of bundle and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBundleTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single bundle template
                ItemTemplateResource result = apiInstance.GetBundleTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetBundleTemplate: " + e.Message );
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

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbundletemplates"></a>
# **GetBundleTemplates**
> PageResourceItemTemplateResource GetBundleTemplates (int? size, int? page, string order)

List and search bundle templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBundleTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new StoreBundlesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search bundle templates
                PageResourceItemTemplateResource result = apiInstance.GetBundleTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.GetBundleTemplates: " + e.Message );
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

[**PageResourceItemTemplateResource**](PageResourceItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebundleitem"></a>
# **UpdateBundleItem**
> BundleItem UpdateBundleItem (int? id, bool? cascade, BundleItem bundleItem)

Update a bundle item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBundleItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = 56;  // int? | The id of the bundle
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var bundleItem = new BundleItem(); // BundleItem | The bundle item object (optional) 

            try
            {
                // Update a bundle item
                BundleItem result = apiInstance.UpdateBundleItem(id, cascade, bundleItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.UpdateBundleItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the bundle | 
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **bundleItem** | [**BundleItem**](BundleItem.md)| The bundle item object | [optional] 

### Return type

[**BundleItem**](BundleItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebundletemplate"></a>
# **UpdateBundleTemplate**
> ItemTemplateResource UpdateBundleTemplate (string id, ItemTemplateResource bundleTemplateResource)

Update a bundle template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBundleTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreBundlesApi();
            var id = id_example;  // string | The id of the template
            var bundleTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The bundle template resource object (optional) 

            try
            {
                // Update a bundle template
                ItemTemplateResource result = apiInstance.UpdateBundleTemplate(id, bundleTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreBundlesApi.UpdateBundleTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **bundleTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The bundle template resource object | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

