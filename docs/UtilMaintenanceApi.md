# com.knetikcloud..UtilMaintenanceApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMaintenance**](UtilMaintenanceApi.md#deletemaintenance) | **DELETE** /maintenance | Delete maintenance info
[**GetMaintenance**](UtilMaintenanceApi.md#getmaintenance) | **GET** /maintenance | Get current maintenance info
[**SetMaintenance**](UtilMaintenanceApi.md#setmaintenance) | **POST** /maintenance | Set current maintenance info
[**UpdateMaintenance**](UtilMaintenanceApi.md#updatemaintenance) | **PUT** /maintenance | Update current maintenance info


<a name="deletemaintenance"></a>
# **DeleteMaintenance**
> void DeleteMaintenance ()

Delete maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteMaintenanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Delete maintenance info
                apiInstance.DeleteMaintenance();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.DeleteMaintenance: " + e.Message );
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

<a name="getmaintenance"></a>
# **GetMaintenance**
> ModelMaintenance GetMaintenance ()

Get current maintenance info

Get current maintenance info. 404 if no maintenance.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetMaintenanceExample
    {
        public void main()
        {
            
            var apiInstance = new UtilMaintenanceApi();

            try
            {
                // Get current maintenance info
                ModelMaintenance result = apiInstance.GetMaintenance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.GetMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ModelMaintenance**](ModelMaintenance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmaintenance"></a>
# **SetMaintenance**
> void SetMaintenance (ModelMaintenance maintenance)

Set current maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetMaintenanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new ModelMaintenance(); // ModelMaintenance | The maintenance object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.SetMaintenance(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.SetMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**ModelMaintenance**](ModelMaintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemaintenance"></a>
# **UpdateMaintenance**
> void UpdateMaintenance (ModelMaintenance maintenance)

Update current maintenance info

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateMaintenanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilMaintenanceApi();
            var maintenance = new ModelMaintenance(); // ModelMaintenance | The maintenance object (optional) 

            try
            {
                // Update current maintenance info
                apiInstance.UpdateMaintenance(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilMaintenanceApi.UpdateMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**ModelMaintenance**](ModelMaintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

