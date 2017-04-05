# com.knetikcloud..CampaignsRewardsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRewardSet**](CampaignsRewardsApi.md#createrewardset) | **POST** /rewards | Create a reward set
[**DeleteRewardSet**](CampaignsRewardsApi.md#deleterewardset) | **DELETE** /rewards/{id} | Delete a reward set
[**GetRewardSet**](CampaignsRewardsApi.md#getrewardset) | **GET** /rewards/{id} | Get a single reward set
[**GetRewardSets**](CampaignsRewardsApi.md#getrewardsets) | **GET** /rewards | List and search reward sets
[**UpdateRewardSet**](CampaignsRewardsApi.md#updaterewardset) | **PUT** /rewards/{id} | Update a reward set


<a name="createrewardset"></a>
# **CreateRewardSet**
> ModelRewardSetResource CreateRewardSet (ModelRewardSetResource rewardSetResource)

Create a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateRewardSetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var rewardSetResource = new ModelRewardSetResource(); // ModelRewardSetResource | The reward set resource object (optional) 

            try
            {
                // Create a reward set
                ModelRewardSetResource result = apiInstance.CreateRewardSet(rewardSetResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.CreateRewardSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rewardSetResource** | [**ModelRewardSetResource**](ModelRewardSetResource.md)| The reward set resource object | [optional] 

### Return type

[**ModelRewardSetResource**](ModelRewardSetResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterewardset"></a>
# **DeleteRewardSet**
> void DeleteRewardSet (int? id)

Delete a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteRewardSetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id

            try
            {
                // Delete a reward set
                apiInstance.DeleteRewardSet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.DeleteRewardSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrewardset"></a>
# **GetRewardSet**
> ModelRewardSetResource GetRewardSet (int? id)

Get a single reward set

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRewardSetExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id

            try
            {
                // Get a single reward set
                ModelRewardSetResource result = apiInstance.GetRewardSet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.GetRewardSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 

### Return type

[**ModelRewardSetResource**](ModelRewardSetResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrewardsets"></a>
# **GetRewardSets**
> ModelPageResourceRewardSetResource GetRewardSets (int? size, int? page, string order)

List and search reward sets

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRewardSetsExample
    {
        public void main()
        {
            
            var apiInstance = new CampaignsRewardsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search reward sets
                ModelPageResourceRewardSetResource result = apiInstance.GetRewardSets(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.GetRewardSets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceRewardSetResource**](ModelPageResourceRewardSetResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterewardset"></a>
# **UpdateRewardSet**
> ModelRewardSetResource UpdateRewardSet (int? id, ModelRewardSetResource rewardSetResource)

Update a reward set

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateRewardSetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsRewardsApi();
            var id = 56;  // int? | The reward id
            var rewardSetResource = new ModelRewardSetResource(); // ModelRewardSetResource | The reward set resource object (optional) 

            try
            {
                // Update a reward set
                ModelRewardSetResource result = apiInstance.UpdateRewardSet(id, rewardSetResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsRewardsApi.UpdateRewardSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The reward id | 
 **rewardSetResource** | [**ModelRewardSetResource**](ModelRewardSetResource.md)| The reward set resource object | [optional] 

### Return type

[**ModelRewardSetResource**](ModelRewardSetResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

