# com.knetikcloud..Reporting_RevenueApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetItemRevenue**](Reporting_RevenueApi.md#getitemrevenue) | **GET** /reporting/revenue/item-sales/{currency_code} | Get item revenue info
[**GetRefundRevenue**](Reporting_RevenueApi.md#getrefundrevenue) | **GET** /reporting/revenue/refunds/{currency_code} | Get refund revenue info
[**GetRevenueByCountry**](Reporting_RevenueApi.md#getrevenuebycountry) | **GET** /reporting/revenue/countries/{currency_code} | Get revenue info by country
[**GetRevenueByItem**](Reporting_RevenueApi.md#getrevenuebyitem) | **GET** /reporting/revenue/products/{currency_code} | Get revenue info by item
[**GetSubscriptionRevenue**](Reporting_RevenueApi.md#getsubscriptionrevenue) | **GET** /reporting/revenue/subscription-sales/{currency_code} | Get subscription revenue info


<a name="getitemrevenue"></a>
# **GetItemRevenue**
> RevenueReportResource GetItemRevenue (string currencyCode, long? startDate, long? endDate)

Get item revenue info

Get basic info about revenue from sales of items and bundles (not subscriptions, shipping, etc), summed up within a time range. <br><br><b>Permissions Needed:</b> REPORTING_REVENUE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetItemRevenueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_RevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get item revenue info
                RevenueReportResource result = apiInstance.GetItemRevenue(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_RevenueApi.GetItemRevenue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrefundrevenue"></a>
# **GetRefundRevenue**
> RevenueReportResource GetRefundRevenue (string currencyCode, long? startDate, long? endDate)

Get refund revenue info

Get basic info about revenue loss from refunds (for all item types), summed up within a time range. <br><br><b>Permissions Needed:</b> REPORTING_REVENUE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRefundRevenueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_RevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get refund data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get refund revenue info
                RevenueReportResource result = apiInstance.GetRefundRevenue(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_RevenueApi.GetRefundRevenue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get refund data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrevenuebycountry"></a>
# **GetRevenueByCountry**
> PageResourceRevenueCountryReportResource GetRevenueByCountry (string currencyCode, long? startDate, long? endDate, int? size, int? page)

Get revenue info by country

Get basic info about revenue from sales of all types, summed up within a time range and split out by country. Sorted for largest revenue at the top. <br><br><b>Permissions Needed:</b> REPORTING_REVENUE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRevenueByCountryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_RevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get revenue info by country
                PageResourceRevenueCountryReportResource result = apiInstance.GetRevenueByCountry(currencyCode, startDate, endDate, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_RevenueApi.GetRevenueByCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceRevenueCountryReportResource**](PageResourceRevenueCountryReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrevenuebyitem"></a>
# **GetRevenueByItem**
> PageResourceRevenueProductReportResource GetRevenueByItem (string currencyCode, long? startDate, long? endDate, int? size, int? page)

Get revenue info by item

Get basic info about revenue from sales of all types, summed up within a time range and split out by specific item. Sorted for largest revenue at the top. <br><br><b>Permissions Needed:</b> REPORTING_REVENUE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRevenueByItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_RevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get revenue info by item
                PageResourceRevenueProductReportResource result = apiInstance.GetRevenueByItem(currencyCode, startDate, endDate, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_RevenueApi.GetRevenueByItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceRevenueProductReportResource**](PageResourceRevenueProductReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionrevenue"></a>
# **GetSubscriptionRevenue**
> RevenueReportResource GetSubscriptionRevenue (string currencyCode, long? startDate, long? endDate)

Get subscription revenue info

Get basic info about revenue from sales of new subscriptions as well as recurring payemnts, summed up within a time range. <br><br><b>Permissions Needed:</b> REPORTING_REVENUE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSubscriptionRevenueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Reporting_RevenueApi();
            var currencyCode = currencyCode_example;  // string | The code for a currency to get sales data for
            var startDate = 789;  // long? | The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time (optional) 
            var endDate = 789;  // long? | The end of the time range to aggregate, unix timestamp in seconds. Default is end of time (optional) 

            try
            {
                // Get subscription revenue info
                RevenueReportResource result = apiInstance.GetSubscriptionRevenue(currencyCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Reporting_RevenueApi.GetSubscriptionRevenue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyCode** | **string**| The code for a currency to get sales data for | 
 **startDate** | **long?**| The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time | [optional] 
 **endDate** | **long?**| The end of the time range to aggregate, unix timestamp in seconds. Default is end of time | [optional] 

### Return type

[**RevenueReportResource**](RevenueReportResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

