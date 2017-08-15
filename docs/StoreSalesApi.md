# com.knetikcloud..StoreSalesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCatalogSale**](StoreSalesApi.md#createcatalogsale) | **POST** /store/sales | Create a sale
[**DeleteCatalogSale**](StoreSalesApi.md#deletecatalogsale) | **DELETE** /store/sales/{id} | Delete a sale
[**GetCatalogSale**](StoreSalesApi.md#getcatalogsale) | **GET** /store/sales/{id} | Get a single sale
[**GetCatalogSales**](StoreSalesApi.md#getcatalogsales) | **GET** /store/sales | List and search sales
[**UpdateCatalogSale**](StoreSalesApi.md#updatecatalogsale) | **PUT** /store/sales/{id} | Update a sale


<a name="createcatalogsale"></a>
# **CreateCatalogSale**
> CatalogSale CreateCatalogSale (CatalogSale catalogSale)

Create a sale

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCatalogSaleExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSalesApi();
            var catalogSale = new CatalogSale(); // CatalogSale | The catalog sale object (optional) 

            try
            {
                // Create a sale
                CatalogSale result = apiInstance.CreateCatalogSale(catalogSale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.CreateCatalogSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogSale** | [**CatalogSale**](CatalogSale.md)| The catalog sale object | [optional] 

### Return type

[**CatalogSale**](CatalogSale.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecatalogsale"></a>
# **DeleteCatalogSale**
> void DeleteCatalogSale (int? id)

Delete a sale

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCatalogSaleExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale

            try
            {
                // Delete a sale
                apiInstance.DeleteCatalogSale(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.DeleteCatalogSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogsale"></a>
# **GetCatalogSale**
> CatalogSale GetCatalogSale (int? id)

Get a single sale

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCatalogSaleExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale

            try
            {
                // Get a single sale
                CatalogSale result = apiInstance.GetCatalogSale(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.GetCatalogSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 

### Return type

[**CatalogSale**](CatalogSale.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogsales"></a>
# **GetCatalogSales**
> PageResourceCatalogSale GetCatalogSales (int? size, int? page, string order)

List and search sales

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCatalogSalesExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSalesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search sales
                PageResourceCatalogSale result = apiInstance.GetCatalogSales(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.GetCatalogSales: " + e.Message );
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

[**PageResourceCatalogSale**](PageResourceCatalogSale.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecatalogsale"></a>
# **UpdateCatalogSale**
> CatalogSale UpdateCatalogSale (int? id, CatalogSale catalogSale)

Update a sale

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCatalogSaleExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSalesApi();
            var id = 56;  // int? | The id of the sale
            var catalogSale = new CatalogSale(); // CatalogSale | The catalog sale object (optional) 

            try
            {
                // Update a sale
                CatalogSale result = apiInstance.UpdateCatalogSale(id, catalogSale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSalesApi.UpdateCatalogSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the sale | 
 **catalogSale** | [**CatalogSale**](CatalogSale.md)| The catalog sale object | [optional] 

### Return type

[**CatalogSale**](CatalogSale.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

