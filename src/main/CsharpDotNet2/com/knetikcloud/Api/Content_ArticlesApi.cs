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
    public interface IContent_ArticlesApi
    {
        /// <summary>
        /// Create a new article Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.&lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="articleResource">The new article</param>
        /// <returns>ArticleResource</returns>
        ArticleResource CreateArticle (ArticleResource articleResource);
        /// <summary>
        /// Create an article template Article Templates define a type of article and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="articleTemplateResource">The article template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateArticleTemplate (TemplateResource articleTemplateResource);
        /// <summary>
        /// Create a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="template">The template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateTemplate (string typeHint, TemplateResource template);
        /// <summary>
        /// Delete an existing article &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The article id</param>
        /// <returns></returns>
        void DeleteArticle (string id);
        /// <summary>
        /// Delete an article template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteArticleTemplate (string id, string cascade);
        /// <summary>
        /// Delete a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">How to cascade the delete</param>
        /// <returns></returns>
        void DeleteTemplate (string typeHint, string id, string cascade);
        /// <summary>
        /// Get a single article &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The article id</param>
        /// <returns>ArticleResource</returns>
        ArticleResource GetArticle (string id);
        /// <summary>
        /// Get a single article template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetArticleTemplate (string id);
        /// <summary>
        /// List and search article templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ARTICLES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetArticleTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search articles Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single article&#39; to retrieve the full resource with assets for a given item as needed. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterActiveOnly">Filter for articles that are active (true) or inactive (false)</param>
        /// <param name="filterCategory">Filter for articles from a specific category by id</param>
        /// <param name="filterTagset">Filter for articles with at least one of a specified set of tags (separated by comma)</param>
        /// <param name="filterTagIntersection">Filter for articles with all of a specified set of tags (separated by comma)</param>
        /// <param name="filterTagExclusion">Filter for articles with none of a specified set of tags (separated by comma)</param>
        /// <param name="filterTitle">Filter for articles whose title contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceArticleResource</returns>
        PageResourceArticleResource GetArticles (bool? filterActiveOnly, string filterCategory, string filterTagset, string filterTagIntersection, string filterTagExclusion, string filterTitle, int? size, int? page, string order);
        /// <summary>
        /// Get a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetTemplate (string typeHint, string id);
        /// <summary>
        /// List and search templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetTemplates (string typeHint, int? size, int? page, string order);
        /// <summary>
        /// Update an existing article &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The article id</param>
        /// <param name="articleResource">The article object</param>
        /// <returns>ArticleResource</returns>
        ArticleResource UpdateArticle (string id, ArticleResource articleResource);
        /// <summary>
        /// Update an article template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="articleTemplateResource">The article template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateArticleTemplate (string id, TemplateResource articleTemplateResource);
        /// <summary>
        /// Update a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateTemplate (string typeHint, string id, TemplateResource template);
        /// <summary>
        /// Validate a templated resource Error code thrown if invalid.&lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param>
        /// <param name="resource">The resource to validate</param>
        /// <returns></returns>
        void Validate (string typeHint, BasicTemplatedResource resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Content_ArticlesApi : IContent_ArticlesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Content_ArticlesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Content_ArticlesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Content_ArticlesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Content_ArticlesApi(String basePath)
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
        /// Create a new article Articles are blobs of text with titles, a category and assets. Formatting and display of the text is in the hands of the front end.&lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="articleResource">The new article</param> 
        /// <returns>ArticleResource</returns>            
        public ArticleResource CreateArticle (ArticleResource articleResource)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArticleResource) ApiClient.Deserialize(response.Content, typeof(ArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Create an article template Article Templates define a type of article and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="articleTemplateResource">The article template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateArticleTemplate (TemplateResource articleTemplateResource)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Create a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="template">The template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateTemplate (string typeHint, TemplateResource template)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling CreateTemplate");
            
    
            var path = "/templates/{type_hint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing article &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an article template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">How to cascade the delete</param> 
        /// <returns></returns>            
        public void DeleteTemplate (string typeHint, string id, string cascade)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling DeleteTemplate");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTemplate");
            
    
            var path = "/templates/{type_hint}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cascade); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single article &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The article id</param> 
        /// <returns>ArticleResource</returns>            
        public ArticleResource GetArticle (string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArticleResource) ApiClient.Deserialize(response.Content, typeof(ArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single article template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetArticleTemplate (string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search article templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ARTICLES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetArticleTemplates (int? size, int? page, string order)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticleTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search articles Get a list of articles with optional filtering. Assets will not be filled in on the resources returned. Use &#39;Get a single article&#39; to retrieve the full resource with assets for a given item as needed. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterActiveOnly">Filter for articles that are active (true) or inactive (false)</param> 
        /// <param name="filterCategory">Filter for articles from a specific category by id</param> 
        /// <param name="filterTagset">Filter for articles with at least one of a specified set of tags (separated by comma)</param> 
        /// <param name="filterTagIntersection">Filter for articles with all of a specified set of tags (separated by comma)</param> 
        /// <param name="filterTagExclusion">Filter for articles with none of a specified set of tags (separated by comma)</param> 
        /// <param name="filterTitle">Filter for articles whose title contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceArticleResource</returns>            
        public PageResourceArticleResource GetArticles (bool? filterActiveOnly, string filterCategory, string filterTagset, string filterTagIntersection, string filterTagExclusion, string filterTitle, int? size, int? page, string order)
        {
            
    
            var path = "/content/articles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterActiveOnly != null) queryParams.Add("filter_active_only", ApiClient.ParameterToString(filterActiveOnly)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterTagIntersection != null) queryParams.Add("filter_tag_intersection", ApiClient.ParameterToString(filterTagIntersection)); // query parameter
 if (filterTagExclusion != null) queryParams.Add("filter_tag_exclusion", ApiClient.ParameterToString(filterTagExclusion)); // query parameter
 if (filterTitle != null) queryParams.Add("filter_title", ApiClient.ParameterToString(filterTitle)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArticles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceArticleResource) ApiClient.Deserialize(response.Content, typeof(PageResourceArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Get a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetTemplate (string typeHint, string id)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling GetTemplate");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTemplate");
            
    
            var path = "/templates/{type_hint}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetTemplates (string typeHint, int? size, int? page, string order)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling GetTemplates");
            
    
            var path = "/templates/{type_hint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update an existing article &lt;b&gt;Permissions Needed:&lt;/b&gt; ARTICLES_ADMIN
        /// </summary>
        /// <param name="id">The article id</param> 
        /// <param name="articleResource">The article object</param> 
        /// <returns>ArticleResource</returns>            
        public ArticleResource UpdateArticle (string id, ArticleResource articleResource)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticle: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticle: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArticleResource) ApiClient.Deserialize(response.Content, typeof(ArticleResource), response.Headers);
        }
    
        /// <summary>
        /// Update an article template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="articleTemplateResource">The article template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateArticleTemplate (string id, TemplateResource articleTemplateResource)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArticleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update a template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateTemplate (string typeHint, string id, TemplateResource template)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling UpdateTemplate");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateTemplate");
            
    
            var path = "/templates/{type_hint}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Validate a templated resource Error code thrown if invalid.&lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATES_ADMIN
        /// </summary>
        /// <param name="typeHint">The type for the resource this template applies to</param> 
        /// <param name="resource">The resource to validate</param> 
        /// <returns></returns>            
        public void Validate (string typeHint, BasicTemplatedResource resource)
        {
            
            // verify the required parameter 'typeHint' is set
            if (typeHint == null) throw new ApiException(400, "Missing required parameter 'typeHint' when calling Validate");
            
    
            var path = "/templates/{type_hint}/validate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type_hint" + "}", ApiClient.ParameterToString(typeHint));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Validate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Validate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
