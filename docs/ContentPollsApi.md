# com.knetikcloud..ContentPollsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerPoll**](ContentPollsApi.md#answerpoll) | **POST** /media/polls/{id}/response | Add your vote to a poll
[**CreatePoll**](ContentPollsApi.md#createpoll) | **POST** /media/polls | Create a new poll
[**CreatePollTemplate**](ContentPollsApi.md#createpolltemplate) | **POST** /media/polls/templates | Create a poll template
[**DeletePoll**](ContentPollsApi.md#deletepoll) | **DELETE** /media/polls/{id} | Delete an existing poll
[**DeletePollTemplate**](ContentPollsApi.md#deletepolltemplate) | **DELETE** /media/polls/templates/{id} | Delete a poll template
[**GetPoll**](ContentPollsApi.md#getpoll) | **GET** /media/polls/{id} | Get a single poll
[**GetPollAnswer**](ContentPollsApi.md#getpollanswer) | **GET** /media/polls/{id}/response | Get poll answer
[**GetPollTemplate**](ContentPollsApi.md#getpolltemplate) | **GET** /media/polls/templates/{id} | Get a single poll template
[**GetPollTemplates**](ContentPollsApi.md#getpolltemplates) | **GET** /media/polls/templates | List and search poll templates
[**GetPolls**](ContentPollsApi.md#getpolls) | **GET** /media/polls | List and search polls
[**UpdatePoll**](ContentPollsApi.md#updatepoll) | **PUT** /media/polls/{id} | Update an existing poll
[**UpdatePollTemplate**](ContentPollsApi.md#updatepolltemplate) | **PUT** /media/polls/templates/{id} | Update a poll template


<a name="answerpoll"></a>
# **AnswerPoll**
> PollResponseResource AnswerPoll (string id, StringWrapper answerKey)

Add your vote to a poll

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AnswerPollExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id
            var answerKey = new StringWrapper(); // StringWrapper | The answer key (optional) 

            try
            {
                // Add your vote to a poll
                PollResponseResource result = apiInstance.AnswerPoll(id, answerKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.AnswerPoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 
 **answerKey** | [**StringWrapper**](StringWrapper.md)| The answer key | [optional] 

### Return type

[**PollResponseResource**](PollResponseResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpoll"></a>
# **CreatePoll**
> PollResource CreatePoll (PollResource pollResource)

Create a new poll

Polls are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreatePollExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var pollResource = new PollResource(); // PollResource | The poll object (optional) 

            try
            {
                // Create a new poll
                PollResource result = apiInstance.CreatePoll(pollResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.CreatePoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pollResource** | [**PollResource**](PollResource.md)| The poll object | [optional] 

### Return type

[**PollResource**](PollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpolltemplate"></a>
# **CreatePollTemplate**
> TemplateResource CreatePollTemplate (TemplateResource pollTemplateResource)

Create a poll template

Poll templates define a type of poll and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class CreatePollTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var pollTemplateResource = new TemplateResource(); // TemplateResource | The poll template resource object (optional) 

            try
            {
                // Create a poll template
                TemplateResource result = apiInstance.CreatePollTemplate(pollTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.CreatePollTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pollTemplateResource** | [**TemplateResource**](TemplateResource.md)| The poll template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepoll"></a>
# **DeletePoll**
> void DeletePoll (string id)

Delete an existing poll

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class DeletePollExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Delete an existing poll
                apiInstance.DeletePoll(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.DeletePoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepolltemplate"></a>
# **DeletePollTemplate**
> void DeletePollTemplate (string id, string cascade)

Delete a poll template

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
    public class DeletePollTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a poll template
                apiInstance.DeletePollTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.DeletePollTemplate: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoll"></a>
# **GetPoll**
> PollResource GetPoll (string id)

Get a single poll

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPollExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Get a single poll
                PollResource result = apiInstance.GetPoll(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

[**PollResource**](PollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpollanswer"></a>
# **GetPollAnswer**
> PollResponseResource GetPollAnswer (string id)

Get poll answer

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPollAnswerExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id

            try
            {
                // Get poll answer
                PollResponseResource result = apiInstance.GetPollAnswer(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 

### Return type

[**PollResponseResource**](PollResponseResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolltemplate"></a>
# **GetPollTemplate**
> TemplateResource GetPollTemplate (string id)

Get a single poll template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPollTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single poll template
                TemplateResource result = apiInstance.GetPollTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollTemplate: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolltemplates"></a>
# **GetPollTemplates**
> PageResourceTemplateResource GetPollTemplates (int? size, int? page, string order)

List and search poll templates

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPollTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search poll templates
                PageResourceTemplateResource result = apiInstance.GetPollTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPollTemplates: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolls"></a>
# **GetPolls**
> PageResourcePollResource GetPolls (string filterCategory, string filterTagset, string filterText, int? size, int? page, string order)

List and search polls

Get a list of polls with optional filtering. Assets will not be filled in on the resources returned. Use 'Get a single poll' to retrieve the full resource with assets for a given item as needed.

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class GetPollsExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var filterCategory = filterCategory_example;  // string | Filter for polls from a specific category by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for polls with specified tags (separated by comma) (optional) 
            var filterText = filterText_example;  // string | Filter for polls whose text contains a string (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search polls
                PageResourcePollResource result = apiInstance.GetPolls(filterCategory, filterTagset, filterText, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.GetPolls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterCategory** | **string**| Filter for polls from a specific category by id | [optional] 
 **filterTagset** | **string**| Filter for polls with specified tags (separated by comma) | [optional] 
 **filterText** | **string**| Filter for polls whose text contains a string | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourcePollResource**](PageResourcePollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepoll"></a>
# **UpdatePoll**
> PollResource UpdatePoll (string id, PollResource pollResource)

Update an existing poll

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdatePollExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The poll id
            var pollResource = new PollResource(); // PollResource | The poll object (optional) 

            try
            {
                // Update an existing poll
                PollResource result = apiInstance.UpdatePoll(id, pollResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.UpdatePoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The poll id | 
 **pollResource** | [**PollResource**](PollResource.md)| The poll object | [optional] 

### Return type

[**PollResource**](PollResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepolltemplate"></a>
# **UpdatePollTemplate**
> TemplateResource UpdatePollTemplate (string id, TemplateResource pollTemplateResource)

Update a poll template

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class UpdatePollTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new ContentPollsApi();
            var id = id_example;  // string | The id of the template
            var pollTemplateResource = new TemplateResource(); // TemplateResource | The poll template resource object (optional) 

            try
            {
                // Update a poll template
                TemplateResource result = apiInstance.UpdatePollTemplate(id, pollTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentPollsApi.UpdatePollTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **pollTemplateResource** | [**TemplateResource**](TemplateResource.md)| The poll template resource object | [optional] 

### Return type

[**TemplateResource**](TemplateResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

