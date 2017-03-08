# IO.Swagger..GamificationTriviaApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddQuestionAnswers**](GamificationTriviaApi.md#addquestionanswers) | **POST** /trivia/questions/{question_id}/answers | Add an answer to a question
[**AddQuestionTag**](GamificationTriviaApi.md#addquestiontag) | **POST** /trivia/questions/{id}/tags | Add a tag to a question
[**AddTagToQuestionsBatch**](GamificationTriviaApi.md#addtagtoquestionsbatch) | **POST** /trivia/questions/tags | Add a tag to a batch of questions
[**CreateImportJob**](GamificationTriviaApi.md#createimportjob) | **POST** /trivia/import | Create an import job
[**CreateQuestion**](GamificationTriviaApi.md#createquestion) | **POST** /trivia/questions | Create a question
[**CreateQuestionTemplate**](GamificationTriviaApi.md#createquestiontemplate) | **POST** /trivia/questions/templates | Create a question template
[**DeleteImportJob**](GamificationTriviaApi.md#deleteimportjob) | **DELETE** /trivia/import/{id} | Delete an import job
[**DeleteQuestion**](GamificationTriviaApi.md#deletequestion) | **DELETE** /trivia/questions/{id} | Delete a question
[**DeleteQuestionAnswers**](GamificationTriviaApi.md#deletequestionanswers) | **DELETE** /trivia/questions/{question_id}/answers/{id} | Remove an answer from a question
[**DeleteQuestionTemplate**](GamificationTriviaApi.md#deletequestiontemplate) | **DELETE** /trivia/questions/templates/{id} | Delete a question template
[**GetImportJob**](GamificationTriviaApi.md#getimportjob) | **GET** /trivia/import/{id} | Get an import job
[**GetImportJobs**](GamificationTriviaApi.md#getimportjobs) | **GET** /trivia/import | Get a list of import job
[**GetQuestion**](GamificationTriviaApi.md#getquestion) | **GET** /trivia/questions/{id} | Get a single question
[**GetQuestionAnswer**](GamificationTriviaApi.md#getquestionanswer) | **GET** /trivia/questions/{question_id}/answers/{id} | Get an answer for a question
[**GetQuestionAnswers**](GamificationTriviaApi.md#getquestionanswers) | **GET** /trivia/questions/{question_id}/answers | List the answers available for a question
[**GetQuestionDeltas**](GamificationTriviaApi.md#getquestiondeltas) | **GET** /trivia/questions/delta | List question deltas in ascending order of updated date
[**GetQuestionTags**](GamificationTriviaApi.md#getquestiontags) | **GET** /trivia/questions/{id}/tags | List the tags for a question
[**GetQuestionTemplate**](GamificationTriviaApi.md#getquestiontemplate) | **GET** /trivia/questions/templates/{id} | Get a single question template
[**GetQuestionTemplates**](GamificationTriviaApi.md#getquestiontemplates) | **GET** /trivia/questions/templates | List and search question templates
[**GetQuestions**](GamificationTriviaApi.md#getquestions) | **GET** /trivia/questions | List and search questions
[**GetQuestionsCount**](GamificationTriviaApi.md#getquestionscount) | **GET** /trivia/questions/count | Count questions based on filters
[**ProcessImportJob**](GamificationTriviaApi.md#processimportjob) | **POST** /trivia/import/{id}/process | Start processing an import job
[**RemoveQuestionTag**](GamificationTriviaApi.md#removequestiontag) | **DELETE** /trivia/questions/{id}/tags/{tag} | Remove a tag from a question
[**RemoveTagToQuestionsBatch**](GamificationTriviaApi.md#removetagtoquestionsbatch) | **DELETE** /trivia/questions/tags/{tag} | Remove a tag from a batch of questions
[**SearchQuestionTags**](GamificationTriviaApi.md#searchquestiontags) | **GET** /trivia/tags | List and search tags by the beginning of the string
[**UpdateImportJob**](GamificationTriviaApi.md#updateimportjob) | **PUT** /trivia/import/{id} | Update an import job
[**UpdateQuestion**](GamificationTriviaApi.md#updatequestion) | **PUT** /trivia/questions/{id} | Update a question
[**UpdateQuestionAnswer**](GamificationTriviaApi.md#updatequestionanswer) | **PUT** /trivia/questions/{question_id}/answers/{id} | Update an answer for a question
[**UpdateQuestionTemplate**](GamificationTriviaApi.md#updatequestiontemplate) | **PUT** /trivia/questions/templates/{id} | Update a question template
[**UpdateQuestionsInBulk**](GamificationTriviaApi.md#updatequestionsinbulk) | **PUT** /trivia/questions | Bulk update questions


<a name="addquestionanswers"></a>
# **AddQuestionAnswers**
> AnswerResource AddQuestionAnswers (string questionId, AnswerResource answer)

Add an answer to a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddQuestionAnswersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var answer = new AnswerResource(); // AnswerResource | The new answer (optional) 

            try
            {
                // Add an answer to a question
                AnswerResource result = apiInstance.AddQuestionAnswers(questionId, answer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.AddQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The new answer | [optional] 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addquestiontag"></a>
# **AddQuestionTag**
> void AddQuestionTag (string id, string tag)

Add a tag to a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddQuestionTagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = tag_example;  // string | The new tag (optional) 

            try
            {
                // Add a tag to a question
                apiInstance.AddQuestionTag(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.AddQuestionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | **string**| The new tag | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagtoquestionsbatch"></a>
# **AddTagToQuestionsBatch**
> int? AddTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)

Add a tag to a batch of questions

All questions that dont't have the tag and match filters will have it added. The returned number is the number of questions updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddTagToQuestionsBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var tag = tag_example;  // string | The tag to add (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Add a tag to a batch of questions
                int? result = apiInstance.AddTagToQuestionsBatch(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.AddTagToQuestionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| The tag to add | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimportjob"></a>
# **CreateImportJob**
> ImportJobResource CreateImportJob (ImportJobResource request)

Create an import job

Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateImportJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var request = new ImportJobResource(); // ImportJobResource | The new import job (optional) 

            try
            {
                // Create an import job
                ImportJobResource result = apiInstance.CreateImportJob(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ImportJobResource**](ImportJobResource.md)| The new import job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestion"></a>
# **CreateQuestion**
> QuestionResource CreateQuestion (QuestionResource question)

Create a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateQuestionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var question = new QuestionResource(); // QuestionResource | The new question (optional) 

            try
            {
                // Create a question
                QuestionResource result = apiInstance.CreateQuestion(question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| The new question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestiontemplate"></a>
# **CreateQuestionTemplate**
> QuestionTemplateResource CreateQuestionTemplate (QuestionTemplateResource questionTemplateResource)

Create a question template

Question templates define a type of question and the properties they have

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateQuestionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Create a question template
                QuestionTemplateResource result = apiInstance.CreateQuestionTemplate(questionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.CreateQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimportjob"></a>
# **DeleteImportJob**
> void DeleteImportJob (long? id)

Delete an import job

Also deletes all questions that were imported by it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteImportJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Delete an import job
                apiInstance.DeleteImportJob(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestion"></a>
# **DeleteQuestion**
> void DeleteQuestion (string id)

Delete a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteQuestionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Delete a question
                apiInstance.DeleteQuestion(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestionanswers"></a>
# **DeleteQuestionAnswers**
> void DeleteQuestionAnswers (string questionId, string id)

Remove an answer from a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteQuestionAnswersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Remove an answer from a question
                apiInstance.DeleteQuestionAnswers(questionId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestiontemplate"></a>
# **DeleteQuestionTemplate**
> void DeleteQuestionTemplate (string id, string cascade)

Delete a question template

If cascade = 'detach', it will force delete the template even if it's attached to other objects

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteQuestionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template
            var cascade = cascade_example;  // string | The value needed to delete used templates (optional) 

            try
            {
                // Delete a question template
                apiInstance.DeleteQuestionTemplate(id, cascade);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.DeleteQuestionTemplate: " + e.Message );
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

<a name="getimportjob"></a>
# **GetImportJob**
> ImportJobResource GetImportJob (long? id)

Get an import job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImportJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job

            try
            {
                // Get an import job
                ImportJobResource result = apiInstance.GetImportJob(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportjobs"></a>
# **GetImportJobs**
> PageResourceImportJobResource GetImportJobs (string filterVendor, string filterCategory, string filterName, string filterStatus, int? size, int? page, string order)

Get a list of import job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImportJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterVendor = filterVendor_example;  // string | Filter for jobs by vendor id (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for jobs by category id (optional) 
            var filterName = filterName_example;  // string | Filter for jobs which name *STARTS* with the given string (optional) 
            var filterStatus = filterStatus_example;  // string | Filter for jobs that are in a specific set of statuses (comma separated) (optional) 
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // Get a list of import job
                PageResourceImportJobResource result = apiInstance.GetImportJobs(filterVendor, filterCategory, filterName, filterStatus, size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetImportJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterVendor** | **string**| Filter for jobs by vendor id | [optional] 
 **filterCategory** | **string**| Filter for jobs by category id | [optional] 
 **filterName** | **string**| Filter for jobs which name *STARTS* with the given string | [optional] 
 **filterStatus** | **string**| Filter for jobs that are in a specific set of statuses (comma separated) | [optional] 
 **size** | **int?**| The number of objects returned per page | [optional] [default to 25]
 **page** | **int?**| The number of the page returned, starting with 1 | [optional] [default to 1]
 **order** | **string**| A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] | [optional] [default to id:ASC]

### Return type

[**PageResourceImportJobResource**](PageResourceImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestion"></a>
# **GetQuestion**
> QuestionResource GetQuestion (string id)

Get a single question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // Get a single question
                QuestionResource result = apiInstance.GetQuestion(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionanswer"></a>
# **GetQuestionAnswer**
> AnswerResource GetQuestionAnswer (string questionId, string id)

Get an answer for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionAnswerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer

            try
            {
                // Get an answer for a question
                AnswerResource result = apiInstance.GetQuestionAnswer(questionId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 

### Return type

[**AnswerResource**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionanswers"></a>
# **GetQuestionAnswers**
> List<AnswerResource> GetQuestionAnswers (string questionId)

List the answers available for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionAnswersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question

            try
            {
                // List the answers available for a question
                List&lt;AnswerResource&gt; result = apiInstance.GetQuestionAnswers(questionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionAnswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 

### Return type

[**List<AnswerResource>**](AnswerResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiondeltas"></a>
# **GetQuestionDeltas**
> List<DeltaResource> GetQuestionDeltas (long? since)

List question deltas in ascending order of updated date

The 'since' parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionDeltasExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var since = 789;  // long? | Timestamp in seconds (optional) 

            try
            {
                // List question deltas in ascending order of updated date
                List&lt;DeltaResource&gt; result = apiInstance.GetQuestionDeltas(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionDeltas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **long?**| Timestamp in seconds | [optional] 

### Return type

[**List<DeltaResource>**](DeltaResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontags"></a>
# **GetQuestionTags**
> List<string> GetQuestionTags (string id)

List the tags for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionTagsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question

            try
            {
                // List the tags for a question
                List&lt;string&gt; result = apiInstance.GetQuestionTags(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 

### Return type

**List<string>**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplate"></a>
# **GetQuestionTemplate**
> QuestionTemplateResource GetQuestionTemplate (string id)

Get a single question template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template

            try
            {
                // Get a single question template
                QuestionTemplateResource result = apiInstance.GetQuestionTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionTemplate: " + e.Message );
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

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestiontemplates"></a>
# **GetQuestionTemplates**
> PageResourceQuestionTemplateResource GetQuestionTemplates (int? size, int? page, string order)

List and search question templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionTemplatesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)

            try
            {
                // List and search question templates
                PageResourceQuestionTemplateResource result = apiInstance.GetQuestionTemplates(size, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionTemplates: " + e.Message );
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

[**PageResourceQuestionTemplateResource**](PageResourceQuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestions"></a>
# **GetQuestions**
> PageResourceQuestionResource GetQuestions (int? size, int? page, string order, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterTag, string filterType, bool? filterPublished, long? filterImportId)

List and search questions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var size = 56;  // int? | The number of objects returned per page (optional)  (default to 25)
            var page = 56;  // int? | The number of the page returned, starting with 1 (optional)  (default to 1)
            var order = order_example;  // string | A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC] (optional)  (default to id:ASC)
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // List and search questions
                PageResourceQuestionResource result = apiInstance.GetQuestions(size, page, order, filterSearch, filterIdset, filterCategory, filterTagset, filterTag, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestions: " + e.Message );
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
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

[**PageResourceQuestionResource**](PageResourceQuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionscount"></a>
# **GetQuestionsCount**
> long? GetQuestionsCount (string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished)

Count questions based on filters

This is also provided by the list endpoint so you don't need to call this for pagination purposes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQuestionsCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 

            try
            {
                // Count questions based on filters
                long? result = apiInstance.GetQuestionsCount(filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.GetQuestionsCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 

### Return type

**long?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processimportjob"></a>
# **ProcessImportJob**
> ImportJobResource ProcessImportJob (long? id, bool? publishNow)

Start processing an import job

Will process the CSV file and add new questions asynchronously. The status of the job must be 'VALID'.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProcessImportJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job
            var publishNow = true;  // bool? | Whether the new questions should be published live immediately

            try
            {
                // Start processing an import job
                ImportJobResource result = apiInstance.ProcessImportJob(id, publishNow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.ProcessImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **publishNow** | **bool?**| Whether the new questions should be published live immediately | 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removequestiontag"></a>
# **RemoveQuestionTag**
> void RemoveQuestionTag (string id, string tag)

Remove a tag from a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveQuestionTagExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var tag = tag_example;  // string | The tag to remove

            try
            {
                // Remove a tag from a question
                apiInstance.RemoveQuestionTag(id, tag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.RemoveQuestionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **tag** | **string**| The tag to remove | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removetagtoquestionsbatch"></a>
# **RemoveTagToQuestionsBatch**
> int? RemoveTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)

Remove a tag from a batch of questions

ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveTagToQuestionsBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var tag = tag_example;  // string | The tag to remove
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTag = filterTag_example;  // string | Filter for questions with specified tag (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Remove a tag from a batch of questions
                int? result = apiInstance.RemoveTagToQuestionsBatch(tag, filterSearch, filterIdset, filterCategory, filterTag, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.RemoveTagToQuestionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| The tag to remove | 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTag** | **string**| Filter for questions with specified tag | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchquestiontags"></a>
# **SearchQuestionTags**
> Collectionstring SearchQuestionTags (string filterSearch, string filterCategory, long? filterImportId)

List and search tags by the beginning of the string

For performance reasons, search & category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchQuestionTagsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var filterSearch = filterSearch_example;  // string | Filter for tags starting with the given text (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for tags on questions from a specific category (optional) 
            var filterImportId = 789;  // long? | Filter for tags on questions from a specific import job (optional) 

            try
            {
                // List and search tags by the beginning of the string
                Collectionstring result = apiInstance.SearchQuestionTags(filterSearch, filterCategory, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.SearchQuestionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterSearch** | **string**| Filter for tags starting with the given text | [optional] 
 **filterCategory** | **string**| Filter for tags on questions from a specific category | [optional] 
 **filterImportId** | **long?**| Filter for tags on questions from a specific import job | [optional] 

### Return type

[**Collectionstring**](Collectionstring.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimportjob"></a>
# **UpdateImportJob**
> ImportJobResource UpdateImportJob (long? id, ImportJobResource request)

Update an import job

Changes should be made before process is started for there to be any effect.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateImportJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = 789;  // long? | The id of the job
            var request = new ImportJobResource(); // ImportJobResource | The updated job (optional) 

            try
            {
                // Update an import job
                ImportJobResource result = apiInstance.UpdateImportJob(id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateImportJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The id of the job | 
 **request** | [**ImportJobResource**](ImportJobResource.md)| The updated job | [optional] 

### Return type

[**ImportJobResource**](ImportJobResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestion"></a>
# **UpdateQuestion**
> QuestionResource UpdateQuestion (string id, QuestionResource question)

Update a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the question
            var question = new QuestionResource(); // QuestionResource | The updated question (optional) 

            try
            {
                // Update a question
                QuestionResource result = apiInstance.UpdateQuestion(id, question);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the question | 
 **question** | [**QuestionResource**](QuestionResource.md)| The updated question | [optional] 

### Return type

[**QuestionResource**](QuestionResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestionanswer"></a>
# **UpdateQuestionAnswer**
> void UpdateQuestionAnswer (string questionId, string id, AnswerResource answer)

Update an answer for a question

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionAnswerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var questionId = questionId_example;  // string | The id of the question
            var id = id_example;  // string | The id of the answer
            var answer = new AnswerResource(); // AnswerResource | The updated answer (optional) 

            try
            {
                // Update an answer for a question
                apiInstance.UpdateQuestionAnswer(questionId, id, answer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestionAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**| The id of the question | 
 **id** | **string**| The id of the answer | 
 **answer** | [**AnswerResource**](AnswerResource.md)| The updated answer | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestiontemplate"></a>
# **UpdateQuestionTemplate**
> QuestionTemplateResource UpdateQuestionTemplate (string id, QuestionTemplateResource questionTemplateResource)

Update a question template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionTemplateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var id = id_example;  // string | The id of the template
            var questionTemplateResource = new QuestionTemplateResource(); // QuestionTemplateResource | The question template resource object (optional) 

            try
            {
                // Update a question template
                QuestionTemplateResource result = apiInstance.UpdateQuestionTemplate(id, questionTemplateResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestionTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the template | 
 **questionTemplateResource** | [**QuestionTemplateResource**](QuestionTemplateResource.md)| The question template resource object | [optional] 

### Return type

[**QuestionTemplateResource**](QuestionTemplateResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatequestionsinbulk"></a>
# **UpdateQuestionsInBulk**
> int? UpdateQuestionsInBulk (QuestionResource question, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)

Bulk update questions

Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateQuestionsInBulkExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GamificationTriviaApi();
            var question = new QuestionResource(); // QuestionResource | New values for a set of question fields (optional) 
            var filterSearch = filterSearch_example;  // string | Filter for documents whose question, answers or tags contains provided string (optional) 
            var filterIdset = filterIdset_example;  // string | Filter for documents whose id is in the comma separated list provided (optional) 
            var filterCategory = filterCategory_example;  // string | Filter for questions with specified category, by id (optional) 
            var filterTagset = filterTagset_example;  // string | Filter for questions with specified tags (separated by comma) (optional) 
            var filterType = filterType_example;  // string | Filter for questions with specified type.  Allowable values: ('TEXT', 'IMAGE', 'VIDEO', 'AUDIO') (optional) 
            var filterPublished = true;  // bool? | Filter for questions currenctly published or not (optional) 
            var filterImportId = 789;  // long? | Filter for questions from a specific import job (optional) 

            try
            {
                // Bulk update questions
                int? result = apiInstance.UpdateQuestionsInBulk(question, filterSearch, filterIdset, filterCategory, filterTagset, filterType, filterPublished, filterImportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationTriviaApi.UpdateQuestionsInBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **question** | [**QuestionResource**](QuestionResource.md)| New values for a set of question fields | [optional] 
 **filterSearch** | **string**| Filter for documents whose question, answers or tags contains provided string | [optional] 
 **filterIdset** | **string**| Filter for documents whose id is in the comma separated list provided | [optional] 
 **filterCategory** | **string**| Filter for questions with specified category, by id | [optional] 
 **filterTagset** | **string**| Filter for questions with specified tags (separated by comma) | [optional] 
 **filterType** | **string**| Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;) | [optional] 
 **filterPublished** | **bool?**| Filter for questions currenctly published or not | [optional] 
 **filterImportId** | **long?**| Filter for questions from a specific import job | [optional] 

### Return type

**int?**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

