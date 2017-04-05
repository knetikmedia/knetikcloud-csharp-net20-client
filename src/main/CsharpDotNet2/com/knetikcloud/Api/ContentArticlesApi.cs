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
    public interface IContentArticlesApi
    {
        /// <summary>
        /// Create a new article Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.
        /// </summary>
        /// <param name="articleResource">The new article</param>
        /// <returns>ModelArticleResource</returns>
        ModelArticleResource CreateArticle (ModelArticleResource articleResource);
        /// <summary>
        /// Create an article template Article Templates define a type of article and the properties they have
        /// </summary>
        /// <param name="articleTemplateResource">The article template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource CreateArticleTemplate (ModelTemplateResource articleTemplateResource);
        /// <summary>
        /// Delete an existing article 
        /// </summary>
        /// <param name="id">The article id</param>
        /// <returns></returns>
        void DeleteArticle (string id);
        /// <summary>
        /// Delete an article template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteArticleTemplate (string id, string cascade);
        /// <summary>
        /// Get a single article 
        /// </summary>
        /// <param name="id">The article id</param>
        /// <returns>ModelArticleResource</returns>
        ModelArticleResource GetArticle (string id);
        /// <summary>
        /// Get a single article template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource GetArticleTemplate (string id);
        /// <summary>
        /// List and search article templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceTemplateResource</returns>
        ModelPageResourceTemplateResource GetArticleTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search articles Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single article&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="filterCategory">Filter for articles from a specific category by id</param>
        /// <param name="filterTagset">Filter for articles with specified tags (separated by comma)</param>
        /// <param name="filterTitle">Filter for articles whose title contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceArticleResource</returns>
        ModelPageResourceArticleResource GetArticles (string filterCategory, string filterTagset, string filterTitle, int? size, int? page, string order);
        /// <summary>
        /// Update an existing article 
        /// </summary>
        /// <param name="id">The article id</param>
        /// <param name="articleResource">The article object</param>
        /// <returns>ModelArticleResource</returns>
        ModelArticleResource UpdateArticle (string id, ModelArticleResource articleResource);
        /// <summary>
        /// Update an article template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="articleTemplateResource">The article template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource UpdateArticleTemplate (string id, ModelTemplateResource articleTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContentArticlesApi : IContentArticlesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentArticlesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContentArticlesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentArticlesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContentArticlesApi(String basePath)
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
        /// Create a new article Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.
        /// </summary>
        /// <param name="articleResource">The new article</param> 
        /// <returns>ModelArticleResource</returns>            
        public ModelArticleResource CreateArticle (ModelArticleResource articleResource)
        {
            
    
            var path = "/content/articles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(articleResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelArticleResource) ApiClient.Deserialize(response.Content, typeof(ModelArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Create an article template Article Templates define a type of article and the properties they have
        /// </summary>
        /// <param name="articleTemplateResource">The article template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource CreateArticleTemplate (ModelTemplateResource articleTemplateResource)
        {
            
    
            var path = "/content/articles/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(articleTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing article 
        /// </summary>
        /// <param name="id">The article id</param> 
        /// <returns></returns>            
        public void DeleteArticle (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteArticle");
            
    
            var path = "/content/articles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an article template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteArticleTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteArticleTemplate");
            
    
            var path = "/content/articles/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single article 
        /// </summary>
        /// <param name="id">The article id</param> 
        /// <returns>ModelArticleResource</returns>            
        public ModelArticleResource GetArticle (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetArticle");
            
    
            var path = "/content/articles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelArticleResource) ApiClient.Deserialize(response.Content, typeof(ModelArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single article template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource GetArticleTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetArticleTemplate");
            
    
            var path = "/content/articles/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search article templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceTemplateResource</returns>            
        public ModelPageResourceTemplateResource GetArticleTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/content/articles/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search articles Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single article&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="filterCategory">Filter for articles from a specific category by id</param> 
        /// <param name="filterTagset">Filter for articles with specified tags (separated by comma)</param> 
        /// <param name="filterTitle">Filter for articles whose title contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceArticleResource</returns>            
        public ModelPageResourceArticleResource GetArticles (string filterCategory, string filterTagset, string filterTitle, int? size, int? page, string order)
        {
            
    
            var path = "/content/articles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterTitle != null) queryParams.Add("filter_title", ApiClient.ParameterToString(filterTitle)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceArticleResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Update an existing article 
        /// </summary>
        /// <param name="id">The article id</param> 
        /// <param name="articleResource">The article object</param> 
        /// <returns>ModelArticleResource</returns>            
        public ModelArticleResource UpdateArticle (string id, ModelArticleResource articleResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateArticle");
            
    
            var path = "/content/articles/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(articleResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelArticleResource) ApiClient.Deserialize(response.Content, typeof(ModelArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Update an article template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="articleTemplateResource">The article template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource UpdateArticleTemplate (string id, ModelTemplateResource articleTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateArticleTemplate");
            
    
            var path = "/content/articles/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(articleTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
    }
}
