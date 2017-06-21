# com.knetikcloud..BRERuleEngineRulesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBRERule**](BRERuleEngineRulesApi.md#createbrerule) | **POST** /bre/rules | Create a rule
[**DeleteBRERule**](BRERuleEngineRulesApi.md#deletebrerule) | **DELETE** /bre/rules/{id} | Delete a rule
[**GetBREExpressionAsString**](BRERuleEngineRulesApi.md#getbreexpressionasstring) | **POST** /bre/rules/expression-as-string | Returns a string representation of the provided expression
[**GetBRERule**](BRERuleEngineRulesApi.md#getbrerule) | **GET** /bre/rules/{id} | Get a single rule
[**GetBRERules**](BRERuleEngineRulesApi.md#getbrerules) | **GET** /bre/rules | List rules
[**SetBRERule**](BRERuleEngineRulesApi.md#setbrerule) | **PUT** /bre/rules/{id}/enabled | Enable or disable a rule
[**UpdateBRERule**](BRERuleEngineRulesApi.md#updatebrerule) | **PUT** /bre/rules/{id} | Update a rule


<a name="createbrerule"></a>
# **CreateBRERule**
> ModelBreRule CreateBRERule (ModelBreRule breRule)

Create a rule

Rules define which actions to run when a given event verifies the specified conditions. Conditions and actions are defined by binding event or context parameters to arguments. Conditions also known as Predicates are logical expressions that result in a boolean. Operators are used to describe rules between arguments to form that condition. There are 3 families of operators: Boolean, Math and String. Math and String operators are functions that transform arguments into numbers or strings...<h1>Boolean Operators</h1><br /><br />1 arg:<br />======<br /><br /><ul> <li>IS_NULL</li> <li>IS_NOT_NULL</li> <li>STRING_IS_EMPTY</li> <li>NOT </li> <li>MAP_IS_EMPTY</li></ul><br />2 args:<br />=======<br /><br /><ul> <li>EQ</li> <li>NE (Not Equals)</li> <li>GT (Greater Than)</li> <li>GOE (Greater Or Equals)</li> <li>LT (Lesser Than)</li> <li>LOE (Lesser Or Equals)</li> <li>OR</li> <li>AND</li> <li>XNOR</li> <li>XOR</li> <li>CONTAINS_KEY (for maps only)</li> <li>CONTAINS_VALUE (for maps only)</li> <li>MATCHES (regex)</li> <li>MATCHES_IC (regex ignore case)</li> <li>STARTS_WITH</li> <li>STARTS_WITH_IC</li> <li>EQ_IGNORE_CASE</li> <li>ENDS_WITH</li> <li>ENDS_WITH_IC</li> <li>STRING_CONTAINS</li> <li>STRING_CONTAINS_IC</li> <li>LIKE (SQL like)</li></ul><br />3 args exceptions:<br />=================<br /><br /><ul> <li>BETWEEN</li></ul><br />n args:<br />=======<br /><br /><ul> <li>IN</li> <li>NOT_INT</li></ul><h1>Math Operators</h1>1 arg:<br />=====<br /><br /><ul> <li>NEGATE</li> <li>MAP_SIZE</li> <li>STRING_LENGTH</li> <li>CEIL</li> <li>ABS</li> <li>FLOOR</li> <li>ROUND</li> <li>RANDOM (no arg)</li> <li>RANDOM2 (seed arg)</li> <li>NUMCAST</li> <li>HOUR</li> <li>MINUTE</li> <li>SECOND</li> <li>MILLISECOND</li> <li>YEAR</li> <li>WEEK</li> <li>YEAR_MONTH</li> <li>YEAR_WEEK</li> <li>DAY_OF_WEEK</li> <li>DAY_OF_MONTH</li> <li>DAY_OF_YEAR</li> <li>WEEK</li> <li>WEEK</li> <li>WEEK</li></ul><br /><br />2 args:<br />======<br /><br /><ul> <li>ADD</li> <li>DIV</li> <li>MULT</li> <li>SUB</li> <li>POWER</li> <li>MOD</li> <li>LOCATE (index of (string, char))</li> <li>DIFF_YEARS</li> <li>DIFF_MONTHS</li> <li>DIFF_WEEKS</li> <li>DIFF_DAYS</li> <li>DIFF_HOURS</li> <li>DIFF_MINUTES</li> <li>DIFF_SECONDS</li></ul><br /><br />2 args:<br />======<br /><br /><ul> <li>MIN</li> <li>MAX</li></ul><h1>String Operators</h1>0 arg:<br />=====<br /><br /><ul> <li>CURRENT_TIME</li></ul><br /><br />1 arg:<br />=====<br /><br /><ul> <li>CURRENT_TIME</li> <li>LOWER</li> <li>UPPER</li> <li>TRIM</li> <li>STRING_CAST</li></ul><br /><br />2 args:<br />=====<br /><br /><ul> <li>CHAR_AT</li> <li>SUBSTR_1ARG (substr(string, start))</li> <li>CONCAT</li> <li>TRIM</li> <li>STRING_CAST</li></ul><br /><br />3 args:<br />=====<br /><br /><ul> <li>SUBSTR_2ARGS (substr(string, start, length))</li></ul>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateBRERuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var breRule = new ModelBreRule(); // ModelBreRule | The BRE rule object (optional) 

            try
            {
                // Create a rule
                ModelBreRule result = apiInstance.CreateBRERule(breRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.CreateBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breRule** | [**ModelBreRule**](ModelBreRule.md)| The BRE rule object | [optional] 

### Return type

[**ModelBreRule**](ModelBreRule.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrerule"></a>
# **DeleteBRERule**
> void DeleteBRERule (string id)

Delete a rule

May fail if there are existing rules against it. Cannot delete core rules

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteBRERuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Delete a rule
                apiInstance.DeleteBRERule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.DeleteBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreexpressionasstring"></a>
# **GetBREExpressionAsString**
> string GetBREExpressionAsString (ModelExpressionobject expression)

Returns a string representation of the provided expression

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBREExpressionAsStringExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var expression = new ModelExpressionobject(); // ModelExpressionobject | The expression (optional) 

            try
            {
                // Returns a string representation of the provided expression
                string result = apiInstance.GetBREExpressionAsString(expression);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.GetBREExpressionAsString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expression** | [**ModelExpressionobject**](ModelExpressionobject.md)| The expression | [optional] 

### Return type

**string**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrerule"></a>
# **GetBRERule**
> ModelBreRule GetBRERule (string id)

Get a single rule

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRERuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule

            try
            {
                // Get a single rule
                ModelBreRule result = apiInstance.GetBRERule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.GetBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 

### Return type

[**ModelBreRule**](ModelBreRule.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrerules"></a>
# **GetBRERules**
> ModelPageResourceBreRule GetBRERules (string filterName, bool? filterEnabled, bool? filterSystem, string filterTrigger, string filterAction, string filterCondition, int? size, int? page)

List rules

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetBRERulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var filterName = filterName_example;  // string | Filter for rules containing the given name (optional) 
            var filterEnabled = true;  // bool? | Filter for rules by active status, null for both (optional)  (default to null)
            var filterSystem = true;  // bool? | Filter for rules that are system rules when true, or not when false. Leave off for both mixed (optional) 
            var filterTrigger = filterTrigger_example;  // string | Filter for rules that are for the trigger with the given name (optional) 
            var filterAction = filterAction_example;  // string | Filter for rules that use the action with the given name (optional) 
            var filterCondition = filterCondition_example;  // string | Filter for rules that have a condition containing the given string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List rules
                ModelPageResourceBreRule result = apiInstance.GetBRERules(filterName, filterEnabled, filterSystem, filterTrigger, filterAction, filterCondition, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.GetBRERules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterName** | **string**| Filter for rules containing the given name | [optional] 
 **filterEnabled** | **bool?**| Filter for rules by active status, null for both | [optional] [default to null]
 **filterSystem** | **bool?**| Filter for rules that are system rules when true, or not when false. Leave off for both mixed | [optional] 
 **filterTrigger** | **string**| Filter for rules that are for the trigger with the given name | [optional] 
 **filterAction** | **string**| Filter for rules that use the action with the given name | [optional] 
 **filterCondition** | **string**| Filter for rules that have a condition containing the given string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelPageResourceBreRule**](ModelPageResourceBreRule.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbrerule"></a>
# **SetBRERule**
> void SetBRERule (string id, ModelBooleanResource enabled)

Enable or disable a rule

This is helpful for turning off systems rules which cannot be deleted or modified otherwise

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetBRERuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule
            var enabled = new ModelBooleanResource(); // ModelBooleanResource | The boolean value (optional) 

            try
            {
                // Enable or disable a rule
                apiInstance.SetBRERule(id, enabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.SetBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **enabled** | [**ModelBooleanResource**](ModelBooleanResource.md)| The boolean value | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrerule"></a>
# **UpdateBRERule**
> ModelBreRule UpdateBRERule (string id, ModelBreRule breRule)

Update a rule

Cannot update system rules

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateBRERuleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineRulesApi();
            var id = id_example;  // string | The id of the rule
            var breRule = new ModelBreRule(); // ModelBreRule | The BRE rule object (optional) 

            try
            {
                // Update a rule
                ModelBreRule result = apiInstance.UpdateBRERule(id, breRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineRulesApi.UpdateBRERule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the rule | 
 **breRule** | [**ModelBreRule**](ModelBreRule.md)| The BRE rule object | [optional] 

### Return type

[**ModelBreRule**](ModelBreRule.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

