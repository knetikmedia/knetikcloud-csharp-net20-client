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
    public interface ISearchApi
    {
        /// <summary>
        /// Count matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <returns>Object</returns>
        Object SearchCountGET (string type);
        /// <summary>
        /// Count matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchCountPOST (string type, Object query);
        /// <summary>
        /// Count matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchCountWithTemplateGET (string type, string template);
        /// <summary>
        /// Count matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchCountWithTemplatePOST (string type, string template, Object query);
        /// <summary>
        /// Get document with no template This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <returns>Object</returns>
        Object SearchDocumentGET (string type, string id);
        /// <summary>
        /// Get document with a template This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchDocumentWithTemplateGET (string type, string id, string template);
        /// <summary>
        /// Explain matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <returns>Object</returns>
        Object SearchExplainGET (string type, string id);
        /// <summary>
        /// Explain matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchExplainPOST (string type, string id, Object query);
        /// <summary>
        /// Explain matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchExplainWithTemplateGET (string type, string id, string template);
        /// <summary>
        /// Explain matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="id">The index id</param>
        /// <param name="template">The index template</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchExplainWithTemplatePOST (string type, string id, string template, Object query);
        /// <summary>
        /// Search an index with no template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchIndex (string type, Object query);
        /// <summary>
        /// Search an index with no template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <returns>Object</returns>
        Object SearchIndexGET (string type);
        /// <summary>
        /// Search an index with a template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchIndexWithTemplateGET (string type, string template);
        /// <summary>
        /// Search an index with a template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchIndexWithTemplatePOST (string type, string template, Object query);
        /// <summary>
        /// Get indices This is a 1 to 1 mapping of a ElasticSearch call to _cat/indices for indices.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <returns>Object</returns>
        Object SearchIndicesGET ();
        /// <summary>
        /// Get mapping with no template This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <returns>Object</returns>
        Object SearchMappingsGET (string type);
        /// <summary>
        /// Get mapping with a template This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchMappingsWithTemplateGET (string type, string template);
        /// <summary>
        /// Validate matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <returns>Object</returns>
        Object SearchValidateGET (string type);
        /// <summary>
        /// Validate matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchValidatePOST (string type, Object query);
        /// <summary>
        /// Validate matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <returns>Object</returns>
        Object SearchValidateWithTemplateGET (string type, string template);
        /// <summary>
        /// Validate matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param>
        /// <param name="template">The index template</param>
        /// <param name="query">The query to be used for the search</param>
        /// <returns>Object</returns>
        Object SearchValidateWithTemplatePOST (string type, string template, Object query);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
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
        /// Count matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <returns>Object</returns>            
        public Object SearchCountGET (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchCountGET");
            
    
            var path = "/search/count/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Count matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchCountPOST (string type, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchCountPOST");
            
    
            var path = "/search/count/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Count matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchCountWithTemplateGET (string type, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchCountWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchCountWithTemplateGET");
            
    
            var path = "/search/count/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Count matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _count.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchCountWithTemplatePOST (string type, string template, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchCountWithTemplatePOST");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchCountWithTemplatePOST");
            
    
            var path = "/search/count/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountWithTemplatePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchCountWithTemplatePOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get document with no template This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <returns>Object</returns>            
        public Object SearchDocumentGET (string type, string id)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchDocumentGET");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchDocumentGET");
            
    
            var path = "/search/documents/{type}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchDocumentGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchDocumentGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get document with a template This is a 1 to 1 mapping of a ElasticSearch call.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchDocumentWithTemplateGET (string type, string id, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchDocumentWithTemplateGET");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchDocumentWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchDocumentWithTemplateGET");
            
    
            var path = "/search/documents/{type}/{template}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchDocumentWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchDocumentWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Explain matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <returns>Object</returns>            
        public Object SearchExplainGET (string type, string id)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchExplainGET");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchExplainGET");
            
    
            var path = "/search/explain/{type}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Explain matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchExplainPOST (string type, string id, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchExplainPOST");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchExplainPOST");
            
    
            var path = "/search/explain/{type}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Explain matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchExplainWithTemplateGET (string type, string id, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchExplainWithTemplateGET");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchExplainWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchExplainWithTemplateGET");
            
    
            var path = "/search/explain/{type}/{template}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Explain matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _explain.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-count.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="id">The index id</param> 
        /// <param name="template">The index template</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchExplainWithTemplatePOST (string type, string id, string template, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchExplainWithTemplatePOST");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SearchExplainWithTemplatePOST");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchExplainWithTemplatePOST");
            
    
            var path = "/search/explain/{type}/{template}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainWithTemplatePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchExplainWithTemplatePOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Search an index with no template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchIndex (string type, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchIndex");
            
    
            var path = "/search/index/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndex: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndex: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Search an index with no template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <returns>Object</returns>            
        public Object SearchIndexGET (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchIndexGET");
            
    
            var path = "/search/index/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Search an index with a template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchIndexWithTemplateGET (string type, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchIndexWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchIndexWithTemplateGET");
            
    
            var path = "/search/index/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Search an index with a template This is a 1 to 1 mapping of a ElasticSearch call to _search.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchIndexWithTemplatePOST (string type, string template, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchIndexWithTemplatePOST");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchIndexWithTemplatePOST");
            
    
            var path = "/search/index/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexWithTemplatePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndexWithTemplatePOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get indices This is a 1 to 1 mapping of a ElasticSearch call to _cat/indices for indices.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <returns>Object</returns>            
        public Object SearchIndicesGET ()
        {
            
    
            var path = "/search/indices";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndicesGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchIndicesGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get mapping with no template This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <returns>Object</returns>            
        public Object SearchMappingsGET (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchMappingsGET");
            
    
            var path = "/search/mappings/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMappingsGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMappingsGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get mapping with a template This is a 1 to 1 mapping of a ElasticSearch call to _mapping.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-get-mapping.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchMappingsWithTemplateGET (string type, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchMappingsWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchMappingsWithTemplateGET");
            
    
            var path = "/search/mappings/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMappingsWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMappingsWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Validate matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <returns>Object</returns>            
        public Object SearchValidateGET (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchValidateGET");
            
    
            var path = "/search/validate/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Validate matches with no template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchValidatePOST (string type, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchValidatePOST");
            
    
            var path = "/search/validate/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidatePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidatePOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Validate matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <returns>Object</returns>            
        public Object SearchValidateWithTemplateGET (string type, string template)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchValidateWithTemplateGET");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchValidateWithTemplateGET");
            
    
            var path = "/search/validate/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateWithTemplateGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateWithTemplateGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Validate matches with a template This is a 1 to 1 mapping of a ElasticSearch call to _validate/query.  Further information can be found at their &lt;a href&#x3D;&#39;https://www.elastic.co/guide/en/elasticsearch/reference/current/search-validate.html&#39;&gt;API guide&lt;/a&gt;. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SEARCH_ADMIN
        /// </summary>
        /// <param name="type">The index type</param> 
        /// <param name="template">The index template</param> 
        /// <param name="query">The query to be used for the search</param> 
        /// <returns>Object</returns>            
        public Object SearchValidateWithTemplatePOST (string type, string template, Object query)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling SearchValidateWithTemplatePOST");
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling SearchValidateWithTemplatePOST");
            
    
            var path = "/search/validate/{type}/{template}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(query); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateWithTemplatePOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchValidateWithTemplatePOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
