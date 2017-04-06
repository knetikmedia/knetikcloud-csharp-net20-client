# com.knetikcloud..MessagingApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendRawEmail**](MessagingApi.md#sendrawemail) | **POST** /messaging/raw-email | Send a raw email to one or more users
[**SendRawSMS**](MessagingApi.md#sendrawsms) | **POST** /messaging/raw-sms | Send a raw SMS
[**SendTemplatedEmail**](MessagingApi.md#sendtemplatedemail) | **POST** /messaging/templated-email | Send a templated email to one or more users
[**SendTemplatedSMS**](MessagingApi.md#sendtemplatedsms) | **POST** /messaging/templated-sms | Send a new templated SMS


<a name="sendrawemail"></a>
# **SendRawEmail**
> void SendRawEmail (ModelRawEmailResource rawEmailResource)

Send a raw email to one or more users

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawEmailResource = new ModelRawEmailResource(); // ModelRawEmailResource | The new raw email to be sent (optional) 

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
 **rawEmailResource** | [**ModelRawEmailResource**](ModelRawEmailResource.md)| The new raw email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendrawsms"></a>
# **SendRawSMS**
> void SendRawSMS (ModelRawSMSResource rawSMSResource)

Send a raw SMS

Sends a raw SMS text message to one or more users. User's without registered mobile numbers will be skipped.

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var rawSMSResource = new ModelRawSMSResource(); // ModelRawSMSResource | The new raw SMS to be sent (optional) 

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
 **rawSMSResource** | [**ModelRawSMSResource**](ModelRawSMSResource.md)| The new raw SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedemail"></a>
# **SendTemplatedEmail**
> void SendTemplatedEmail (ModelTemplateEmailResource messageResource)

Send a templated email to one or more users

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var messageResource = new ModelTemplateEmailResource(); // ModelTemplateEmailResource | The new template email to be sent (optional) 

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
 **messageResource** | [**ModelTemplateEmailResource**](ModelTemplateEmailResource.md)| The new template email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplatedsms"></a>
# **SendTemplatedSMS**
> void SendTemplatedSMS (ModelTemplateSMSResource templateSMSResource)

Send a new templated SMS

Sends a templated SMS text message to one or more users. User's without registered mobile numbers will be skipped.

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
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi();
            var templateSMSResource = new ModelTemplateSMSResource(); // ModelTemplateSMSResource | The new template SMS to be sent (optional) 

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
 **templateSMSResource** | [**ModelTemplateSMSResource**](ModelTemplateSMSResource.md)| The new template SMS to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
