# com.knetikcloud..Store_Shopping_CartsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomDiscount**](Store_Shopping_CartsApi.md#addcustomdiscount) | **POST** /carts/{id}/custom-discounts | Adds a custom discount to the cart
[**AddDiscountToCart**](Store_Shopping_CartsApi.md#adddiscounttocart) | **POST** /carts/{id}/discounts | Adds a discount coupon to the cart
[**AddItemToCart**](Store_Shopping_CartsApi.md#additemtocart) | **POST** /carts/{id}/items | Add an item to the cart
[**CreateCart**](Store_Shopping_CartsApi.md#createcart) | **POST** /carts | Create a cart
[**GetCart**](Store_Shopping_CartsApi.md#getcart) | **GET** /carts/{id} | Returns the cart with the given GUID
[**GetCarts**](Store_Shopping_CartsApi.md#getcarts) | **GET** /carts | Get a list of carts
[**GetShippable**](Store_Shopping_CartsApi.md#getshippable) | **GET** /carts/{id}/shippable | Returns whether a cart requires shipping
[**GetShippingCountries**](Store_Shopping_CartsApi.md#getshippingcountries) | **GET** /carts/{id}/countries | Get the list of available shipping countries per vendor
[**RemoveDiscountFromCart**](Store_Shopping_CartsApi.md#removediscountfromcart) | **DELETE** /carts/{id}/discounts/{code} | Removes a discount coupon from the cart
[**SetCartCurrency**](Store_Shopping_CartsApi.md#setcartcurrency) | **PUT** /carts/{id}/currency | Sets the currency to use for the cart
[**SetCartOwner**](Store_Shopping_CartsApi.md#setcartowner) | **PUT** /carts/{id}/owner | Sets the owner of a cart if none is set already
[**UpdateItemInCart**](Store_Shopping_CartsApi.md#updateitemincart) | **PUT** /carts/{id}/items | Changes the quantity of an item already in the cart
[**UpdateShippingAddress**](Store_Shopping_CartsApi.md#updateshippingaddress) | **PUT** /carts/{id}/shipping-address | Modifies or sets the order shipping address


<a name="addcustomdiscount"></a>
# **AddCustomDiscount**
> void AddCustomDiscount (string id, CouponDefinition customDiscount)

Adds a custom discount to the cart

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddCustomDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var customDiscount = new CouponDefinition(); // CouponDefinition | The details of the discount to add (optional) 

            try
            {
                // Adds a custom discount to the cart
                apiInstance.AddCustomDiscount(id, customDiscount);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.AddCustomDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **customDiscount** | [**CouponDefinition**](CouponDefinition.md)| The details of the discount to add | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddiscounttocart"></a>
# **AddDiscountToCart**
> void AddDiscountToCart (string id, SkuRequest skuRequest)

Adds a discount coupon to the cart

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddDiscountToCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var skuRequest = new SkuRequest(); // SkuRequest | The request of the sku (optional) 

            try
            {
                // Adds a discount coupon to the cart
                apiInstance.AddDiscountToCart(id, skuRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.AddDiscountToCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **skuRequest** | [**SkuRequest**](SkuRequest.md)| The request of the sku | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additemtocart"></a>
# **AddItemToCart**
> void AddItemToCart (string id, CartItemRequest cartItemRequest)

Add an item to the cart

Currently, carts cannot contain virtual and real currency items at the same time. Furthermore, the API only support a single virtual item at the moment. <br><br><b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddItemToCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var cartItemRequest = new CartItemRequest(); // CartItemRequest | The cart item request object (optional) 

            try
            {
                // Add an item to the cart
                apiInstance.AddItemToCart(id, cartItemRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.AddItemToCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartItemRequest** | [**CartItemRequest**](CartItemRequest.md)| The cart item request object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcart"></a>
# **CreateCart**
> string CreateCart (int? owner, string currencyCode)

Create a cart

You don't have to have a user to create a cart but the API requires authentication to checkout. <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var owner = 56;  // int? | Set the owner of a cart. If not specified, defaults to the calling user's id. If specified and is not the calling user's id, SHOPPING_CARTS_ADMIN permission is required (optional) 
            var currencyCode = currencyCode_example;  // string | Set the currency for the cart, by currency code. May be disallowed by site settings. (optional) 

            try
            {
                // Create a cart
                string result = apiInstance.CreateCart(owner, currencyCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.CreateCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **int?**| Set the owner of a cart. If not specified, defaults to the calling user&#39;s id. If specified and is not the calling user&#39;s id, SHOPPING_CARTS_ADMIN permission is required | [optional] 
 **currencyCode** | **string**| Set the currency for the cart, by currency code. May be disallowed by site settings. | [optional] 

### Return type

**string**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcart"></a>
# **GetCart**
> Cart GetCart (string id)

Returns the cart with the given GUID

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Returns the cart with the given GUID
                Cart result = apiInstance.GetCart(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.GetCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**Cart**](Cart.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarts"></a>
# **GetCarts**
> PageResourceCartSummary GetCarts (int? filterOwnerId, int? size, int? page, string order)

Get a list of carts

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetCartsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var filterOwnerId = 56;  // int? | Filter by the id of the owner (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get a list of carts
                PageResourceCartSummary result = apiInstance.GetCarts(filterOwnerId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.GetCarts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterOwnerId** | **int?**| Filter by the id of the owner | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceCartSummary**](PageResourceCartSummary.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippable"></a>
# **GetShippable**
> CartShippableResponse GetShippable (string id)

Returns whether a cart requires shipping

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetShippableExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Returns whether a cart requires shipping
                CartShippableResponse result = apiInstance.GetShippable(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.GetShippable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**CartShippableResponse**](CartShippableResponse.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshippingcountries"></a>
# **GetShippingCountries**
> SampleCountriesResponse GetShippingCountries (string id)

Get the list of available shipping countries per vendor

Since a cart can have multiple vendors with different shipping options, the countries are broken down by vendors. Please see notes about the response object as the fields are variable. <br><br><b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetShippingCountriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart

            try
            {
                // Get the list of available shipping countries per vendor
                SampleCountriesResponse result = apiInstance.GetShippingCountries(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.GetShippingCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 

### Return type

[**SampleCountriesResponse**](SampleCountriesResponse.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removediscountfromcart"></a>
# **RemoveDiscountFromCart**
> void RemoveDiscountFromCart (string id, string code)

Removes a discount coupon from the cart

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveDiscountFromCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var code = code_example;  // string | The SKU code of the coupon to remove

            try
            {
                // Removes a discount coupon from the cart
                apiInstance.RemoveDiscountFromCart(id, code);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.RemoveDiscountFromCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **code** | **string**| The SKU code of the coupon to remove | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcartcurrency"></a>
# **SetCartCurrency**
> void SetCartCurrency (string id, StringWrapper currencyCode)

Sets the currency to use for the cart

May be disallowed by site settings. <br><br><b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetCartCurrencyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var currencyCode = new StringWrapper(); // StringWrapper | The code of the currency (optional) 

            try
            {
                // Sets the currency to use for the cart
                apiInstance.SetCartCurrency(id, currencyCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.SetCartCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **currencyCode** | [**StringWrapper**](StringWrapper.md)| The code of the currency | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcartowner"></a>
# **SetCartOwner**
> void SetCartOwner (string id, IntWrapper userId)

Sets the owner of a cart if none is set already

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetCartOwnerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var userId = new IntWrapper(); // IntWrapper | The id of the user (optional) 

            try
            {
                // Sets the owner of a cart if none is set already
                apiInstance.SetCartOwner(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.SetCartOwner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **userId** | [**IntWrapper**](IntWrapper.md)| The id of the user | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemincart"></a>
# **UpdateItemInCart**
> void UpdateItemInCart (string id, CartItemRequest cartItemRequest)

Changes the quantity of an item already in the cart

A quantity of zero will remove the item from the cart altogether. <br><br><b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateItemInCartExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var cartItemRequest = new CartItemRequest(); // CartItemRequest | The cart item request object (optional) 

            try
            {
                // Changes the quantity of an item already in the cart
                apiInstance.UpdateItemInCart(id, cartItemRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.UpdateItemInCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartItemRequest** | [**CartItemRequest**](CartItemRequest.md)| The cart item request object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshippingaddress"></a>
# **UpdateShippingAddress**
> void UpdateShippingAddress (string id, CartShippingAddressRequest cartShippingAddressRequest)

Modifies or sets the order shipping address

<b>Permissions Needed:</b> SHOPPING_CARTS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateShippingAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Store_Shopping_CartsApi();
            var id = id_example;  // string | The id of the cart
            var cartShippingAddressRequest = new CartShippingAddressRequest(); // CartShippingAddressRequest | The cart shipping address request object (optional) 

            try
            {
                // Modifies or sets the order shipping address
                apiInstance.UpdateShippingAddress(id, cartShippingAddressRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Store_Shopping_CartsApi.UpdateShippingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the cart | 
 **cartShippingAddressRequest** | [**CartShippingAddressRequest**](CartShippingAddressRequest.md)| The cart shipping address request object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

