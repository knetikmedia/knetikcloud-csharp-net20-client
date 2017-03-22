# com.knetikcloud..UsersGroupsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMemberToGroup**](UsersGroupsApi.md#addmembertogroup) | **POST** /users/groups/{unique_name}/members | Adds a new member to the group
[**CreateGroup**](UsersGroupsApi.md#creategroup) | **POST** /users/groups | Create a group
[**CreateGroupTemplate**](UsersGroupsApi.md#creategrouptemplate) | **POST** /users/groups/templates | Create a group template
[**DeleteGroup**](UsersGroupsApi.md#deletegroup) | **DELETE** /users/groups/{unique_name} | Removes a group from the system IF no resources are attached to it
[**DeleteGroupTemplate**](UsersGroupsApi.md#deletegrouptemplate) | **DELETE** /users/groups/templates/{id} | Delete a group template
[**GetGroup**](UsersGroupsApi.md#getgroup) | **GET** /users/groups/{unique_name} | Loads a specific group&#39;s details
[**GetGroupMember**](UsersGroupsApi.md#getgroupmember) | **GET** /users/groups/{unique_name}/members/{user_id} | Get a user from a group
[**GetGroupMembers**](UsersGroupsApi.md#getgroupmembers) | **GET** /users/groups/{unique_name}/members | Lists members of the group
[**GetGroupTemplate**](UsersGroupsApi.md#getgrouptemplate) | **GET** /users/groups/templates/{id} | Get a single group template
[**GetGroupTemplates**](UsersGroupsApi.md#getgrouptemplates) | **GET** /users/groups/templates | List and search group templates
[**GetGroupsForUser**](UsersGroupsApi.md#getgroupsforuser) | **GET** /users/{user_id}/groups | List groups a user is in
[**RemoveGroupMember**](UsersGroupsApi.md#removegroupmember) | **DELETE** /users/groups/{unique_name}/members/{user_id} | Removes a user from a group
[**UpdateGroup**](UsersGroupsApi.md#updategroup) | **PUT** /users/groups/{unique_name} | Update a group
[**UpdateGroupMemberStatus**](UsersGroupsApi.md#updategroupmemberstatus) | **PUT** /users/groups/{unique_name}/members/{user_id}/status | Change a user&#39;s status
[**UpdateGroupTemplate**](UsersGroupsApi.md#updategrouptemplate) | **PUT** /users/groups/templates/{id} | Update a group template
[**UpdateGroups**](UsersGroupsApi.md#updategroups) | **GET** /users/groups | List and search groups


<a name="addmembertogroup"></a>
# **AddMemberToGroup**
> ModelGroupMemberResource AddMemberToGroup (string uniqueName, ModelGroupMemberResource username)

Adds a new member to the group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddMemberToGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var username = new ModelGroupMemberResource(); // ModelGroupMemberResource | The username of a user to add to the group

            try
            {
                // Adds a new member to the group
                ModelGroupMemberResource result = apiInstance.AddMemberToGroup(uniqueName, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.AddMemberToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **username** | [**ModelGroupMemberResource**](ModelGroupMemberResource.md)| The username of a user to add to the group | 

### Return type

[**ModelGroupMemberResource**](ModelGroupMemberResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroup"></a>
# **CreateGroup**
> ModelGroupResource CreateGroup (ModelGroupResource groupResource)

Create a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var groupResource = new ModelGroupResource(); // ModelGroupResource | The new group (optional) 

            try
            {
                // Create a group
                ModelGroupResource result = apiInstance.CreateGroup(groupResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupResource** | [**ModelGroupResource**](ModelGroupResource.md)| The new group | [optional] 

### Return type

[**ModelGroupResource**](ModelGroupResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategrouptemplate"></a>
# **CreateGroupTemplate**
> ModelTemplateResource CreateGroupTemplate (ModelTemplateResource groupTemplateResource)

Create a group template

Group Templates define a type of group and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var groupTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The group template resource object (optional) 

            try
            {
                // Create a group template
                ModelTemplateResource result = apiInstance.CreateGroupTemplate(groupTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.CreateGroupTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The group template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string uniqueName)

Removes a group from the system IF no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Removes a group from the system IF no resources are attached to it
                apiInstance.DeleteGroup(uniqueName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegrouptemplate"></a>
# **DeleteGroupTemplate**
> void DeleteGroupTemplate (string id, string cascade)

Delete a group template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a group template
                apiInstance.DeleteGroupTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.DeleteGroupTemplate: " + e.Message );
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> ModelGroupResource GetGroup (string uniqueName)

Loads a specific group's details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Loads a specific group's details
                ModelGroupResource result = apiInstance.GetGroup(uniqueName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 

### Return type

[**ModelGroupResource**](ModelGroupResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmember"></a>
# **GetGroupMember**
> ModelGroupMemberResource GetGroupMember (string uniqueName, int? userId)

Get a user from a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupMemberExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get a user from a group
                ModelGroupMemberResource result = apiInstance.GetGroupMember(uniqueName, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The id of the user | 

### Return type

[**ModelGroupMemberResource**](ModelGroupMemberResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembers"></a>
# **GetGroupMembers**
> ModelPageResourceGroupMemberResource GetGroupMembers (string uniqueName, int? size, int? page, string order)

Lists members of the group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupMembersExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Lists members of the group
                ModelPageResourceGroupMemberResource result = apiInstance.GetGroupMembers(uniqueName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceGroupMemberResource**](ModelPageResourceGroupMemberResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouptemplate"></a>
# **GetGroupTemplate**
> ModelTemplateResource GetGroupTemplate (string id)

Get a single group template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single group template
                ModelTemplateResource result = apiInstance.GetGroupTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupTemplate: " + e.Message );
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

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouptemplates"></a>
# **GetGroupTemplates**
> ModelPageResourceTemplateResource GetGroupTemplates (int? size, int? page, string order)

List and search group templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search group templates
                ModelPageResourceTemplateResource result = apiInstance.GetGroupTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupTemplates: " + e.Message );
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
 **order** | **string**| a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**ModelPageResourceTemplateResource**](ModelPageResourceTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsforuser"></a>
# **GetGroupsForUser**
> List<string> GetGroupsForUser (int? userId)

List groups a user is in

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupsForUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var userId = 56;  // int? | The id of the user

            try
            {
                // List groups a user is in
                List&lt;string&gt; result = apiInstance.GetGroupsForUser(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.GetGroupsForUser: " + e.Message );
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

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removegroupmember"></a>
# **RemoveGroupMember**
> void RemoveGroupMember (string uniqueName, int? userId)

Removes a user from a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveGroupMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user to remove

            try
            {
                // Removes a user from a group
                apiInstance.RemoveGroupMember(uniqueName, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.RemoveGroupMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The id of the user to remove | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (string uniqueName, ModelGroupResource groupResource)

Update a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var groupResource = new ModelGroupResource(); // ModelGroupResource | The updated group (optional) 

            try
            {
                // Update a group
                apiInstance.UpdateGroup(uniqueName, groupResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **groupResource** | [**ModelGroupResource**](ModelGroupResource.md)| The updated group | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmemberstatus"></a>
# **UpdateGroupMemberStatus**
> void UpdateGroupMemberStatus (string uniqueName, int? userId, string status)

Change a user's status

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupMemberStatusExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The user id of the member to modify
            var status = status_example;  // string | The new status for the user

            try
            {
                // Change a user's status
                apiInstance.UpdateGroupMemberStatus(uniqueName, userId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroupMemberStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **int?**| The user id of the member to modify | 
 **status** | **string**| The new status for the user | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategrouptemplate"></a>
# **UpdateGroupTemplate**
> ModelTemplateResource UpdateGroupTemplate (string id, ModelTemplateResource groupTemplateResource)

Update a group template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersGroupsApi();
            var id = id_example;  // string | The id of the template
            var groupTemplateResource = new ModelTemplateResource(); // ModelTemplateResource | The group template resource object (optional) 

            try
            {
                // Update a group template
                ModelTemplateResource result = apiInstance.UpdateGroupTemplate(id, groupTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroupTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **groupTemplateResource** | [**ModelTemplateResource**](ModelTemplateResource.md)| The group template resource object | [optional] 

### Return type

[**ModelTemplateResource**](ModelTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroups"></a>
# **UpdateGroups**
> ModelPageResourceGroupResource UpdateGroups (int? size, int? page, string order)

List and search groups

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersGroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search groups
                ModelPageResourceGroupResource result = apiInstance.UpdateGroups(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersGroupsApi.UpdateGroups: " + e.Message );
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

[**ModelPageResourceGroupResource**](ModelPageResourceGroupResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

