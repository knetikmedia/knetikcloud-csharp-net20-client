# com.knetikcloud..Store_CouponsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponItem**](Store_CouponsApi.md#createcouponitem) | **POST** /store/coupons | Create a coupon item
[**CreateCouponTemplate**](Store_CouponsApi.md#createcoupontemplate) | **POST** /store/coupons/templates | Create a coupon template
[**DeleteCouponItem**](Store_CouponsApi.md#deletecouponitem) | **DELETE** /store/coupons/{id} | Delete a coupon item
[**DeleteCouponTemplate**](Store_CouponsApi.md#deletecoupontemplate) | **DELETE** /store/coupons/templates/{id} | Delete a coupon template
[**GetCouponItem**](Store_CouponsApi.md#getcouponitem) | **GET** /store/coupons/{id} | Get a single coupon item
[**GetCouponItemBySku**](Store_CouponsApi.md#getcouponitembysku) | **GET** /store/coupons/skus/{sku} | Get a coupon by sku
[**GetCouponTemplate**](Store_CouponsApi.md#getcoupontemplate) | **GET** /store/coupons/templates/{id} | Get a single coupon template
[**GetCouponTemplates**](Store_CouponsApi.md#getcoupontemplates) | **GET** /store/coupons/templates | List and search coupon templates
[**UpdateCouponItem**](Store_CouponsApi.md#updatecouponitem) | **PUT** /store/coupons/{id} | Update a coupon item
[**UpdateCouponTemplate**](Store_CouponsApi.md#updatecoupontemplate) | **PUT** /store/coupons/templates/{id} | Update a coupon template


<a name="createcouponitem"></a>
# **CreateCouponItem**
> CouponItem CreateCouponItem (bool? cascade, CouponItem couponItem)

Create a coupon item

SKUs have to be unique in the entire store. <br><br><b>Permissions Needed:</b> COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCouponItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var couponItem = new CouponItem(); // CouponItem | The coupon item object (optional) 

            try
            {
                // Create a coupon item
                CouponItem result = apiInstance.CreateCouponItem(cascade, couponItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.CreateCouponItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **couponItem** | [**CouponItem**](CouponItem.md)| The coupon item object | [optional] 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcoupontemplate"></a>
# **CreateCouponTemplate**
> ItemTemplateResource CreateCouponTemplate (ItemTemplateResource couponTemplateResource)

Create a coupon template

Coupon Templates define a type of coupon and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCouponTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var couponTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The new coupon template (optional) 

            try
            {
                // Create a coupon template
                ItemTemplateResource result = apiInstance.CreateCouponTemplate(couponTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.CreateCouponTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The new coupon template | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponitem"></a>
# **DeleteCouponItem**
> void DeleteCouponItem (int? id)

Delete a coupon item

<b>Permissions Needed:</b> COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCouponItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = 56;  // int? | The id of the coupon

            try
            {
                // Delete a coupon item
                apiInstance.DeleteCouponItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.DeleteCouponItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecoupontemplate"></a>
# **DeleteCouponTemplate**
> void DeleteCouponTemplate (string id, string cascade)

Delete a coupon template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCouponTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a coupon template
                apiInstance.DeleteCouponTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.DeleteCouponTemplate: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponitem"></a>
# **GetCouponItem**
> CouponItem GetCouponItem (int? id)

Get a single coupon item

<b>Permissions Needed:</b> COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCouponItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = 56;  // int? | The id of the coupon

            try
            {
                // Get a single coupon item
                CouponItem result = apiInstance.GetCouponItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.GetCouponItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponitembysku"></a>
# **GetCouponItemBySku**
> CouponItem GetCouponItemBySku (string sku)

Get a coupon by sku

<b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCouponItemBySkuExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var sku = sku_example;  // string | A sku of the coupon

            try
            {
                // Get a coupon by sku
                CouponItem result = apiInstance.GetCouponItemBySku(sku);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.GetCouponItemBySku: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sku** | **string**| A sku of the coupon | 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupontemplate"></a>
# **GetCouponTemplate**
> ItemTemplateResource GetCouponTemplate (string id)

Get a single coupon template

Coupon Templates define a type of coupon and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN or COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCouponTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single coupon template
                ItemTemplateResource result = apiInstance.GetCouponTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.GetCouponTemplate: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoupontemplates"></a>
# **GetCouponTemplates**
> PageResourceItemTemplateResource GetCouponTemplates (int? size, int? page, string order)

List and search coupon templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCouponTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search coupon templates
                PageResourceItemTemplateResource result = apiInstance.GetCouponTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.GetCouponTemplates: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecouponitem"></a>
# **UpdateCouponItem**
> CouponItem UpdateCouponItem (int? id, bool? cascade, CouponItem couponItem)

Update a coupon item

<b>Permissions Needed:</b> COUPONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCouponItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = 56;  // int? | The id of the coupon
            var cascade = true;  // bool? | Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. (optional)  (default to false)
            var couponItem = new CouponItem(); // CouponItem | The coupon item object (optional) 

            try
            {
                // Update a coupon item
                CouponItem result = apiInstance.UpdateCouponItem(id, cascade, couponItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.UpdateCouponItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the coupon | 
 **cascade** | **bool?**| Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values. | [optional] [default to false]
 **couponItem** | [**CouponItem**](CouponItem.md)| The coupon item object | [optional] 

### Return type

[**CouponItem**](CouponItem.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecoupontemplate"></a>
# **UpdateCouponTemplate**
> ItemTemplateResource UpdateCouponTemplate (string id, ItemTemplateResource couponTemplateResource)

Update a coupon template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCouponTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_CouponsApi();
            var id = id_example;  // string | The id of the template
            var couponTemplateResource = new ItemTemplateResource(); // ItemTemplateResource | The coupon template resource object (optional) 

            try
            {
                // Update a coupon template
                ItemTemplateResource result = apiInstance.UpdateCouponTemplate(id, couponTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_CouponsApi.UpdateCouponTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **couponTemplateResource** | [**ItemTemplateResource**](ItemTemplateResource.md)| The coupon template resource object | [optional] 

### Return type

[**ItemTemplateResource**](ItemTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

