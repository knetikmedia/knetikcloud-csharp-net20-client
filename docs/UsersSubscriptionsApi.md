# com.knetikcloud..UsersSubscriptionsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserSubscriptionDetails**](UsersSubscriptionsApi.md#getusersubscriptiondetails) | **GET** /users/{user_id}/subscriptions/{inventory_id} | Get details about a user&#39;s subscription
[**GetUsersSubscriptionDetails**](UsersSubscriptionsApi.md#getuserssubscriptiondetails) | **GET** /users/{user_id}/subscriptions | Get details about a user&#39;s subscriptions
[**ReactivateUserSubscription**](UsersSubscriptionsApi.md#reactivateusersubscription) | **POST** /users/{user_id}/subscriptions/{inventory_id}/reactivate | Reactivate a subscription and charge fee
[**SetSubscriptionBillDate**](UsersSubscriptionsApi.md#setsubscriptionbilldate) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/bill-date | Set a new date to bill a subscription on
[**SetSubscriptionPaymentMethod**](UsersSubscriptionsApi.md#setsubscriptionpaymentmethod) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/payment-method | Set the payment method to use for a subscription
[**SetSubscriptionStatus**](UsersSubscriptionsApi.md#setsubscriptionstatus) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/status | Set the status of a subscription
[**SetUserSubscriptionPlan**](UsersSubscriptionsApi.md#setusersubscriptionplan) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/plan | Set a new subscription plan for a user
[**SetUserSubscriptionPrice**](UsersSubscriptionsApi.md#setusersubscriptionprice) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/price-override | Set a new subscription price for a user


<a name="getusersubscriptiondetails"></a>
# **GetUserSubscriptionDetails**
> InventorySubscriptionResource GetUserSubscriptionDetails (int? userId, int? inventoryId)

Get details about a user's subscription

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserSubscriptionDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory

            try
            {
                // Get details about a user's subscription
                InventorySubscriptionResource result = apiInstance.GetUserSubscriptionDetails(userId, inventoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.GetUserSubscriptionDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 

### Return type

[**InventorySubscriptionResource**](InventorySubscriptionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserssubscriptiondetails"></a>
# **GetUsersSubscriptionDetails**
> List<InventorySubscriptionResource> GetUsersSubscriptionDetails (int? userId)

Get details about a user's subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUsersSubscriptionDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get details about a user's subscriptions
                List&lt;InventorySubscriptionResource&gt; result = apiInstance.GetUsersSubscriptionDetails(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.GetUsersSubscriptionDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 

### Return type

[**List<InventorySubscriptionResource>**](InventorySubscriptionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivateusersubscription"></a>
# **ReactivateUserSubscription**
> InvoiceResource ReactivateUserSubscription (int? userId, int? inventoryId, ReactivateSubscriptionRequest reactivateSubscriptionRequest)

Reactivate a subscription and charge fee

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ReactivateUserSubscriptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var reactivateSubscriptionRequest = new ReactivateSubscriptionRequest(); // ReactivateSubscriptionRequest | The reactivate subscription request object inventory (optional) 

            try
            {
                // Reactivate a subscription and charge fee
                InvoiceResource result = apiInstance.ReactivateUserSubscription(userId, inventoryId, reactivateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.ReactivateUserSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **reactivateSubscriptionRequest** | [**ReactivateSubscriptionRequest**](ReactivateSubscriptionRequest.md)| The reactivate subscription request object inventory | [optional] 

### Return type

[**InvoiceResource**](InvoiceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionbilldate"></a>
# **SetSubscriptionBillDate**
> void SetSubscriptionBillDate (int? userId, int? inventoryId, long? billDate)

Set a new date to bill a subscription on

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetSubscriptionBillDateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var billDate = 789;  // long? | The new bill date. Unix timestamp in seconds

            try
            {
                // Set a new date to bill a subscription on
                apiInstance.SetSubscriptionBillDate(userId, inventoryId, billDate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetSubscriptionBillDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **billDate** | **long?**| The new bill date. Unix timestamp in seconds | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionpaymentmethod"></a>
# **SetSubscriptionPaymentMethod**
> void SetSubscriptionPaymentMethod (int? userId, int? inventoryId, int? paymentMethodId)

Set the payment method to use for a subscription

May send null to use floating default

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetSubscriptionPaymentMethodExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var paymentMethodId = 56;  // int? | The id of the payment method (optional) 

            try
            {
                // Set the payment method to use for a subscription
                apiInstance.SetSubscriptionPaymentMethod(userId, inventoryId, paymentMethodId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetSubscriptionPaymentMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **paymentMethodId** | **int?**| The id of the payment method | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionstatus"></a>
# **SetSubscriptionStatus**
> void SetSubscriptionStatus (int? userId, int? inventoryId, string status)

Set the status of a subscription

The body is a json string (put in quotes) that should match a desired invoice status type. Note that the new status may be blocked if the system is not configured to allow the current status to be changed to the new, to enforce proper flow. The default options for statuses are shown below but may be altered for special use cases

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetSubscriptionStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var status = status_example;  // string | The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: ('current', 'canceled', 'stopped', 'payment_failed', 'suspended')

            try
            {
                // Set the status of a subscription
                apiInstance.SetSubscriptionStatus(userId, inventoryId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetSubscriptionStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **status** | **string**| The new status for the subscription. Actual options may differ from the indicated set if the invoice status type data has been altered.  Allowable values: (&#39;current&#39;, &#39;canceled&#39;, &#39;stopped&#39;, &#39;payment_failed&#39;, &#39;suspended&#39;) | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setusersubscriptionplan"></a>
# **SetUserSubscriptionPlan**
> void SetUserSubscriptionPlan (int? userId, int? inventoryId, string planId)

Set a new subscription plan for a user

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserSubscriptionPlanExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var planId = planId_example;  // string | The id of the new plan. Must be from the same subscription (optional) 

            try
            {
                // Set a new subscription plan for a user
                apiInstance.SetUserSubscriptionPlan(userId, inventoryId, planId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetUserSubscriptionPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **planId** | **string**| The id of the new plan. Must be from the same subscription | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setusersubscriptionprice"></a>
# **SetUserSubscriptionPrice**
> void SetUserSubscriptionPrice (int? userId, int? inventoryId, SubscriptionPriceOverrideRequest theOverrideDetails)

Set a new subscription price for a user

This new price will be what the user is charged at the begining of each new period. This override is specific to the current subscription and will not carry over if they end and later re-subscribe. It will persist if the plan is changed using the setUserSubscriptionPlan endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserSubscriptionPriceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersSubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var theOverrideDetails = new SubscriptionPriceOverrideRequest(); // SubscriptionPriceOverrideRequest | override (optional) 

            try
            {
                // Set a new subscription price for a user
                apiInstance.SetUserSubscriptionPrice(userId, inventoryId, theOverrideDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersSubscriptionsApi.SetUserSubscriptionPrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **inventoryId** | **int?**| The id of the user&#39;s inventory | 
 **theOverrideDetails** | [**SubscriptionPriceOverrideRequest**](SubscriptionPriceOverrideRequest.md)| override | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

