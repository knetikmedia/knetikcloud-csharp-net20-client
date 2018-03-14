# com.knetikcloud..Users_GroupsApi

All URIs are relative to *https://jsapi-integration.us-east-1.elasticbeanstalk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMemberToGroup**](Users_GroupsApi.md#addmembertogroup) | **POST** /users/groups/{unique_name}/members | Adds a new member to the group
[**AddMembersToGroup**](Users_GroupsApi.md#addmemberstogroup) | **POST** /users/groups/{unique_name}/members/batch-add | Adds multiple members to the group
[**CreateGroup**](Users_GroupsApi.md#creategroup) | **POST** /users/groups | Create a group
[**CreateGroupMemberTemplate**](Users_GroupsApi.md#creategroupmembertemplate) | **POST** /users/groups/members/templates | Create an group member template
[**CreateGroupTemplate**](Users_GroupsApi.md#creategrouptemplate) | **POST** /users/groups/templates | Create a group template
[**DeleteGroup**](Users_GroupsApi.md#deletegroup) | **DELETE** /users/groups/{unique_name} | Removes a group from the system
[**DeleteGroupMemberTemplate**](Users_GroupsApi.md#deletegroupmembertemplate) | **DELETE** /users/groups/members/templates/{id} | Delete an group member template
[**DeleteGroupTemplate**](Users_GroupsApi.md#deletegrouptemplate) | **DELETE** /users/groups/templates/{id} | Delete a group template
[**DisableGroupNotification**](Users_GroupsApi.md#disablegroupnotification) | **PUT** /users/groups/{unique_name}/members/{user_id}/messages/disabled | Enable or disable notification of group messages
[**GetGroup**](Users_GroupsApi.md#getgroup) | **GET** /users/groups/{unique_name} | Loads a specific group&#39;s details
[**GetGroupAncestors**](Users_GroupsApi.md#getgroupancestors) | **GET** /users/groups/{unique_name}/ancestors | Get group ancestors
[**GetGroupMember**](Users_GroupsApi.md#getgroupmember) | **GET** /users/groups/{unique_name}/members/{user_id} | Get a user from a group
[**GetGroupMemberTemplate**](Users_GroupsApi.md#getgroupmembertemplate) | **GET** /users/groups/members/templates/{id} | Get a single group member template
[**GetGroupMemberTemplates**](Users_GroupsApi.md#getgroupmembertemplates) | **GET** /users/groups/members/templates | List and search group member templates
[**GetGroupMembers**](Users_GroupsApi.md#getgroupmembers) | **GET** /users/groups/{unique_name}/members | Lists members of the group
[**GetGroupMessages**](Users_GroupsApi.md#getgroupmessages) | **GET** /users/groups/{unique_name}/messages | Get a list of group messages
[**GetGroupTemplate**](Users_GroupsApi.md#getgrouptemplate) | **GET** /users/groups/templates/{id} | Get a single group template
[**GetGroupTemplates**](Users_GroupsApi.md#getgrouptemplates) | **GET** /users/groups/templates | List and search group templates
[**GetGroupsForUser**](Users_GroupsApi.md#getgroupsforuser) | **GET** /users/{user_id}/groups | List groups a user is in
[**ListGroups**](Users_GroupsApi.md#listgroups) | **GET** /users/groups | List and search groups
[**PostGroupMessage**](Users_GroupsApi.md#postgroupmessage) | **POST** /users/groups/{unique_name}/messages | Send a group message
[**RemoveGroupMember**](Users_GroupsApi.md#removegroupmember) | **DELETE** /users/groups/{unique_name}/members/{user_id} | Removes a user from a group
[**UpdateGroup**](Users_GroupsApi.md#updategroup) | **PUT** /users/groups/{unique_name} | Update a group
[**UpdateGroupMemberProperties**](Users_GroupsApi.md#updategroupmemberproperties) | **PUT** /users/groups/{unique_name}/members/{user_id}/order | Change a user&#39;s order
[**UpdateGroupMemberProperties1**](Users_GroupsApi.md#updategroupmemberproperties1) | **PUT** /users/groups/{unique_name}/members/{user_id}/properties | Change a user&#39;s membership properties
[**UpdateGroupMemberStatus**](Users_GroupsApi.md#updategroupmemberstatus) | **PUT** /users/groups/{unique_name}/members/{user_id}/status | Change a user&#39;s status
[**UpdateGroupMemberTemplate**](Users_GroupsApi.md#updategroupmembertemplate) | **PUT** /users/groups/members/templates/{id} | Update an group member template
[**UpdateGroupTemplate**](Users_GroupsApi.md#updategrouptemplate) | **PUT** /users/groups/templates/{id} | Update a group template


<a name="addmembertogroup"></a>
# **AddMemberToGroup**
> GroupMemberResource AddMemberToGroup (string uniqueName, GroupMemberResource user)

Adds a new member to the group

<b>Permissions Needed:</b> GROUP_ADMIN or self if open

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var user = new GroupMemberResource(); // GroupMemberResource | The id and status for a user to add to the group

            try
            {
                // Adds a new member to the group
                GroupMemberResource result = apiInstance.AddMemberToGroup(uniqueName, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.AddMemberToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **user** | [**GroupMemberResource**](GroupMemberResource.md)| The id and status for a user to add to the group | 

### Return type

[**GroupMemberResource**](GroupMemberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmemberstogroup"></a>
# **AddMembersToGroup**
> List<GroupMemberResource> AddMembersToGroup (string uniqueName, List<GroupMemberResource> users)

Adds multiple members to the group

<b>Permissions Needed:</b> GROUP_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddMembersToGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var users = new List<GroupMemberResource>(); // List<GroupMemberResource> | The id and status for a list of users to add to the group

            try
            {
                // Adds multiple members to the group
                List&lt;GroupMemberResource&gt; result = apiInstance.AddMembersToGroup(uniqueName, users);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.AddMembersToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **users** | [**List<GroupMemberResource>**](GroupMemberResource.md)| The id and status for a list of users to add to the group | 

### Return type

[**List<GroupMemberResource>**](GroupMemberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroup"></a>
# **CreateGroup**
> GroupResource CreateGroup (GroupResource groupResource)

Create a group

<b>Permissions Needed:</b> GROUP_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var groupResource = new GroupResource(); // GroupResource | The new group (optional) 

            try
            {
                // Create a group
                GroupResource result = apiInstance.CreateGroup(groupResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupResource** | [**GroupResource**](GroupResource.md)| The new group | [optional] 

### Return type

[**GroupResource**](GroupResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategroupmembertemplate"></a>
# **CreateGroupMemberTemplate**
> TemplateResource CreateGroupMemberTemplate (TemplateResource groupMemberTemplateResource)

Create an group member template

GroupMember Templates define a type of group member and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateGroupMemberTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var groupMemberTemplateResource = new TemplateResource(); // TemplateResource | The group member template resource object (optional) 

            try
            {
                // Create an group member template
                TemplateResource result = apiInstance.CreateGroupMemberTemplate(groupMemberTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.CreateGroupMemberTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupMemberTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group member template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategrouptemplate"></a>
# **CreateGroupTemplate**
> TemplateResource CreateGroupTemplate (TemplateResource groupTemplateResource)

Create a group template

Group Templates define a type of group and the properties they have. <br><br><b>Permissions Needed:</b> TEMPLATE_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var groupTemplateResource = new TemplateResource(); // TemplateResource | The group template resource object (optional) 

            try
            {
                // Create a group template
                TemplateResource result = apiInstance.CreateGroupTemplate(groupTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.CreateGroupTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string uniqueName)

Removes a group from the system

All groups listing this as the parent are also removed and users are in turn removed from this and those groups. This may result in users no longer being in this group's parent if they were not added to it directly as well. <br><br><b>Permissions Needed:</b> GROUP_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Removes a group from the system
                apiInstance.DeleteGroup(uniqueName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.DeleteGroup: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupmembertemplate"></a>
# **DeleteGroupMemberTemplate**
> void DeleteGroupMemberTemplate (string id, string cascade)

Delete an group member template

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
    public class DeleteGroupMemberTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete an group member template
                apiInstance.DeleteGroupMemberTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.DeleteGroupMemberTemplate: " + e.Message );
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

<a name="deletegrouptemplate"></a>
# **DeleteGroupTemplate**
> void DeleteGroupTemplate (string id, string cascade)

Delete a group template

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
    public class DeleteGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a group template
                apiInstance.DeleteGroupTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.DeleteGroupTemplate: " + e.Message );
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

<a name="disablegroupnotification"></a>
# **DisableGroupNotification**
> void DisableGroupNotification (string uniqueName, string userId, ValueWrapperboolean disabled)

Enable or disable notification of group messages

<b>Permissions Needed:</b> TOPICS_ADMIN or self

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DisableGroupNotificationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = userId_example;  // string | The user id of the member or 'me'
            var disabled = new ValueWrapperboolean(); // ValueWrapperboolean | disabled

            try
            {
                // Enable or disable notification of group messages
                apiInstance.DisableGroupNotification(uniqueName, userId, disabled);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.DisableGroupNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **userId** | **string**| The user id of the member or &#39;me&#39; | 
 **disabled** | [**ValueWrapperboolean**](ValueWrapperboolean.md)| disabled | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> GroupResource GetGroup (string uniqueName)

Loads a specific group's details

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
    public class GetGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Loads a specific group's details
                GroupResource result = apiInstance.GetGroup(uniqueName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroup: " + e.Message );
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

[**GroupResource**](GroupResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupancestors"></a>
# **GetGroupAncestors**
> List<GroupResource> GetGroupAncestors (string uniqueName)

Get group ancestors

Returns a list of ancestor groups in reverse order (parent, then grandparent, etc). <br><br><b>Permissions Needed:</b> ANY

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupAncestorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name

            try
            {
                // Get group ancestors
                List&lt;GroupResource&gt; result = apiInstance.GetGroupAncestors(uniqueName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupAncestors: " + e.Message );
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

[**List<GroupResource>**](GroupResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmember"></a>
# **GetGroupMember**
> GroupMemberResource GetGroupMember (string uniqueName, int? userId)

Get a user from a group

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
    public class GetGroupMemberExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user

            try
            {
                // Get a user from a group
                GroupMemberResource result = apiInstance.GetGroupMember(uniqueName, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupMember: " + e.Message );
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

[**GroupMemberResource**](GroupMemberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembertemplate"></a>
# **GetGroupMemberTemplate**
> TemplateResource GetGroupMemberTemplate (string id)

Get a single group member template

<b>Permissions Needed:</b> TEMPLATE_ADMIN or GROUP_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupMemberTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single group member template
                TemplateResource result = apiInstance.GetGroupMemberTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupMemberTemplate: " + e.Message );
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

<a name="getgroupmembertemplates"></a>
# **GetGroupMemberTemplates**
> PageResourceTemplateResource GetGroupMemberTemplates (int? size, int? page, string order)

List and search group member templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or GROUP_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetGroupMemberTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search group member templates
                PageResourceTemplateResource result = apiInstance.GetGroupMemberTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupMemberTemplates: " + e.Message );
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

<a name="getgroupmembers"></a>
# **GetGroupMembers**
> PageResourceGroupMemberResource GetGroupMembers (string uniqueName, int? size, int? page, string order)

Lists members of the group

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
    public class GetGroupMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to order:ASC)

            try
            {
                // Lists members of the group
                PageResourceGroupMemberResource result = apiInstance.GetGroupMembers(uniqueName, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupMembers: " + e.Message );
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
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to order:ASC]

### Return type

[**PageResourceGroupMemberResource**](PageResourceGroupMemberResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmessages"></a>
# **GetGroupMessages**
> PageResourceChatMessageResource GetGroupMessages (string uniqueName, int? size, int? page)

Get a list of group messages

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
    public class GetGroupMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get a list of group messages
                PageResourceChatMessageResource result = apiInstance.GetGroupMessages(uniqueName, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupMessages: " + e.Message );
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

### Return type

[**PageResourceChatMessageResource**](PageResourceChatMessageResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgrouptemplate"></a>
# **GetGroupTemplate**
> TemplateResource GetGroupTemplate (string id)

Get a single group template

<b>Permissions Needed:</b> TEMPLATE_ADMIN or GROUP_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single group template
                TemplateResource result = apiInstance.GetGroupTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupTemplate: " + e.Message );
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

<a name="getgrouptemplates"></a>
# **GetGroupTemplates**
> PageResourceTemplateResource GetGroupTemplates (int? size, int? page, string order)

List and search group templates

<b>Permissions Needed:</b> TEMPLATE_ADMIN or GROUP_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | a comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search group templates
                PageResourceTemplateResource result = apiInstance.GetGroupTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupTemplates: " + e.Message );
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

[**PageResourceTemplateResource**](PageResourceTemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsforuser"></a>
# **GetGroupsForUser**
> List<string> GetGroupsForUser (int? userId, bool? filterChildren)

List groups a user is in

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
    public class GetGroupsForUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var userId = 56;  // int? | The id of the user
            var filterChildren = true;  // bool? | Whether to limit group list to children of groups only. If true, shows only groups with parents. If false, shows only groups with no parent. (optional) 

            try
            {
                // List groups a user is in
                List&lt;string&gt; result = apiInstance.GetGroupsForUser(userId, filterChildren);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.GetGroupsForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The id of the user | 
 **filterChildren** | **bool?**| Whether to limit group list to children of groups only. If true, shows only groups with parents. If false, shows only groups with no parent. | [optional] 

### Return type

**List<string>**

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgroups"></a>
# **ListGroups**
> PageResourceGroupResource ListGroups (string filterTemplate, string filterMemberCount, string filterName, string filterUniqueName, string filterParent, string filterStatus, int? size, int? page, string order)

List and search groups

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
    public class ListGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var filterTemplate = filterTemplate_example;  // string | Filter for groups using a specific template, by id (optional) 
            var filterMemberCount = filterMemberCount_example;  // string | Filters groups by member count. Multiple values possible for range search. Format: filter_member_count=OP,ts&... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_member_count=GT,14,LT,17 (optional) 
            var filterName = filterName_example;  // string | Filter for groups with names starting with the given string (optional) 
            var filterUniqueName = filterUniqueName_example;  // string | Filter for groups whose unique_name starts with provided string (optional) 
            var filterParent = filterParent_example;  // string | Filter for groups with a specific parent, by unique name (optional) 
            var filterStatus = filterStatus_example;  // string | Filter for groups with a certain status (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to name:ASC)

            try
            {
                // List and search groups
                PageResourceGroupResource result = apiInstance.ListGroups(filterTemplate, filterMemberCount, filterName, filterUniqueName, filterParent, filterStatus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.ListGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterTemplate** | **string**| Filter for groups using a specific template, by id | [optional] 
 **filterMemberCount** | **string**| Filters groups by member count. Multiple values possible for range search. Format: filter_member_count&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ). Ex: filter_member_count&#x3D;GT,14,LT,17 | [optional] 
 **filterName** | **string**| Filter for groups with names starting with the given string | [optional] 
 **filterUniqueName** | **string**| Filter for groups whose unique_name starts with provided string | [optional] 
 **filterParent** | **string**| Filter for groups with a specific parent, by unique name | [optional] 
 **filterStatus** | **string**| Filter for groups with a certain status | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to name:ASC]

### Return type

[**PageResourceGroupResource**](PageResourceGroupResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgroupmessage"></a>
# **PostGroupMessage**
> ChatMessageResource PostGroupMessage (string uniqueName, ChatMessageRequest chatMessageRequest)

Send a group message

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class PostGroupMessageExample
    {
        public void main()
        {
            
            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var chatMessageRequest = new ChatMessageRequest(); // ChatMessageRequest | The chat message request (optional) 

            try
            {
                // Send a group message
                ChatMessageResource result = apiInstance.PostGroupMessage(uniqueName, chatMessageRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.PostGroupMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **chatMessageRequest** | [**ChatMessageRequest**](ChatMessageRequest.md)| The chat message request | [optional] 

### Return type

[**ChatMessageResource**](ChatMessageResource.md)

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

<b>Permissions Needed:</b> GROUP_ADMIN or self if open

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The id of the user to remove

            try
            {
                // Removes a user from a group
                apiInstance.RemoveGroupMember(uniqueName, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.RemoveGroupMember: " + e.Message );
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

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (string uniqueName, GroupResource groupResource)

Update a group

If adding/removing/changing parent, user membership in group/new parent groups may be modified. The parent being removed will remove members from this sub group unless they were added explicitly to the parent and the new parent will gain members unless they were already a part of it. <br><br><b>Permissions Needed:</b> GROUP_ADMIN or admin of the group

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var groupResource = new GroupResource(); // GroupResource | The updated group (optional) 

            try
            {
                // Update a group
                apiInstance.UpdateGroup(uniqueName, groupResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueName** | **string**| The group unique name | 
 **groupResource** | [**GroupResource**](GroupResource.md)| The updated group | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmemberproperties"></a>
# **UpdateGroupMemberProperties**
> void UpdateGroupMemberProperties (string uniqueName, int? userId, StringWrapper order)

Change a user's order

<b>Permissions Needed:</b> GROUP_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupMemberPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The user id of the member to modify
            var order = new StringWrapper(); // StringWrapper | The new order for the membership

            try
            {
                // Change a user's order
                apiInstance.UpdateGroupMemberProperties(uniqueName, userId, order);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroupMemberProperties: " + e.Message );
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
 **order** | [**StringWrapper**](StringWrapper.md)| The new order for the membership | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmemberproperties1"></a>
# **UpdateGroupMemberProperties1**
> void UpdateGroupMemberProperties1 (string uniqueName, int? userId, Object properties)

Change a user's membership properties

<b>Permissions Needed:</b> GROUP_ADMIN

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateGroupMemberProperties1Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The user id of the member to modify
            var properties = ;  // Object | The new properties for the membership

            try
            {
                // Change a user's membership properties
                apiInstance.UpdateGroupMemberProperties1(uniqueName, userId, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroupMemberProperties1: " + e.Message );
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
 **properties** | **Object**| The new properties for the membership | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmemberstatus"></a>
# **UpdateGroupMemberStatus**
> void UpdateGroupMemberStatus (string uniqueName, int? userId, GroupMemberStatusWrapper status)

Change a user's status

<b>Permissions Needed:</b> GROUP_ADMIN

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
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var uniqueName = uniqueName_example;  // string | The group unique name
            var userId = 56;  // int? | The user id of the member to modify
            var status = new GroupMemberStatusWrapper(); // GroupMemberStatusWrapper | The new status for the user

            try
            {
                // Change a user's status
                apiInstance.UpdateGroupMemberStatus(uniqueName, userId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroupMemberStatus: " + e.Message );
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
 **status** | [**GroupMemberStatusWrapper**](GroupMemberStatusWrapper.md)| The new status for the user | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupmembertemplate"></a>
# **UpdateGroupMemberTemplate**
> TemplateResource UpdateGroupMemberTemplate (string id, TemplateResource groupMemberTemplateResource)

Update an group member template

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
    public class UpdateGroupMemberTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template
            var groupMemberTemplateResource = new TemplateResource(); // TemplateResource | The group member template resource object (optional) 

            try
            {
                // Update an group member template
                TemplateResource result = apiInstance.UpdateGroupMemberTemplate(id, groupMemberTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroupMemberTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **groupMemberTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group member template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategrouptemplate"></a>
# **UpdateGroupTemplate**
> TemplateResource UpdateGroupTemplate (string id, TemplateResource groupTemplateResource)

Update a group template

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
    public class UpdateGroupTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Users_GroupsApi();
            var id = id_example;  // string | The id of the template
            var groupTemplateResource = new TemplateResource(); // TemplateResource | The group template resource object (optional) 

            try
            {
                // Update a group template
                TemplateResource result = apiInstance.UpdateGroupTemplate(id, groupTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Users_GroupsApi.UpdateGroupTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **groupTemplateResource** | [**TemplateResource**](TemplateResource.md)| The group template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

