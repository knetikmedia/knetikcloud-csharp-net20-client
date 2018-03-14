# com.knetikcloud..MessagingApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompileMessageTemplate**](MessagingApi.md#compilemessagetemplate) | **POST** /messaging/templates/compilations | Compile a message template
[**CreateMessageTemplate**](MessagingApi.md#createmessagetemplate) | **POST** /messaging/templates | Create a message template
[**DeleteMessageTemplate**](MessagingApi.md#deletemessagetemplate) | **DELETE** /messaging/templates/{id} | Delete an existing message template
[**GetMessageTemplate**](MessagingApi.md#getmessagetemplate) | **GET** /messaging/templates/{id} | Get a single message template
[**GetMessageTemplates**](MessagingApi.md#getmessagetemplates) | **GET** /messaging/templates | List and search message templates
[**SendMessage**](MessagingApi.md#sendmessage) | **POST** /messaging/message | Send a message
[**SendRawEmail**](MessagingApi.md#sendrawemail) | **POST** /messaging/raw-email | Send a raw email to one or more users
[**SendRawPush**](MessagingApi.md#sendrawpush) | **POST** /messaging/raw-push | Send a raw push notification
[**SendRawSMS**](MessagingApi.md#sendrawsms) | **POST** /messaging/raw-sms | Send a raw SMS
[**SendTemplatedEmail**](MessagingApi.md#sendtemplatedemail) | **POST** /messaging/templated-email | Send a templated email to one or more users
[**SendTemplatedPush**](MessagingApi.md#sendtemplatedpush) | **POST** /messaging/templated-push | Send a templated push notification
[**SendTemplatedSMS**](MessagingApi.md#sendtemplatedsms) | **POST** /messaging/templated-sms | Send a new templated SMS
[**SendWebsocket**](MessagingApi.md#sendwebsocket) | **POST** /messaging/websocket-message | Send a websocket message
[**UpdateMessageTemplate**](MessagingApi.md#updatemessagetemplate) | **PUT** /messaging/templates/{id} | Update an existing message template


<a name="compilemessagetemplate"></a>
# **CompileMessageTemplate**
> Dictionary<string, string> CompileMessageTemplate (MessageTemplateBulkRequest request)

Compile a message template

Processes a set of input data against the template and returnes the compiled result. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CompileMessageTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var request = new MessageTemplateBulkRequest(); // MessageTemplateBulkRequest | request (optional) 

            try
            {
                // Compile a message template
                Dictionary&lt;string, string&gt; result = apiInstance.CompileMessageTemplate(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CompileMessageTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MessageTemplateBulkRequest**](MessageTemplateBulkRequest.md)| request | [optional] 

### Return type

**Dictionary<string, string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmessagetemplate"></a>
# **CreateMessageTemplate**
> MessageTemplateResource CreateMessageTemplate (MessageTemplateResource messageTemplate)

Create a message template

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateMessageTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageTemplate = new MessageTemplateResource(); // MessageTemplateResource | The new template email to be sent (optional) 

            try
            {
                // Create a message template
                MessageTemplateResource result = apiInstance.CreateMessageTemplate(messageTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.CreateMessageTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageTemplate** | [**MessageTemplateResource**](MessageTemplateResource.md)| The new template email to be sent | [optional] 

### Return type

[**MessageTemplateResource**](MessageTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemessagetemplate"></a>
# **DeleteMessageTemplate**
> void DeleteMessageTemplate (string id)

Delete an existing message template

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteMessageTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var id = id_example;  // string | The message_template id

            try
            {
                // Delete an existing message template
                apiInstance.DeleteMessageTemplate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.DeleteMessageTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The message_template id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagetemplate"></a>
# **GetMessageTemplate**
> MessageTemplateResource GetMessageTemplate (string id)

Get a single message template

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetMessageTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var id = id_example;  // string | The message_template id

            try
            {
                // Get a single message template
                MessageTemplateResource result = apiInstance.GetMessageTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessageTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The message_template id | 

### Return type

[**MessageTemplateResource**](MessageTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagetemplates"></a>
# **GetMessageTemplates**
> PageResourceMessageTemplateResource GetMessageTemplates (string filterTagset, string filterTagIntersection, string filterTagExclusion, int? size, int? page, string order)

List and search message templates

Get a list of message templates with optional filtering. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetMessageTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var filterTagset = filterTagset_example;  // string | Filter for message templates with at least one of a specified set of tags (separated by comma) (optional) 
            var filterTagIntersection = filterTagIntersection_example;  // string | Filter for message templates with all of a specified set of tags (separated by comma) (optional) 
            var filterTagExclusion = filterTagExclusion_example;  // string | Filter for message templates with none of a specified set of tags (separated by comma) (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search message templates
                PageResourceMessageTemplateResource result = apiInstance.GetMessageTemplates(filterTagset, filterTagIntersection, filterTagExclusion, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessageTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTagset** | **string**| Filter for message templates with at least one of a specified set of tags (separated by comma) | [optional] 
 **filterTagIntersection** | **string**| Filter for message templates with all of a specified set of tags (separated by comma) | [optional] 
 **filterTagExclusion** | **string**| Filter for message templates with none of a specified set of tags (separated by comma) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceMessageTemplateResource**](PageResourceMessageTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessage"></a>
# **SendMessage**
> void SendMessage (MessageResource messageResource)

Send a message

Sends a message with one or more formats to one or more users. Fill in any message formats desired (email, sms, websockets) and each user will recieve all valid formats. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageResource = new MessageResource(); // MessageResource | The message to be sent (optional) 

            try
            {
                // Send a message
                apiInstance.SendMessage(messageResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageResource** | [**MessageResource**](MessageResource.md)| The message to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawemail"></a>
# **SendRawEmail**
> void SendRawEmail (RawEmailResource rawEmailResource)

Send a raw email to one or more users

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawEmailResource = new RawEmailResource(); // RawEmailResource | The new raw email to be sent (optional) 

            try
            {
                // Send a raw email to one or more users
                apiInstance.SendRawEmail(rawEmailResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawEmailResource** | [**RawEmailResource**](RawEmailResource.md)| The new raw email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawpush"></a>
# **SendRawPush**
> void SendRawPush (RawPushResource rawPushResource)

Send a raw push notification

Sends a raw push notification message to one or more users. User's without registered mobile device for the application will be skipped. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawPushExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawPushResource = new RawPushResource(); // RawPushResource | The new raw push notification to be sent (optional) 

            try
            {
                // Send a raw push notification
                apiInstance.SendRawPush(rawPushResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawPush: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawPushResource** | [**RawPushResource**](RawPushResource.md)| The new raw push notification to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawsms"></a>
# **SendRawSMS**
> void SendRawSMS (RawSMSResource rawSMSResource)

Send a raw SMS

Sends a raw SMS text message to one or more users. User's without registered mobile numbers will be skipped. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendRawSMSExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawSMSResource = new RawSMSResource(); // RawSMSResource | The new raw SMS to be sent (optional) 

            try
            {
                // Send a raw SMS
                apiInstance.SendRawSMS(rawSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendRawSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rawSMSResource** | [**RawSMSResource**](RawSMSResource.md)| The new raw SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedemail"></a>
# **SendTemplatedEmail**
> void SendTemplatedEmail (TemplateEmailResource messageResource)

Send a templated email to one or more users

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageResource = new TemplateEmailResource(); // TemplateEmailResource | The new template email to be sent (optional) 

            try
            {
                // Send a templated email to one or more users
                apiInstance.SendTemplatedEmail(messageResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageResource** | [**TemplateEmailResource**](TemplateEmailResource.md)| The new template email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedpush"></a>
# **SendTemplatedPush**
> void SendTemplatedPush (TemplatePushResource templatePushResource)

Send a templated push notification

Sends a templated push notification message to one or more users. User's without registered mobile device for the application will be skipped. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedPushExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templatePushResource = new TemplatePushResource(); // TemplatePushResource | The new templated push notification to be sent (optional) 

            try
            {
                // Send a templated push notification
                apiInstance.SendTemplatedPush(templatePushResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedPush: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templatePushResource** | [**TemplatePushResource**](TemplatePushResource.md)| The new templated push notification to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedsms"></a>
# **SendTemplatedSMS**
> void SendTemplatedSMS (TemplateSMSResource templateSMSResource)

Send a new templated SMS

Sends a templated SMS text message to one or more users. User's without registered mobile numbers will be skipped. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendTemplatedSMSExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templateSMSResource = new TemplateSMSResource(); // TemplateSMSResource | The new template SMS to be sent (optional) 

            try
            {
                // Send a new templated SMS
                apiInstance.SendTemplatedSMS(templateSMSResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendTemplatedSMS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateSMSResource** | [**TemplateSMSResource**](TemplateSMSResource.md)| The new template SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwebsocket"></a>
# **SendWebsocket**
> void SendWebsocket (WebsocketMessageResource websocketResource)

Send a websocket message

Sends a websocket message to one or more users. <br><br><b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SendWebsocketExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var websocketResource = new WebsocketMessageResource(); // WebsocketMessageResource | The new websocket message to be sent (optional) 

            try
            {
                // Send a websocket message
                apiInstance.SendWebsocket(websocketResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendWebsocket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **websocketResource** | [**WebsocketMessageResource**](WebsocketMessageResource.md)| The new websocket message to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessagetemplate"></a>
# **UpdateMessageTemplate**
> MessageTemplateResource UpdateMessageTemplate (string id, MessageTemplateResource messageTemplateResource)

Update an existing message template

<b>Permissions Needed:</b> MESSAGING_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateMessageTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var id = id_example;  // string | The message_template id
            var messageTemplateResource = new MessageTemplateResource(); // MessageTemplateResource | The message template (optional) 

            try
            {
                // Update an existing message template
                MessageTemplateResource result = apiInstance.UpdateMessageTemplate(id, messageTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.UpdateMessageTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The message_template id | 
 **messageTemplateResource** | [**MessageTemplateResource**](MessageTemplateResource.md)| The message template | [optional] 

### Return type

[**MessageTemplateResource**](MessageTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

