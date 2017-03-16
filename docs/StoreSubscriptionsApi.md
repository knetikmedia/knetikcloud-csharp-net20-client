# com.knetikcloud..StoreSubscriptionsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](StoreSubscriptionsApi.md#createsubscription) | **POST** /subscriptions | Creates a subscription item and associated plans
[**CreateSubscriptionTemplate**](StoreSubscriptionsApi.md#createsubscriptiontemplate) | **POST** /subscriptions/templates | Create a subscription template
[**DeleteSubscription**](StoreSubscriptionsApi.md#deletesubscription) | **DELETE** /subscriptions/{id}/plans/{plan_id} | Delete a subscription plan
[**DeleteSubscriptionTemplate**](StoreSubscriptionsApi.md#deletesubscriptiontemplate) | **DELETE** /subscriptions/templates/{id} | Delete a subscription template
[**GetSubscription**](StoreSubscriptionsApi.md#getsubscription) | **GET** /subscriptions/{id} | Retrieve a single subscription item and associated plans
[**GetSubscriptionTemplate**](StoreSubscriptionsApi.md#getsubscriptiontemplate) | **GET** /subscriptions/templates/{id} | Get a single subscription template
[**GetSubscriptionTemplates**](StoreSubscriptionsApi.md#getsubscriptiontemplates) | **GET** /subscriptions/templates | List and search subscription templates
[**GetSubscriptions**](StoreSubscriptionsApi.md#getsubscriptions) | **GET** /subscriptions | List available subscription items and associated plans
[**ProcessSubscriptions**](StoreSubscriptionsApi.md#processsubscriptions) | **POST** /subscriptions/process | Processes subscriptions and charge dues
[**UpdateSubscription**](StoreSubscriptionsApi.md#updatesubscription) | **PUT** /subscriptions/{id} | Updates a subscription item and associated plans
[**UpdateSubscriptionTemplate**](StoreSubscriptionsApi.md#updatesubscriptiontemplate) | **PUT** /subscriptions/templates/{id} | Update a subscription template


<a name="createsubscription"></a>
# **CreateSubscription**
> SubscriptionResource CreateSubscription (SubscriptionResource subscriptionResource)

Creates a subscription item and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var subscriptionResource = new SubscriptionResource(); // SubscriptionResource | The subscription to be created (optional) 

            try
            {
                // Creates a subscription item and associated plans
                SubscriptionResource result = apiInstance.CreateSubscription(subscriptionResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionResource** | [**SubscriptionResource**](SubscriptionResource.md)| The subscription to be created | [optional] 

### Return type

[**SubscriptionResource**](SubscriptionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptiontemplate"></a>
# **CreateSubscriptionTemplate**
> SubscriptionTemplateResource CreateSubscriptionTemplate (SubscriptionTemplateResource subscriptionTemplateResource)

Create a subscription template

Subscription Templates define a type of subscription and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateSubscriptionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var subscriptionTemplateResource = new SubscriptionTemplateResource(); // SubscriptionTemplateResource | The new subscription template (optional) 

            try
            {
                // Create a subscription template
                SubscriptionTemplateResource result = apiInstance.CreateSubscriptionTemplate(subscriptionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.CreateSubscriptionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriptionTemplateResource** | [**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)| The new subscription template | [optional] 

### Return type

[**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (int? id, string planId)

Delete a subscription plan

Must not be locked or a migration target

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription
            var planId = planId_example;  // string | The id of the plan

            try
            {
                // Delete a subscription plan
                apiInstance.DeleteSubscription(id, planId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 
 **planId** | **string**| The id of the plan | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscriptiontemplate"></a>
# **DeleteSubscriptionTemplate**
> void DeleteSubscriptionTemplate (string id, string cascade)

Delete a subscription template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteSubscriptionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | force deleting the template if it's attached to other objects, cascade = detach (optional) 

            try
            {
                // Delete a subscription template
                apiInstance.DeleteSubscriptionTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.DeleteSubscriptionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> SubscriptionResource GetSubscription (int? id)

Retrieve a single subscription item and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription

            try
            {
                // Retrieve a single subscription item and associated plans
                SubscriptionResource result = apiInstance.GetSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 

### Return type

[**SubscriptionResource**](SubscriptionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiontemplate"></a>
# **GetSubscriptionTemplate**
> SubscriptionTemplateResource GetSubscriptionTemplate (string id)

Get a single subscription template

Subscription Templates define a type of subscription and the properties they have.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSubscriptionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single subscription template
                SubscriptionTemplateResource result = apiInstance.GetSubscriptionTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 

### Return type

[**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptiontemplates"></a>
# **GetSubscriptionTemplates**
> PageResourceSubscriptionTemplateResource GetSubscriptionTemplates (int? size, int? page, string order)

List and search subscription templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSubscriptionTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search subscription templates
                PageResourceSubscriptionTemplateResource result = apiInstance.GetSubscriptionTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptionTemplates: " + e.Message );
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

[**PageResourceSubscriptionTemplateResource**](PageResourceSubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptions"></a>
# **GetSubscriptions**
> PageResourceSubscriptionResource GetSubscriptions (int? size, int? page, string order)

List available subscription items and associated plans

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public void main()
        {
            
            var apiInstance = new StoreSubscriptionsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List available subscription items and associated plans
                PageResourceSubscriptionResource result = apiInstance.GetSubscriptions(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.GetSubscriptions: " + e.Message );
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

[**PageResourceSubscriptionResource**](PageResourceSubscriptionResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processsubscriptions"></a>
# **ProcessSubscriptions**
> void ProcessSubscriptions ()

Processes subscriptions and charge dues

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ProcessSubscriptionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();

            try
            {
                // Processes subscriptions and charge dues
                apiInstance.ProcessSubscriptions();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.ProcessSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscription"></a>
# **UpdateSubscription**
> void UpdateSubscription (int? id, SubscriptionResource subscriptionResource)

Updates a subscription item and associated plans

Will not remove plans left out

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = 56;  // int? | The id of the subscription
            var subscriptionResource = new SubscriptionResource(); // SubscriptionResource | The subscription resource object (optional) 

            try
            {
                // Updates a subscription item and associated plans
                apiInstance.UpdateSubscription(id, subscriptionResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.UpdateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the subscription | 
 **subscriptionResource** | [**SubscriptionResource**](SubscriptionResource.md)| The subscription resource object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscriptiontemplate"></a>
# **UpdateSubscriptionTemplate**
> SubscriptionTemplateResource UpdateSubscriptionTemplate (string id, SubscriptionTemplateResource subscriptionTemplateResource)

Update a subscription template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateSubscriptionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoreSubscriptionsApi();
            var id = id_example;  // string | The id of the template
            var subscriptionTemplateResource = new SubscriptionTemplateResource(); // SubscriptionTemplateResource | The subscription template resource object (optional) 

            try
            {
                // Update a subscription template
                SubscriptionTemplateResource result = apiInstance.UpdateSubscriptionTemplate(id, subscriptionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreSubscriptionsApi.UpdateSubscriptionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **subscriptionTemplateResource** | [**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)| The subscription template resource object | [optional] 

### Return type

[**SubscriptionTemplateResource**](SubscriptionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

