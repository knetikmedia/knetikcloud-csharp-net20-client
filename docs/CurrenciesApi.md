# com.knetikcloud.client..CurrenciesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCurrency**](CurrenciesApi.md#createcurrency) | **POST** /currencies | Create a currency
[**DeleteCurrency**](CurrenciesApi.md#deletecurrency) | **DELETE** /currencies/{code} | Delete a currency
[**GetCurrencies**](CurrenciesApi.md#getcurrencies) | **GET** /currencies | List and search currencies
[**GetCurrency**](CurrenciesApi.md#getcurrency) | **GET** /currencies/{code} | Get a single currency
[**UpdateCurrency**](CurrenciesApi.md#updatecurrency) | **PUT** /currencies/{code} | Update a currency


<a name="createcurrency"></a>
# **CreateCurrency**
> CurrencyResource CreateCurrency (CurrencyResource currency)

Create a currency

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class CreateCurrencyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var currency = new CurrencyResource(); // CurrencyResource | The currency object (optional) 

            try
            {
                // Create a currency
                CurrencyResource result = apiInstance.CreateCurrency(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.CreateCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | [**CurrencyResource**](CurrencyResource.md)| The currency object | [optional] 

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecurrency"></a>
# **DeleteCurrency**
> void DeleteCurrency (string code)

Delete a currency

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class DeleteCurrencyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code

            try
            {
                // Delete a currency
                apiInstance.DeleteCurrency(code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.DeleteCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencies"></a>
# **GetCurrencies**
> PageResourceCurrencyResource GetCurrencies (bool? filterEnabledCurrencies, string filterType, int? size, int? page, string order)

List and search currencies

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public void main()
        {
            
            var apiInstance = new CurrenciesApi();
            var filterEnabledCurrencies = true;  // bool? | Filter for alternate currencies setup explicitely in system config (optional) 
            var filterType = filterType_example;  // string | Filter currencies by type.  Allowable values: ('virtual', 'real') (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search currencies
                PageResourceCurrencyResource result = apiInstance.GetCurrencies(filterEnabledCurrencies, filterType, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEnabledCurrencies** | **bool?**| Filter for alternate currencies setup explicitely in system config | [optional] 
 **filterType** | **string**| Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceCurrencyResource**](PageResourceCurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrency"></a>
# **GetCurrency**
> CurrencyResource GetCurrency (string code)

Get a single currency

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class GetCurrencyExample
    {
        public void main()
        {
            
            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code

            try
            {
                // Get a single currency
                CurrencyResource result = apiInstance.GetCurrency(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.GetCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecurrency"></a>
# **UpdateCurrency**
> void UpdateCurrency (string code, CurrencyResource currency)

Update a currency

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.client.Api;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace Example
{
    public class UpdateCurrencyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi();
            var code = code_example;  // string | The currency code
            var currency = new CurrencyResource(); // CurrencyResource | The currency object (optional) 

            try
            {
                // Update a currency
                apiInstance.UpdateCurrency(code, currency);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.UpdateCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The currency code | 
 **currency** | [**CurrencyResource**](CurrencyResource.md)| The currency object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

