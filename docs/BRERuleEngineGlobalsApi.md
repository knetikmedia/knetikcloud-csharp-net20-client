# IO.Swagger..BRERuleEngineGlobalsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBREGlobal**](BRERuleEngineGlobalsApi.md#createbreglobal) | **POST** /bre/globals/definitions | Create a global definition
[**DeleteBREGlobal**](BRERuleEngineGlobalsApi.md#deletebreglobal) | **DELETE** /bre/globals/definitions/{id} | Delete a global
[**GetBREGlobal**](BRERuleEngineGlobalsApi.md#getbreglobal) | **GET** /bre/globals/definitions/{id} | Get a single global definition
[**GetBREGlobals**](BRERuleEngineGlobalsApi.md#getbreglobals) | **GET** /bre/globals/definitions | List global definitions
[**UpdateBREGlobal**](BRERuleEngineGlobalsApi.md#updatebreglobal) | **PUT** /bre/globals/definitions/{id} | Update a global definition


<a name="createbreglobal"></a>
# **CreateBREGlobal**
> BreGlobalResource CreateBREGlobal (BreGlobalResource breGlobalResource)

Create a global definition

Once created you can then use in a custom rule. Note that global definitions cannot be modified or deleted if in use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBREGlobalExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineGlobalsApi();
            var breGlobalResource = new BreGlobalResource(); // BreGlobalResource | The BRE global resource object (optional) 

            try
            {
                // Create a global definition
                BreGlobalResource result = apiInstance.CreateBREGlobal(breGlobalResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.CreateBREGlobal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breGlobalResource** | [**BreGlobalResource**](BreGlobalResource.md)| The BRE global resource object | [optional] 

### Return type

[**BreGlobalResource**](BreGlobalResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebreglobal"></a>
# **DeleteBREGlobal**
> void DeleteBREGlobal (string id)

Delete a global

May fail if there are existing rules against it. Cannot delete core globals

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBREGlobalExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition

            try
            {
                // Delete a global
                apiInstance.DeleteBREGlobal(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.DeleteBREGlobal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreglobal"></a>
# **GetBREGlobal**
> BreGlobalResource GetBREGlobal (string id)

Get a single global definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBREGlobalExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition

            try
            {
                // Get a single global definition
                BreGlobalResource result = apiInstance.GetBREGlobal(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.GetBREGlobal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 

### Return type

[**BreGlobalResource**](BreGlobalResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbreglobals"></a>
# **GetBREGlobals**
> PageResourceBreGlobalResource GetBREGlobals (bool? filterSystem, int? size, int? page)

List global definitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBREGlobalsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineGlobalsApi();
            var filterSystem = true;  // bool? | Filter for globals that are system globals when true, or not when false. Leave off for both mixed (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // List global definitions
                PageResourceBreGlobalResource result = apiInstance.GetBREGlobals(filterSystem, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.GetBREGlobals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSystem** | **bool?**| Filter for globals that are system globals when true, or not when false. Leave off for both mixed | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceBreGlobalResource**](PageResourceBreGlobalResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebreglobal"></a>
# **UpdateBREGlobal**
> BreGlobalResource UpdateBREGlobal (string id, BreGlobalResource breGlobalResource)

Update a global definition

May fail if new parameters mismatch requirements of existing rules. Cannot update core globals

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBREGlobalExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BRERuleEngineGlobalsApi();
            var id = id_example;  // string | The id of the global definition
            var breGlobalResource = new BreGlobalResource(); // BreGlobalResource | The BRE global resource object (optional) 

            try
            {
                // Update a global definition
                BreGlobalResource result = apiInstance.UpdateBREGlobal(id, breGlobalResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BRERuleEngineGlobalsApi.UpdateBREGlobal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the global definition | 
 **breGlobalResource** | [**BreGlobalResource**](BreGlobalResource.md)| The BRE global resource object | [optional] 

### Return type

[**BreGlobalResource**](BreGlobalResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

