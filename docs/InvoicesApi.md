# com.knetikcloud..InvoicesApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /invoices | Create an invoice
[**GetFulFillmentStatuses**](InvoicesApi.md#getfulfillmentstatuses) | **GET** /invoices/fulfillment-statuses | Lists available fulfillment statuses
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /invoices/{id} | Retrieve an invoice
[**GetInvoiceLogs**](InvoicesApi.md#getinvoicelogs) | **GET** /invoices/{id}/logs | List invoice logs
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /invoices | Retrieve invoices
[**GetPaymentStatuses**](InvoicesApi.md#getpaymentstatuses) | **GET** /invoices/payment-statuses | Lists available payment statuses
[**PayInvoice**](InvoicesApi.md#payinvoice) | **POST** /invoices/{id}/payments | Pay an invoice using a saved payment method
[**SetBundledInvoiceItemFulfillmentStatus**](InvoicesApi.md#setbundledinvoiceitemfulfillmentstatus) | **PUT** /invoices/{id}/items/{bundleSku}/bundled-skus/{sku}/fulfillment-status | Set the fulfillment status of a bundled invoice item
[**SetExternalRef**](InvoicesApi.md#setexternalref) | **PUT** /invoices/{id}/external-ref | Set the external reference of an invoice
[**SetInvoiceItemFulfillmentStatus**](InvoicesApi.md#setinvoiceitemfulfillmentstatus) | **PUT** /invoices/{id}/items/{sku}/fulfillment-status | Set the fulfillment status of an invoice item
[**SetOrderNotes**](InvoicesApi.md#setordernotes) | **PUT** /invoices/{id}/order-notes | Set the order notes of an invoice
[**SetPaymentStatus**](InvoicesApi.md#setpaymentstatus) | **PUT** /invoices/{id}/payment-status | Set the payment status of an invoice
[**UpdateBillingInfo**](InvoicesApi.md#updatebillinginfo) | **PUT** /invoices/{id}/billing-address | Set or update billing info


<a name="createinvoice"></a>
# **CreateInvoice**
> List<InvoiceResource> CreateInvoice (InvoiceCreateRequest req)

Create an invoice

Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor. <br><br><b>Permissions Needed:</b> INVOICES_USER or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var req = new InvoiceCreateRequest(); // InvoiceCreateRequest | Invoice to be created (optional) 

            try
            {
                // Create an invoice
                List&lt;InvoiceResource&gt; result = apiInstance.CreateInvoice(req);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **req** | [**InvoiceCreateRequest**](InvoiceCreateRequest.md)| Invoice to be created | [optional] 

### Return type

[**List<InvoiceResource>**](InvoiceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentstatuses"></a>
# **GetFulFillmentStatuses**
> List<string> GetFulFillmentStatuses ()

Lists available fulfillment statuses

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
    public class GetFulFillmentStatusesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available fulfillment statuses
                List&lt;string&gt; result = apiInstance.GetFulFillmentStatuses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetFulFillmentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> InvoiceResource GetInvoice (int? id)

Retrieve an invoice

<b>Permissions Needed:</b> INVOICES_USER and owner, or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice

            try
            {
                // Retrieve an invoice
                InvoiceResource result = apiInstance.GetInvoice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicelogs"></a>
# **GetInvoiceLogs**
> PageResourceInvoiceLogEntry GetInvoiceLogs (int? id, int? size, int? page)

List invoice logs

<b>Permissions Needed:</b> INVOICES_USER and owner, or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoiceLogsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List invoice logs
                PageResourceInvoiceLogEntry result = apiInstance.GetInvoiceLogs(id, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceInvoiceLogEntry**](PageResourceInvoiceLogEntry.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> PageResourceInvoiceResource GetInvoices (int? filterUser, string filterEmail, string filterFulfillmentStatus, string filterPaymentStatus, string filterItemName, string filterExternalRef, string filterCreatedDate, string filterVendorIds, string filterCurrency, string filterShippingStateName, string filterShippingCountryName, string filterShipping, string filterVendorName, string filterSku, int? size, int? page, string order)

Retrieve invoices

Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user's invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices. <br><br><b>Permissions Needed:</b> INVOICES_USER and owner, or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var filterUser = 56;  // int? | The id of a user to get invoices for. Automtically added if not being called with admin permissions. (optional) 
            var filterEmail = filterEmail_example;  // string | Filters invoices by customer's email. Admins only. (optional) 
            var filterFulfillmentStatus = filterFulfillmentStatus_example;  // string | Filters invoices by fulfillment status type. Can be a comma separated list of statuses (optional) 
            var filterPaymentStatus = filterPaymentStatus_example;  // string | Filters invoices by payment status type. Can be a comma separated list of statuses (optional) 
            var filterItemName = filterItemName_example;  // string | Filters invoices by item name containing the given string (optional) 
            var filterExternalRef = filterExternalRef_example;  // string | Filters invoices by external reference. (optional) 
            var filterCreatedDate = filterCreatedDate_example;  // string | Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date=OP,ts&... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date=GT,1452154258,LT,1554254874 (optional) 
            var filterVendorIds = filterVendorIds_example;  // string | Filters invoices for ones from one of the vendors whose id is in the given comma separated list (optional) 
            var filterCurrency = filterCurrency_example;  // string | Filters invoices by currency. ISO3 currency code (optional) 
            var filterShippingStateName = filterShippingStateName_example;  // string | Filters invoices by shipping address: Exact match state name (optional) 
            var filterShippingCountryName = filterShippingCountryName_example;  // string | Filters invoices by shipping address: Exact match country name (optional) 
            var filterShipping = filterShipping_example;  // string | Filters invoices by shipping price. Multiple values possible for range search. Format: filter_shipping=OP,ts&... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_shipping=GT,14.58,LT,15.54 (optional) 
            var filterVendorName = filterVendorName_example;  // string | Filters invoices by vendor name starting with given string (optional) 
            var filterSku = filterSku_example;  // string | Filters invoices by item sku (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // Retrieve invoices
                PageResourceInvoiceResource result = apiInstance.GetInvoices(filterUser, filterEmail, filterFulfillmentStatus, filterPaymentStatus, filterItemName, filterExternalRef, filterCreatedDate, filterVendorIds, filterCurrency, filterShippingStateName, filterShippingCountryName, filterShipping, filterVendorName, filterSku, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterUser** | **int?**| The id of a user to get invoices for. Automtically added if not being called with admin permissions. | [optional] 
 **filterEmail** | **string**| Filters invoices by customer&#39;s email. Admins only. | [optional] 
 **filterFulfillmentStatus** | **string**| Filters invoices by fulfillment status type. Can be a comma separated list of statuses | [optional] 
 **filterPaymentStatus** | **string**| Filters invoices by payment status type. Can be a comma separated list of statuses | [optional] 
 **filterItemName** | **string**| Filters invoices by item name containing the given string | [optional] 
 **filterExternalRef** | **string**| Filters invoices by external reference. | [optional] 
 **filterCreatedDate** | **string**| Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874 | [optional] 
 **filterVendorIds** | **string**| Filters invoices for ones from one of the vendors whose id is in the given comma separated list | [optional] 
 **filterCurrency** | **string**| Filters invoices by currency. ISO3 currency code | [optional] 
 **filterShippingStateName** | **string**| Filters invoices by shipping address: Exact match state name | [optional] 
 **filterShippingCountryName** | **string**| Filters invoices by shipping address: Exact match country name | [optional] 
 **filterShipping** | **string**| Filters invoices by shipping price. Multiple values possible for range search. Format: filter_shipping&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_shipping&#x3D;GT,14.58,LT,15.54 | [optional] 
 **filterVendorName** | **string**| Filters invoices by vendor name starting with given string | [optional] 
 **filterSku** | **string**| Filters invoices by item sku | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceInvoiceResource**](PageResourceInvoiceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentstatuses"></a>
# **GetPaymentStatuses**
> List<string> GetPaymentStatuses ()

Lists available payment statuses

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
    public class GetPaymentStatusesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();

            try
            {
                // Lists available payment statuses
                List&lt;string&gt; result = apiInstance.GetPaymentStatuses();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetPaymentStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payinvoice"></a>
# **PayInvoice**
> void PayInvoice (int? id, PayBySavedMethodRequest request)

Pay an invoice using a saved payment method

<b>Permissions Needed:</b> INVOICES_USER and owner, or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PayInvoiceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new PayBySavedMethodRequest(); // PayBySavedMethodRequest | The payment method details. Will default to the appropriate user's wallet in the invoice currency if ommited. (optional) 

            try
            {
                // Pay an invoice using a saved payment method
                apiInstance.PayInvoice(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.PayInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**PayBySavedMethodRequest**](PayBySavedMethodRequest.md)| The payment method details. Will default to the appropriate user&#39;s wallet in the invoice currency if ommited. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbundledinvoiceitemfulfillmentstatus"></a>
# **SetBundledInvoiceItemFulfillmentStatus**
> void SetBundledInvoiceItemFulfillmentStatus (int? id, string bundleSku, string sku, StringWrapper status)

Set the fulfillment status of a bundled invoice item

This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which. <br><br><b>Permissions Needed:</b> INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetBundledInvoiceItemFulfillmentStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var bundleSku = bundleSku_example;  // string | The sku of the bundle in the invoice that contains the given target
            var sku = sku_example;  // string | The sku of an item in the bundle in the invoice
            var status = new StringWrapper(); // StringWrapper | The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  'unfulfilled', 'fulfilled', 'not fulfillable', 'failed', 'processing', 'failed_permanent', 'delayed'

            try
            {
                // Set the fulfillment status of a bundled invoice item
                apiInstance.SetBundledInvoiceItemFulfillmentStatus(id, bundleSku, sku, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetBundledInvoiceItemFulfillmentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **bundleSku** | **string**| The sku of the bundle in the invoice that contains the given target | 
 **sku** | **string**| The sku of an item in the bundle in the invoice | 
 **status** | [**StringWrapper**](StringWrapper.md)| The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39; | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexternalref"></a>
# **SetExternalRef**
> void SetExternalRef (int? id, StringWrapper externalRef)

Set the external reference of an invoice

<b>Permissions Needed:</b> INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetExternalRefExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var externalRef = new StringWrapper(); // StringWrapper | External reference info (optional) 

            try
            {
                // Set the external reference of an invoice
                apiInstance.SetExternalRef(id, externalRef);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetExternalRef: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **externalRef** | [**StringWrapper**](StringWrapper.md)| External reference info | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setinvoiceitemfulfillmentstatus"></a>
# **SetInvoiceItemFulfillmentStatus**
> void SetInvoiceItemFulfillmentStatus (int? id, string sku, StringWrapper status)

Set the fulfillment status of an invoice item

This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which. <br><br><b>Permissions Needed:</b> INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetInvoiceItemFulfillmentStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var sku = sku_example;  // string | The sku of an item in the invoice
            var status = new StringWrapper(); // StringWrapper | The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  'unfulfilled', 'fulfilled', 'not fulfillable', 'failed', 'processing', 'failed_permanent', 'delayed'

            try
            {
                // Set the fulfillment status of an invoice item
                apiInstance.SetInvoiceItemFulfillmentStatus(id, sku, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetInvoiceItemFulfillmentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **sku** | **string**| The sku of an item in the invoice | 
 **status** | [**StringWrapper**](StringWrapper.md)| The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39; | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setordernotes"></a>
# **SetOrderNotes**
> void SetOrderNotes (int? id, StringWrapper orderNotes)

Set the order notes of an invoice

<b>Permissions Needed:</b> INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetOrderNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var orderNotes = new StringWrapper(); // StringWrapper | Payment status info (optional) 

            try
            {
                // Set the order notes of an invoice
                apiInstance.SetOrderNotes(id, orderNotes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetOrderNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **orderNotes** | [**StringWrapper**](StringWrapper.md)| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpaymentstatus"></a>
# **SetPaymentStatus**
> void SetPaymentStatus (int? id, InvoicePaymentStatusRequest request)

Set the payment status of an invoice

This may trigger fulfillment if setting the status to 'paid'. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which. <br><br><b>Permissions Needed:</b> INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetPaymentStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var request = new InvoicePaymentStatusRequest(); // InvoicePaymentStatusRequest | Payment status info (optional) 

            try
            {
                // Set the payment status of an invoice
                apiInstance.SetPaymentStatus(id, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SetPaymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **request** | [**InvoicePaymentStatusRequest**](InvoicePaymentStatusRequest.md)| Payment status info | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillinginfo"></a>
# **UpdateBillingInfo**
> void UpdateBillingInfo (int? id, AddressResource billingInfoRequest)

Set or update billing info

<b>Permissions Needed:</b> INVOICES_USER and owner, or INVOICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBillingInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var id = 56;  // int? | The id of the invoice
            var billingInfoRequest = new AddressResource(); // AddressResource | Address info (optional) 

            try
            {
                // Set or update billing info
                apiInstance.UpdateBillingInfo(id, billingInfoRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateBillingInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the invoice | 
 **billingInfoRequest** | [**AddressResource**](AddressResource.md)| Address info | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

