# com.knetikcloud..TemplatesPropertiesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTemplatePropertyType**](TemplatesPropertiesApi.md#gettemplatepropertytype) | **GET** /templates/properties/{type} | Get details for a template property type
[**GetTemplatePropertyTypes**](TemplatesPropertiesApi.md#gettemplatepropertytypes) | **GET** /templates/properties | List template property types


<a name="gettemplatepropertytype"></a>
# **GetTemplatePropertyType**
> ModelPropertyFieldListResource GetTemplatePropertyType (string type)

Get details for a template property type

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTemplatePropertyTypeExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesPropertiesApi();
            var type = type_example;  // string | type

            try
            {
                // Get details for a template property type
                ModelPropertyFieldListResource result = apiInstance.GetTemplatePropertyType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesPropertiesApi.GetTemplatePropertyType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| type | 

### Return type

[**ModelPropertyFieldListResource**](ModelPropertyFieldListResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatepropertytypes"></a>
# **GetTemplatePropertyTypes**
> List<ModelPropertyFieldListResource> GetTemplatePropertyTypes ()

List template property types

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTemplatePropertyTypesExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesPropertiesApi();

            try
            {
                // List template property types
                List&lt;ModelPropertyFieldListResource&gt; result = apiInstance.GetTemplatePropertyTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesPropertiesApi.GetTemplatePropertyTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelPropertyFieldListResource>**](ModelPropertyFieldListResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

