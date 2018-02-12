# com.knetikcloud..DevicesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeviceUsers**](DevicesApi.md#adddeviceusers) | **POST** /devices/{id}/users | Add device users
[**CreateDevice**](DevicesApi.md#createdevice) | **POST** /devices | Create a device
[**CreateDeviceTemplate**](DevicesApi.md#createdevicetemplate) | **POST** /devices/templates | Create a device template
[**DeleteDevice**](DevicesApi.md#deletedevice) | **DELETE** /devices/{id} | Delete a device
[**DeleteDeviceTemplate**](DevicesApi.md#deletedevicetemplate) | **DELETE** /devices/templates/{id} | Delete an device template
[**DeleteDeviceUser**](DevicesApi.md#deletedeviceuser) | **DELETE** /devices/{id}/users/{user_id} | Delete a device user
[**DeleteDeviceUsers**](DevicesApi.md#deletedeviceusers) | **DELETE** /devices/{id}/users | Delete all device users
[**GetDevice**](DevicesApi.md#getdevice) | **GET** /devices/{id} | Get a single device
[**GetDeviceTemplate**](DevicesApi.md#getdevicetemplate) | **GET** /devices/templates/{id} | Get a single device template
[**GetDeviceTemplates**](DevicesApi.md#getdevicetemplates) | **GET** /devices/templates | List and search device templates
[**GetDevices**](DevicesApi.md#getdevices) | **GET** /devices | List and search devices
[**UpdateDevice**](DevicesApi.md#updatedevice) | **PUT** /devices/{id} | Update a device
[**UpdateDeviceTemplate**](DevicesApi.md#updatedevicetemplate) | **PUT** /devices/templates/{id} | Update an device template


<a name="adddeviceusers"></a>
# **AddDeviceUsers**
> DeviceResource AddDeviceUsers (List<SimpleUserResource> userResources, string id)

Add device users

<b>Permissions Needed:</b> DEVICES_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var userResources = new List<SimpleUserResource>(); // List<SimpleUserResource> | userResources
            var id = id_example;  // string | id

            try
            {
                // Add device users
                DeviceResource result = apiInstance.AddDeviceUsers(userResources, id);
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
 **userResources** | [**List<SimpleUserResource>**](SimpleUserResource.md)| userResources | 
 **id** | **string**| id | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdevice"></a>
# **CreateDevice**
> DeviceResource CreateDevice (DeviceResource device)

Create a device

<b>Permissions Needed:</b> ANY

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new DeviceResource(); // DeviceResource | device

            try
            {
                // Create a device
                DeviceResource result = apiInstance.CreateDevice(device);
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
 **device** | [**DeviceResource**](DeviceResource.md)| device | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdevicetemplate"></a>
# **CreateDeviceTemplate**
> TemplateResource CreateDeviceTemplate (TemplateResource deviceTemplateResource)

Create a device template

Device Templates define a type of device and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateDeviceTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var deviceTemplateResource = new TemplateResource(); // TemplateResource | The device template resource object (optional) 

            try
            {
                // Create a device template
                TemplateResource result = apiInstance.CreateDeviceTemplate(deviceTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.CreateDeviceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTemplateResource** | [**TemplateResource**](TemplateResource.md)| The device template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevice"></a>
# **DeleteDevice**
> void DeleteDevice (string id)

Delete a device

<b>Permissions Needed:</b> DEVICES_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | id

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
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevicetemplate"></a>
# **DeleteDeviceTemplate**
> void DeleteDeviceTemplate (string id, string cascade)

Delete an device template

If cascade = 'detach', it will force delete the template even if it's attached to other objects. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteDeviceTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an device template
                apiInstance.DeleteDeviceTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDeviceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **cascade** | **string**| The value needed to delete used templates | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeviceuser"></a>
# **DeleteDeviceUser**
> void DeleteDeviceUser (string id, int? userId)

Delete a device user

<b>Permissions Needed:</b> DEVICES_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | The id of the device
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
 **id** | **string**| The id of the device | 
 **userId** | **int?**| The user id of the device user | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeviceusers"></a>
# **DeleteDeviceUsers**
> void DeleteDeviceUsers (string id, string filterId)

Delete all device users

<b>Permissions Needed:</b> DEVICES_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | The id of the device
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
 **id** | **string**| The id of the device | 
 **filterId** | **string**| Filter for device users to delete with a user id in a given comma separated list of ids | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevice"></a>
# **GetDevice**
> DeviceResource GetDevice (string id)

Get a single device

<b>Permissions Needed:</b> DEVICES_ADMIN or owner

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | id

            try
            {
                // Get a single device
                DeviceResource result = apiInstance.GetDevice(id);
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
 **id** | **string**| id | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetemplate"></a>
# **GetDeviceTemplate**
> TemplateResource GetDeviceTemplate (string id)

Get a single device template

<b>Permissions Needed:</b> description

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDeviceTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single device template
                TemplateResource result = apiInstance.GetDeviceTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDeviceTemplate: " + e.Message );
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

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevicetemplates"></a>
# **GetDeviceTemplates**
> PageResourceTemplateResource GetDeviceTemplates (int? size, int? page, string order)

List and search device templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or DEVICES_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetDeviceTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search device templates
                PageResourceTemplateResource result = apiInstance.GetDeviceTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.GetDeviceTemplates: " + e.Message );
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

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdevices"></a>
# **GetDevices**
> PageResourceDeviceResource GetDevices (string filterMake, string filterModel, string filterOs, string filterSerial, string filterType, string filterTag, int? size, int? page, string order)

List and search devices

Get a list of devices with optional filtering. <br><br><b>Permissions Needed:</b> DEVICES_ADMIN or user

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var filterMake = filterMake_example;  // string | Filter for devices with specified make (optional) 
            var filterModel = filterModel_example;  // string | Filter for devices with specified model (optional) 
            var filterOs = filterOs_example;  // string | Filter for devices with specified OS (optional) 
            var filterSerial = filterSerial_example;  // string | Filter for devices with specified serial (optional) 
            var filterType = filterType_example;  // string | Filter for devices with specified type (optional) 
            var filterTag = filterTag_example;  // string | A comma separated list without spaces to filter for devices with specified tags (matches any) (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search devices
                PageResourceDeviceResource result = apiInstance.GetDevices(filterMake, filterModel, filterOs, filterSerial, filterType, filterTag, size, page, order);
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
 **filterOs** | **string**| Filter for devices with specified OS | [optional] 
 **filterSerial** | **string**| Filter for devices with specified serial | [optional] 
 **filterType** | **string**| Filter for devices with specified type | [optional] 
 **filterTag** | **string**| A comma separated list without spaces to filter for devices with specified tags (matches any) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceDeviceResource**](PageResourceDeviceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevice"></a>
# **UpdateDevice**
> DeviceResource UpdateDevice (DeviceResource device, string id)

Update a device

<b>Permissions Needed:</b> CUSTOMERS_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var device = new DeviceResource(); // DeviceResource | device
            var id = id_example;  // string | id

            try
            {
                // Update a device
                DeviceResource result = apiInstance.UpdateDevice(device, id);
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
 **device** | [**DeviceResource**](DeviceResource.md)| device | 
 **id** | **string**| id | 

### Return type

[**DeviceResource**](DeviceResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevicetemplate"></a>
# **UpdateDeviceTemplate**
> TemplateResource UpdateDeviceTemplate (string id, TemplateResource deviceTemplateResource)

Update an device template

<b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateDeviceTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi();
            var id = id_example;  // string | The id of the template
            var deviceTemplateResource = new TemplateResource(); // TemplateResource | The device template resource object (optional) 

            try
            {
                // Update an device template
                TemplateResource result = apiInstance.UpdateDeviceTemplate(id, deviceTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDeviceTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **deviceTemplateResource** | [**TemplateResource**](TemplateResource.md)| The device template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

