# com.knetikcloud..MessagingTopicsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisableTopicSubscriber**](MessagingTopicsApi.md#disabletopicsubscriber) | **PUT** /messaging/topics/{id}/subscribers/{user_id}/disabled | Enable or disable messages for a user
[**GetTopicSubscriber**](MessagingTopicsApi.md#gettopicsubscriber) | **GET** /messaging/topics/{id}/subscribers/{user_id} | Get a subscriber to a topic
[**GetTopicSubscribers**](MessagingTopicsApi.md#gettopicsubscribers) | **GET** /messaging/topics/{id}/subscribers | Get all subscribers to a topic
[**GetUserTopics**](MessagingTopicsApi.md#getusertopics) | **GET** /users/{id}/topics | Get all messaging topics for a given user


<a name="disabletopicsubscriber"></a>
# **DisableTopicSubscriber**
> void DisableTopicSubscriber (string id, string userId, ValueWrapperboolean disabled)

Enable or disable messages for a user

Useful for opt-out options on a single topic. Consider multiple topics for multiple opt-out options.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DisableTopicSubscriberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingTopicsApi();
            var id = id_example;  // string | The id of the topic
            var userId = userId_example;  // string | The id of the subscriber or 'me'
            var disabled = new ValueWrapperboolean(); // ValueWrapperboolean | disabled

            try
            {
                // Enable or disable messages for a user
                apiInstance.DisableTopicSubscriber(id, userId, disabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingTopicsApi.DisableTopicSubscriber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the topic | 
 **userId** | **string**| The id of the subscriber or &#39;me&#39; | 
 **disabled** | [**ValueWrapperboolean**](ValueWrapperboolean.md)| disabled | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettopicsubscriber"></a>
# **GetTopicSubscriber**
> TopicSubscriberResource GetTopicSubscriber (string id, string userId)

Get a subscriber to a topic

<b>Permissions Needed:</b> TOPICS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTopicSubscriberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingTopicsApi();
            var id = id_example;  // string | The id of the topic
            var userId = userId_example;  // string | The id of the subscriber or 'me'

            try
            {
                // Get a subscriber to a topic
                TopicSubscriberResource result = apiInstance.GetTopicSubscriber(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingTopicsApi.GetTopicSubscriber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the topic | 
 **userId** | **string**| The id of the subscriber or &#39;me&#39; | 

### Return type

[**TopicSubscriberResource**](TopicSubscriberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettopicsubscribers"></a>
# **GetTopicSubscribers**
> PageResourceTopicSubscriberResource GetTopicSubscribers (string id)

Get all subscribers to a topic

<b>Permissions Needed:</b> TOPICS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetTopicSubscribersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingTopicsApi();
            var id = id_example;  // string | The id of the topic

            try
            {
                // Get all subscribers to a topic
                PageResourceTopicSubscriberResource result = apiInstance.GetTopicSubscribers(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingTopicsApi.GetTopicSubscribers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the topic | 

### Return type

[**PageResourceTopicSubscriberResource**](PageResourceTopicSubscriberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusertopics"></a>
# **GetUserTopics**
> PageResourceTopicResource GetUserTopics (string id)

Get all messaging topics for a given user

<b>Permissions Needed:</b> TOPICS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserTopicsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingTopicsApi();
            var id = id_example;  // string | The id of the user or 'me'

            try
            {
                // Get all messaging topics for a given user
                PageResourceTopicResource result = apiInstance.GetUserTopics(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingTopicsApi.GetUserTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 

### Return type

[**PageResourceTopicResource**](PageResourceTopicResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

