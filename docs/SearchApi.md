# IO.Swagger..SearchApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSearchIndex**](SearchApi.md#addsearchindex) | **POST** /search/index/{type}/{id} | Add a new object to an index
[**AddSearchMappings**](SearchApi.md#addsearchmappings) | **POST** /search/mappings | Register reference mappings
[**DeleteSearchIndex**](SearchApi.md#deletesearchindex) | **DELETE** /search/index/{type}/{id} | Delete an object
[**DeleteSearchIndexes**](SearchApi.md#deletesearchindexes) | **DELETE** /search/index/{type} | Delete all objects in an index
[**SearchIndex**](SearchApi.md#searchindex) | **POST** /search/index/{type} | Search an index


<a name="addsearchindex"></a>
# **AddSearchIndex**
> void AddSearchIndex (string type, string id, Object _object)

Add a new object to an index

Mainly intended for internal use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddSearchIndexExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The ID of the object
            var _object = ;  // Object | The object to add (optional) 

            try
            {
                // Add a new object to an index
                apiInstance.AddSearchIndex(type, id, _object);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.AddSearchIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The ID of the object | 
 **_object** | **Object**| The object to add | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsearchmappings"></a>
# **AddSearchMappings**
> void AddSearchMappings (List<SearchReferenceMapping> mappings)

Register reference mappings

Add a new type mapping to connect data from one index to another, or discover an exsting one. Mainly intended for internal use.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddSearchMappingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var mappings = new List<SearchReferenceMapping>(); // List<SearchReferenceMapping> | The mappings to add (optional) 

            try
            {
                // Register reference mappings
                apiInstance.AddSearchMappings(mappings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.AddSearchMappings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mappings** | [**List<SearchReferenceMapping>**](SearchReferenceMapping.md)| The mappings to add | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesearchindex"></a>
# **DeleteSearchIndex**
> void DeleteSearchIndex (string type, string id)

Delete an object

Mainly intended for internal use. Requires SEARCH_ADMIN.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSearchIndexExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The ID of the object to delete

            try
            {
                // Delete an object
                apiInstance.DeleteSearchIndex(type, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.DeleteSearchIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The ID of the object to delete | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesearchindexes"></a>
# **DeleteSearchIndexes**
> void DeleteSearchIndexes (string type)

Delete all objects in an index

Mainly intended for internal use

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSearchIndexesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Delete all objects in an index
                apiInstance.DeleteSearchIndexes(type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.DeleteSearchIndexes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindex"></a>
# **SearchIndex**
> PageResourceMapstringobject SearchIndex (string type, Object query, int? size, int? page)

Search an index

The body is an ElasticSearch query in JSON format. Please see their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html'>documentation</a> for details on the format and search options. The searchable object's format depends on on the type. See individual search endpoints on other resources for details on their format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchIndexExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Search an index
                PageResourceMapstringobject result = apiInstance.SearchIndex(type, query, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **query** | **Object**| The query to be used for the search | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceMapstringobject**](PageResourceMapstringobject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

