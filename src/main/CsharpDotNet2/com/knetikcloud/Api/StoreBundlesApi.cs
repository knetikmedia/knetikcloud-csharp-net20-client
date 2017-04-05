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
    public interface IStoreBundlesApi
    {
        /// <summary>
        /// Create a bundle item The SKU for the bundle itself must be unique and there can only be one SKU.  Extra notes for price_override:  The price of all the items (multiplied by the quantity) must equal the price of the bundle.  With individual prices set, items will be processed individually and can be refunded as such.  However, if all prices are set to null, the price of the bundle will be used and will be treated as one item.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="bundleItem">The bundle item object</param>
        /// <returns>ModelBundleItem</returns>
        ModelBundleItem CreateBundleItem (bool? cascade, ModelBundleItem bundleItem);
        /// <summary>
        /// Create a bundle template Bundle Templates define a type of bundle and the properties they have.
        /// </summary>
        /// <param name="bundleTemplateResource">The new bundle template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource CreateBundleTemplate (ModelItemTemplateResource bundleTemplateResource);
        /// <summary>
        /// Delete a bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param>
        /// <returns></returns>
        void DeleteBundleItem (int? id);
        /// <summary>
        /// Delete a bundle template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <returns></returns>
        void DeleteBundleTemplate (string id, string cascade);
        /// <summary>
        /// Get a single bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param>
        /// <returns>ModelBundleItem</returns>
        ModelBundleItem GetBundleItem (int? id);
        /// <summary>
        /// Get a single bundle template Bundle Templates define a type of bundle and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource GetBundleTemplate (string id);
        /// <summary>
        /// List and search bundle templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceItemTemplateResource</returns>
        ModelPageResourceItemTemplateResource GetBundleTemplates (int? size, int? page, string order);
        /// <summary>
        /// Update a bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="bundleItem">The bundle item object</param>
        /// <returns>ModelBundleItem</returns>
        ModelBundleItem UpdateBundleItem (int? id, bool? cascade, ModelBundleItem bundleItem);
        /// <summary>
        /// Update a bundle template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="bundleTemplateResource">The bundle template resource object</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource UpdateBundleTemplate (string id, ModelItemTemplateResource bundleTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreBundlesApi : IStoreBundlesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBundlesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreBundlesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBundlesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreBundlesApi(String basePath)
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
        /// Create a bundle item The SKU for the bundle itself must be unique and there can only be one SKU.  Extra notes for price_override:  The price of all the items (multiplied by the quantity) must equal the price of the bundle.  With individual prices set, items will be processed individually and can be refunded as such.  However, if all prices are set to null, the price of the bundle will be used and will be treated as one item.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="bundleItem">The bundle item object</param> 
        /// <returns>ModelBundleItem</returns>            
        public ModelBundleItem CreateBundleItem (bool? cascade, ModelBundleItem bundleItem)
        {
            
    
            var path = "/store/bundles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(bundleItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBundleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBundleItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelBundleItem) ApiClient.Deserialize(response.Content, typeof(ModelBundleItem), response.Headers);
        }
    
        /// <summary>
        /// Create a bundle template Bundle Templates define a type of bundle and the properties they have.
        /// </summary>
        /// <param name="bundleTemplateResource">The new bundle template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource CreateBundleTemplate (ModelItemTemplateResource bundleTemplateResource)
        {
            
    
            var path = "/store/bundles/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(bundleTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBundleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBundleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param> 
        /// <returns></returns>            
        public void DeleteBundleItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBundleItem");
            
    
            var path = "/store/bundles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBundleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBundleItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a bundle template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param> 
        /// <returns></returns>            
        public void DeleteBundleTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBundleTemplate");
            
    
            var path = "/store/bundles/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBundleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBundleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param> 
        /// <returns>ModelBundleItem</returns>            
        public ModelBundleItem GetBundleItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBundleItem");
            
    
            var path = "/store/bundles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelBundleItem) ApiClient.Deserialize(response.Content, typeof(ModelBundleItem), response.Headers);
        }
    
        /// <summary>
        /// Get a single bundle template Bundle Templates define a type of bundle and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource GetBundleTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBundleTemplate");
            
    
            var path = "/store/bundles/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search bundle templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceItemTemplateResource</returns>            
        public ModelPageResourceItemTemplateResource GetBundleTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/store/bundles/templates";
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBundleTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update a bundle item 
        /// </summary>
        /// <param name="id">The id of the bundle</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="bundleItem">The bundle item object</param> 
        /// <returns>ModelBundleItem</returns>            
        public ModelBundleItem UpdateBundleItem (int? id, bool? cascade, ModelBundleItem bundleItem)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBundleItem");
            
    
            var path = "/store/bundles/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(bundleItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBundleItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBundleItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelBundleItem) ApiClient.Deserialize(response.Content, typeof(ModelBundleItem), response.Headers);
        }
    
        /// <summary>
        /// Update a bundle template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="bundleTemplateResource">The bundle template resource object</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource UpdateBundleTemplate (string id, ModelItemTemplateResource bundleTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBundleTemplate");
            
    
            var path = "/store/bundles/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(bundleTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBundleTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBundleTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
    }
}
