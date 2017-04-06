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
    public interface IBRERuleEngineCategoriesApi
    {
        /// <summary>
        /// Create a BRE category template Templates define a type of BRE category and the properties they have
        /// </summary>
        /// <param name="template">The category template to create</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource CreateBRECategoryTemplate (ModelTemplateResource template);
        /// <summary>
        /// Delete a BRE category template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteBRECategoryTemplate (string id, string cascade);
        /// <summary>
        /// List categories 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>ModelPageResourceBreCategoryResource</returns>
        ModelPageResourceBreCategoryResource GetBRECategories (int? size, int? page);
        /// <summary>
        /// Get a single category 
        /// </summary>
        /// <param name="name">The category name</param>
        /// <returns>ModelBreCategoryResource</returns>
        ModelBreCategoryResource GetBRECategory (string name);
        /// <summary>
        /// Get a single BRE category template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource GetBRECategoryTemplate (string id);
        /// <summary>
        /// List and search BRE category templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceTemplateResource</returns>
        ModelPageResourceTemplateResource GetBRECategoryTemplates (int? size, int? page, string order);
        /// <summary>
        /// Update a category 
        /// </summary>
        /// <param name="name">The category name</param>
        /// <param name="category">The updated BRE category information</param>
        /// <returns>ModelBreCategoryResource</returns>
        ModelBreCategoryResource UpdateBRECategory (string name, ModelBreCategoryResource category);
        /// <summary>
        /// Update a BRE category template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated category template definition</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource UpdateBRECategoryTemplate (string id, ModelTemplateResource template);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BRERuleEngineCategoriesApi : IBRERuleEngineCategoriesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineCategoriesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BRERuleEngineCategoriesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BRERuleEngineCategoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BRERuleEngineCategoriesApi(String basePath)
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
        /// Create a BRE category template Templates define a type of BRE category and the properties they have
        /// </summary>
        /// <param name="template">The category template to create</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource CreateBRECategoryTemplate (ModelTemplateResource template)
        {
            
    
            var path = "/bre/categories/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRECategoryTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBRECategoryTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a BRE category template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteBRECategoryTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBRECategoryTemplate");
            
    
            var path = "/bre/categories/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRECategoryTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBRECategoryTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List categories 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>ModelPageResourceBreCategoryResource</returns>            
        public ModelPageResourceBreCategoryResource GetBRECategories (int? size, int? page)
        {
            
    
            var path = "/bre/categories";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceBreCategoryResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceBreCategoryResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single category 
        /// </summary>
        /// <param name="name">The category name</param> 
        /// <returns>ModelBreCategoryResource</returns>            
        public ModelBreCategoryResource GetBRECategory (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetBRECategory");
            
    
            var path = "/bre/categories/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelBreCategoryResource) ApiClient.Deserialize(response.Content, typeof(ModelBreCategoryResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single BRE category template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource GetBRECategoryTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBRECategoryTemplate");
            
    
            var path = "/bre/categories/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategoryTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategoryTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search BRE category templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceTemplateResource</returns>            
        public ModelPageResourceTemplateResource GetBRECategoryTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/bre/categories/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategoryTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBRECategoryTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update a category 
        /// </summary>
        /// <param name="name">The category name</param> 
        /// <param name="category">The updated BRE category information</param> 
        /// <returns>ModelBreCategoryResource</returns>            
        public ModelBreCategoryResource UpdateBRECategory (string name, ModelBreCategoryResource category)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBRECategory");
            
    
            var path = "/bre/categories/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(category); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRECategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRECategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelBreCategoryResource) ApiClient.Deserialize(response.Content, typeof(ModelBreCategoryResource), response.Headers);
        }
    
        /// <summary>
        /// Update a BRE category template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The updated category template definition</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource UpdateBRECategoryTemplate (string id, ModelTemplateResource template)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBRECategoryTemplate");
            
    
            var path = "/bre/categories/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRECategoryTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBRECategoryTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
    }
}