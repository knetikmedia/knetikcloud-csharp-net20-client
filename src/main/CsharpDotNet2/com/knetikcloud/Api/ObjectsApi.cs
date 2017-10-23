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
    public interface IObjectsApi
    {
        /// <summary>
        /// Create an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is to be part of</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="objectItem">The object item object</param>
        /// <returns>ObjectResource</returns>
        ObjectResource CreateObjectItem (string templateId, bool? cascade, ObjectResource objectItem);
        /// <summary>
        /// Create an object template Object templates define a type of entitlement and the properties they have
        /// </summary>
        /// <param name="template">The entitlement template to be created</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource CreateObjectTemplate (ItemTemplateResource template);
        /// <summary>
        /// Delete an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param>
        /// <param name="objectId">The id of the object</param>
        /// <returns></returns>
        void DeleteObjectItem (string templateId, int? objectId);
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteObjectTemplate (string id, string cascade);
        /// <summary>
        /// Get a single object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param>
        /// <param name="objectId">The id of the object</param>
        /// <returns>ObjectResource</returns>
        ObjectResource GetObjectItem (string templateId, int? objectId);
        /// <summary>
        /// List and search objects 
        /// </summary>
        /// <param name="templateId">The id of the template to get objects for</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceObjectResource</returns>
        PageResourceObjectResource GetObjectItems (string templateId, int? size, int? page, string order);
        /// <summary>
        /// Get a single entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource GetObjectTemplate (string id);
        /// <summary>
        /// List and search entitlement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceItemTemplateResource</returns>
        PageResourceItemTemplateResource GetObjectTemplates (int? size, int? page, string order);
        /// <summary>
        /// Update an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="objectItem">The object item object</param>
        /// <returns></returns>
        void UpdateObjectItem (string templateId, int? entitlementId, bool? cascade, EntitlementItem objectItem);
        /// <summary>
        /// Update an entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource UpdateObjectTemplate (string id, ItemTemplateResource template);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ObjectsApi : IObjectsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ObjectsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectsApi(String basePath)
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
        /// Create an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is to be part of</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="objectItem">The object item object</param> 
        /// <returns>ObjectResource</returns>            
        public ObjectResource CreateObjectItem (string templateId, bool? cascade, ObjectResource objectItem)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateObjectItem");
            
    
            var path = "/objects/{template_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_id" + "}", ApiClient.ParameterToString(templateId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(objectItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateObjectItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateObjectItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ObjectResource) ApiClient.Deserialize(response.Content, typeof(ObjectResource), response.Headers);
        }
    
        /// <summary>
        /// Create an object template Object templates define a type of entitlement and the properties they have
        /// </summary>
        /// <param name="template">The entitlement template to be created</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource CreateObjectTemplate (ItemTemplateResource template)
        {
            
    
            var path = "/objects/templates";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateObjectTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateObjectTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param> 
        /// <param name="objectId">The id of the object</param> 
        /// <returns></returns>            
        public void DeleteObjectItem (string templateId, int? objectId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteObjectItem");
            
            // verify the required parameter 'objectId' is set
            if (objectId == null) throw new ApiException(400, "Missing required parameter 'objectId' when calling DeleteObjectItem");
            
    
            var path = "/objects/{template_id}/{object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_id" + "}", ApiClient.ParameterToString(templateId));
path = path.Replace("{" + "object_id" + "}", ApiClient.ParameterToString(objectId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteObjectItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteObjectItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteObjectTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteObjectTemplate");
            
    
            var path = "/objects/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteObjectTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteObjectTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param> 
        /// <param name="objectId">The id of the object</param> 
        /// <returns>ObjectResource</returns>            
        public ObjectResource GetObjectItem (string templateId, int? objectId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetObjectItem");
            
            // verify the required parameter 'objectId' is set
            if (objectId == null) throw new ApiException(400, "Missing required parameter 'objectId' when calling GetObjectItem");
            
    
            var path = "/objects/{template_id}/{object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_id" + "}", ApiClient.ParameterToString(templateId));
path = path.Replace("{" + "object_id" + "}", ApiClient.ParameterToString(objectId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ObjectResource) ApiClient.Deserialize(response.Content, typeof(ObjectResource), response.Headers);
        }
    
        /// <summary>
        /// List and search objects 
        /// </summary>
        /// <param name="templateId">The id of the template to get objects for</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceObjectResource</returns>            
        public PageResourceObjectResource GetObjectItems (string templateId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetObjectItems");
            
    
            var path = "/objects/{template_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_id" + "}", ApiClient.ParameterToString(templateId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceObjectResource) ApiClient.Deserialize(response.Content, typeof(PageResourceObjectResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource GetObjectTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetObjectTemplate");
            
    
            var path = "/objects/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search entitlement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceItemTemplateResource</returns>            
        public PageResourceItemTemplateResource GetObjectTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/objects/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetObjectTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update an object 
        /// </summary>
        /// <param name="templateId">The id of the template this object is part of</param> 
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="objectItem">The object item object</param> 
        /// <returns></returns>            
        public void UpdateObjectItem (string templateId, int? entitlementId, bool? cascade, EntitlementItem objectItem)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateObjectItem");
            
            // verify the required parameter 'entitlementId' is set
            if (entitlementId == null) throw new ApiException(400, "Missing required parameter 'entitlementId' when calling UpdateObjectItem");
            
    
            var path = "/objects/{template_id}/{object_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_id" + "}", ApiClient.ParameterToString(templateId));
path = path.Replace("{" + "entitlement_id" + "}", ApiClient.ParameterToString(entitlementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(objectItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateObjectItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateObjectItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The updated template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource UpdateObjectTemplate (string id, ItemTemplateResource template)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateObjectTemplate");
            
    
            var path = "/objects/templates/{id}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateObjectTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateObjectTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
    }
}
