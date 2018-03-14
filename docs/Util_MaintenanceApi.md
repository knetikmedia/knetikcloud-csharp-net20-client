# com.knetikcloud..Util_MaintenanceApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMaintenance**](Util_MaintenanceApi.md#deletemaintenance) | **DELETE** /maintenance | Delete maintenance info
[**GetMaintenance**](Util_MaintenanceApi.md#getmaintenance) | **GET** /maintenance | Get current maintenance info
[**SetMaintenance**](Util_MaintenanceApi.md#setmaintenance) | **POST** /maintenance | Set current maintenance info
[**UpdateMaintenance**](Util_MaintenanceApi.md#updatemaintenance) | **PUT** /maintenance | Update current maintenance info


<a name="deletemaintenance"></a>
# **DeleteMaintenance**
> void DeleteMaintenance ()

Delete maintenance info

<b>Permissions Needed:</b> MAINTENANCE_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Util_MaintenanceApi();

            try
            {
                // Delete maintenance info
                apiInstance.DeleteMaintenance();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Util_MaintenanceApi.DeleteMaintenance: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmaintenance"></a>
# **GetMaintenance**
> Maintenance GetMaintenance ()

Get current maintenance info

Get current maintenance info. 404 if no maintenance. <br><br><b>Permissions Needed:</b> ANY

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Util_MaintenanceApi();

            try
            {
                // Get current maintenance info
                Maintenance result = apiInstance.GetMaintenance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Util_MaintenanceApi.GetMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Maintenance**](Maintenance.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmaintenance"></a>
# **SetMaintenance**
> void SetMaintenance (Maintenance maintenance)

Set current maintenance info

<b>Permissions Needed:</b> MAINTENANCE_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Util_MaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The maintenance object (optional) 

            try
            {
                // Set current maintenance info
                apiInstance.SetMaintenance(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Util_MaintenanceApi.SetMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemaintenance"></a>
# **UpdateMaintenance**
> void UpdateMaintenance (Maintenance maintenance)

Update current maintenance info

<b>Permissions Needed:</b> MAINTENANCE_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Util_MaintenanceApi();
            var maintenance = new Maintenance(); // Maintenance | The maintenance object (optional) 

            try
            {
                // Update current maintenance info
                apiInstance.UpdateMaintenance(maintenance);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Util_MaintenanceApi.UpdateMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maintenance** | [**Maintenance**](Maintenance.md)| The maintenance object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

