# com.knetikcloud..NotificationsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNotificationType**](NotificationsApi.md#createnotificationtype) | **POST** /notifications/types | Create a notification type
[**DeleteNotificationType**](NotificationsApi.md#deletenotificationtype) | **DELETE** /notifications/types/{id} | Delete a notification type
[**GetNotificationType**](NotificationsApi.md#getnotificationtype) | **GET** /notifications/types/{id} | Get a single notification type
[**GetNotificationTypes**](NotificationsApi.md#getnotificationtypes) | **GET** /notifications/types | List and search notification types
[**GetUserNotificationInfo**](NotificationsApi.md#getusernotificationinfo) | **GET** /users/{user_id}/notifications/types/{type_id} | View a user&#39;s notification settings for a type
[**GetUserNotificationInfoList**](NotificationsApi.md#getusernotificationinfolist) | **GET** /users/{user_id}/notifications/types | View a user&#39;s notification settings
[**GetUserNotifications**](NotificationsApi.md#getusernotifications) | **GET** /users/{id}/notifications | Get notifications
[**SendNotification**](NotificationsApi.md#sendnotification) | **POST** /notifications | Send a notification
[**SetUserNotificationStatus**](NotificationsApi.md#setusernotificationstatus) | **PUT** /users/{user_id}/notifications/{notification_id}/status | Set notification status
[**SilenceDirectNotifications**](NotificationsApi.md#silencedirectnotifications) | **PUT** /users/{user_id}/notifications/types/{type_id}/silenced | Enable or disable direct notifications for a user
[**UpdateNotificationType**](NotificationsApi.md#updatenotificationtype) | **PUT** /notifications/types/{id} | Update a notificationType


<a name="createnotificationtype"></a>
# **CreateNotificationType**
> NotificationTypeResource CreateNotificationType (NotificationTypeResource notificationType)

Create a notification type

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateNotificationTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var notificationType = new NotificationTypeResource(); // NotificationTypeResource | notificationType (optional) 

            try
            {
                // Create a notification type
                NotificationTypeResource result = apiInstance.CreateNotificationType(notificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateNotificationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationType** | [**NotificationTypeResource**](NotificationTypeResource.md)| notificationType | [optional] 

### Return type

[**NotificationTypeResource**](NotificationTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenotificationtype"></a>
# **DeleteNotificationType**
> void DeleteNotificationType (string id)

Delete a notification type

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteNotificationTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | id

            try
            {
                // Delete a notification type
                apiInstance.DeleteNotificationType(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotificationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationtype"></a>
# **GetNotificationType**
> NotificationTypeResource GetNotificationType (string id)

Get a single notification type

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetNotificationTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | id

            try
            {
                // Get a single notification type
                NotificationTypeResource result = apiInstance.GetNotificationType(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**NotificationTypeResource**](NotificationTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationtypes"></a>
# **GetNotificationTypes**
> PageResourceNotificationTypeResource GetNotificationTypes (int? size, int? page, string order)

List and search notification types

Get a list of notification type with optional filtering. <br><br><b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetNotificationTypesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search notification types
                PageResourceNotificationTypeResource result = apiInstance.GetNotificationTypes(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationTypes: " + e.Message );
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

[**PageResourceNotificationTypeResource**](PageResourceNotificationTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernotificationinfo"></a>
# **GetUserNotificationInfo**
> NotificationUserTypeResource GetUserNotificationInfo (string typeId, string userId)

View a user's notification settings for a type

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserNotificationInfoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var typeId = typeId_example;  // string | The id of the topic
            var userId = userId_example;  // string | The id of the subscriber or 'me'

            try
            {
                // View a user's notification settings for a type
                NotificationUserTypeResource result = apiInstance.GetUserNotificationInfo(typeId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetUserNotificationInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **string**| The id of the topic | 
 **userId** | **string**| The id of the subscriber or &#39;me&#39; | 

### Return type

[**NotificationUserTypeResource**](NotificationUserTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernotificationinfolist"></a>
# **GetUserNotificationInfoList**
> PageResourceNotificationUserTypeResource GetUserNotificationInfoList (string userId, int? size, int? page, string order)

View a user's notification settings

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserNotificationInfoListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var userId = userId_example;  // string | The id of the subscriber or 'me'
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // View a user's notification settings
                PageResourceNotificationUserTypeResource result = apiInstance.GetUserNotificationInfoList(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetUserNotificationInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the subscriber or &#39;me&#39; | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceNotificationUserTypeResource**](PageResourceNotificationUserTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusernotifications"></a>
# **GetUserNotifications**
> PageResourceUserNotificationResource GetUserNotifications (string id, string filterStatus, int? size, int? page, string order)

Get notifications

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserNotificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | The id of the user or 'me'
            var filterStatus = filterStatus_example;  // string | filter for notifications with a given status (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get notifications
                PageResourceUserNotificationResource result = apiInstance.GetUserNotifications(id, filterStatus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetUserNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the user or &#39;me&#39; | 
 **filterStatus** | **string**| filter for notifications with a given status | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceUserNotificationResource**](PageResourceUserNotificationResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendnotification"></a>
# **SendNotification**
> NotificationResource SendNotification (NotificationResource notification)

Send a notification

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendNotificationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var notification = new NotificationResource(); // NotificationResource | notification (optional) 

            try
            {
                // Send a notification
                NotificationResource result = apiInstance.SendNotification(notification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.SendNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**NotificationResource**](NotificationResource.md)| notification | [optional] 

### Return type

[**NotificationResource**](NotificationResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setusernotificationstatus"></a>
# **SetUserNotificationStatus**
> void SetUserNotificationStatus (string userId, string notificationId, UserNotificationStatusWrapper notification)

Set notification status

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserNotificationStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var userId = userId_example;  // string | The id of the user or 'me'
            var notificationId = notificationId_example;  // string | The id of the notification
            var notification = new UserNotificationStatusWrapper(); // UserNotificationStatusWrapper | status (optional) 

            try
            {
                // Set notification status
                apiInstance.SetUserNotificationStatus(userId, notificationId, notification);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.SetUserNotificationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user or &#39;me&#39; | 
 **notificationId** | **string**| The id of the notification | 
 **notification** | [**UserNotificationStatusWrapper**](UserNotificationStatusWrapper.md)| status | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="silencedirectnotifications"></a>
# **SilenceDirectNotifications**
> void SilenceDirectNotifications (string typeId, string userId, ValueWrapperboolean silenced)

Enable or disable direct notifications for a user

Allows enabling or disabling messages for a given notification type when sent direct to the user. Notifications can still be retrieved by endpoint. For notifications broadcased to a topic, see the topic service to disable messages for the user there. <br><br><b>Permissions Needed:</b> NOTIFICATIONS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SilenceDirectNotificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var typeId = typeId_example;  // string | The id of the topic
            var userId = userId_example;  // string | The id of the subscriber or 'me'
            var silenced = new ValueWrapperboolean(); // ValueWrapperboolean | silenced

            try
            {
                // Enable or disable direct notifications for a user
                apiInstance.SilenceDirectNotifications(typeId, userId, silenced);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.SilenceDirectNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **string**| The id of the topic | 
 **userId** | **string**| The id of the subscriber or &#39;me&#39; | 
 **silenced** | [**ValueWrapperboolean**](ValueWrapperboolean.md)| silenced | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenotificationtype"></a>
# **UpdateNotificationType**
> NotificationTypeResource UpdateNotificationType (string id, NotificationTypeResource notificationType)

Update a notificationType

<b>Permissions Needed:</b> NOTIFICATIONS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateNotificationTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | id
            var notificationType = new NotificationTypeResource(); // NotificationTypeResource | notificationType (optional) 

            try
            {
                // Update a notificationType
                NotificationTypeResource result = apiInstance.UpdateNotificationType(id, notificationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateNotificationType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 
 **notificationType** | [**NotificationTypeResource**](NotificationTypeResource.md)| notificationType | [optional] 

### Return type

[**NotificationTypeResource**](NotificationTypeResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

