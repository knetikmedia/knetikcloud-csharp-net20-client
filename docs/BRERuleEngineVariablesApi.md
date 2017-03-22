# com.knetikcloud..BRERuleEngineVariablesApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREVariableTypes**](BRERuleEngineVariablesApi.md#getbrevariabletypes) | **GET** /bre/variable-types | Get a list of variable types available


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

