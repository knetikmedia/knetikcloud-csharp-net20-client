# com.knetikcloud..UsersAddressesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddress**](UsersAddressesApi.md#createaddress) | **POST** /users/{user_id}/addresses | Create a new address
[**DeleteAddress**](UsersAddressesApi.md#deleteaddress) | **DELETE** /users/{user_id}/addresses/{id} | Delete an address
[**GetAddress**](UsersAddressesApi.md#getaddress) | **GET** /users/{user_id}/addresses/{id} | Get a single address
[**GetAddresses**](UsersAddressesApi.md#getaddresses) | **GET** /users/{user_id}/addresses | List and search addresses
[**UpdateAddress**](UsersAddressesApi.md#updateaddress) | **PUT** /users/{user_id}/addresses/{id} | Update an address


<a name="createaddress"></a>
# **CreateAddress**
> ModelSavedAddressResource CreateAddress (string userId, ModelSavedAddressResource savedAddressResource)

Create a new address

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var savedAddressResource = new ModelSavedAddressResource(); // ModelSavedAddressResource | The new address (optional) 

            try
            {
                // Create a new address
                ModelSavedAddressResource result = apiInstance.CreateAddress(userId, savedAddressResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.CreateAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **savedAddressResource** | [**ModelSavedAddressResource**](ModelSavedAddressResource.md)| The new address | [optional] 

### Return type

[**ModelSavedAddressResource**](ModelSavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaddress"></a>
# **DeleteAddress**
> void DeleteAddress (string userId, int? id)

Delete an address

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address

            try
            {
                // Delete an address
                apiInstance.DeleteAddress(userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.DeleteAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddress"></a>
# **GetAddress**
> ModelSavedAddressResource GetAddress (string userId, int? id)

Get a single address

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address

            try
            {
                // Get a single address
                ModelSavedAddressResource result = apiInstance.GetAddress(userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.GetAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 

### Return type

[**ModelSavedAddressResource**](ModelSavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddresses"></a>
# **GetAddresses**
> ModelPageResourceSavedAddressResource GetAddresses (string userId, int? size, int? page, string order)

List and search addresses

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetAddressesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search addresses
                ModelPageResourceSavedAddressResource result = apiInstance.GetAddresses(userId, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.GetAddresses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceSavedAddressResource**](ModelPageResourceSavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaddress"></a>
# **UpdateAddress**
> ModelSavedAddressResource UpdateAddress (string userId, int? id, ModelSavedAddressResource savedAddressResource)

Update an address

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersAddressesApi();
            var userId = userId_example;  // string | The id of the user
            var id = 56;  // int? | The id of the address
            var savedAddressResource = new ModelSavedAddressResource(); // ModelSavedAddressResource | The saved address resource object (optional) 

            try
            {
                // Update an address
                ModelSavedAddressResource result = apiInstance.UpdateAddress(userId, id, savedAddressResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersAddressesApi.UpdateAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The id of the user | 
 **id** | **int?**| The id of the address | 
 **savedAddressResource** | [**ModelSavedAddressResource**](ModelSavedAddressResource.md)| The saved address resource object | [optional] 

### Return type

[**ModelSavedAddressResource**](ModelSavedAddressResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

