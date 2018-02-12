# com.knetikcloud..PaymentsWalletsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserWallet**](PaymentsWalletsApi.md#getuserwallet) | **GET** /users/{user_id}/wallets/{currency_code} | Returns the user&#39;s wallet for the given currency code
[**GetUserWalletTransactions**](PaymentsWalletsApi.md#getuserwallettransactions) | **GET** /users/{user_id}/wallets/{currency_code}/transactions | Retrieve a user&#39;s wallet transactions
[**GetUserWallets**](PaymentsWalletsApi.md#getuserwallets) | **GET** /users/{user_id}/wallets | List all of a user&#39;s wallets
[**GetWalletBalances**](PaymentsWalletsApi.md#getwalletbalances) | **GET** /wallets/totals | Retrieves a summation of wallet balances by currency code
[**GetWalletTransactions**](PaymentsWalletsApi.md#getwallettransactions) | **GET** /wallets/transactions | Retrieve wallet transactions across the system
[**GetWallets**](PaymentsWalletsApi.md#getwallets) | **GET** /wallets | Retrieve a list of wallets across the system
[**UpdateWalletBalance**](PaymentsWalletsApi.md#updatewalletbalance) | **PUT** /users/{user_id}/wallets/{currency_code}/balance | Updates the balance for a user&#39;s wallet


<a name="getuserwallet"></a>
# **GetUserWallet**
> SimpleWallet GetUserWallet (int? userId, string currencyCode)

Returns the user's wallet for the given currency code

<b>Permissions Needed:</b> WALLETS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserWalletExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet is being retrieved
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet

            try
            {
                // Returns the user's wallet for the given currency code
                SimpleWallet result = apiInstance.GetUserWallet(userId, currencyCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetUserWallet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet is being retrieved | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 

### Return type

[**SimpleWallet**](SimpleWallet.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserwallettransactions"></a>
# **GetUserWalletTransactions**
> PageResourceWalletTransactionResource GetUserWalletTransactions (int? userId, string currencyCode, string filterType, long? filterMaxDate, long? filterMinDate, string filterSign, int? size, int? page, string order)

Retrieve a user's wallet transactions

<b>Permissions Needed:</b> WALLETS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserWalletTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet transactions are being retrieved
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet
            var filterType = filterType_example;  // string | Filter for transactions with specified type (optional) 
            var filterMaxDate = 789;  // long? | Filter for transactions from no earlier than the specified date as a unix timestamp in seconds (optional) 
            var filterMinDate = 789;  // long? | Filter for transactions from no later than the specified date as a unix timestamp in seconds (optional) 
            var filterSign = filterSign_example;  // string | Filter for transactions with amount with the given sign.  Allowable values: ('positive', 'negative') (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve a user's wallet transactions
                PageResourceWalletTransactionResource result = apiInstance.GetUserWalletTransactions(userId, currencyCode, filterType, filterMaxDate, filterMinDate, filterSign, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetUserWalletTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet transactions are being retrieved | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 
 **filterType** | **string**| Filter for transactions with specified type | [optional] 
 **filterMaxDate** | **long?**| Filter for transactions from no earlier than the specified date as a unix timestamp in seconds | [optional] 
 **filterMinDate** | **long?**| Filter for transactions from no later than the specified date as a unix timestamp in seconds | [optional] 
 **filterSign** | **string**| Filter for transactions with amount with the given sign.  Allowable values: (&#39;positive&#39;, &#39;negative&#39;) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceWalletTransactionResource**](PageResourceWalletTransactionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserwallets"></a>
# **GetUserWallets**
> List<SimpleWallet> GetUserWallets (int? userId)

List all of a user's wallets

<b>Permissions Needed:</b> WALLETS_ADMIN or owner

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserWalletsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallets are being retrieved

            try
            {
                // List all of a user's wallets
                List&lt;SimpleWallet&gt; result = apiInstance.GetUserWallets(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetUserWallets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallets are being retrieved | 

### Return type

[**List<SimpleWallet>**](SimpleWallet.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwalletbalances"></a>
# **GetWalletBalances**
> PageResourceWalletTotalResponse GetWalletBalances ()

Retrieves a summation of wallet balances by currency code

<b>Permissions Needed:</b> WALLETS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetWalletBalancesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();

            try
            {
                // Retrieves a summation of wallet balances by currency code
                PageResourceWalletTotalResponse result = apiInstance.GetWalletBalances();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PageResourceWalletTotalResponse**](PageResourceWalletTotalResponse.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwallettransactions"></a>
# **GetWalletTransactions**
> PageResourceWalletTransactionResource GetWalletTransactions (int? filterInvoice, string filterType, string filterDate, string filterSign, int? filterUserId, string filterUsername, string filterDetails, string filterCurrencyCode, int? size, int? page, string order)

Retrieve wallet transactions across the system

<b>Permissions Needed:</b> WALLETS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetWalletTransactionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var filterInvoice = 56;  // int? | Filter for transactions from a specific invoice (optional) 
            var filterType = filterType_example;  // string | Filter for transactions with specified type (optional) 
            var filterDate = filterDate_example;  // string | A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). (optional) 
            var filterSign = filterSign_example;  // string | Filter for transactions with amount with the given sign (optional) 
            var filterUserId = 56;  // int? | Filter for transactions for specific userId (optional) 
            var filterUsername = filterUsername_example;  // string | Filter for transactions for specific username that start with the given string (optional) 
            var filterDetails = filterDetails_example;  // string | Filter for transactions for specific details that start with the given string (optional) 
            var filterCurrencyCode = filterCurrencyCode_example;  // string | Filter for transactions for specific currency code (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve wallet transactions across the system
                PageResourceWalletTransactionResource result = apiInstance.GetWalletTransactions(filterInvoice, filterType, filterDate, filterSign, filterUserId, filterUsername, filterDetails, filterCurrencyCode, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWalletTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterInvoice** | **int?**| Filter for transactions from a specific invoice | [optional] 
 **filterType** | **string**| Filter for transactions with specified type | [optional] 
 **filterDate** | **string**| A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE). | [optional] 
 **filterSign** | **string**| Filter for transactions with amount with the given sign | [optional] 
 **filterUserId** | **int?**| Filter for transactions for specific userId | [optional] 
 **filterUsername** | **string**| Filter for transactions for specific username that start with the given string | [optional] 
 **filterDetails** | **string**| Filter for transactions for specific details that start with the given string | [optional] 
 **filterCurrencyCode** | **string**| Filter for transactions for specific currency code | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceWalletTransactionResource**](PageResourceWalletTransactionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwallets"></a>
# **GetWallets**
> PageResourceSimpleWallet GetWallets (int? size, int? page, string order)

Retrieve a list of wallets across the system

<b>Permissions Needed:</b> WALLETS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetWalletsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Retrieve a list of wallets across the system
                PageResourceSimpleWallet result = apiInstance.GetWallets(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.GetWallets: " + e.Message );
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

[**PageResourceSimpleWallet**](PageResourceSimpleWallet.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewalletbalance"></a>
# **UpdateWalletBalance**
> WalletTransactionResource UpdateWalletBalance (int? userId, string currencyCode, WalletAlterRequest request)

Updates the balance for a user's wallet

<b>Permissions Needed:</b> WALLETS_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateWalletBalanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PaymentsWalletsApi();
            var userId = 56;  // int? | The ID of the user for whom wallet is being modified
            var currencyCode = currencyCode_example;  // string | Currency code of the user's wallet
            var request = new WalletAlterRequest(); // WalletAlterRequest | The requested balance modification to be made to the user's wallet (optional) 

            try
            {
                // Updates the balance for a user's wallet
                WalletTransactionResource result = apiInstance.UpdateWalletBalance(userId, currencyCode, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsWalletsApi.UpdateWalletBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The ID of the user for whom wallet is being modified | 
 **currencyCode** | **string**| Currency code of the user&#39;s wallet | 
 **request** | [**WalletAlterRequest**](WalletAlterRequest.md)| The requested balance modification to be made to the user&#39;s wallet | [optional] 

### Return type

[**WalletTransactionResource**](WalletTransactionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

