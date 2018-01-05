# com.knetikcloud..TaxesApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCountryTax**](TaxesApi.md#createcountrytax) | **POST** /tax/countries | Create a country tax
[**CreateStateTax**](TaxesApi.md#createstatetax) | **POST** /tax/countries/{country_code_iso3}/states | Create a state tax
[**DeleteCountryTax**](TaxesApi.md#deletecountrytax) | **DELETE** /tax/countries/{country_code_iso3} | Delete an existing tax
[**DeleteStateTax**](TaxesApi.md#deletestatetax) | **DELETE** /tax/countries/{country_code_iso3}/states/{state_code} | Delete an existing state tax
[**GetCountryTax**](TaxesApi.md#getcountrytax) | **GET** /tax/countries/{country_code_iso3} | Get a single tax
[**GetCountryTaxes**](TaxesApi.md#getcountrytaxes) | **GET** /tax/countries | List and search taxes
[**GetStateTax**](TaxesApi.md#getstatetax) | **GET** /tax/countries/{country_code_iso3}/states/{state_code} | Get a single state tax
[**GetStateTaxesForCountries**](TaxesApi.md#getstatetaxesforcountries) | **GET** /tax/states | List and search taxes across all countries
[**GetStateTaxesForCountry**](TaxesApi.md#getstatetaxesforcountry) | **GET** /tax/countries/{country_code_iso3}/states | List and search taxes within a country
[**UpdateCountryTax**](TaxesApi.md#updatecountrytax) | **PUT** /tax/countries/{country_code_iso3} | Create or update a tax
[**UpdateStateTax**](TaxesApi.md#updatestatetax) | **PUT** /tax/countries/{country_code_iso3}/states/{state_code} | Create or update a state tax


<a name="createcountrytax"></a>
# **CreateCountryTax**
> CountryTaxResource CreateCountryTax (CountryTaxResource taxResource)

Create a country tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCountryTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var taxResource = new CountryTaxResource(); // CountryTaxResource | The tax object (optional) 

            try
            {
                // Create a country tax
                CountryTaxResource result = apiInstance.CreateCountryTax(taxResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.CreateCountryTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxResource** | [**CountryTaxResource**](CountryTaxResource.md)| The tax object | [optional] 

### Return type

[**CountryTaxResource**](CountryTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstatetax"></a>
# **CreateStateTax**
> StateTaxResource CreateStateTax (string countryCodeIso3, StateTaxResource taxResource)

Create a state tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateStateTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var taxResource = new StateTaxResource(); // StateTaxResource | The tax object (optional) 

            try
            {
                // Create a state tax
                StateTaxResource result = apiInstance.CreateStateTax(countryCodeIso3, taxResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.CreateStateTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **taxResource** | [**StateTaxResource**](StateTaxResource.md)| The tax object | [optional] 

### Return type

[**StateTaxResource**](StateTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecountrytax"></a>
# **DeleteCountryTax**
> void DeleteCountryTax (string countryCodeIso3)

Delete an existing tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteCountryTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Delete an existing tax
                apiInstance.DeleteCountryTax(countryCodeIso3);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.DeleteCountryTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestatetax"></a>
# **DeleteStateTax**
> void DeleteStateTax (string countryCodeIso3, string stateCode)

Delete an existing state tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteStateTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Delete an existing state tax
                apiInstance.DeleteStateTax(countryCodeIso3, stateCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.DeleteStateTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrytax"></a>
# **GetCountryTax**
> CountryTaxResource GetCountryTax (string countryCodeIso3)

Get a single tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCountryTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Get a single tax
                CountryTaxResource result = apiInstance.GetCountryTax(countryCodeIso3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetCountryTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 

### Return type

[**CountryTaxResource**](CountryTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrytaxes"></a>
# **GetCountryTaxes**
> PageResourceCountryTaxResource GetCountryTaxes (int? size, int? page, string order)

List and search taxes

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCountryTaxesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search taxes
                PageResourceCountryTaxResource result = apiInstance.GetCountryTaxes(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetCountryTaxes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceCountryTaxResource**](PageResourceCountryTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatetax"></a>
# **GetStateTax**
> StateTaxResource GetStateTax (string countryCodeIso3, string stateCode)

Get a single state tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStateTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state

            try
            {
                // Get a single state tax
                StateTaxResource result = apiInstance.GetStateTax(countryCodeIso3, stateCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetStateTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 

### Return type

[**StateTaxResource**](StateTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatetaxesforcountries"></a>
# **GetStateTaxesForCountries**
> PageResourceStateTaxResource GetStateTaxesForCountries (int? size, int? page, string order)

List and search taxes across all countries

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStateTaxesForCountriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // List and search taxes across all countries
                PageResourceStateTaxResource result = apiInstance.GetStateTaxesForCountries(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetStateTaxesForCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceStateTaxResource**](PageResourceStateTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstatetaxesforcountry"></a>
# **GetStateTaxesForCountry**
> PageResourceStateTaxResource GetStateTaxesForCountry (string countryCodeIso3, int? size, int? page, string order)

List and search taxes within a country

Get a list of taxes

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetStateTaxesForCountryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // List and search taxes within a country
                PageResourceStateTaxResource result = apiInstance.GetStateTaxesForCountry(countryCodeIso3, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.GetStateTaxesForCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**PageResourceStateTaxResource**](PageResourceStateTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecountrytax"></a>
# **UpdateCountryTax**
> CountryTaxResource UpdateCountryTax (string countryCodeIso3, CountryTaxResource taxResource)

Create or update a tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateCountryTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var taxResource = new CountryTaxResource(); // CountryTaxResource | The tax object (optional) 

            try
            {
                // Create or update a tax
                CountryTaxResource result = apiInstance.UpdateCountryTax(countryCodeIso3, taxResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.UpdateCountryTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **taxResource** | [**CountryTaxResource**](CountryTaxResource.md)| The tax object | [optional] 

### Return type

[**CountryTaxResource**](CountryTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestatetax"></a>
# **UpdateStateTax**
> StateTaxResource UpdateStateTax (string countryCodeIso3, string stateCode, StateTaxResource taxResource)

Create or update a state tax

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateStateTaxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxesApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country
            var stateCode = stateCode_example;  // string | The code of the state
            var taxResource = new StateTaxResource(); // StateTaxResource | The tax object (optional) 

            try
            {
                // Create or update a state tax
                StateTaxResource result = apiInstance.UpdateStateTax(countryCodeIso3, stateCode, taxResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxesApi.UpdateStateTax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCodeIso3** | **string**| The iso3 code of the country | 
 **stateCode** | **string**| The code of the state | 
 **taxResource** | [**StateTaxResource**](StateTaxResource.md)| The tax object | [optional] 

### Return type

[**StateTaxResource**](StateTaxResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

