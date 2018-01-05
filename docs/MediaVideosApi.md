# com.knetikcloud..MediaVideosApi

All URIs are relative to *https://devsandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserToVideoWhitelist**](MediaVideosApi.md#addusertovideowhitelist) | **POST** /media/videos/{id}/whitelist | Adds a user to a video&#39;s whitelist
[**AddVideo**](MediaVideosApi.md#addvideo) | **POST** /media/videos | Adds a new video in the system
[**AddVideoComment**](MediaVideosApi.md#addvideocomment) | **POST** /media/videos/{video_id}/comments | Add a new video comment
[**AddVideoContributor**](MediaVideosApi.md#addvideocontributor) | **POST** /media/videos/{video_id}/contributors | Adds a contributor to a video
[**AddVideoFlag**](MediaVideosApi.md#addvideoflag) | **POST** /media/videos/{video_id}/moderation | Add a new flag
[**AddVideoRelationships**](MediaVideosApi.md#addvideorelationships) | **POST** /media/videos/{video_id}/related | Adds one or more existing videos as related to this one
[**CreateVideoDisposition**](MediaVideosApi.md#createvideodisposition) | **POST** /media/videos/{video_id}/dispositions | Create a video disposition
[**CreateVideoTemplate**](MediaVideosApi.md#createvideotemplate) | **POST** /media/videos/templates | Create a video template
[**DeleteVideo**](MediaVideosApi.md#deletevideo) | **DELETE** /media/videos/{id} | Deletes a video from the system if no resources are attached to it
[**DeleteVideoComment**](MediaVideosApi.md#deletevideocomment) | **DELETE** /media/videos/{video_id}/comments/{id} | Delete a video comment
[**DeleteVideoDisposition**](MediaVideosApi.md#deletevideodisposition) | **DELETE** /media/videos/{video_id}/dispositions/{disposition_id} | Delete a video disposition
[**DeleteVideoFlag**](MediaVideosApi.md#deletevideoflag) | **DELETE** /media/videos/{video_id}/moderation | Delete a flag
[**DeleteVideoRelationship**](MediaVideosApi.md#deletevideorelationship) | **DELETE** /media/videos/{video_id}/related/{id} | Delete a video&#39;s relationship
[**DeleteVideoTemplate**](MediaVideosApi.md#deletevideotemplate) | **DELETE** /media/videos/templates/{id} | Delete a video template
[**GetUserVideos**](MediaVideosApi.md#getuservideos) | **GET** /users/{user_id}/videos | Get user videos
[**GetVideo**](MediaVideosApi.md#getvideo) | **GET** /media/videos/{id} | Loads a specific video details
[**GetVideoComments**](MediaVideosApi.md#getvideocomments) | **GET** /media/videos/{video_id}/comments | Returns a page of comments for a video
[**GetVideoDispositions**](MediaVideosApi.md#getvideodispositions) | **GET** /media/videos/{video_id}/dispositions | Returns a page of dispositions for a video
[**GetVideoRelationships**](MediaVideosApi.md#getvideorelationships) | **GET** /media/videos/{video_id}/related | Returns a page of video relationships
[**GetVideoTemplate**](MediaVideosApi.md#getvideotemplate) | **GET** /media/videos/templates/{id} | Get a single video template
[**GetVideoTemplates**](MediaVideosApi.md#getvideotemplates) | **GET** /media/videos/templates | List and search video templates
[**GetVideos**](MediaVideosApi.md#getvideos) | **GET** /media/videos | Search videos using the documented filters
[**RemoveUserFromVideoWhitelist**](MediaVideosApi.md#removeuserfromvideowhitelist) | **DELETE** /media/videos/{video_id}/whitelist/{id} | Removes a user from a video&#39;s whitelist
[**RemoveVideoContributor**](MediaVideosApi.md#removevideocontributor) | **DELETE** /media/videos/{video_id}/contributors/{id} | Removes a contributor from a video
[**UpdateVideo**](MediaVideosApi.md#updatevideo) | **PUT** /media/videos/{id} | Modifies a video&#39;s details
[**UpdateVideoComment**](MediaVideosApi.md#updatevideocomment) | **PUT** /media/videos/{video_id}/comments/{id}/content | Update a video comment
[**UpdateVideoRelationship**](MediaVideosApi.md#updatevideorelationship) | **PUT** /media/videos/{video_id}/related/{id}/relationship_details | Update a video&#39;s relationship details
[**UpdateVideoTemplate**](MediaVideosApi.md#updatevideotemplate) | **PUT** /media/videos/templates/{id} | Update a video template
[**ViewVideo**](MediaVideosApi.md#viewvideo) | **POST** /media/videos/{id}/views | Increment a video&#39;s view count


<a name="addusertovideowhitelist"></a>
# **AddUserToVideoWhitelist**
> void AddUserToVideoWhitelist (long? id, IntWrapper userId)

Adds a user to a video's whitelist

Whitelisted users can view video regardless of privacy setting.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddUserToVideoWhitelistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id
            var userId = new IntWrapper(); // IntWrapper | The user id (optional) 

            try
            {
                // Adds a user to a video's whitelist
                apiInstance.AddUserToVideoWhitelist(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddUserToVideoWhitelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 
 **userId** | [**IntWrapper**](IntWrapper.md)| The user id | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideo"></a>
# **AddVideo**
> VideoResource AddVideo (VideoResource videoResource)

Adds a new video in the system

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddVideoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoResource = new VideoResource(); // VideoResource | The video object (optional) 

            try
            {
                // Adds a new video in the system
                VideoResource result = apiInstance.AddVideo(videoResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoResource** | [**VideoResource**](VideoResource.md)| The video object | [optional] 

### Return type

[**VideoResource**](VideoResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideocomment"></a>
# **AddVideoComment**
> CommentResource AddVideoComment (int? videoId, CommentResource commentResource)

Add a new video comment

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddVideoCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id 
            var commentResource = new CommentResource(); // CommentResource | The comment object (optional) 

            try
            {
                // Add a new video comment
                CommentResource result = apiInstance.AddVideoComment(videoId, commentResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideoComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id  | 
 **commentResource** | [**CommentResource**](CommentResource.md)| The comment object | [optional] 

### Return type

[**CommentResource**](CommentResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideocontributor"></a>
# **AddVideoContributor**
> void AddVideoContributor (long? videoId, ContributionResource contributionResource)

Adds a contributor to a video

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddVideoContributorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var contributionResource = new ContributionResource(); // ContributionResource | The contribution object (optional) 

            try
            {
                // Adds a contributor to a video
                apiInstance.AddVideoContributor(videoId, contributionResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideoContributor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **contributionResource** | [**ContributionResource**](ContributionResource.md)| The contribution object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideoflag"></a>
# **AddVideoFlag**
> FlagResource AddVideoFlag (long? videoId, StringWrapper reason)

Add a new flag

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddVideoFlagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var reason = new StringWrapper(); // StringWrapper | The flag reason (optional) 

            try
            {
                // Add a new flag
                FlagResource result = apiInstance.AddVideoFlag(videoId, reason);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideoFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **reason** | [**StringWrapper**](StringWrapper.md)| The flag reason | [optional] 

### Return type

[**FlagResource**](FlagResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideorelationships"></a>
# **AddVideoRelationships**
> VideoRelationshipResource AddVideoRelationships (long? videoId, VideoRelationshipResource videoRelationshipResource)

Adds one or more existing videos as related to this one

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddVideoRelationshipsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var videoRelationshipResource = new VideoRelationshipResource(); // VideoRelationshipResource | The video relationship object  (optional) 

            try
            {
                // Adds one or more existing videos as related to this one
                VideoRelationshipResource result = apiInstance.AddVideoRelationships(videoId, videoRelationshipResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.AddVideoRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **videoRelationshipResource** | [**VideoRelationshipResource**](VideoRelationshipResource.md)| The video relationship object  | [optional] 

### Return type

[**VideoRelationshipResource**](VideoRelationshipResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvideodisposition"></a>
# **CreateVideoDisposition**
> DispositionResource CreateVideoDisposition (int? videoId, DispositionResource dispositionResource)

Create a video disposition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateVideoDispositionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var dispositionResource = new DispositionResource(); // DispositionResource | The disposition object (optional) 

            try
            {
                // Create a video disposition
                DispositionResource result = apiInstance.CreateVideoDisposition(videoId, dispositionResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.CreateVideoDisposition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **dispositionResource** | [**DispositionResource**](DispositionResource.md)| The disposition object | [optional] 

### Return type

[**DispositionResource**](DispositionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvideotemplate"></a>
# **CreateVideoTemplate**
> TemplateResource CreateVideoTemplate (TemplateResource videoTemplateResource)

Create a video template

Video Templates define a type of video and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreateVideoTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoTemplateResource = new TemplateResource(); // TemplateResource | The video template resource object (optional) 

            try
            {
                // Create a video template
                TemplateResource result = apiInstance.CreateVideoTemplate(videoTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.CreateVideoTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoTemplateResource** | [**TemplateResource**](TemplateResource.md)| The video template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideo"></a>
# **DeleteVideo**
> void DeleteVideo (long? id)

Deletes a video from the system if no resources are attached to it

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVideoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Deletes a video from the system if no resources are attached to it
                apiInstance.DeleteVideo(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideocomment"></a>
# **DeleteVideoComment**
> void DeleteVideoComment (long? videoId, long? id)

Delete a video comment

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVideoCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The comment id

            try
            {
                // Delete a video comment
                apiInstance.DeleteVideoComment(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The comment id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideodisposition"></a>
# **DeleteVideoDisposition**
> void DeleteVideoDisposition (long? dispositionId)

Delete a video disposition

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVideoDispositionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var dispositionId = 789;  // long? | The disposition id

            try
            {
                // Delete a video disposition
                apiInstance.DeleteVideoDisposition(dispositionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoDisposition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dispositionId** | **long?**| The disposition id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideoflag"></a>
# **DeleteVideoFlag**
> void DeleteVideoFlag (long? videoId)

Delete a flag

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVideoFlagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id

            try
            {
                // Delete a flag
                apiInstance.DeleteVideoFlag(videoId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideorelationship"></a>
# **DeleteVideoRelationship**
> void DeleteVideoRelationship (long? videoId, long? id)

Delete a video's relationship

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeleteVideoRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The relationship id

            try
            {
                // Delete a video's relationship
                apiInstance.DeleteVideoRelationship(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The relationship id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideotemplate"></a>
# **DeleteVideoTemplate**
> void DeleteVideoTemplate (string id, string cascade)

Delete a video template

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
    public class DeleteVideoTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a video template
                apiInstance.DeleteVideoTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.DeleteVideoTemplate: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuservideos"></a>
# **GetUserVideos**
> PageResourceVideoResource GetUserVideos (int? userId, bool? excludeFlagged, int? size, int? page)

Get user videos

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetUserVideosExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var userId = 56;  // int? | The user id
            var excludeFlagged = true;  // bool? | Skip videos that have been flagged by the current user (optional)  (default to true)
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Get user videos
                PageResourceVideoResource result = apiInstance.GetUserVideos(userId, excludeFlagged, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetUserVideos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| The user id | 
 **excludeFlagged** | **bool?**| Skip videos that have been flagged by the current user | [optional] [default to true]
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceVideoResource**](PageResourceVideoResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideo"></a>
# **GetVideo**
> VideoResource GetVideo (long? id)

Loads a specific video details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Loads a specific video details
                VideoResource result = apiInstance.GetVideo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

[**VideoResource**](VideoResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocomments"></a>
# **GetVideoComments**
> PageResourceCommentResource GetVideoComments (int? videoId, int? size, int? page)

Returns a page of comments for a video

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoCommentsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of comments for a video
                PageResourceCommentResource result = apiInstance.GetVideoComments(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceCommentResource**](PageResourceCommentResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideodispositions"></a>
# **GetVideoDispositions**
> PageResourceDispositionResource GetVideoDispositions (int? videoId, int? size, int? page)

Returns a page of dispositions for a video

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoDispositionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 56;  // int? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of dispositions for a video
                PageResourceDispositionResource result = apiInstance.GetVideoDispositions(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoDispositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **int?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceDispositionResource**](PageResourceDispositionResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideorelationships"></a>
# **GetVideoRelationships**
> PageResourceVideoRelationshipResource GetVideoRelationships (long? videoId, int? size, int? page)

Returns a page of video relationships

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoRelationshipsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)

            try
            {
                // Returns a page of video relationships
                PageResourceVideoRelationshipResource result = apiInstance.GetVideoRelationships(videoId, size, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoRelationships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]

### Return type

[**PageResourceVideoRelationshipResource**](PageResourceVideoRelationshipResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideotemplate"></a>
# **GetVideoTemplate**
> TemplateResource GetVideoTemplate (string id)

Get a single video template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single video template
                TemplateResource result = apiInstance.GetVideoTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoTemplate: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideotemplates"></a>
# **GetVideoTemplates**
> PageResourceTemplateResource GetVideoTemplates (int? size, int? page, string order)

List and search video templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideoTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search video templates
                PageResourceTemplateResource result = apiInstance.GetVideoTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideoTemplates: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideos"></a>
# **GetVideos**
> PageResourceVideoResource GetVideos (bool? excludeFlagged, int? filterVideosByUploader, string filterCategory, string filterTagset, string filterVideosByName, int? filterVideosByContributor, int? filterVideosByAuthor, bool? filterHasAuthor, bool? filterHasUploader, string filterRelatedTo, bool? filterFriends, string filterDisposition, int? size, int? page, string order)

Search videos using the documented filters

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetVideosExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var excludeFlagged = true;  // bool? | Skip videos that have been flagged by the current user (optional)  (default to true)
            var filterVideosByUploader = 56;  // int? | Filter for videos by uploader id (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for videos from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for videos with specified tags (separated by comma) (optional) 
            var filterVideosByName = filterVideosByName_example;  // string | Filter for videos which name *STARTS* with the given string (optional) 
            var filterVideosByContributor = 56;  // int? | Filter for videos with contribution from the artist specified by ID (optional) 
            var filterVideosByAuthor = 56;  // int? | Filter for videos with an artist as author specified by ID (optional) 
            var filterHasAuthor = true;  // bool? | Filter for videos that have an author set if true, or that have no author if false (optional) 
            var filterHasUploader = true;  // bool? | Filter for videos that have an uploader set if true, or that have no uploader if false (optional) 
            var filterRelatedTo = filterRelatedTo_example;  // string | Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well (optional) 
            var filterFriends = true;  // bool? | Filter for videos uploaded by friends. 'true' for friends of the caller (requires user token) or a user id for a specific user's friends (requires VIDEOS_ADMIN permission) (optional) 
            var filterDisposition = filterDisposition_example;  // string | Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or 'me' for the caller (requires user token for 'me') and DISPOSITION is the name of the disposition. E.G. filter_disposition=123:like or filter_disposition=me:favorite (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to author:ASC)

            try
            {
                // Search videos using the documented filters
                PageResourceVideoResource result = apiInstance.GetVideos(excludeFlagged, filterVideosByUploader, filterCategory, filterTagset, filterVideosByName, filterVideosByContributor, filterVideosByAuthor, filterHasAuthor, filterHasUploader, filterRelatedTo, filterFriends, filterDisposition, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.GetVideos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeFlagged** | **bool?**| Skip videos that have been flagged by the current user | [optional] [default to true]
 **filterVideosByUploader** | **int?**| Filter for videos by uploader id | [optional] 
 **filterCategory** | **string**| Filter for videos from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for videos with specified tags (separated by comma) | [optional] 
 **filterVideosByName** | **string**| Filter for videos which name *STARTS* with the given string | [optional] 
 **filterVideosByContributor** | **int?**| Filter for videos with contribution from the artist specified by ID | [optional] 
 **filterVideosByAuthor** | **int?**| Filter for videos with an artist as author specified by ID | [optional] 
 **filterHasAuthor** | **bool?**| Filter for videos that have an author set if true, or that have no author if false | [optional] 
 **filterHasUploader** | **bool?**| Filter for videos that have an uploader set if true, or that have no uploader if false | [optional] 
 **filterRelatedTo** | **string**| Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well | [optional] 
 **filterFriends** | **bool?**| Filter for videos uploaded by friends. &#39;true&#39; for friends of the caller (requires user token) or a user id for a specific user&#39;s friends (requires VIDEOS_ADMIN permission) | [optional] 
 **filterDisposition** | **string**| Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or &#39;me&#39; for the caller (requires user token for &#39;me&#39;) and DISPOSITION is the name of the disposition. E.G. filter_disposition&#x3D;123:like or filter_disposition&#x3D;me:favorite | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to author:ASC]

### Return type

[**PageResourceVideoResource**](PageResourceVideoResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserfromvideowhitelist"></a>
# **RemoveUserFromVideoWhitelist**
> void RemoveUserFromVideoWhitelist (long? videoId, int? id)

Removes a user from a video's whitelist

Remove the user with the id given in the path from the whitelist of users that can view this video regardless of privacy setting.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveUserFromVideoWhitelistExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 56;  // int? | The user id

            try
            {
                // Removes a user from a video's whitelist
                apiInstance.RemoveUserFromVideoWhitelist(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.RemoveUserFromVideoWhitelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **int?**| The user id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideocontributor"></a>
# **RemoveVideoContributor**
> void RemoveVideoContributor (long? videoId, int? id)

Removes a contributor from a video

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class RemoveVideoContributorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 56;  // int? | The contributor id

            try
            {
                // Removes a contributor from a video
                apiInstance.RemoveVideoContributor(videoId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.RemoveVideoContributor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **int?**| The contributor id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideo"></a>
# **UpdateVideo**
> void UpdateVideo (long? id, VideoResource videoResource)

Modifies a video's details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVideoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id
            var videoResource = new VideoResource(); // VideoResource | The video object (optional) 

            try
            {
                // Modifies a video's details
                apiInstance.UpdateVideo(id, videoResource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 
 **videoResource** | [**VideoResource**](VideoResource.md)| The video object | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideocomment"></a>
# **UpdateVideoComment**
> void UpdateVideoComment (long? videoId, long? id, StringWrapper content)

Update a video comment

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVideoCommentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var id = 789;  // long? | The comment id
            var content = new StringWrapper(); // StringWrapper | The comment content (optional) 

            try
            {
                // Update a video comment
                apiInstance.UpdateVideoComment(videoId, id, content);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateVideoComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **id** | **long?**| The comment id | 
 **content** | [**StringWrapper**](StringWrapper.md)| The comment content | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideorelationship"></a>
# **UpdateVideoRelationship**
> void UpdateVideoRelationship (long? videoId, long? relationshipId, StringWrapper details)

Update a video's relationship details

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVideoRelationshipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var videoId = 789;  // long? | The video id
            var relationshipId = 789;  // long? | The relationship id
            var details = new StringWrapper(); // StringWrapper | The video relationship details (optional) 

            try
            {
                // Update a video's relationship details
                apiInstance.UpdateVideoRelationship(videoId, relationshipId, details);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateVideoRelationship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoId** | **long?**| The video id | 
 **relationshipId** | **long?**| The relationship id | 
 **details** | [**StringWrapper**](StringWrapper.md)| The video relationship details | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevideotemplate"></a>
# **UpdateVideoTemplate**
> TemplateResource UpdateVideoTemplate (string id, TemplateResource videoTemplateResource)

Update a video template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdateVideoTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = id_example;  // string | The id of the template
            var videoTemplateResource = new TemplateResource(); // TemplateResource | The video template resource object (optional) 

            try
            {
                // Update a video template
                TemplateResource result = apiInstance.UpdateVideoTemplate(id, videoTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.UpdateVideoTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **videoTemplateResource** | [**TemplateResource**](TemplateResource.md)| The video template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewvideo"></a>
# **ViewVideo**
> void ViewVideo (long? id)

Increment a video's view count

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class ViewVideoExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_client_credentials_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_password_grant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MediaVideosApi();
            var id = 789;  // long? | The video id

            try
            {
                // Increment a video's view count
                apiInstance.ViewVideo(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVideosApi.ViewVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The video id | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials_grant](../README.md#oauth2_client_credentials_grant), [oauth2_password_grant](../README.md#oauth2_password_grant)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

