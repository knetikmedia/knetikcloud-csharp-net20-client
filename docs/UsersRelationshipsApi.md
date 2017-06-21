# com.knetikcloud..UsersRelationshipsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserRelationship**](UsersRelationshipsApi.md#createuserrelationship) | **POST** /users/relationships | Create a user relationship
[**DeleteUserRelationship**](UsersRelationshipsApi.md#deleteuserrelationship) | **DELETE** /users/relationships/{id} | Delete a user relationship
[**GetUserRelationship**](UsersRelationshipsApi.md#getuserrelationship) | **GET** /users/relationships/{id} | Get a user relationship
[**GetUserRelationships**](UsersRelationshipsApi.md#getuserrelationships) | **GET** /users/relationships | Get a list of user relationships
[**UpdateUserRelationship**](UsersRelationshipsApi.md#updateuserrelationship) | **PUT** /users/relationships/{id} | Update a user relationship


<a name="createuserrelationship"></a>
# **CreateUserRelationship**
> ModelUserRelationshipResource CreateUserRelationship (ModelUserRelationshipResource relationship)

Create a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateUserRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var relationship = new ModelUserRelationshipResource(); // ModelUserRelationshipResource | The new relationship (optional) 

            try
            {
                // Create a user relationship
                ModelUserRelationshipResource result = apiInstance.CreateUserRelationship(relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.CreateUserRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relationship** | [**ModelUserRelationshipResource**](ModelUserRelationshipResource.md)| The new relationship | [optional] 

### Return type

[**ModelUserRelationshipResource**](ModelUserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuserrelationship"></a>
# **DeleteUserRelationship**
> void DeleteUserRelationship (long? id)

Delete a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteUserRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship

            try
            {
                // Delete a user relationship
                apiInstance.DeleteUserRelationship(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.DeleteUserRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrelationship"></a>
# **GetUserRelationship**
> ModelUserRelationshipResource GetUserRelationship (long? id)

Get a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship

            try
            {
                // Get a user relationship
                ModelUserRelationshipResource result = apiInstance.GetUserRelationship(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.GetUserRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 

### Return type

[**ModelUserRelationshipResource**](ModelUserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserrelationships"></a>
# **GetUserRelationships**
> ModelPageResourceUserRelationshipResource GetUserRelationships (int? size, int? page, string order)

Get a list of user relationships

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserRelationshipsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional) 

            try
            {
                // Get a list of user relationships
                ModelPageResourceUserRelationshipResource result = apiInstance.GetUserRelationships(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.GetUserRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] 

### Return type

[**ModelPageResourceUserRelationshipResource**](ModelPageResourceUserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserrelationship"></a>
# **UpdateUserRelationship**
> ModelUserRelationshipResource UpdateUserRelationship (long? id, ModelUserRelationshipResource relationship)

Update a user relationship

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateUserRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersRelationshipsApi();
            var id = 789;  // long? | The id of the relationship
            var relationship = new ModelUserRelationshipResource(); // ModelUserRelationshipResource | The new relationship (optional) 

            try
            {
                // Update a user relationship
                ModelUserRelationshipResource result = apiInstance.UpdateUserRelationship(id, relationship);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersRelationshipsApi.UpdateUserRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the relationship | 
 **relationship** | [**ModelUserRelationshipResource**](ModelUserRelationshipResource.md)| The new relationship | [optional] 

### Return type

[**ModelUserRelationshipResource**](ModelUserRelationshipResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

