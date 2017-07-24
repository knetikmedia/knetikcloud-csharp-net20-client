# com.knetikcloud..LocationsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCountries**](LocationsApi.md#getcountries) | **GET** /location/countries | Get a list of countries
[**GetCountryByGeoLocation**](LocationsApi.md#getcountrybygeolocation) | **GET** /location/geolocation/country | Get the iso3 code of your country
[**GetCountryStates**](LocationsApi.md#getcountrystates) | **GET** /location/countries/{country_code_iso3}/states | Get a list of a country&#39;s states
[**GetCurrencyByGeoLocation**](LocationsApi.md#getcurrencybygeolocation) | **GET** /location/geolocation/currency | Get the currency information of your country


<a name="getcountries"></a>
# **GetCountries**
> List<CountryResource> GetCountries ()

Get a list of countries

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get a list of countries
                List&lt;CountryResource&gt; result = apiInstance.GetCountries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CountryResource>**](CountryResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrybygeolocation"></a>
# **GetCountryByGeoLocation**
> string GetCountryByGeoLocation ()

Get the iso3 code of your country

Determined by geo ip location

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCountryByGeoLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the iso3 code of your country
                string result = apiInstance.GetCountryByGeoLocation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountryByGeoLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrystates"></a>
# **GetCountryStates**
> List<StateResource> GetCountryStates (string countryCodeIso3)

Get a list of a country's states

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCountryStatesExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();
            var countryCodeIso3 = countryCodeIso3_example;  // string | The iso3 code of the country

            try
            {
                // Get a list of a country's states
                List&lt;StateResource&gt; result = apiInstance.GetCountryStates(countryCodeIso3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCountryStates: " + e.Message );
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

[**List<StateResource>**](StateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencybygeolocation"></a>
# **GetCurrencyByGeoLocation**
> CurrencyResource GetCurrencyByGeoLocation ()

Get the currency information of your country

Determined by geo ip location, currency to country mapping and a fallback setting

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCurrencyByGeoLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LocationsApi();

            try
            {
                // Get the currency information of your country
                CurrencyResource result = apiInstance.GetCurrencyByGeoLocation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.GetCurrencyByGeoLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrencyResource**](CurrencyResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

