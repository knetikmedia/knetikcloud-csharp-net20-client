# com.knetikcloud..StoreVendorsApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVendor**](StoreVendorsApi.md#createvendor) | **POST** /vendors | Create a vendor
[**CreateVendorTemplate**](StoreVendorsApi.md#createvendortemplate) | **POST** /vendors/templates | Create a vendor template
[**DeleteVendor**](StoreVendorsApi.md#deletevendor) | **DELETE** /vendors/{id} | Delete a vendor
[**DeleteVendorTemplate**](StoreVendorsApi.md#deletevendortemplate) | **DELETE** /vendors/templates/{id} | Delete a vendor template
[**GetVendor**](StoreVendorsApi.md#getvendor) | **GET** /vendors/{id} | Get a single vendor
[**GetVendorTemplate**](StoreVendorsApi.md#getvendortemplate) | **GET** /vendors/templates/{id} | Get a single vendor template
[**GetVendorTemplates**](StoreVendorsApi.md#getvendortemplates) | **GET** /vendors/templates | List and search vendor templates
[**GetVendors**](StoreVendorsApi.md#getvendors) | **GET** /vendors | List and search vendors
[**UpdateVendor**](StoreVendorsApi.md#updatevendor) | **PUT** /vendors/{id} | Update a vendor
[**UpdateVendorTemplate**](StoreVendorsApi.md#updatevendortemplate) | **PUT** /vendors/templates/{id} | Update a vendor template


<a name="createvendor"></a>
# **CreateVendor**
> ModelVendorResource CreateVendor (ModelVendorResource vendor)

Create a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var vendor = new ModelVendorResource(); // ModelVendorResource | The vendor (optional) 

            try
            {
                // Create a vendor
                ModelVendorResource result = apiInstance.CreateVendor(vendor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.CreateVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendor** | [**ModelVendorResource**](ModelVendorResource.md)| The vendor | [optional] 

### Return type

[**ModelVendorResource**](ModelVendorResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvendortemplate"></a>
# **CreateVendorTemplate**
> ModelItemTemplateResource CreateVendorTemplate (ModelItemTemplateResource vendorTemplateResource)

Create a vendor template

Vendor Templates define a type of vendor and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateVendorTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var vendorTemplateResource = new ModelItemTemplateResource(); // ModelItemTemplateResource | The new vendor template (optional) 

            try
            {
                // Create a vendor template
                ModelItemTemplateResource result = apiInstance.CreateVendorTemplate(vendorTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.CreateVendorTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorTemplateResource** | [**ModelItemTemplateResource**](ModelItemTemplateResource.md)| The new vendor template | [optional] 

### Return type

[**ModelItemTemplateResource**](ModelItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendor"></a>
# **DeleteVendor**
> void DeleteVendor (int? id)

Delete a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Delete a vendor
                apiInstance.DeleteVendor(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.DeleteVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendortemplate"></a>
# **DeleteVendorTemplate**
> void DeleteVendorTemplate (string id, string cascade)

Delete a vendor template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVendorTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a vendor template
                apiInstance.DeleteVendorTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.DeleteVendorTemplate: " + e.Message );
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

<a name="getvendor"></a>
# **GetVendor**
> ModelVendorResource GetVendor (int? id)

Get a single vendor

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVendorExample
    {
        public void main()
        {
            
            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor

            try
            {
                // Get a single vendor
                ModelVendorResource result = apiInstance.GetVendor(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 

### Return type

[**ModelVendorResource**](ModelVendorResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendortemplate"></a>
# **GetVendorTemplate**
> ModelItemTemplateResource GetVendorTemplate (string id)

Get a single vendor template

Vendor Templates define a type of vendor and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVendorTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single vendor template
                ModelItemTemplateResource result = apiInstance.GetVendorTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendorTemplate: " + e.Message );
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

<a name="getvendortemplates"></a>
# **GetVendorTemplates**
> ModelPageResourceItemTemplateResource GetVendorTemplates (int? size, int? page, string order)

List and search vendor templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVendorTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to 1)

            try
            {
                // List and search vendor templates
                ModelPageResourceItemTemplateResource result = apiInstance.GetVendorTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendorTemplates: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to 1]

### Return type

[**ModelPageResourceItemTemplateResource**](ModelPageResourceItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendors"></a>
# **GetVendors**
> ModelPageResourceVendorResource GetVendors (string filterName, int? size, int? page, string order)

List and search vendors

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVendorsExample
    {
        public void main()
        {
            
            var apiInstance = new StoreVendorsApi();
            var filterName = filterName_example;  // string | Filters vendors by name starting with the text provided in the filter (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search vendors
                ModelPageResourceVendorResource result = apiInstance.GetVendors(filterName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.GetVendors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filters vendors by name starting with the text provided in the filter | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceVendorResource**](ModelPageResourceVendorResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendor"></a>
# **UpdateVendor**
> ModelVendorResource UpdateVendor (int? id, ModelVendorResource vendor)

Update a vendor

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVendorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = 56;  // int? | The id of the vendor
            var vendor = new ModelVendorResource(); // ModelVendorResource | The vendor (optional) 

            try
            {
                // Update a vendor
                ModelVendorResource result = apiInstance.UpdateVendor(id, vendor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.UpdateVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the vendor | 
 **vendor** | [**ModelVendorResource**](ModelVendorResource.md)| The vendor | [optional] 

### Return type

[**ModelVendorResource**](ModelVendorResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendortemplate"></a>
# **UpdateVendorTemplate**
> ModelItemTemplateResource UpdateVendorTemplate (string id, ModelItemTemplateResource vendorTemplateResource)

Update a vendor template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVendorTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreVendorsApi();
            var id = id_example;  // string | The id of the template
            var vendorTemplateResource = new ModelItemTemplateResource(); // ModelItemTemplateResource | The vendor template resource object (optional) 

            try
            {
                // Update a vendor template
                ModelItemTemplateResource result = apiInstance.UpdateVendorTemplate(id, vendorTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreVendorsApi.UpdateVendorTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **vendorTemplateResource** | [**ModelItemTemplateResource**](ModelItemTemplateResource.md)| The vendor template resource object | [optional] 

### Return type

[**ModelItemTemplateResource**](ModelItemTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

