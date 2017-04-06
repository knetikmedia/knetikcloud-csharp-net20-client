# com.knetikcloud..AuthRolesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRole**](AuthRolesApi.md#createrole) | **POST** /auth/roles | Create a new role
[**DeleteRole**](AuthRolesApi.md#deleterole) | **DELETE** /auth/roles/{role} | Delete a role
[**GetClientRoles**](AuthRolesApi.md#getclientroles) | **GET** /auth/clients/{client_key}/roles | Get roles for a client
[**GetRole**](AuthRolesApi.md#getrole) | **GET** /auth/roles/{role} | Get a single role
[**GetRoles**](AuthRolesApi.md#getroles) | **GET** /auth/roles | List and search roles
[**GetUserRoles**](AuthRolesApi.md#getuserroles) | **GET** /auth/users/{user_id}/roles | Get roles for a user
[**SetClientRoles**](AuthRolesApi.md#setclientroles) | **PUT** /auth/clients/{client_key}/roles | Set roles for a client
[**SetPermissionsForRole**](AuthRolesApi.md#setpermissionsforrole) | **PUT** /auth/roles/{role}/permissions | Set permissions for a role
[**SetUserRoles**](AuthRolesApi.md#setuserroles) | **PUT** /auth/users/{user_id}/roles | Set roles for a user
[**UpdateRole**](AuthRolesApi.md#updaterole) | **PUT** /auth/roles/{role} | Update a role


<a name="createrole"></a>
# **CreateRole**
> ModelRoleResource CreateRole (ModelRoleResource roleResource)

Create a new role

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var roleResource = new ModelRoleResource(); // ModelRoleResource | The role resource object (optional) 

            try
            {
                // Create a new role
                ModelRoleResource result = apiInstance.CreateRole(roleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.CreateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleResource** | [**ModelRoleResource**](ModelRoleResource.md)| The role resource object | [optional] 

### Return type

[**ModelRoleResource**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string role, bool? force)

Delete a role

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var force = true;  // bool? | If true, removes role from users/clients (optional) 

            try
            {
                // Delete a role
                apiInstance.DeleteRole(role, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.DeleteRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **force** | **bool?**| If true, removes role from users/clients | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientroles"></a>
# **GetClientRoles**
> List<ModelRoleResource> GetClientRoles (string clientKey)

Get roles for a client

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetClientRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var clientKey = clientKey_example;  // string | The client key

            try
            {
                // Get roles for a client
                List&lt;ModelRoleResource&gt; result = apiInstance.GetClientRoles(clientKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetClientRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 

### Return type

[**List<ModelRoleResource>**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrole"></a>
# **GetRole**
> ModelRoleResource GetRole (string role)

Get a single role

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value

            try
            {
                // Get a single role
                ModelRoleResource result = apiInstance.GetRole(role);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 

### Return type

[**ModelRoleResource**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> ModelPageResourceRoleResource GetRoles (int? size, int? page, string order)

List and search roles

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search roles
                ModelPageResourceRoleResource result = apiInstance.GetRoles(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetRoles: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**ModelPageResourceRoleResource**](ModelPageResourceRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserroles"></a>
# **GetUserRoles**
> List<ModelRoleResource> GetUserRoles (int? userId)

Get roles for a user

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var userId = 56;  // int? | The user's id

            try
            {
                // Get roles for a user
                List&lt;ModelRoleResource&gt; result = apiInstance.GetUserRoles(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 

### Return type

[**List<ModelRoleResource>**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setclientroles"></a>
# **SetClientRoles**
> ModelClientResource SetClientRoles (string clientKey, List<string> rolesList)

Set roles for a client

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetClientRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var clientKey = clientKey_example;  // string | The client key
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a client
                ModelClientResource result = apiInstance.SetClientRoles(clientKey, rolesList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.SetClientRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientKey** | **string**| The client key | 
 **rolesList** | **List<string>**| The list of unique roles | [optional] 

### Return type

[**ModelClientResource**](ModelClientResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpermissionsforrole"></a>
# **SetPermissionsForRole**
> ModelRoleResource SetPermissionsForRole (string role, List<string> permissionsList)

Set permissions for a role

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetPermissionsForRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var permissionsList = ;  // List<string> | The list of unique permissions (optional) 

            try
            {
                // Set permissions for a role
                ModelRoleResource result = apiInstance.SetPermissionsForRole(role, permissionsList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.SetPermissionsForRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **permissionsList** | **List<string>**| The list of unique permissions | [optional] 

### Return type

[**ModelRoleResource**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setuserroles"></a>
# **SetUserRoles**
> ModelUserResource SetUserRoles (int? userId, List<string> rolesList)

Set roles for a user

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class SetUserRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var userId = 56;  // int? | The user's id
            var rolesList = ;  // List<string> | The list of unique roles (optional) 

            try
            {
                // Set roles for a user
                ModelUserResource result = apiInstance.SetUserRoles(userId, rolesList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.SetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user&#39;s id | 
 **rolesList** | **List<string>**| The list of unique roles | [optional] 

### Return type

[**ModelUserResource**](ModelUserResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterole"></a>
# **UpdateRole**
> ModelRoleResource UpdateRole (string role, ModelRoleResource roleResource)

Update a role

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthRolesApi();
            var role = role_example;  // string | The role value
            var roleResource = new ModelRoleResource(); // ModelRoleResource | The role resource object (optional) 

            try
            {
                // Update a role
                ModelRoleResource result = apiInstance.UpdateRole(role, roleResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthRolesApi.UpdateRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| The role value | 
 **roleResource** | [**ModelRoleResource**](ModelRoleResource.md)| The role resource object | [optional] 

### Return type

[**ModelRoleResource**](ModelRoleResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
