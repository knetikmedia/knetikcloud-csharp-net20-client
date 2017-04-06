# com.knetikcloud..GamificationLeaderboardsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLeaderboard**](GamificationLeaderboardsApi.md#getleaderboard) | **GET** /leaderboards/{context_type}/{context_id} | Retrieves leaderboard details and paginated entries
[**GetLeaderboardRank**](GamificationLeaderboardsApi.md#getleaderboardrank) | **GET** /leaderboards/{context_type}/{context_id}/users/{id}/rank | Retrieves a specific user entry with rank
[**GetLeaderboardStrategies**](GamificationLeaderboardsApi.md#getleaderboardstrategies) | **GET** /leaderboards/strategies | Get a list of available leaderboard strategy names


<a name="getleaderboard"></a>
# **GetLeaderboard**
> ModelLeaderboardResource GetLeaderboard (string contextType, string contextId, int? size, int? page)

Retrieves leaderboard details and paginated entries

The context type identifies the type of entity (i.e., 'activity') being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLeaderboardExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationLeaderboardsApi();
            var contextType = contextType_example;  // string | The context type for the leaderboard
            var contextId = contextId_example;  // string | The context id for the leaderboard
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Retrieves leaderboard details and paginated entries
                ModelLeaderboardResource result = apiInstance.GetLeaderboard(contextType, contextId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetLeaderboard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextType** | **string**| The context type for the leaderboard | 
 **contextId** | **string**| The context id for the leaderboard | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**ModelLeaderboardResource**](ModelLeaderboardResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getleaderboardrank"></a>
# **GetLeaderboardRank**
> ModelLeaderboardEntryResource GetLeaderboardRank (string contextType, string contextId, string id)

Retrieves a specific user entry with rank

The context type identifies the type of entity (i.e., 'activity') being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLeaderboardRankExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationLeaderboardsApi();
            var contextType = contextType_example;  // string | The context type for the leaderboard
            var contextId = contextId_example;  // string | The context id for the leaderboard
            var id = id_example;  // string | The id of a user

            try
            {
                // Retrieves a specific user entry with rank
                ModelLeaderboardEntryResource result = apiInstance.GetLeaderboardRank(contextType, contextId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetLeaderboardRank: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contextType** | **string**| The context type for the leaderboard | 
 **contextId** | **string**| The context id for the leaderboard | 
 **id** | **string**| The id of a user | 

### Return type

[**ModelLeaderboardEntryResource**](ModelLeaderboardEntryResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getleaderboardstrategies"></a>
# **GetLeaderboardStrategies**
> List<string> GetLeaderboardStrategies ()

Get a list of available leaderboard strategy names

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetLeaderboardStrategiesExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationLeaderboardsApi();

            try
            {
                // Get a list of available leaderboard strategy names
                List&lt;string&gt; result = apiInstance.GetLeaderboardStrategies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationLeaderboardsApi.GetLeaderboardStrategies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
