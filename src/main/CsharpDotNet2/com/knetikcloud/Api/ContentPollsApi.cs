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
    public interface IContentPollsApi
    {
        /// <summary>
        /// Add your vote to a poll 
        /// </summary>
        /// <param name="id">The poll id</param>
        /// <param name="answerKey">The answer key</param>
        /// <returns>ModelPollResponseResource</returns>
        ModelPollResponseResource AnswerPoll (string id, string answerKey);
        /// <summary>
        /// Create a new poll Polls are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.
        /// </summary>
        /// <param name="pollResource">The poll object</param>
        /// <returns>ModelPollResource</returns>
        ModelPollResource CreatePoll (ModelPollResource pollResource);
        /// <summary>
        /// Create a poll template Poll templates define a type of poll and the properties they have
        /// </summary>
        /// <param name="pollTemplateResource">The poll template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource CreatePollTemplate (ModelTemplateResource pollTemplateResource);
        /// <summary>
        /// Delete an existing poll 
        /// </summary>
        /// <param name="id">The poll id</param>
        /// <returns></returns>
        void DeletePoll (string id);
        /// <summary>
        /// Delete a poll template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeletePollTemplate (string id, string cascade);
        /// <summary>
        /// Get a single poll 
        /// </summary>
        /// <param name="id">The poll id</param>
        /// <returns>ModelPollResource</returns>
        ModelPollResource GetPoll (string id);
        /// <summary>
        /// Get poll answer 
        /// </summary>
        /// <param name="id">The poll id</param>
        /// <returns>ModelPollResponseResource</returns>
        ModelPollResponseResource GetPollAnswer (string id);
        /// <summary>
        /// Get a single poll template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource GetPollTemplate (string id);
        /// <summary>
        /// List and search poll templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceTemplateResource</returns>
        ModelPageResourceTemplateResource GetPollTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search polls Get a list of polls with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="filterCategory">Filter for polls from a specific category by id</param>
        /// <param name="filterTagset">Filter for polls with specified tags (separated by comma)</param>
        /// <param name="filterText">Filter for polls whose text contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourcePollResource</returns>
        ModelPageResourcePollResource GetPolls (string filterCategory, string filterTagset, string filterText, int? size, int? page, string order);
        /// <summary>
        /// Update an existing poll 
        /// </summary>
        /// <param name="id">The poll id</param>
        /// <param name="pollResource">The poll object</param>
        /// <returns>ModelPollResource</returns>
        ModelPollResource UpdatePoll (string id, ModelPollResource pollResource);
        /// <summary>
        /// Update a poll template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="pollTemplateResource">The poll template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource UpdatePollTemplate (string id, ModelTemplateResource pollTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContentPollsApi : IContentPollsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPollsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContentPollsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPollsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContentPollsApi(String basePath)
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
        /// Add your vote to a poll 
        /// </summary>
        /// <param name="id">The poll id</param> 
        /// <param name="answerKey">The answer key</param> 
        /// <returns>ModelPollResponseResource</returns>            
        public ModelPollResponseResource AnswerPoll (string id, string answerKey)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AnswerPoll");
            
    
            var path = "/media/polls/{id}/response";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(answerKey); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AnswerPoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AnswerPoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPollResponseResource) ApiClient.Deserialize(response.Content, typeof(ModelPollResponseResource), response.Headers);
        }
    
        /// <summary>
        /// Create a new poll Polls are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.
        /// </summary>
        /// <param name="pollResource">The poll object</param> 
        /// <returns>ModelPollResource</returns>            
        public ModelPollResource CreatePoll (ModelPollResource pollResource)
        {
            
    
            var path = "/media/polls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(pollResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPollResource) ApiClient.Deserialize(response.Content, typeof(ModelPollResource), response.Headers);
        }
    
        /// <summary>
        /// Create a poll template Poll templates define a type of poll and the properties they have
        /// </summary>
        /// <param name="pollTemplateResource">The poll template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource CreatePollTemplate (ModelTemplateResource pollTemplateResource)
        {
            
    
            var path = "/media/polls/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(pollTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePollTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePollTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing poll 
        /// </summary>
        /// <param name="id">The poll id</param> 
        /// <returns></returns>            
        public void DeletePoll (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePoll");
            
    
            var path = "/media/polls/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a poll template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeletePollTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePollTemplate");
            
    
            var path = "/media/polls/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePollTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePollTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single poll 
        /// </summary>
        /// <param name="id">The poll id</param> 
        /// <returns>ModelPollResource</returns>            
        public ModelPollResource GetPoll (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPoll");
            
    
            var path = "/media/polls/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPollResource) ApiClient.Deserialize(response.Content, typeof(ModelPollResource), response.Headers);
        }
    
        /// <summary>
        /// Get poll answer 
        /// </summary>
        /// <param name="id">The poll id</param> 
        /// <returns>ModelPollResponseResource</returns>            
        public ModelPollResponseResource GetPollAnswer (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPollAnswer");
            
    
            var path = "/media/polls/{id}/response";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollAnswer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollAnswer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPollResponseResource) ApiClient.Deserialize(response.Content, typeof(ModelPollResponseResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single poll template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource GetPollTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPollTemplate");
            
    
            var path = "/media/polls/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search poll templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceTemplateResource</returns>            
        public ModelPageResourceTemplateResource GetPollTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/media/polls/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPollTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search polls Get a list of polls with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="filterCategory">Filter for polls from a specific category by id</param> 
        /// <param name="filterTagset">Filter for polls with specified tags (separated by comma)</param> 
        /// <param name="filterText">Filter for polls whose text contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourcePollResource</returns>            
        public ModelPageResourcePollResource GetPolls (string filterCategory, string filterTagset, string filterText, int? size, int? page, string order)
        {
            
    
            var path = "/media/polls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterText != null) queryParams.Add("filter_text", ApiClient.ParameterToString(filterText)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPolls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPolls: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourcePollResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourcePollResource), response.Headers);
        }
    
        /// <summary>
        /// Update an existing poll 
        /// </summary>
        /// <param name="id">The poll id</param> 
        /// <param name="pollResource">The poll object</param> 
        /// <returns>ModelPollResource</returns>            
        public ModelPollResource UpdatePoll (string id, ModelPollResource pollResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePoll");
            
    
            var path = "/media/polls/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(pollResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPollResource) ApiClient.Deserialize(response.Content, typeof(ModelPollResource), response.Headers);
        }
    
        /// <summary>
        /// Update a poll template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="pollTemplateResource">The poll template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource UpdatePollTemplate (string id, ModelTemplateResource pollTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePollTemplate");
            
    
            var path = "/media/polls/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(pollTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePollTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePollTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
    }
}