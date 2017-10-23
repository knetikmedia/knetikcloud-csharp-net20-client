# com.knetikcloud..BRERuleEngineExpressionsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBREExpression**](BRERuleEngineExpressionsApi.md#getbreexpression) | **GET** /bre/expressions/{type} | Lookup a specific expression
[**GetBREExpressions**](BRERuleEngineExpressionsApi.md#getbreexpressions) | **GET** /bre/expressions | Get a list of supported expressions to use in conditions or actions.
[**GetExpressionAsText**](BRERuleEngineExpressionsApi.md#getexpressionastext) | **POST** /bre/expressions | Returns the textual representation of an expression


<a name="getbreexpression"></a>
# **GetBREExpression**
> ExpressionResource GetBREExpression (string type)

Lookup a specific expression

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREExpressionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineExpressionsApi();
            var type = type_example;  // string | Specifiy the type of expression as returned by the listing endpoint

            try
            {
                // Lookup a specific expression
                ExpressionResource result = apiInstance.GetBREExpression(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineExpressionsApi.GetBREExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Specifiy the type of expression as returned by the listing endpoint | 

### Return type

[**ExpressionResource**](ExpressionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreexpressions"></a>
# **GetBREExpressions**
> List<ExpressionResource> GetBREExpressions (string filterTypeGroup)

Get a list of supported expressions to use in conditions or actions.

Each resource contains a type and a definition that are read-only, all the other fields must be provided when using the expression in a rule.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREExpressionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineExpressionsApi();
            var filterTypeGroup = filterTypeGroup_example;  // string | Filter for expressions by type group (optional) 

            try
            {
                // Get a list of supported expressions to use in conditions or actions.
                List&lt;ExpressionResource&gt; result = apiInstance.GetBREExpressions(filterTypeGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineExpressionsApi.GetBREExpressions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTypeGroup** | **string**| Filter for expressions by type group | [optional] 

### Return type

[**List<ExpressionResource>**](ExpressionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexpressionastext"></a>
# **GetExpressionAsText**
> StringWrapper GetExpressionAsText (ExpressionResource expression)

Returns the textual representation of an expression

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetExpressionAsTextExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineExpressionsApi();
            var expression = new ExpressionResource(); // ExpressionResource | The expression resource to be converted (optional) 

            try
            {
                // Returns the textual representation of an expression
                StringWrapper result = apiInstance.GetExpressionAsText(expression);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineExpressionsApi.GetExpressionAsText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expression** | [**ExpressionResource**](ExpressionResource.md)| The expression resource to be converted | [optional] 

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

