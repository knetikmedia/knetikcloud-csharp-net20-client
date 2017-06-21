# com.knetikcloud..BRERuleEngineVariablesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREVariableTypes**](BRERuleEngineVariablesApi.md#getbrevariabletypes) | **GET** /bre/variable-types | Get a list of variable types available
[**GetBREVariableValues**](BRERuleEngineVariablesApi.md#getbrevariablevalues) | **GET** /bre/variable-types/{name}/values | List valid values for a type


<a name="getbrevariabletypes"></a>
# **GetBREVariableTypes**
> List<ModelVariableTypeResource> GetBREVariableTypes ()

Get a list of variable types available

Types include integer, string, user and invoice. These are used to qualify trigger parameters and action variables with strong typing.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREVariableTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineVariablesApi();

            try
            {
                // Get a list of variable types available
                List&lt;ModelVariableTypeResource&gt; result = apiInstance.GetBREVariableTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineVariablesApi.GetBREVariableTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelVariableTypeResource>**](ModelVariableTypeResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrevariablevalues"></a>
# **GetBREVariableValues**
> ModelPageResourceSimpleReferenceResourceobject GetBREVariableValues (string name, string filterName, int? size, int? page)

List valid values for a type

Used to lookup users to fill in a user constant for example. Only types marked as enumerable are suppoorted here.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREVariableValuesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineVariablesApi();
            var name = name_example;  // string | The name of the type
            var filterName = filterName_example;  // string | Filter results by those with names starting with this string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List valid values for a type
                ModelPageResourceSimpleReferenceResourceobject result = apiInstance.GetBREVariableValues(name, filterName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineVariablesApi.GetBREVariableValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the type | 
 **filterName** | **string**| Filter results by those with names starting with this string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceSimpleReferenceResourceobject**](ModelPageResourceSimpleReferenceResourceobject.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

