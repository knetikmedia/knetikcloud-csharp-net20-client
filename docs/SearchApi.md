# com.knetikcloud..SearchApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchIndex**](SearchApi.md#searchindex) | **POST** /search/index/{type} | Search an index


<a name="searchindex"></a>
# **SearchIndex**
> PageResourceMapstringobject SearchIndex (string type, Object query, int? size, int? page)

Search an index

The body is an ElasticSearch query in JSON format. Please see their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html'>documentation</a> for details on the format and search options. The searchable object's format depends on on the type but mostly matches the resource from it's main endpoint. Exceptions include referenced objects (like user) being replaced with the full user resource to allow deeper searching.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchIndexExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 
            var size = 56;  // int? | The number of documents returned per page (optional)  (default to 25)
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
 **size** | **int?**| The number of documents returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceMapstringobject**](PageResourceMapstringobject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

