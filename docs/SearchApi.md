# com.knetikcloud..SearchApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchCountGET**](SearchApi.md#searchcountget) | **GET** /search/count/{type} | Count matches with no template
[**SearchCountPOST**](SearchApi.md#searchcountpost) | **POST** /search/count/{type} | Count matches with no template
[**SearchCountWithTemplateGET**](SearchApi.md#searchcountwithtemplateget) | **GET** /search/count/{type}/{template} | Count matches with a template
[**SearchCountWithTemplatePOST**](SearchApi.md#searchcountwithtemplatepost) | **POST** /search/count/{type}/{template} | Count matches with a template
[**SearchDocumentGET**](SearchApi.md#searchdocumentget) | **GET** /search/documents/{type}/{id} | Get document with no template
[**SearchDocumentWithTemplateGET**](SearchApi.md#searchdocumentwithtemplateget) | **GET** /search/documents/{type}/{template}/{id} | Get document with a template
[**SearchExplainGET**](SearchApi.md#searchexplainget) | **GET** /search/explain/{type}/{id} | Explain matches with no template
[**SearchExplainPOST**](SearchApi.md#searchexplainpost) | **POST** /search/explain/{type}/{id} | Explain matches with no template
[**SearchExplainWithTemplateGET**](SearchApi.md#searchexplainwithtemplateget) | **GET** /search/explain/{type}/{template}/{id} | Explain matches with a template
[**SearchExplainWithTemplatePOST**](SearchApi.md#searchexplainwithtemplatepost) | **POST** /search/explain/{type}/{template}/{id} | Explain matches with a template
[**SearchIndex**](SearchApi.md#searchindex) | **POST** /search/index/{type} | Search an index with no template
[**SearchIndexGET**](SearchApi.md#searchindexget) | **GET** /search/index/{type} | Search an index with no template
[**SearchIndexWithTemplateGET**](SearchApi.md#searchindexwithtemplateget) | **GET** /search/index/{type}/{template} | Search an index with a template
[**SearchIndexWithTemplatePOST**](SearchApi.md#searchindexwithtemplatepost) | **POST** /search/index/{type}/{template} | Search an index with a template
[**SearchIndicesGET**](SearchApi.md#searchindicesget) | **GET** /search/indices | Get indices
[**SearchMappingsGET**](SearchApi.md#searchmappingsget) | **GET** /search/mappings/{type} | Get mapping with no template
[**SearchMappingsWithTemplateGET**](SearchApi.md#searchmappingswithtemplateget) | **GET** /search/mappings/{type}/{template} | Get mapping with a template
[**SearchValidateGET**](SearchApi.md#searchvalidateget) | **GET** /search/validate/{type} | Validate matches with no template
[**SearchValidatePOST**](SearchApi.md#searchvalidatepost) | **POST** /search/validate/{type} | Validate matches with no template
[**SearchValidateWithTemplateGET**](SearchApi.md#searchvalidatewithtemplateget) | **GET** /search/validate/{type}/{template} | Validate matches with a template
[**SearchValidateWithTemplatePOST**](SearchApi.md#searchvalidatewithtemplatepost) | **POST** /search/validate/{type}/{template} | Validate matches with a template


<a name="searchcountget"></a>
# **SearchCountGET**
> Object SearchCountGET (string type)

Count matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchCountGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Count matches with no template
                Object result = apiInstance.SearchCountGET(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCountGET: " + e.Message );
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

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcountpost"></a>
# **SearchCountPOST**
> Object SearchCountPOST (string type, Object query)

Count matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchCountPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Count matches with no template
                Object result = apiInstance.SearchCountPOST(type, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCountPOST: " + e.Message );
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

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcountwithtemplateget"></a>
# **SearchCountWithTemplateGET**
> Object SearchCountWithTemplateGET (string type, string template)

Count matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchCountWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template

            try
            {
                // Count matches with a template
                Object result = apiInstance.SearchCountWithTemplateGET(type, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCountWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcountwithtemplatepost"></a>
# **SearchCountWithTemplatePOST**
> Object SearchCountWithTemplatePOST (string type, string template, Object query)

Count matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchCountWithTemplatePOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Count matches with a template
                Object result = apiInstance.SearchCountWithTemplatePOST(type, template, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCountWithTemplatePOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 
 **query** | **Object**| The query to be used for the search | [optional] 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchdocumentget"></a>
# **SearchDocumentGET**
> Object SearchDocumentGET (string type, string id)

Get document with no template

This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchDocumentGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id

            try
            {
                // Get document with no template
                Object result = apiInstance.SearchDocumentGET(type, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchDocumentGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchdocumentwithtemplateget"></a>
# **SearchDocumentWithTemplateGET**
> Object SearchDocumentWithTemplateGET (string type, string id, string template)

Get document with a template

This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchDocumentWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id
            var template = template_example;  // string | The index template

            try
            {
                // Get document with a template
                Object result = apiInstance.SearchDocumentWithTemplateGET(type, id, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchDocumentWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchexplainget"></a>
# **SearchExplainGET**
> Object SearchExplainGET (string type, string id)

Explain matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchExplainGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id

            try
            {
                // Explain matches with no template
                Object result = apiInstance.SearchExplainGET(type, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchExplainGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchexplainpost"></a>
# **SearchExplainPOST**
> Object SearchExplainPOST (string type, string id, Object query)

Explain matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchExplainPOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Explain matches with no template
                Object result = apiInstance.SearchExplainPOST(type, id, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchExplainPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 
 **query** | **Object**| The query to be used for the search | [optional] 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchexplainwithtemplateget"></a>
# **SearchExplainWithTemplateGET**
> Object SearchExplainWithTemplateGET (string type, string id, string template)

Explain matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchExplainWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id
            var template = template_example;  // string | The index template

            try
            {
                // Explain matches with a template
                Object result = apiInstance.SearchExplainWithTemplateGET(type, id, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchExplainWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchexplainwithtemplatepost"></a>
# **SearchExplainWithTemplatePOST**
> Object SearchExplainWithTemplatePOST (string type, string id, string template, Object query)

Explain matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchExplainWithTemplatePOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var id = id_example;  // string | The index id
            var template = template_example;  // string | The index template
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Explain matches with a template
                Object result = apiInstance.SearchExplainWithTemplatePOST(type, id, template, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchExplainWithTemplatePOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **id** | **string**| The index id | 
 **template** | **string**| The index template | 
 **query** | **Object**| The query to be used for the search | [optional] 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindex"></a>
# **SearchIndex**
> Object SearchIndex (string type, Object query)

Search an index with no template

This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html'>API guide</a>

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Search an index with no template
                Object result = apiInstance.SearchIndex(type, query);
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

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindexget"></a>
# **SearchIndexGET**
> Object SearchIndexGET (string type)

Search an index with no template

This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchIndexGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Search an index with no template
                Object result = apiInstance.SearchIndexGET(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndexGET: " + e.Message );
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

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindexwithtemplateget"></a>
# **SearchIndexWithTemplateGET**
> Object SearchIndexWithTemplateGET (string type, string template)

Search an index with a template

This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchIndexWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template

            try
            {
                // Search an index with a template
                Object result = apiInstance.SearchIndexWithTemplateGET(type, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndexWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindexwithtemplatepost"></a>
# **SearchIndexWithTemplatePOST**
> Object SearchIndexWithTemplatePOST (string type, string template, Object query)

Search an index with a template

This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchIndexWithTemplatePOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Search an index with a template
                Object result = apiInstance.SearchIndexWithTemplatePOST(type, template, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndexWithTemplatePOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 
 **query** | **Object**| The query to be used for the search | [optional] 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchindicesget"></a>
# **SearchIndicesGET**
> Object SearchIndicesGET ()

Get indices

This is a 1 to 1 mapping of a ElasticSearch call to _cat/indices for indices.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchIndicesGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();

            try
            {
                // Get indices
                Object result = apiInstance.SearchIndicesGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIndicesGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchmappingsget"></a>
# **SearchMappingsGET**
> Object SearchMappingsGET (string type)

Get mapping with no template

This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchMappingsGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Get mapping with no template
                Object result = apiInstance.SearchMappingsGET(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchMappingsGET: " + e.Message );
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

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchmappingswithtemplateget"></a>
# **SearchMappingsWithTemplateGET**
> Object SearchMappingsWithTemplateGET (string type, string template)

Get mapping with a template

This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchMappingsWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template

            try
            {
                // Get mapping with a template
                Object result = apiInstance.SearchMappingsWithTemplateGET(type, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchMappingsWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvalidateget"></a>
# **SearchValidateGET**
> Object SearchValidateGET (string type)

Validate matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchValidateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type

            try
            {
                // Validate matches with no template
                Object result = apiInstance.SearchValidateGET(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchValidateGET: " + e.Message );
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

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvalidatepost"></a>
# **SearchValidatePOST**
> Object SearchValidatePOST (string type, Object query)

Validate matches with no template

This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchValidatePOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Validate matches with no template
                Object result = apiInstance.SearchValidatePOST(type, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchValidatePOST: " + e.Message );
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

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvalidatewithtemplateget"></a>
# **SearchValidateWithTemplateGET**
> Object SearchValidateWithTemplateGET (string type, string template)

Validate matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchValidateWithTemplateGETExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template

            try
            {
                // Validate matches with a template
                Object result = apiInstance.SearchValidateWithTemplateGET(type, template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchValidateWithTemplateGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvalidatewithtemplatepost"></a>
# **SearchValidateWithTemplatePOST**
> Object SearchValidateWithTemplatePOST (string type, string template, Object query)

Validate matches with a template

This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their <a href='https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html'>API guide</a>

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SearchValidateWithTemplatePOSTExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var type = type_example;  // string | The index type
            var template = template_example;  // string | The index template
            var query = ;  // Object | The query to be used for the search (optional) 

            try
            {
                // Validate matches with a template
                Object result = apiInstance.SearchValidateWithTemplatePOST(type, template, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchValidateWithTemplatePOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The index type | 
 **template** | **string**| The index template | 
 **query** | **Object**| The query to be used for the search | [optional] 

### Return type

**Object**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

