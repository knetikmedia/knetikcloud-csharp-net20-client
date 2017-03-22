# com.knetikcloud..DispositionsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDisposition**](DispositionsApi.md#adddisposition) | **POST** /dispositions | Add a new disposition
[**DeleteDisposition**](DispositionsApi.md#deletedisposition) | **DELETE** /dispositions/{id} | Delete a disposition
[**GetDisposition**](DispositionsApi.md#getdisposition) | **GET** /dispositions/{id} | Returns a disposition
[**GetDispositionCounts**](DispositionsApi.md#getdispositioncounts) | **GET** /dispositions/count | Returns a list of disposition counts
[**GetDispositions**](DispositionsApi.md#getdispositions) | **GET** /dispositions | Returns a page of dispositions


<a name="adddisposition"></a>
# **AddDisposition**
> ModelDispositionResource AddDisposition (ModelDispositionResource disposition)

Add a new disposition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddDispositionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DispositionsApi();
            var disposition = new ModelDispositionResource(); // ModelDispositionResource | The new disposition record (optional) 

            try
            {
                // Add a new disposition
                ModelDispositionResource result = apiInstance.AddDisposition(disposition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.AddDisposition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disposition** | [**ModelDispositionResource**](ModelDispositionResource.md)| The new disposition record | [optional] 

### Return type

[**ModelDispositionResource**](ModelDispositionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedisposition"></a>
# **DeleteDisposition**
> void DeleteDisposition (long? id)

Delete a disposition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteDispositionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DispositionsApi();
            var id = 789;  // long? | The id of the disposition record

            try
            {
                // Delete a disposition
                apiInstance.DeleteDisposition(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.DeleteDisposition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the disposition record | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdisposition"></a>
# **GetDisposition**
> ModelDispositionResource GetDisposition (long? id)

Returns a disposition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDispositionExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var id = 789;  // long? | The id of the disposition record

            try
            {
                // Returns a disposition
                ModelDispositionResource result = apiInstance.GetDisposition(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDisposition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the disposition record | 

### Return type

[**ModelDispositionResource**](ModelDispositionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositioncounts"></a>
# **GetDispositionCounts**
> List<ModelDispositionCount> GetDispositionCounts (string filterContext, string filterOwner)

Returns a list of disposition counts

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDispositionCountsExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var filterContext = filterContext_example;  // string | Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context=video:47 (optional) 
            var filterOwner = filterOwner_example;  // string | Filter for dispositions from a specific user by id or 'me' (optional) 

            try
            {
                // Returns a list of disposition counts
                List&lt;ModelDispositionCount&gt; result = apiInstance.GetDispositionCounts(filterContext, filterOwner);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDispositionCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterContext** | **string**| Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47 | [optional] 
 **filterOwner** | **string**| Filter for dispositions from a specific user by id or &#39;me&#39; | [optional] 

### Return type

[**List<ModelDispositionCount>**](ModelDispositionCount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdispositions"></a>
# **GetDispositions**
> ModelPageResourceDispositionResource GetDispositions (string filterContext, string filterOwner, int? size, int? page, string order)

Returns a page of dispositions

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDispositionsExample
    {
        public void main()
        {
            
            var apiInstance = new DispositionsApi();
            var filterContext = filterContext_example;  // string | Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context=video:47 (optional) 
            var filterOwner = filterOwner_example;  // string | Filter for dispositions from a specific user by id or 'me' (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Returns a page of dispositions
                ModelPageResourceDispositionResource result = apiInstance.GetDispositions(filterContext, filterOwner, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositionsApi.GetDispositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterContext** | **string**| Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47 | [optional] 
 **filterOwner** | **string**| Filter for dispositions from a specific user by id or &#39;me&#39; | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceDispositionResource**](ModelPageResourceDispositionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

