# com.knetikcloud..Users_SubscriptionsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserSubscriptionDetails**](Users_SubscriptionsApi.md#getusersubscriptiondetails) | **GET** /users/{user_id}/subscriptions/{inventory_id} | Get details about a user&#39;s subscription
[**GetUsersSubscriptionDetails**](Users_SubscriptionsApi.md#getuserssubscriptiondetails) | **GET** /users/{user_id}/subscriptions | Get details about a user&#39;s subscriptions
[**ReactivateUserSubscription**](Users_SubscriptionsApi.md#reactivateusersubscription) | **POST** /users/{user_id}/subscriptions/{inventory_id}/reactivate | Reactivate a subscription and charge fee
[**SetSubscriptionBillDate**](Users_SubscriptionsApi.md#setsubscriptionbilldate) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/bill-date | Set a new date to bill a subscription on
[**SetSubscriptionPaymentMethod**](Users_SubscriptionsApi.md#setsubscriptionpaymentmethod) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/payment-method | Set the payment method to use for a subscription
[**SetSubscriptionStatus**](Users_SubscriptionsApi.md#setsubscriptionstatus) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/status | Set the status of a subscription
[**SetUserSubscriptionPlan**](Users_SubscriptionsApi.md#setusersubscriptionplan) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/plan | Set a new subscription plan for a user
[**SetUserSubscriptionPrice**](Users_SubscriptionsApi.md#setusersubscriptionprice) | **PUT** /users/{user_id}/subscriptions/{inventory_id}/price-override | Set a new subscription price for a user


<a name="getusersubscriptiondetails"></a>
# **GetUserSubscriptionDetails**
> InventorySubscriptionResource GetUserSubscriptionDetails (int? userId, int? inventoryId)

Get details about a user's subscription

<b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
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
                Debug.Print("Exception when calling Users_SubscriptionsApi.GetUserSubscriptionDetails: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserssubscriptiondetails"></a>
# **GetUsersSubscriptionDetails**
> List<InventorySubscriptionResource> GetUsersSubscriptionDetails (int? userId)

Get details about a user's subscriptions

<b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get details about a user's subscriptions
                List&lt;InventorySubscriptionResource&gt; result = apiInstance.GetUsersSubscriptionDetails(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_SubscriptionsApi.GetUsersSubscriptionDetails: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactivateusersubscription"></a>
# **ReactivateUserSubscription**
> InvoiceResource ReactivateUserSubscription (int? userId, int? inventoryId, ReactivateSubscriptionRequest reactivateSubscriptionRequest)

Reactivate a subscription and charge fee

<b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
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
                Debug.Print("Exception when calling Users_SubscriptionsApi.ReactivateUserSubscription: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionbilldate"></a>
# **SetSubscriptionBillDate**
> void SetSubscriptionBillDate (int? userId, int? inventoryId, long? billDate)

Set a new date to bill a subscription on

<b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
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
                Debug.Print("Exception when calling Users_SubscriptionsApi.SetSubscriptionBillDate: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionpaymentmethod"></a>
# **SetSubscriptionPaymentMethod**
> void SetSubscriptionPaymentMethod (int? userId, int? inventoryId, IntWrapper paymentMethodId)

Set the payment method to use for a subscription

May send null to use floating default. <br><br><b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var paymentMethodId = new IntWrapper(); // IntWrapper | The id of the payment method (optional) 

            try
            {
                // Set the payment method to use for a subscription
                apiInstance.SetSubscriptionPaymentMethod(userId, inventoryId, paymentMethodId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_SubscriptionsApi.SetSubscriptionPaymentMethod: " + e.Message );
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
 **paymentMethodId** | [**IntWrapper**](IntWrapper.md)| The id of the payment method | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsubscriptionstatus"></a>
# **SetSubscriptionStatus**
> void SetSubscriptionStatus (int? userId, int? inventoryId, SubscriptionStatusWrapper status)

Set the status of a subscription

Note that the new status may be blocked if the system is not configured to allow the current status to be changed to the new, to enforce proper flow. The default options for statuses are shown below but may be altered for special use cases. <br><br><b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var status = new SubscriptionStatusWrapper(); // SubscriptionStatusWrapper | The new status for the subscription

            try
            {
                // Set the status of a subscription
                apiInstance.SetSubscriptionStatus(userId, inventoryId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_SubscriptionsApi.SetSubscriptionStatus: " + e.Message );
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
 **status** | [**SubscriptionStatusWrapper**](SubscriptionStatusWrapper.md)| The new status for the subscription | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setusersubscriptionplan"></a>
# **SetUserSubscriptionPlan**
> void SetUserSubscriptionPlan (int? userId, int? inventoryId, StringWrapper planId)

Set a new subscription plan for a user

<b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
            var userId = 56;  // int? | The id of the user
            var inventoryId = 56;  // int? | The id of the user's inventory
            var planId = new StringWrapper(); // StringWrapper | The id of the new plan. Must be from the same subscription (optional) 

            try
            {
                // Set a new subscription plan for a user
                apiInstance.SetUserSubscriptionPlan(userId, inventoryId, planId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_SubscriptionsApi.SetUserSubscriptionPlan: " + e.Message );
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
 **planId** | [**StringWrapper**](StringWrapper.md)| The id of the new plan. Must be from the same subscription | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setusersubscriptionprice"></a>
# **SetUserSubscriptionPrice**
> void SetUserSubscriptionPrice (int? userId, int? inventoryId, SubscriptionPriceOverrideRequest theOverrideDetails)

Set a new subscription price for a user

This new price will be what the user is charged at the begining of each new period. This override is specific to the current subscription and will not carry over if they end and later re-subscribe. It will persist if the plan is changed using the setUserSubscriptionPlan endpoint. <br><br><b>Permissions Needed:</b> USERS_SUBSCRIPTIONS_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_SubscriptionsApi();
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
                Debug.Print("Exception when calling Users_SubscriptionsApi.SetUserSubscriptionPrice: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

