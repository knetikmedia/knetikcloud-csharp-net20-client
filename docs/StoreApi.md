# com.knetikcloud..StoreApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateItemTemplate**](StoreApi.md#createitemtemplate) | **POST** /store/items/templates | Create an item template
[**CreateStoreItem**](StoreApi.md#createstoreitem) | **POST** /store/items | Create a store item
[**DeleteItemTemplate**](StoreApi.md#deleteitemtemplate) | **DELETE** /store/items/templates/{id} | Delete an item template
[**DeleteStoreItem**](StoreApi.md#deletestoreitem) | **DELETE** /store/items/{id} | Delete a store item
[**GetBehaviors**](StoreApi.md#getbehaviors) | **GET** /store/items/behaviors | List available item behaviors
[**GetItemTemplate**](StoreApi.md#getitemtemplate) | **GET** /store/items/templates/{id} | Get a single item template
[**GetItemTemplates**](StoreApi.md#getitemtemplates) | **GET** /store/items/templates | List and search item templates
[**GetStore**](StoreApi.md#getstore) | **GET** /store | Get a listing of store items
[**GetStoreItem**](StoreApi.md#getstoreitem) | **GET** /store/items/{id} | Get a single store item
[**GetStoreItems**](StoreApi.md#getstoreitems) | **GET** /store/items | List and search store items
[**QuickBuy**](StoreApi.md#quickbuy) | **POST** /store/quick-buy | One-step purchase and pay for a single SKU item from a user&#39;s wallet
[**UpdateItemTemplate**](StoreApi.md#updateitemtemplate) | **PUT** /store/items/templates/{id} | Update an item template
[**UpdateStoreItem**](StoreApi.md#updatestoreitem) | **PUT** /store/items/{id} | Update a store item


<a name="createitemtemplate"></a>
# **CreateItemTemplate**
> StoreItemTemplateResource CreateItemTemplate (StoreItemTemplateResource itemTemplateResource)

Create an item template

Item Templates define a type of item and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateItemTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var itemTemplateResource = new StoreItemTemplateResource(); // StoreItemTemplateResource | The new item template (optional) 

            try
            {
                // Create an item template
                StoreItemTemplateResource result = apiInstance.CreateItemTemplate(itemTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.CreateItemTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemTemplateResource** | [**StoreItemTemplateResource**](StoreItemTemplateResource.md)| The new item template | [optional] 

### Return type

[**StoreItemTemplateResource**](StoreItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstoreitem"></a>
# **CreateStoreItem**
> StoreItem CreateStoreItem (bool? cascade, StoreItem storeItem)

Create a store item

SKUs have to be unique in the entire store. If a duplicate SKU is found, a 400 error is generated and the response will have a \"parameters\" field that is a list of duplicates. A duplicate is an object like {item_id, offending_sku_list}. Ex:<br /> {..., parameters: [[{item: 1, skus: [\"SKU-1\"]}]]}<br /> If an item is brand new and has duplicate SKUs within itself, the item ID will be 0.  Item subclasses are not allowed here, you will have to use their respective endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateStoreItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var storeItem = new StoreItem(); // StoreItem | The store item object (optional) 

            try
            {
                // Create a store item
                StoreItem result = apiInstance.CreateStoreItem(cascade, storeItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.CreateStoreItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **storeItem** | [**StoreItem**](StoreItem.md)| The store item object | [optional] 

### Return type

[**StoreItem**](StoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitemtemplate"></a>
# **DeleteItemTemplate**
> void DeleteItemTemplate (string id, string cascade)

Delete an item template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteItemTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete an item template
                apiInstance.DeleteItemTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteItemTemplate: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestoreitem"></a>
# **DeleteStoreItem**
> void DeleteStoreItem (int? id)

Delete a store item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteStoreItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item

            try
            {
                // Delete a store item
                apiInstance.DeleteStoreItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteStoreItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbehaviors"></a>
# **GetBehaviors**
> List<BehaviorDefinitionResource> GetBehaviors ()

List available item behaviors

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBehaviorsExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();

            try
            {
                // List available item behaviors
                List&lt;BehaviorDefinitionResource&gt; result = apiInstance.GetBehaviors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetBehaviors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BehaviorDefinitionResource>**](BehaviorDefinitionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemtemplate"></a>
# **GetItemTemplate**
> StoreItemTemplateResource GetItemTemplate (string id)

Get a single item template

Item Templates define a type of item and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetItemTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single item template
                StoreItemTemplateResource result = apiInstance.GetItemTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetItemTemplate: " + e.Message );
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

[**StoreItemTemplateResource**](StoreItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getitemtemplates"></a>
# **GetItemTemplates**
> PageResourceStoreItemTemplateResource GetItemTemplates (int? size, int? page, string order)

List and search item templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetItemTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search item templates
                PageResourceStoreItemTemplateResource result = apiInstance.GetItemTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetItemTemplates: " + e.Message );
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

[**PageResourceStoreItemTemplateResource**](PageResourceStoreItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstore"></a>
# **GetStore**
> PageResourceStoreItem GetStore (int? limit, int? page, bool? useCatalog, bool? ignoreLocation, bool? inStockOnly)

Get a listing of store items

The exact structure of each items may differ to include fields specific to the type. The same is true for behaviors.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStoreExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var limit = 56;  // int? | The amount of items returned (optional) 
            var page = 56;  // int? | The page of the request (optional) 
            var useCatalog = true;  // bool? | Whether to remove items that are not intended for display or not in date (optional) 
            var ignoreLocation = true;  // bool? | Whether to ignore country restrictions based on the caller's location (optional) 
            var inStockOnly = true;  // bool? | Whether only in-stock items should be returned.  Default value is false (optional)  (default to false)

            try
            {
                // Get a listing of store items
                PageResourceStoreItem result = apiInstance.GetStore(limit, page, useCatalog, ignoreLocation, inStockOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The amount of items returned | [optional] 
 **page** | **int?**| The page of the request | [optional] 
 **useCatalog** | **bool?**| Whether to remove items that are not intended for display or not in date | [optional] 
 **ignoreLocation** | **bool?**| Whether to ignore country restrictions based on the caller&#39;s location | [optional] 
 **inStockOnly** | **bool?**| Whether only in-stock items should be returned.  Default value is false | [optional] [default to false]

### Return type

[**PageResourceStoreItem**](PageResourceStoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreitem"></a>
# **GetStoreItem**
> StoreItem GetStoreItem (int? id)

Get a single store item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStoreItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item

            try
            {
                // Get a single store item
                StoreItem result = apiInstance.GetStoreItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetStoreItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 

### Return type

[**StoreItem**](StoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreitems"></a>
# **GetStoreItems**
> PageResourceStoreItem GetStoreItems (string filterNameSearch, string filterUniqueKey, bool? filterPublished, bool? filterDisplayable, string filterStart, string filterEnd, string filterStartDate, string filterStopDate, string filterSku, string filterPrice, string filterTag, string filterItemsByType, string filterBundledSkus, int? filterVendor, int? size, int? page, string order)

List and search store items

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStoreItemsExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var filterNameSearch = filterNameSearch_example;  // string | Filter for items whose name starts with a given string. (optional) 
            var filterUniqueKey = filterUniqueKey_example;  // string | Filter for items whose unique_key is a given string. (optional) 
            var filterPublished = true;  // bool? | Filter for skus that have been published. (optional) 
            var filterDisplayable = true;  // bool? | Filter for items that are displayable. (optional) 
            var filterStart = filterStart_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterEnd = filterEnd_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterStartDate = filterStartDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterStopDate = filterStopDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterSku = filterSku_example;  // string | Filter for skus whose name starts with a given string. (optional) 
            var filterPrice = filterPrice_example;  // string | A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ). (optional) 
            var filterTag = filterTag_example;  // string | A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags. (optional) 
            var filterItemsByType = filterItemsByType_example;  // string | Filter for item type based on its type hint. (optional) 
            var filterBundledSkus = filterBundledSkus_example;  // string | Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is 'bundle_item' (optional) 
            var filterVendor = 56;  // int? | Filter for items from a given vendor, by id. (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search store items
                PageResourceStoreItem result = apiInstance.GetStoreItems(filterNameSearch, filterUniqueKey, filterPublished, filterDisplayable, filterStart, filterEnd, filterStartDate, filterStopDate, filterSku, filterPrice, filterTag, filterItemsByType, filterBundledSkus, filterVendor, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetStoreItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterNameSearch** | **string**| Filter for items whose name starts with a given string. | [optional] 
 **filterUniqueKey** | **string**| Filter for items whose unique_key is a given string. | [optional] 
 **filterPublished** | **bool?**| Filter for skus that have been published. | [optional] 
 **filterDisplayable** | **bool?**| Filter for items that are displayable. | [optional] 
 **filterStart** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterEnd** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterStartDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterStopDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterSku** | **string**| Filter for skus whose name starts with a given string. | [optional] 
 **filterPrice** | **string**| A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ). | [optional] 
 **filterTag** | **string**| A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags. | [optional] 
 **filterItemsByType** | **string**| Filter for item type based on its type hint. | [optional] 
 **filterBundledSkus** | **string**| Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is &#39;bundle_item&#39; | [optional] 
 **filterVendor** | **int?**| Filter for items from a given vendor, by id. | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceStoreItem**](PageResourceStoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickbuy"></a>
# **QuickBuy**
> InvoiceResource QuickBuy (QuickBuyRequest quickBuyRequest)

One-step purchase and pay for a single SKU item from a user's wallet

Used to create and automatically pay an invoice for a single unit of a single SKU from a user's wallet. SKU must be priced in virtual currency and must not be an item that requires shipping. PAYMENTS_ADMIN permission is required if user ID is specified and is not the ID of the currently logged in user. If invoice price does not match expected price, purchase is aborted

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class QuickBuyExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var quickBuyRequest = new QuickBuyRequest(); // QuickBuyRequest | Quick buy details (optional) 

            try
            {
                // One-step purchase and pay for a single SKU item from a user's wallet
                InvoiceResource result = apiInstance.QuickBuy(quickBuyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.QuickBuy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickBuyRequest** | [**QuickBuyRequest**](QuickBuyRequest.md)| Quick buy details | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemtemplate"></a>
# **UpdateItemTemplate**
> StoreItemTemplateResource UpdateItemTemplate (string id, StoreItemTemplateResource itemTemplateResource)

Update an item template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateItemTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = id_example;  // string | The id of the template
            var itemTemplateResource = new StoreItemTemplateResource(); // StoreItemTemplateResource | The item template resource object (optional) 

            try
            {
                // Update an item template
                StoreItemTemplateResource result = apiInstance.UpdateItemTemplate(id, itemTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.UpdateItemTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **itemTemplateResource** | [**StoreItemTemplateResource**](StoreItemTemplateResource.md)| The item template resource object | [optional] 

### Return type

[**StoreItemTemplateResource**](StoreItemTemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestoreitem"></a>
# **UpdateStoreItem**
> StoreItem UpdateStoreItem (int? id, bool? cascade, StoreItem storeItem)

Update a store item

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateStoreItemExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var id = 56;  // int? | The id of the item
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var storeItem = new StoreItem(); // StoreItem | The store item object (optional) 

            try
            {
                // Update a store item
                StoreItem result = apiInstance.UpdateStoreItem(id, cascade, storeItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.UpdateStoreItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the item | 
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **storeItem** | [**StoreItem**](StoreItem.md)| The store item object | [optional] 

### Return type

[**StoreItem**](StoreItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

