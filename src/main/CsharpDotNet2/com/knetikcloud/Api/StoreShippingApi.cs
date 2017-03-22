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
    public interface IStoreShippingApi
    {
        /// <summary>
        /// Create a shipping item A shipping item represents a shipping option and cost. SKUs have to be unique in the entire store.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="shippingItem">The shipping item object</param>
        /// <returns>ModelShippingItem</returns>
        ModelShippingItem CreateShippingItem (bool? cascade, ModelShippingItem shippingItem);
        /// <summary>
        /// Create a shipping template Shipping Templates define a type of shipping and the properties they have.
        /// </summary>
        /// <param name="shippingTemplateResource">The new shipping template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource CreateShippingTemplate (ModelItemTemplateResource shippingTemplateResource);
        /// <summary>
        /// Delete a shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param>
        /// <returns></returns>
        void DeleteShippingItem (int? id);
        /// <summary>
        /// Delete a shipping template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <returns></returns>
        void DeleteShippingTemplate (string id, string cascade);
        /// <summary>
        /// Get a single shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param>
        /// <returns>ModelShippingItem</returns>
        ModelShippingItem GetShippingItem (int? id);
        /// <summary>
        /// Get a single shipping template Shipping Templates define a type of shipping and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource GetShippingTemplate (string id);
        /// <summary>
        /// List and search shipping templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceItemTemplateResource</returns>
        ModelPageResourceItemTemplateResource GetShippingTemplates (int? size, int? page, string order);
        /// <summary>
        /// Update a shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="shippingItem">The shipping item object</param>
        /// <returns>ModelShippingItem</returns>
        ModelShippingItem UpdateShippingItem (int? id, bool? cascade, ModelShippingItem shippingItem);
        /// <summary>
        /// Update a shipping template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="shippingTemplateResource">The shipping template resource object</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource UpdateShippingTemplate (string id, ModelItemTemplateResource shippingTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreShippingApi : IStoreShippingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreShippingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreShippingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreShippingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreShippingApi(String basePath)
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
        /// Create a shipping item A shipping item represents a shipping option and cost. SKUs have to be unique in the entire store.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="shippingItem">The shipping item object</param> 
        /// <returns>ModelShippingItem</returns>            
        public ModelShippingItem CreateShippingItem (bool? cascade, ModelShippingItem shippingItem)
        {
            
    
            var path = "/store/shipping";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(shippingItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateShippingItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateShippingItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelShippingItem) ApiClient.Deserialize(response.Content, typeof(ModelShippingItem), response.Headers);
        }
    
        /// <summary>
        /// Create a shipping template Shipping Templates define a type of shipping and the properties they have.
        /// </summary>
        /// <param name="shippingTemplateResource">The new shipping template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource CreateShippingTemplate (ModelItemTemplateResource shippingTemplateResource)
        {
            
    
            var path = "/store/shipping/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(shippingTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateShippingTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateShippingTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param> 
        /// <returns></returns>            
        public void DeleteShippingItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteShippingItem");
            
    
            var path = "/store/shipping/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a shipping template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param> 
        /// <returns></returns>            
        public void DeleteShippingTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteShippingTemplate");
            
    
            var path = "/store/shipping/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param> 
        /// <returns>ModelShippingItem</returns>            
        public ModelShippingItem GetShippingItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetShippingItem");
            
    
            var path = "/store/shipping/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelShippingItem) ApiClient.Deserialize(response.Content, typeof(ModelShippingItem), response.Headers);
        }
    
        /// <summary>
        /// Get a single shipping template Shipping Templates define a type of shipping and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource GetShippingTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetShippingTemplate");
            
    
            var path = "/store/shipping/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search shipping templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceItemTemplateResource</returns>            
        public ModelPageResourceItemTemplateResource GetShippingTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/store/shipping/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update a shipping item 
        /// </summary>
        /// <param name="id">The id of the shipping item</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="shippingItem">The shipping item object</param> 
        /// <returns>ModelShippingItem</returns>            
        public ModelShippingItem UpdateShippingItem (int? id, bool? cascade, ModelShippingItem shippingItem)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateShippingItem");
            
    
            var path = "/store/shipping/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(shippingItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelShippingItem) ApiClient.Deserialize(response.Content, typeof(ModelShippingItem), response.Headers);
        }
    
        /// <summary>
        /// Update a shipping template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="shippingTemplateResource">The shipping template resource object</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource UpdateShippingTemplate (string id, ModelItemTemplateResource shippingTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateShippingTemplate");
            
    
            var path = "/store/shipping/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(shippingTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
    }
}
