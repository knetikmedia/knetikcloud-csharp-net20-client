# IO.Swagger..UsersInventoryApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItemToUserInventory**](UsersInventoryApi.md#additemtouserinventory) | **POST** /users/{id}/inventory | Adds an item to the user inventory
[**CheckUserEntitlementItem**](UsersInventoryApi.md#checkuserentitlementitem) | **GET** /users/{user_id}/entitlements/{item_id}/check | Check for access to an item without consuming
[**CreateEntitlementItem**](UsersInventoryApi.md#createentitlementitem) | **POST** /entitlements | Create an entitlement item
[**CreateEntitlementTemplate**](UsersInventoryApi.md#createentitlementtemplate) | **POST** /entitlements/templates | Create an entitlement template
[**DeleteEntitlementItem**](UsersInventoryApi.md#deleteentitlementitem) | **DELETE** /entitlements/{entitlement_id} | Delete an entitlement item
[**DeleteEntitlementTemplate**](UsersInventoryApi.md#deleteentitlementtemplate) | **DELETE** /entitlements/templates/{id} | Delete an entitlement template
[**GetEntitlementItem**](UsersInventoryApi.md#getentitlementitem) | **GET** /entitlements/{entitlement_id} | Get a single entitlement item
[**GetEntitlementItems**](UsersInventoryApi.md#getentitlementitems) | **GET** /entitlements | List and search entitlement items
[**GetEntitlementTemplate**](UsersInventoryApi.md#getentitlementtemplate) | **GET** /entitlements/templates/{id} | Get a single entitlement template
[**GetEntitlementTemplates**](UsersInventoryApi.md#getentitlementtemplates) | **GET** /entitlements/templates | List and search entitlement templates
[**GetUserInventories**](UsersInventoryApi.md#getuserinventories) | **GET** /users/{id}/inventory | List the user inventory entries for a given user
[**GetUserInventory**](UsersInventoryApi.md#getuserinventory) | **GET** /users/{user_id}/inventory/{id} | Get an inventory entry
[**GetUserInventoryLog**](UsersInventoryApi.md#getuserinventorylog) | **GET** /users/{user_id}/inventory/{id}/log | List the log entries for this inventory entry
[**GetUsersInventory**](UsersInventoryApi.md#getusersinventory) | **GET** /inventories | List the user inventory entries for all users
[**GrantUserEntitlement**](UsersInventoryApi.md#grantuserentitlement) | **POST** /users/{user_id}/entitlements | Grant an entitlement
[**UpdateEntitlementItem**](UsersInventoryApi.md#updateentitlementitem) | **PUT** /entitlements/{entitlement_id} | Update an entitlement item
[**UpdateEntitlementTemplate**](UsersInventoryApi.md#updateentitlementtemplate) | **PUT** /entitlements/templates/{id} | Update an entitlement template
[**UpdateUserInventoryBehaviorData**](UsersInventoryApi.md#updateuserinventorybehaviordata) | **PUT** /users/{user_id}/inventory/{id}/behavior-data | Set the behavior data for an inventory entry
[**UpdateUserInventoryExpires**](UsersInventoryApi.md#updateuserinventoryexpires) | **PUT** /users/{user_id}/inventory/{id}/expires | Set the expiration date
[**UpdateUserInventoryStatus**](UsersInventoryApi.md#updateuserinventorystatus) | **PUT** /users/{user_id}/inventory/{id}/status | Set the status for an inventory entry
[**UseUserEntitlementItem**](UsersInventoryApi.md#useuserentitlementitem) | **POST** /users/{user_id}/entitlements/{item_id}/use | Use an item


<a name="additemtouserinventory"></a>
# **AddItemToUserInventory**
> InvoiceResource AddItemToUserInventory (int? id, UserInventoryAddRequest userInventoryAddRequest)

Adds an item to the user inventory

The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddItemToUserInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = 56;  // int? | The id of the user
            var userInventoryAddRequest = new UserInventoryAddRequest(); // UserInventoryAddRequest | The user inventory add request object (optional) 

            try
            {
                // Adds an item to the user inventory
                InvoiceResource result = apiInstance.AddItemToUserInventory(id, userInventoryAddRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.AddItemToUserInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **userInventoryAddRequest** | [**UserInventoryAddRequest**](UserInventoryAddRequest.md)| The user inventory add request object | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkuserentitlementitem"></a>
# **CheckUserEntitlementItem**
> void CheckUserEntitlementItem (string userId, int? itemId, string sku)

Check for access to an item without consuming

Useful for pre-check and accounts for all various buisness rules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckUserEntitlementItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the user to check for or 'me' for logged in user
            var itemId = 56;  // int? | The id of the item
            var sku = sku_example;  // string | The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out (optional) 

            try
            {
                // Check for access to an item without consuming
                apiInstance.CheckUserEntitlementItem(userId, itemId, sku);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.CheckUserEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to check for or &#39;me&#39; for logged in user | 
 **itemId** | **int?**| The id of the item | 
 **sku** | **string**| The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createentitlementitem"></a>
# **CreateEntitlementItem**
> EntitlementItem CreateEntitlementItem (bool? cascade, EntitlementItem entitlementItem)

Create an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateEntitlementItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var entitlementItem = new EntitlementItem(); // EntitlementItem | The entitlement item object (optional) 

            try
            {
                // Create an entitlement item
                EntitlementItem result = apiInstance.CreateEntitlementItem(cascade, entitlementItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.CreateEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **entitlementItem** | [**EntitlementItem**](EntitlementItem.md)| The entitlement item object | [optional] 

### Return type

[**EntitlementItem**](EntitlementItem.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createentitlementtemplate"></a>
# **CreateEntitlementTemplate**
> ItemTemplateResource CreateEntitlementTemplate (ItemTemplateResource template)

Create an entitlement template

Entitlement templates define a type of entitlement and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateEntitlementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var template = new ItemTemplateResource(); // ItemTemplateResource | The entitlement template to be created (optional) 

            try
            {
                // Create an entitlement template
                ItemTemplateResource result = apiInstance.CreateEntitlementTemplate(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.CreateEntitlementTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**ItemTemplateResource**](ItemTemplateResource.md)| The entitlement template to be created | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentitlementitem"></a>
# **DeleteEntitlementItem**
> void DeleteEntitlementItem (int? entitlementId)

Delete an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEntitlementItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement

            try
            {
                // Delete an entitlement item
                apiInstance.DeleteEntitlementItem(entitlementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.DeleteEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentitlementtemplate"></a>
# **DeleteEntitlementTemplate**
> void DeleteEntitlementTemplate (string id, string cascade)

Delete an entitlement template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEntitlementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an entitlement template
                apiInstance.DeleteEntitlementTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.DeleteEntitlementTemplate: " + e.Message );
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

<a name="getentitlementitem"></a>
# **GetEntitlementItem**
> EntitlementItem GetEntitlementItem (int? entitlementId)

Get a single entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementItemExample
    {
        public void main()
        {
            
            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement

            try
            {
                // Get a single entitlement item
                EntitlementItem result = apiInstance.GetEntitlementItem(entitlementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 

### Return type

[**EntitlementItem**](EntitlementItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitlementitems"></a>
# **GetEntitlementItems**
> PageResourceEntitlementItem GetEntitlementItems (int? size, int? page, string order)

List and search entitlement items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementItemsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersInventoryApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search entitlement items
                PageResourceEntitlementItem result = apiInstance.GetEntitlementItems(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementItems: " + e.Message );
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

[**PageResourceEntitlementItem**](PageResourceEntitlementItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitlementtemplate"></a>
# **GetEntitlementTemplate**
> ItemTemplateResource GetEntitlementTemplate (string id)

Get a single entitlement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single entitlement template
                ItemTemplateResource result = apiInstance.GetEntitlementTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementTemplate: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitlementtemplates"></a>
# **GetEntitlementTemplates**
> PageResourceItemTemplateResource GetEntitlementTemplates (int? size, int? page, string order)

List and search entitlement templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitlementTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search entitlement templates
                PageResourceItemTemplateResource result = apiInstance.GetEntitlementTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetEntitlementTemplates: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinventories"></a>
# **GetUserInventories**
> PageResourceUserInventoryResource GetUserInventories (int? id, bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)

List the user inventory entries for a given user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInventoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = 56;  // int? | The id of the user
            var inactive = true;  // bool? | If true, accepts inactive user inventories (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var filterItemName = filterItemName_example;  // string | Filter by items whose name starts with a string (optional) 
            var filterItemId = 56;  // int? | Filter by item id (optional) 
            var filterUsername = filterUsername_example;  // string | Filter by entries owned by the user with the specified username (optional) 
            var filterGroup = filterGroup_example;  // string | Filter by entries owned by the users in a given group, by unique name (optional) 
            var filterDate = filterDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 

            try
            {
                // List the user inventory entries for a given user
                PageResourceUserInventoryResource result = apiInstance.GetUserInventories(id, inactive, size, page, filterItemName, filterItemId, filterUsername, filterGroup, filterDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUserInventories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the user | 
 **inactive** | **bool?**| If true, accepts inactive user inventories | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **filterItemName** | **string**| Filter by items whose name starts with a string | [optional] 
 **filterItemId** | **int?**| Filter by item id | [optional] 
 **filterUsername** | **string**| Filter by entries owned by the user with the specified username | [optional] 
 **filterGroup** | **string**| Filter by entries owned by the users in a given group, by unique name | [optional] 
 **filterDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 

### Return type

[**PageResourceUserInventoryResource**](PageResourceUserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinventory"></a>
# **GetUserInventory**
> UserInventoryResource GetUserInventory (int? userId, int? id)

Get an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the inventory owner or 'me' for the logged in user
            var id = 56;  // int? | The id of the user inventory

            try
            {
                // Get an inventory entry
                UserInventoryResource result = apiInstance.GetUserInventory(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUserInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the inventory owner or &#39;me&#39; for the logged in user | 
 **id** | **int?**| The id of the user inventory | 

### Return type

[**UserInventoryResource**](UserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinventorylog"></a>
# **GetUserInventoryLog**
> PageResourceUserItemLogResource GetUserInventoryLog (string userId, int? id, int? size, int? page)

List the log entries for this inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserInventoryLogExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the inventory owner or 'me' for the logged in user
            var id = 56;  // int? | The id of the user inventory
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List the log entries for this inventory entry
                PageResourceUserItemLogResource result = apiInstance.GetUserInventoryLog(userId, id, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUserInventoryLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the inventory owner or &#39;me&#39; for the logged in user | 
 **id** | **int?**| The id of the user inventory | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceUserItemLogResource**](PageResourceUserItemLogResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersinventory"></a>
# **GetUsersInventory**
> PageResourceUserInventoryResource GetUsersInventory (bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)

List the user inventory entries for all users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var inactive = true;  // bool? | If true, accepts inactive user inventories (optional)  (default to false)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var filterItemName = filterItemName_example;  // string | Filter by items whose name starts with a string (optional) 
            var filterItemId = 56;  // int? | Filter by item id (optional) 
            var filterUsername = filterUsername_example;  // string | Filter by entries owned by the user with the specified username (optional) 
            var filterGroup = filterGroup_example;  // string | Filter by entries owned by the users in a given group, by unique name (optional) 
            var filterDate = filterDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 

            try
            {
                // List the user inventory entries for all users
                PageResourceUserInventoryResource result = apiInstance.GetUsersInventory(inactive, size, page, filterItemName, filterItemId, filterUsername, filterGroup, filterDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GetUsersInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inactive** | **bool?**| If true, accepts inactive user inventories | [optional] [default to false]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **filterItemName** | **string**| Filter by items whose name starts with a string | [optional] 
 **filterItemId** | **int?**| Filter by item id | [optional] 
 **filterUsername** | **string**| Filter by entries owned by the user with the specified username | [optional] 
 **filterGroup** | **string**| Filter by entries owned by the users in a given group, by unique name | [optional] 
 **filterDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 

### Return type

[**PageResourceUserInventoryResource**](PageResourceUserInventoryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="grantuserentitlement"></a>
# **GrantUserEntitlement**
> void GrantUserEntitlement (int? userId, EntitlementGrantRequest grantRequest)

Grant an entitlement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GrantUserEntitlementExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the user to grant the entitlement to
            var grantRequest = new EntitlementGrantRequest(); // EntitlementGrantRequest | grantRequest

            try
            {
                // Grant an entitlement
                apiInstance.GrantUserEntitlement(userId, grantRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.GrantUserEntitlement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user to grant the entitlement to | 
 **grantRequest** | [**EntitlementGrantRequest**](EntitlementGrantRequest.md)| grantRequest | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateentitlementitem"></a>
# **UpdateEntitlementItem**
> void UpdateEntitlementItem (int? entitlementId, bool? cascade, EntitlementItem entitlementItem)

Update an entitlement item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEntitlementItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var entitlementId = 56;  // int? | The id of the entitlement
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var entitlementItem = new EntitlementItem(); // EntitlementItem | The entitlement item object (optional) 

            try
            {
                // Update an entitlement item
                apiInstance.UpdateEntitlementItem(entitlementId, cascade, entitlementItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entitlementId** | **int?**| The id of the entitlement | 
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **entitlementItem** | [**EntitlementItem**](EntitlementItem.md)| The entitlement item object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateentitlementtemplate"></a>
# **UpdateEntitlementTemplate**
> ItemTemplateResource UpdateEntitlementTemplate (string id, ItemTemplateResource template)

Update an entitlement template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEntitlementTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var id = id_example;  // string | The id of the template
            var template = new ItemTemplateResource(); // ItemTemplateResource | The updated template (optional) 

            try
            {
                // Update an entitlement template
                ItemTemplateResource result = apiInstance.UpdateEntitlementTemplate(id, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateEntitlementTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **template** | [**ItemTemplateResource**](ItemTemplateResource.md)| The updated template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventorybehaviordata"></a>
# **UpdateUserInventoryBehaviorData**
> void UpdateUserInventoryBehaviorData (int? userId, int? id, Object data)

Set the behavior data for an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryBehaviorDataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the user
            var id = 56;  // int? | The id of the user inventory
            var data = ;  // Object | The data map (optional) 

            try
            {
                // Set the behavior data for an inventory entry
                apiInstance.UpdateUserInventoryBehaviorData(userId, id, data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryBehaviorData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **id** | **int?**| The id of the user inventory | 
 **data** | **Object**| The data map | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventoryexpires"></a>
# **UpdateUserInventoryExpires**
> void UpdateUserInventoryExpires (int? userId, int? id, long? timestamp)

Set the expiration date

Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryExpiresExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | user_id
            var id = 56;  // int? | The id of the user inventory
            var timestamp = 789;  // long? | The new expiration date as a unix timestamp in seconds. May be null (no body). (optional) 

            try
            {
                // Set the expiration date
                apiInstance.UpdateUserInventoryExpires(userId, id, timestamp);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryExpires: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| user_id | 
 **id** | **int?**| The id of the user inventory | 
 **timestamp** | **long?**| The new expiration date as a unix timestamp in seconds. May be null (no body). | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserinventorystatus"></a>
# **UpdateUserInventoryStatus**
> void UpdateUserInventoryStatus (int? userId, int? id, string inventoryStatus)

Set the status for an inventory entry

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserInventoryStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = 56;  // int? | The id of the user
            var id = 56;  // int? | The id of the user inventory
            var inventoryStatus = inventoryStatus_example;  // string | The inventory status object (optional) 

            try
            {
                // Set the status for an inventory entry
                apiInstance.UpdateUserInventoryStatus(userId, id, inventoryStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UpdateUserInventoryStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **id** | **int?**| The id of the user inventory | 
 **inventoryStatus** | **string**| The inventory status object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="useuserentitlementitem"></a>
# **UseUserEntitlementItem**
> void UseUserEntitlementItem (string userId, int? itemId, string sku, string info)

Use an item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UseUserEntitlementItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersInventoryApi();
            var userId = userId_example;  // string | The id of the user to check for or 'me' for logged in user
            var itemId = 56;  // int? | The id of the item
            var sku = sku_example;  // string | The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out (optional) 
            var info = info_example;  // string | Any additional info to add to the log about this use (optional) 

            try
            {
                // Use an item
                apiInstance.UseUserEntitlementItem(userId, itemId, sku, info);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersInventoryApi.UseUserEntitlementItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user to check for or &#39;me&#39; for logged in user | 
 **itemId** | **int?**| The id of the item | 
 **sku** | **string**| The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out | [optional] 
 **info** | **string**| Any additional info to add to the log about this use | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

