using System;
using System.Collections.Generic;
using RestSharp;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace com.knetikcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGamificationTriviaApi
    {
        /// <summary>
        /// Add an answer to a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param>
        /// <param name="answer">The new answer</param>
        /// <returns>ModelAnswerResource</returns>
        ModelAnswerResource AddQuestionAnswers (string questionId, ModelAnswerResource answer);
        /// <summary>
        /// Add a tag to a question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <param name="tag">The new tag</param>
        /// <returns></returns>
        void AddQuestionTag (string id, string tag);
        /// <summary>
        /// Add a tag to a batch of questions All questions that dont&#39;t have the tag and match filters will have it added. The returned number is the number of questions updated.
        /// </summary>
        /// <param name="tag">The tag to add</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <returns>int?</returns>
        int? AddTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId);
        /// <summary>
        /// Create an import job Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint.
        /// </summary>
        /// <param name="request">The new import job</param>
        /// <returns>ModelImportJobResource</returns>
        ModelImportJobResource CreateImportJob (ModelImportJobResource request);
        /// <summary>
        /// Create a question 
        /// </summary>
        /// <param name="question">The new question</param>
        /// <returns>ModelQuestionResource</returns>
        ModelQuestionResource CreateQuestion (ModelQuestionResource question);
        /// <summary>
        /// Create a question template Question templates define a type of question and the properties they have
        /// </summary>
        /// <param name="questionTemplateResource">The question template resource object</param>
        /// <returns>ModelQuestionTemplateResource</returns>
        ModelQuestionTemplateResource CreateQuestionTemplate (ModelQuestionTemplateResource questionTemplateResource);
        /// <summary>
        /// Delete an import job Also deletes all questions that were imported by it
        /// </summary>
        /// <param name="id">The id of the job</param>
        /// <returns></returns>
        void DeleteImportJob (long? id);
        /// <summary>
        /// Delete a question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <returns></returns>
        void DeleteQuestion (string id);
        /// <summary>
        /// Remove an answer from a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <returns></returns>
        void DeleteQuestionAnswers (string questionId, string id);
        /// <summary>
        /// Delete a question template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteQuestionTemplate (string id, string cascade);
        /// <summary>
        /// Get an import job 
        /// </summary>
        /// <param name="id">The id of the job</param>
        /// <returns>ModelImportJobResource</returns>
        ModelImportJobResource GetImportJob (long? id);
        /// <summary>
        /// Get a list of import job 
        /// </summary>
        /// <param name="filterVendor">Filter for jobs by vendor id</param>
        /// <param name="filterCategory">Filter for jobs by category id</param>
        /// <param name="filterName">Filter for jobs which name *STARTS* with the given string</param>
        /// <param name="filterStatus">Filter for jobs that are in a specific set of statuses (comma separated)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceImportJobResource</returns>
        ModelPageResourceImportJobResource GetImportJobs (string filterVendor, string filterCategory, string filterName, string filterStatus, int? size, int? page, string order);
        /// <summary>
        /// Get a single question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <returns>ModelQuestionResource</returns>
        ModelQuestionResource GetQuestion (string id);
        /// <summary>
        /// Get an answer for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <returns>ModelAnswerResource</returns>
        ModelAnswerResource GetQuestionAnswer (string questionId, string id);
        /// <summary>
        /// List the answers available for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param>
        /// <returns>List&lt;ModelAnswerResource&gt;</returns>
        List<ModelAnswerResource> GetQuestionAnswers (string questionId);
        /// <summary>
        /// List question deltas in ascending order of updated date The &#39;since&#39; parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps
        /// </summary>
        /// <param name="since">Timestamp in seconds</param>
        /// <returns>List&lt;ModelDeltaResource&gt;</returns>
        List<ModelDeltaResource> GetQuestionDeltas (long? since);
        /// <summary>
        /// List the tags for a question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetQuestionTags (string id);
        /// <summary>
        /// Get a single question template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelQuestionTemplateResource</returns>
        ModelQuestionTemplateResource GetQuestionTemplate (string id);
        /// <summary>
        /// List and search question templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceQuestionTemplateResource</returns>
        ModelPageResourceQuestionTemplateResource GetQuestionTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search questions 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <returns>ModelPageResourceQuestionResource</returns>
        ModelPageResourceQuestionResource GetQuestions (int? size, int? page, string order, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterTag, string filterType, bool? filterPublished, long? filterImportId);
        /// <summary>
        /// Count questions based on filters This is also provided by the list endpoint so you don&#39;t need to call this for pagination purposes
        /// </summary>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <returns>long?</returns>
        long? GetQuestionsCount (string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished);
        /// <summary>
        /// Start processing an import job Will process the CSV file and add new questions asynchronously. The status of the job must be &#39;VALID&#39;.
        /// </summary>
        /// <param name="id">The id of the job</param>
        /// <param name="publishNow">Whether the new questions should be published live immediately</param>
        /// <returns>ModelImportJobResource</returns>
        ModelImportJobResource ProcessImportJob (long? id, bool? publishNow);
        /// <summary>
        /// Remove a tag from a question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <param name="tag">The tag to remove</param>
        /// <returns></returns>
        void RemoveQuestionTag (string id, string tag);
        /// <summary>
        /// Remove a tag from a batch of questions ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated.
        /// </summary>
        /// <param name="tag">The tag to remove</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTag">Filter for questions with specified tag</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <returns>int?</returns>
        int? RemoveTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId);
        /// <summary>
        /// List and search tags by the beginning of the string For performance reasons, search &amp; category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead.
        /// </summary>
        /// <param name="filterSearch">Filter for tags starting with the given text</param>
        /// <param name="filterCategory">Filter for tags on questions from a specific category</param>
        /// <param name="filterImportId">Filter for tags on questions from a specific import job</param>
        /// <returns>ModelCollectionstring</returns>
        ModelCollectionstring SearchQuestionTags (string filterSearch, string filterCategory, long? filterImportId);
        /// <summary>
        /// Update an import job Changes should be made before process is started for there to be any effect.
        /// </summary>
        /// <param name="id">The id of the job</param>
        /// <param name="request">The updated job</param>
        /// <returns>ModelImportJobResource</returns>
        ModelImportJobResource UpdateImportJob (long? id, ModelImportJobResource request);
        /// <summary>
        /// Update a question 
        /// </summary>
        /// <param name="id">The id of the question</param>
        /// <param name="question">The updated question</param>
        /// <returns>ModelQuestionResource</returns>
        ModelQuestionResource UpdateQuestion (string id, ModelQuestionResource question);
        /// <summary>
        /// Update an answer for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param>
        /// <param name="id">The id of the answer</param>
        /// <param name="answer">The updated answer</param>
        /// <returns></returns>
        void UpdateQuestionAnswer (string questionId, string id, ModelAnswerResource answer);
        /// <summary>
        /// Update a question template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="questionTemplateResource">The question template resource object</param>
        /// <returns>ModelQuestionTemplateResource</returns>
        ModelQuestionTemplateResource UpdateQuestionTemplate (string id, ModelQuestionTemplateResource questionTemplateResource);
        /// <summary>
        /// Bulk update questions Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated.
        /// </summary>
        /// <param name="question">New values for a set of question fields</param>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param>
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param>
        /// <param name="filterCategory">Filter for questions with specified category, by id</param>
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param>
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param>
        /// <param name="filterPublished">Filter for questions currenctly published or not</param>
        /// <param name="filterImportId">Filter for questions from a specific import job</param>
        /// <returns>int?</returns>
        int? UpdateQuestionsInBulk (ModelQuestionResource question, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterType, bool? filterPublished, long? filterImportId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GamificationTriviaApi : IGamificationTriviaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationTriviaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GamificationTriviaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationTriviaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamificationTriviaApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add an answer to a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param> 
        /// <param name="answer">The new answer</param> 
        /// <returns>ModelAnswerResource</returns>            
        public ModelAnswerResource AddQuestionAnswers (string questionId, ModelAnswerResource answer)
        {
            
            // verify the required parameter 'questionId' is set
            if (questionId == null) throw new ApiException(400, "Missing required parameter 'questionId' when calling AddQuestionAnswers");
            
    
            var path = "/trivia/questions/{question_id}/answers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "question_id" + "}", ApiClient.ParameterToString(questionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(answer); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddQuestionAnswers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddQuestionAnswers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAnswerResource) ApiClient.Deserialize(response.Content, typeof(ModelAnswerResource), response.Headers);
        }
    
        /// <summary>
        /// Add a tag to a question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <param name="tag">The new tag</param> 
        /// <returns></returns>            
        public void AddQuestionTag (string id, string tag)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddQuestionTag");
            
    
            var path = "/trivia/questions/{id}/tags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tag); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddQuestionTag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddQuestionTag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a tag to a batch of questions All questions that dont&#39;t have the tag and match filters will have it added. The returned number is the number of questions updated.
        /// </summary>
        /// <param name="tag">The tag to add</param> 
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param> 
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param> 
        /// <param name="filterCategory">Filter for questions with specified category, by id</param> 
        /// <param name="filterTag">Filter for questions with specified tag</param> 
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param> 
        /// <param name="filterType">Filter for questions with specified type</param> 
        /// <param name="filterPublished">Filter for questions currenctly published or not</param> 
        /// <param name="filterImportId">Filter for questions from a specific import job</param> 
        /// <returns>int?</returns>            
        public int? AddTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)
        {
            
    
            var path = "/trivia/questions/tags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterIdset != null) queryParams.Add("filter_idset", ApiClient.ParameterToString(filterIdset)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
 if (filterImportId != null) queryParams.Add("filter_import_id", ApiClient.ParameterToString(filterImportId)); // query parameter
                                    postBody = ApiClient.Serialize(tag); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTagToQuestionsBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTagToQuestionsBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Create an import job Set up a job to import a set of trivia questions from a cvs file at a remote url. the file will be validated asynchronously but will not be processed until started manually with the process endpoint.
        /// </summary>
        /// <param name="request">The new import job</param> 
        /// <returns>ModelImportJobResource</returns>            
        public ModelImportJobResource CreateImportJob (ModelImportJobResource request)
        {
            
    
            var path = "/trivia/import";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateImportJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateImportJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelImportJobResource) ApiClient.Deserialize(response.Content, typeof(ModelImportJobResource), response.Headers);
        }
    
        /// <summary>
        /// Create a question 
        /// </summary>
        /// <param name="question">The new question</param> 
        /// <returns>ModelQuestionResource</returns>            
        public ModelQuestionResource CreateQuestion (ModelQuestionResource question)
        {
            
    
            var path = "/trivia/questions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(question); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQuestion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQuestion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionResource), response.Headers);
        }
    
        /// <summary>
        /// Create a question template Question templates define a type of question and the properties they have
        /// </summary>
        /// <param name="questionTemplateResource">The question template resource object</param> 
        /// <returns>ModelQuestionTemplateResource</returns>            
        public ModelQuestionTemplateResource CreateQuestionTemplate (ModelQuestionTemplateResource questionTemplateResource)
        {
            
    
            var path = "/trivia/questions/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(questionTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQuestionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQuestionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an import job Also deletes all questions that were imported by it
        /// </summary>
        /// <param name="id">The id of the job</param> 
        /// <returns></returns>            
        public void DeleteImportJob (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteImportJob");
            
    
            var path = "/trivia/import/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteImportJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteImportJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <returns></returns>            
        public void DeleteQuestion (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteQuestion");
            
    
            var path = "/trivia/questions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestion: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove an answer from a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param> 
        /// <param name="id">The id of the answer</param> 
        /// <returns></returns>            
        public void DeleteQuestionAnswers (string questionId, string id)
        {
            
            // verify the required parameter 'questionId' is set
            if (questionId == null) throw new ApiException(400, "Missing required parameter 'questionId' when calling DeleteQuestionAnswers");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteQuestionAnswers");
            
    
            var path = "/trivia/questions/{question_id}/answers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "question_id" + "}", ApiClient.ParameterToString(questionId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestionAnswers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestionAnswers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a question template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteQuestionTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteQuestionTemplate");
            
    
            var path = "/trivia/questions/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQuestionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an import job 
        /// </summary>
        /// <param name="id">The id of the job</param> 
        /// <returns>ModelImportJobResource</returns>            
        public ModelImportJobResource GetImportJob (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetImportJob");
            
    
            var path = "/trivia/import/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetImportJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetImportJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelImportJobResource) ApiClient.Deserialize(response.Content, typeof(ModelImportJobResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of import job 
        /// </summary>
        /// <param name="filterVendor">Filter for jobs by vendor id</param> 
        /// <param name="filterCategory">Filter for jobs by category id</param> 
        /// <param name="filterName">Filter for jobs which name *STARTS* with the given string</param> 
        /// <param name="filterStatus">Filter for jobs that are in a specific set of statuses (comma separated)</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceImportJobResource</returns>            
        public ModelPageResourceImportJobResource GetImportJobs (string filterVendor, string filterCategory, string filterName, string filterStatus, int? size, int? page, string order)
        {
            
    
            var path = "/trivia/import";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterVendor != null) queryParams.Add("filter_vendor", ApiClient.ParameterToString(filterVendor)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterStatus != null) queryParams.Add("filter_status", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetImportJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetImportJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceImportJobResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceImportJobResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <returns>ModelQuestionResource</returns>            
        public ModelQuestionResource GetQuestion (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetQuestion");
            
    
            var path = "/trivia/questions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionResource), response.Headers);
        }
    
        /// <summary>
        /// Get an answer for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param> 
        /// <param name="id">The id of the answer</param> 
        /// <returns>ModelAnswerResource</returns>            
        public ModelAnswerResource GetQuestionAnswer (string questionId, string id)
        {
            
            // verify the required parameter 'questionId' is set
            if (questionId == null) throw new ApiException(400, "Missing required parameter 'questionId' when calling GetQuestionAnswer");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetQuestionAnswer");
            
    
            var path = "/trivia/questions/{question_id}/answers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "question_id" + "}", ApiClient.ParameterToString(questionId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionAnswer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionAnswer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelAnswerResource) ApiClient.Deserialize(response.Content, typeof(ModelAnswerResource), response.Headers);
        }
    
        /// <summary>
        /// List the answers available for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param> 
        /// <returns>List&lt;ModelAnswerResource&gt;</returns>            
        public List<ModelAnswerResource> GetQuestionAnswers (string questionId)
        {
            
            // verify the required parameter 'questionId' is set
            if (questionId == null) throw new ApiException(400, "Missing required parameter 'questionId' when calling GetQuestionAnswers");
            
    
            var path = "/trivia/questions/{question_id}/answers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "question_id" + "}", ApiClient.ParameterToString(questionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionAnswers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionAnswers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelAnswerResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelAnswerResource>), response.Headers);
        }
    
        /// <summary>
        /// List question deltas in ascending order of updated date The &#39;since&#39; parameter is important to avoid getting a full list of all questions. Implementors should make sure they pass the updated date of the last resource loaded, not the date of the last request, in order to avoid gaps
        /// </summary>
        /// <param name="since">Timestamp in seconds</param> 
        /// <returns>List&lt;ModelDeltaResource&gt;</returns>            
        public List<ModelDeltaResource> GetQuestionDeltas (long? since)
        {
            
    
            var path = "/trivia/questions/delta";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionDeltas: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionDeltas: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelDeltaResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelDeltaResource>), response.Headers);
        }
    
        /// <summary>
        /// List the tags for a question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetQuestionTags (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetQuestionTags");
            
    
            var path = "/trivia/questions/{id}/tags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Get a single question template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelQuestionTemplateResource</returns>            
        public ModelQuestionTemplateResource GetQuestionTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetQuestionTemplate");
            
    
            var path = "/trivia/questions/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search question templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceQuestionTemplateResource</returns>            
        public ModelPageResourceQuestionTemplateResource GetQuestionTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/trivia/questions/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceQuestionTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceQuestionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search questions 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param> 
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param> 
        /// <param name="filterCategory">Filter for questions with specified category, by id</param> 
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param> 
        /// <param name="filterTag">Filter for questions with specified tag</param> 
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param> 
        /// <param name="filterPublished">Filter for questions currenctly published or not</param> 
        /// <param name="filterImportId">Filter for questions from a specific import job</param> 
        /// <returns>ModelPageResourceQuestionResource</returns>            
        public ModelPageResourceQuestionResource GetQuestions (int? size, int? page, string order, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterTag, string filterType, bool? filterPublished, long? filterImportId)
        {
            
    
            var path = "/trivia/questions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
 if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterIdset != null) queryParams.Add("filter_idset", ApiClient.ParameterToString(filterIdset)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
 if (filterImportId != null) queryParams.Add("filter_import_id", ApiClient.ParameterToString(filterImportId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceQuestionResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceQuestionResource), response.Headers);
        }
    
        /// <summary>
        /// Count questions based on filters This is also provided by the list endpoint so you don&#39;t need to call this for pagination purposes
        /// </summary>
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param> 
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param> 
        /// <param name="filterCategory">Filter for questions with specified category, by id</param> 
        /// <param name="filterTag">Filter for questions with specified tag</param> 
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param> 
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param> 
        /// <param name="filterPublished">Filter for questions currenctly published or not</param> 
        /// <returns>long?</returns>            
        public long? GetQuestionsCount (string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished)
        {
            
    
            var path = "/trivia/questions/count";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterIdset != null) queryParams.Add("filter_idset", ApiClient.ParameterToString(filterIdset)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionsCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQuestionsCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (long?) ApiClient.Deserialize(response.Content, typeof(long?), response.Headers);
        }
    
        /// <summary>
        /// Start processing an import job Will process the CSV file and add new questions asynchronously. The status of the job must be &#39;VALID&#39;.
        /// </summary>
        /// <param name="id">The id of the job</param> 
        /// <param name="publishNow">Whether the new questions should be published live immediately</param> 
        /// <returns>ModelImportJobResource</returns>            
        public ModelImportJobResource ProcessImportJob (long? id, bool? publishNow)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessImportJob");
            
            // verify the required parameter 'publishNow' is set
            if (publishNow == null) throw new ApiException(400, "Missing required parameter 'publishNow' when calling ProcessImportJob");
            
    
            var path = "/trivia/import/{id}/process";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (publishNow != null) queryParams.Add("publish_now", ApiClient.ParameterToString(publishNow)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProcessImportJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProcessImportJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelImportJobResource) ApiClient.Deserialize(response.Content, typeof(ModelImportJobResource), response.Headers);
        }
    
        /// <summary>
        /// Remove a tag from a question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <param name="tag">The tag to remove</param> 
        /// <returns></returns>            
        public void RemoveQuestionTag (string id, string tag)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveQuestionTag");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling RemoveQuestionTag");
            
    
            var path = "/trivia/questions/{id}/tags/{tag}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveQuestionTag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveQuestionTag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a tag from a batch of questions ll questions that have the tag and match filters will have it removed. The returned number is the number of questions updated.
        /// </summary>
        /// <param name="tag">The tag to remove</param> 
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param> 
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param> 
        /// <param name="filterCategory">Filter for questions with specified category, by id</param> 
        /// <param name="filterTag">Filter for questions with specified tag</param> 
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param> 
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param> 
        /// <param name="filterPublished">Filter for questions currenctly published or not</param> 
        /// <param name="filterImportId">Filter for questions from a specific import job</param> 
        /// <returns>int?</returns>            
        public int? RemoveTagToQuestionsBatch (string tag, string filterSearch, string filterIdset, string filterCategory, string filterTag, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)
        {
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling RemoveTagToQuestionsBatch");
            
    
            var path = "/trivia/questions/tags/{tag}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterIdset != null) queryParams.Add("filter_idset", ApiClient.ParameterToString(filterIdset)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
 if (filterImportId != null) queryParams.Add("filter_import_id", ApiClient.ParameterToString(filterImportId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveTagToQuestionsBatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveTagToQuestionsBatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// List and search tags by the beginning of the string For performance reasons, search &amp; category filters are mutually exclusive. If category is specified, search filter will be ignored in order to do fast matches for typeahead.
        /// </summary>
        /// <param name="filterSearch">Filter for tags starting with the given text</param> 
        /// <param name="filterCategory">Filter for tags on questions from a specific category</param> 
        /// <param name="filterImportId">Filter for tags on questions from a specific import job</param> 
        /// <returns>ModelCollectionstring</returns>            
        public ModelCollectionstring SearchQuestionTags (string filterSearch, string filterCategory, long? filterImportId)
        {
            
    
            var path = "/trivia/tags";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterImportId != null) queryParams.Add("filter_import_id", ApiClient.ParameterToString(filterImportId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchQuestionTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchQuestionTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCollectionstring) ApiClient.Deserialize(response.Content, typeof(ModelCollectionstring), response.Headers);
        }
    
        /// <summary>
        /// Update an import job Changes should be made before process is started for there to be any effect.
        /// </summary>
        /// <param name="id">The id of the job</param> 
        /// <param name="request">The updated job</param> 
        /// <returns>ModelImportJobResource</returns>            
        public ModelImportJobResource UpdateImportJob (long? id, ModelImportJobResource request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateImportJob");
            
    
            var path = "/trivia/import/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateImportJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateImportJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelImportJobResource) ApiClient.Deserialize(response.Content, typeof(ModelImportJobResource), response.Headers);
        }
    
        /// <summary>
        /// Update a question 
        /// </summary>
        /// <param name="id">The id of the question</param> 
        /// <param name="question">The updated question</param> 
        /// <returns>ModelQuestionResource</returns>            
        public ModelQuestionResource UpdateQuestion (string id, ModelQuestionResource question)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateQuestion");
            
    
            var path = "/trivia/questions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(question); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionResource), response.Headers);
        }
    
        /// <summary>
        /// Update an answer for a question 
        /// </summary>
        /// <param name="questionId">The id of the question</param> 
        /// <param name="id">The id of the answer</param> 
        /// <param name="answer">The updated answer</param> 
        /// <returns></returns>            
        public void UpdateQuestionAnswer (string questionId, string id, ModelAnswerResource answer)
        {
            
            // verify the required parameter 'questionId' is set
            if (questionId == null) throw new ApiException(400, "Missing required parameter 'questionId' when calling UpdateQuestionAnswer");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateQuestionAnswer");
            
    
            var path = "/trivia/questions/{question_id}/answers/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "question_id" + "}", ApiClient.ParameterToString(questionId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(answer); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionAnswer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionAnswer: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a question template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="questionTemplateResource">The question template resource object</param> 
        /// <returns>ModelQuestionTemplateResource</returns>            
        public ModelQuestionTemplateResource UpdateQuestionTemplate (string id, ModelQuestionTemplateResource questionTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateQuestionTemplate");
            
    
            var path = "/trivia/questions/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(questionTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelQuestionTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelQuestionTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Bulk update questions Will update all questions that match filters used (or all questions in system if no filters used). Body should match a question resource with only those properties you wish to set. Null values will be ignored. Returned number is how many were updated.
        /// </summary>
        /// <param name="question">New values for a set of question fields</param> 
        /// <param name="filterSearch">Filter for documents whose question, answers or tags contains provided string</param> 
        /// <param name="filterIdset">Filter for documents whose id is in the comma separated list provided</param> 
        /// <param name="filterCategory">Filter for questions with specified category, by id</param> 
        /// <param name="filterTagset">Filter for questions with specified tags (separated by comma)</param> 
        /// <param name="filterType">Filter for questions with specified type.  Allowable values: (&#39;TEXT&#39;, &#39;IMAGE&#39;, &#39;VIDEO&#39;, &#39;AUDIO&#39;)</param> 
        /// <param name="filterPublished">Filter for questions currenctly published or not</param> 
        /// <param name="filterImportId">Filter for questions from a specific import job</param> 
        /// <returns>int?</returns>            
        public int? UpdateQuestionsInBulk (ModelQuestionResource question, string filterSearch, string filterIdset, string filterCategory, string filterTagset, string filterType, bool? filterPublished, long? filterImportId)
        {
            
    
            var path = "/trivia/questions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterSearch != null) queryParams.Add("filter_search", ApiClient.ParameterToString(filterSearch)); // query parameter
 if (filterIdset != null) queryParams.Add("filter_idset", ApiClient.ParameterToString(filterIdset)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
 if (filterImportId != null) queryParams.Add("filter_import_id", ApiClient.ParameterToString(filterImportId)); // query parameter
                                    postBody = ApiClient.Serialize(question); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionsInBulk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQuestionsInBulk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
    }
}
