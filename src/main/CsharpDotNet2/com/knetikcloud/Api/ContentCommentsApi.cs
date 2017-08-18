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
    public interface IContentCommentsApi
    {
        /// <summary>
        /// Add a new comment 
        /// </summary>
        /// <param name="commentResource">The comment to be added</param>
        /// <returns>CommentResource</returns>
        CommentResource AddComment (CommentResource commentResource);
        /// <summary>
        /// Delete a comment 
        /// </summary>
        /// <param name="id">The comment id</param>
        /// <returns></returns>
        void DeleteComment (long? id);
        /// <summary>
        /// Return a comment 
        /// </summary>
        /// <param name="id">The comment id</param>
        /// <returns>CommentResource</returns>
        CommentResource GetComment (long? id);
        /// <summary>
        /// Returns a page of comments 
        /// </summary>
        /// <param name="context">Get comments by context type</param>
        /// <param name="contextId">Get comments by context id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceCommentResource</returns>
        PageResourceCommentResource GetComments (string context, int? contextId, int? size, int? page);
        /// <summary>
        /// Search the comment index The body is an ElasticSearch query json. Please see their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/index.html&#39;&gt;documentation&lt;/a&gt; for details on the format and search options
        /// </summary>
        /// <param name="query">The search query</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>CommentSearch</returns>
        CommentSearch SearchComments (Object query, int? size, int? page);
        /// <summary>
        /// Update a comment 
        /// </summary>
        /// <param name="id">The comment id</param>
        /// <param name="content">The comment content</param>
        /// <returns></returns>
        void UpdateComment (long? id, StringWrapper content);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContentCommentsApi : IContentCommentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentCommentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContentCommentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentCommentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContentCommentsApi(String basePath)
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
        /// Add a new comment 
        /// </summary>
        /// <param name="commentResource">The comment to be added</param> 
        /// <returns>CommentResource</returns>            
        public CommentResource AddComment (CommentResource commentResource)
        {
            
    
            var path = "/comments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(commentResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommentResource) ApiClient.Deserialize(response.Content, typeof(CommentResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a comment 
        /// </summary>
        /// <param name="id">The comment id</param> 
        /// <returns></returns>            
        public void DeleteComment (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteComment");
            
    
            var path = "/comments/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Return a comment 
        /// </summary>
        /// <param name="id">The comment id</param> 
        /// <returns>CommentResource</returns>            
        public CommentResource GetComment (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetComment");
            
    
            var path = "/comments/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommentResource) ApiClient.Deserialize(response.Content, typeof(CommentResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of comments 
        /// </summary>
        /// <param name="context">Get comments by context type</param> 
        /// <param name="contextId">Get comments by context id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceCommentResource</returns>            
        public PageResourceCommentResource GetComments (string context, int? contextId, int? size, int? page)
        {
            
            // verify the required parameter 'context' is set
            if (context == null) throw new ApiException(400, "Missing required parameter 'context' when calling GetComments");
            
            // verify the required parameter 'contextId' is set
            if (contextId == null) throw new ApiException(400, "Missing required parameter 'contextId' when calling GetComments");
            
    
            var path = "/comments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (context != null) queryParams.Add("context", ApiClient.ParameterToString(context)); // query parameter
 if (contextId != null) queryParams.Add("context_id", ApiClient.ParameterToString(contextId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceCommentResource) ApiClient.Deserialize(response.Content, typeof(PageResourceCommentResource), response.Headers);
        }
    
        /// <summary>
        /// Search the comment index The body is an ElasticSearch query json. Please see their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/index.html&#39;&gt;documentation&lt;/a&gt; for details on the format and search options
        /// </summary>
        /// <param name="query">The search query</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>CommentSearch</returns>            
        public CommentSearch SearchComments (Object query, int? size, int? page)
        {
            
    
            var path = "/comments/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommentSearch) ApiClient.Deserialize(response.Content, typeof(CommentSearch), response.Headers);
        }
    
        /// <summary>
        /// Update a comment 
        /// </summary>
        /// <param name="id">The comment id</param> 
        /// <param name="content">The comment content</param> 
        /// <returns></returns>            
        public void UpdateComment (long? id, StringWrapper content)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateComment");
            
    
            var path = "/comments/{id}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(content); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
