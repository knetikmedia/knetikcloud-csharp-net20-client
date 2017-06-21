# com.knetikcloud..DevicesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeviceUsers**](DevicesApi.md#adddeviceusers) | **POST** /devices/{id}/users | Add device users
[**CreateDevice**](DevicesApi.md#createdevice) | **POST** /devices | Create a device
[**DeleteDevice**](DevicesApi.md#deletedevice) | **DELETE** /devices/{id} | Delete a device
[**DeleteDeviceUser**](DevicesApi.md#deletedeviceuser) | **DELETE** /devices/{id}/users/{user_id} | Delete a device user
[**DeleteDeviceUsers**](DevicesApi.md#deletedeviceusers) | **DELETE** /devices/{id}/users | Delete all device users
[**GetDevice**](DevicesApi.md#getdevice) | **GET** /devices/{id} | Get a single device
[**GetDevices**](DevicesApi.md#getdevices) | **GET** /devices | List and search devices
[**UpdateDevice**](DevicesApi.md#updatedevice) | **PUT** /devices/{id} | Update a device


<a name="adddeviceusers"></a>
# **AddDeviceUsers**
> ModelDeviceResource AddDeviceUsers (List<ModelSimpleUserResource> userResources, int? id)

Add device users

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddDeviceUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var userResources = new List<ModelSimpleUserResource>(); // List<ModelSimpleUserResource> | userResources
            var id = 56;  // int? | id

            try
            {
                // Add device users
                ModelDeviceResource result = apiInstance.AddDeviceUsers(userResources, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.AddDeviceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userResources** | [**List<ModelSimpleUserResource>**](ModelSimpleUserResource.md)| userResources | 
 **id** | **int?**| id | 

### Return type

[**ModelDeviceResource**](ModelDeviceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdevice"></a>
# **CreateDevice**
> ModelDeviceResource CreateDevice (ModelDeviceResource device)

Create a device

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new ModelDeviceResource(); // ModelDeviceResource | device

            try
            {
                // Create a device
                ModelDeviceResource result = apiInstance.CreateDevice(device);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.CreateDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **device** | [**ModelDeviceResource**](ModelDeviceResource.md)| device | 

### Return type

[**ModelDeviceResource**](ModelDeviceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevice"></a>
# **DeleteDevice**
> void DeleteDevice (int? id)

Delete a device

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | id

            try
            {
                // Delete a device
                apiInstance.DeleteDevice(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeviceuser"></a>
# **DeleteDeviceUser**
> void DeleteDeviceUser (int? id, int? userId)

Delete a device user

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteDeviceUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | The id of the device
            var userId = 56;  // int? | The user id of the device user

            try
            {
                // Delete a device user
                apiInstance.DeleteDeviceUser(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDeviceUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the device | 
 **userId** | **int?**| The user id of the device user | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeviceusers"></a>
# **DeleteDeviceUsers**
> void DeleteDeviceUsers (int? id, string filterId)

Delete all device users

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteDeviceUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | The id of the device
            var filterId = filterId_example;  // string | Filter for device users to delete with a user id in a given comma separated list of ids (optional) 

            try
            {
                // Delete all device users
                apiInstance.DeleteDeviceUsers(id, filterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDeviceUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the device | 
 **filterId** | **string**| Filter for device users to delete with a user id in a given comma separated list of ids | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevice"></a>
# **GetDevice**
> ModelDeviceResource GetDevice (int? id)

Get a single device

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = 56;  // int? | id

            try
            {
                // Get a single device
                ModelDeviceResource result = apiInstance.GetDevice(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

[**ModelDeviceResource**](ModelDeviceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevices"></a>
# **GetDevices**
> ModelPageResourceDeviceResource GetDevices (string filterMake, string filterModel, int? size, int? page, string order)

List and search devices

Get a list of devices with optional filtering

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDevicesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var filterMake = filterMake_example;  // string | Filter for devices with specified make (optional) 
            var filterModel = filterModel_example;  // string | Filter for devices with specified model (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search devices
                ModelPageResourceDeviceResource result = apiInstance.GetDevices(filterMake, filterModel, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterMake** | **string**| Filter for devices with specified make | [optional] 
 **filterModel** | **string**| Filter for devices with specified model | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceDeviceResource**](ModelPageResourceDeviceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevice"></a>
# **UpdateDevice**
> ModelDeviceResource UpdateDevice (ModelDeviceResource device, int? id)

Update a device

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateDeviceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new ModelDeviceResource(); // ModelDeviceResource | device
            var id = 56;  // int? | id

            try
            {
                // Update a device
                ModelDeviceResource result = apiInstance.UpdateDevice(device, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDevice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **device** | [**ModelDeviceResource**](ModelDeviceResource.md)| device | 
 **id** | **int?**| id | 

### Return type

[**ModelDeviceResource**](ModelDeviceResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

