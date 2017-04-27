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
    public interface IUsersInventoryApi
    {
        /// <summary>
        /// Adds an item to the user inventory The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <param name="userInventoryAddRequest">The user inventory add request object</param>
        /// <returns>ModelInvoiceResource</returns>
        ModelInvoiceResource AddItemToUserInventory (int? id, ModelUserInventoryAddRequest userInventoryAddRequest);
        /// <summary>
        /// Check for access to an item without consuming Useful for pre-check and accounts for all various buisness rules
        /// </summary>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param>
        /// <param name="itemId">The id of the item</param>
        /// <param name="sku">The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param>
        /// <returns></returns>
        void CheckUserEntitlementItem (string userId, int? itemId, string sku);
        /// <summary>
        /// Create an entitlement item 
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <returns>ModelEntitlementItem</returns>
        ModelEntitlementItem CreateEntitlementItem (bool? cascade, ModelEntitlementItem entitlementItem);
        /// <summary>
        /// Create an entitlement template Entitlement templates define a type of entitlement and the properties they have
        /// </summary>
        /// <param name="template">The entitlement template to be created</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource CreateEntitlementTemplate (ModelItemTemplateResource template);
        /// <summary>
        /// Delete an entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <returns></returns>
        void DeleteEntitlementItem (int? entitlementId);
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteEntitlementTemplate (string id, string cascade);
        /// <summary>
        /// Get a single entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <returns>ModelEntitlementItem</returns>
        ModelEntitlementItem GetEntitlementItem (int? entitlementId);
        /// <summary>
        /// List and search entitlement items 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceEntitlementItem</returns>
        ModelPageResourceEntitlementItem GetEntitlementItems (int? size, int? page, string order);
        /// <summary>
        /// Get a single entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource GetEntitlementTemplate (string id);
        /// <summary>
        /// List and search entitlement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceItemTemplateResource</returns>
        ModelPageResourceItemTemplateResource GetEntitlementTemplates (int? size, int? page, string order);
        /// <summary>
        /// List the user inventory entries for a given user 
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <param name="inactive">If true, accepts inactive user inventories</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="filterItemName">Filter by items whose name starts with a string</param>
        /// <param name="filterItemId">Filter by item id</param>
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param>
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param>
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <returns>ModelPageResourceUserInventoryResource</returns>
        ModelPageResourceUserInventoryResource GetUserInventories (int? id, bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate);
        /// <summary>
        /// Get an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <returns>ModelUserInventoryResource</returns>
        ModelUserInventoryResource GetUserInventory (int? userId, int? id);
        /// <summary>
        /// List the log entries for this inventory entry 
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>ModelPageResourceUserItemLogResource</returns>
        ModelPageResourceUserItemLogResource GetUserInventoryLog (string userId, int? id, int? size, int? page);
        /// <summary>
        /// List the user inventory entries for all users 
        /// </summary>
        /// <param name="inactive">If true, accepts inactive user inventories</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="filterItemName">Filter by items whose name starts with a string</param>
        /// <param name="filterItemId">Filter by item id</param>
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param>
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param>
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <returns>ModelPageResourceUserInventoryResource</returns>
        ModelPageResourceUserInventoryResource GetUsersInventory (bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate);
        /// <summary>
        /// Grant an entitlement 
        /// </summary>
        /// <param name="userId">The id of the user to grant the entitlement to</param>
        /// <param name="grantRequest">grantRequest</param>
        /// <returns></returns>
        void GrantUserEntitlement (int? userId, ModelEntitlementGrantRequest grantRequest);
        /// <summary>
        /// Update an entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <returns></returns>
        void UpdateEntitlementItem (int? entitlementId, bool? cascade, ModelEntitlementItem entitlementItem);
        /// <summary>
        /// Update an entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <returns>ModelItemTemplateResource</returns>
        ModelItemTemplateResource UpdateEntitlementTemplate (string id, ModelItemTemplateResource template);
        /// <summary>
        /// Set the behavior data for an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="data">The data map</param>
        /// <returns></returns>
        void UpdateUserInventoryBehaviorData (int? userId, int? id, Object data);
        /// <summary>
        /// Set the expiration date Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill)
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="timestamp">The new expiration date as a unix timestamp in seconds. May be null (no body).</param>
        /// <returns></returns>
        void UpdateUserInventoryExpires (int? userId, int? id, long? timestamp);
        /// <summary>
        /// Set the status for an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="inventoryStatus">The inventory status object</param>
        /// <returns></returns>
        void UpdateUserInventoryStatus (int? userId, int? id, string inventoryStatus);
        /// <summary>
        /// Use an item 
        /// </summary>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param>
        /// <param name="itemId">The id of the item</param>
        /// <param name="sku">The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param>
        /// <param name="info">Any additional info to add to the log about this use</param>
        /// <returns></returns>
        void UseUserEntitlementItem (string userId, int? itemId, string sku, string info);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersInventoryApi : IUsersInventoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersInventoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersInventoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersInventoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersInventoryApi(String basePath)
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
        /// Adds an item to the user inventory The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <param name="userInventoryAddRequest">The user inventory add request object</param> 
        /// <returns>ModelInvoiceResource</returns>            
        public ModelInvoiceResource AddItemToUserInventory (int? id, ModelUserInventoryAddRequest userInventoryAddRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddItemToUserInventory");
            
    
            var path = "/users/{id}/inventory";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userInventoryAddRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToUserInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToUserInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelInvoiceResource) ApiClient.Deserialize(response.Content, typeof(ModelInvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// Check for access to an item without consuming Useful for pre-check and accounts for all various buisness rules
        /// </summary>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param> 
        /// <param name="itemId">The id of the item</param> 
        /// <param name="sku">The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param> 
        /// <returns></returns>            
        public void CheckUserEntitlementItem (string userId, int? itemId, string sku)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling CheckUserEntitlementItem");
            
            // verify the required parameter 'itemId' is set
            if (itemId == null) throw new ApiException(400, "Missing required parameter 'itemId' when calling CheckUserEntitlementItem");
            
    
            var path = "/users/{user_id}/entitlements/{item_id}/check";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "item_id" + "}", ApiClient.ParameterToString(itemId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sku != null) queryParams.Add("sku", ApiClient.ParameterToString(sku)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckUserEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckUserEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an entitlement item 
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="entitlementItem">The entitlement item object</param> 
        /// <returns>ModelEntitlementItem</returns>            
        public ModelEntitlementItem CreateEntitlementItem (bool? cascade, ModelEntitlementItem entitlementItem)
        {
            
    
            var path = "/entitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(entitlementItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEntitlementItem) ApiClient.Deserialize(response.Content, typeof(ModelEntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// Create an entitlement template Entitlement templates define a type of entitlement and the properties they have
        /// </summary>
        /// <param name="template">The entitlement template to be created</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource CreateEntitlementTemplate (ModelItemTemplateResource template)
        {
            
    
            var path = "/entitlements/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <returns></returns>            
        public void DeleteEntitlementItem (int? entitlementId)
        {
            
            // verify the required parameter 'entitlementId' is set
            if (entitlementId == null) throw new ApiException(400, "Missing required parameter 'entitlementId' when calling DeleteEntitlementItem");
            
    
            var path = "/entitlements/{entitlement_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "entitlement_id" + "}", ApiClient.ParameterToString(entitlementId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteEntitlementTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteEntitlementTemplate");
            
    
            var path = "/entitlements/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <returns>ModelEntitlementItem</returns>            
        public ModelEntitlementItem GetEntitlementItem (int? entitlementId)
        {
            
            // verify the required parameter 'entitlementId' is set
            if (entitlementId == null) throw new ApiException(400, "Missing required parameter 'entitlementId' when calling GetEntitlementItem");
            
    
            var path = "/entitlements/{entitlement_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "entitlement_id" + "}", ApiClient.ParameterToString(entitlementId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEntitlementItem) ApiClient.Deserialize(response.Content, typeof(ModelEntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// List and search entitlement items 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceEntitlementItem</returns>            
        public ModelPageResourceEntitlementItem GetEntitlementItems (int? size, int? page, string order)
        {
            
    
            var path = "/entitlements";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceEntitlementItem) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceEntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// Get a single entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource GetEntitlementTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEntitlementTemplate");
            
    
            var path = "/entitlements/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search entitlement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceItemTemplateResource</returns>            
        public ModelPageResourceItemTemplateResource GetEntitlementTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/entitlements/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List the user inventory entries for a given user 
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <param name="inactive">If true, accepts inactive user inventories</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="filterItemName">Filter by items whose name starts with a string</param> 
        /// <param name="filterItemId">Filter by item id</param> 
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param> 
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param> 
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <returns>ModelPageResourceUserInventoryResource</returns>            
        public ModelPageResourceUserInventoryResource GetUserInventories (int? id, bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserInventories");
            
    
            var path = "/users/{id}/inventory";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inactive != null) queryParams.Add("inactive", ApiClient.ParameterToString(inactive)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (filterItemName != null) queryParams.Add("filter_item_name", ApiClient.ParameterToString(filterItemName)); // query parameter
 if (filterItemId != null) queryParams.Add("filter_item_id", ApiClient.ParameterToString(filterItemId)); // query parameter
 if (filterUsername != null) queryParams.Add("filter_username", ApiClient.ParameterToString(filterUsername)); // query parameter
 if (filterGroup != null) queryParams.Add("filter_group", ApiClient.ParameterToString(filterGroup)); // query parameter
 if (filterDate != null) queryParams.Add("filter_date", ApiClient.ParameterToString(filterDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceUserInventoryResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceUserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// Get an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <returns>ModelUserInventoryResource</returns>            
        public ModelUserInventoryResource GetUserInventory (int? userId, int? id)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserInventory");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserInventory");
            
    
            var path = "/users/{user_id}/inventory/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelUserInventoryResource) ApiClient.Deserialize(response.Content, typeof(ModelUserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// List the log entries for this inventory entry 
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>ModelPageResourceUserItemLogResource</returns>            
        public ModelPageResourceUserItemLogResource GetUserInventoryLog (string userId, int? id, int? size, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserInventoryLog");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserInventoryLog");
            
    
            var path = "/users/{user_id}/inventory/{id}/log";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventoryLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventoryLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceUserItemLogResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceUserItemLogResource), response.Headers);
        }
    
        /// <summary>
        /// List the user inventory entries for all users 
        /// </summary>
        /// <param name="inactive">If true, accepts inactive user inventories</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="filterItemName">Filter by items whose name starts with a string</param> 
        /// <param name="filterItemId">Filter by item id</param> 
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param> 
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param> 
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <returns>ModelPageResourceUserInventoryResource</returns>            
        public ModelPageResourceUserInventoryResource GetUsersInventory (bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)
        {
            
    
            var path = "/inventories";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inactive != null) queryParams.Add("inactive", ApiClient.ParameterToString(inactive)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (filterItemName != null) queryParams.Add("filter_item_name", ApiClient.ParameterToString(filterItemName)); // query parameter
 if (filterItemId != null) queryParams.Add("filter_item_id", ApiClient.ParameterToString(filterItemId)); // query parameter
 if (filterUsername != null) queryParams.Add("filter_username", ApiClient.ParameterToString(filterUsername)); // query parameter
 if (filterGroup != null) queryParams.Add("filter_group", ApiClient.ParameterToString(filterGroup)); // query parameter
 if (filterDate != null) queryParams.Add("filter_date", ApiClient.ParameterToString(filterDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceUserInventoryResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceUserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// Grant an entitlement 
        /// </summary>
        /// <param name="userId">The id of the user to grant the entitlement to</param> 
        /// <param name="grantRequest">grantRequest</param> 
        /// <returns></returns>            
        public void GrantUserEntitlement (int? userId, ModelEntitlementGrantRequest grantRequest)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GrantUserEntitlement");
            
            // verify the required parameter 'grantRequest' is set
            if (grantRequest == null) throw new ApiException(400, "Missing required parameter 'grantRequest' when calling GrantUserEntitlement");
            
    
            var path = "/users/{user_id}/entitlements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(grantRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GrantUserEntitlement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GrantUserEntitlement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an entitlement item 
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="entitlementItem">The entitlement item object</param> 
        /// <returns></returns>            
        public void UpdateEntitlementItem (int? entitlementId, bool? cascade, ModelEntitlementItem entitlementItem)
        {
            
            // verify the required parameter 'entitlementId' is set
            if (entitlementId == null) throw new ApiException(400, "Missing required parameter 'entitlementId' when calling UpdateEntitlementItem");
            
    
            var path = "/entitlements/{entitlement_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "entitlement_id" + "}", ApiClient.ParameterToString(entitlementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(entitlementItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an entitlement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The updated template</param> 
        /// <returns>ModelItemTemplateResource</returns>            
        public ModelItemTemplateResource UpdateEntitlementTemplate (string id, ModelItemTemplateResource template)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateEntitlementTemplate");
            
    
            var path = "/entitlements/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Set the behavior data for an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <param name="data">The data map</param> 
        /// <returns></returns>            
        public void UpdateUserInventoryBehaviorData (int? userId, int? id, Object data)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserInventoryBehaviorData");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUserInventoryBehaviorData");
            
    
            var path = "/users/{user_id}/inventory/{id}/behavior-data";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(data); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryBehaviorData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryBehaviorData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the expiration date Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill)
        /// </summary>
        /// <param name="userId">user_id</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <param name="timestamp">The new expiration date as a unix timestamp in seconds. May be null (no body).</param> 
        /// <returns></returns>            
        public void UpdateUserInventoryExpires (int? userId, int? id, long? timestamp)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserInventoryExpires");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUserInventoryExpires");
            
    
            var path = "/users/{user_id}/inventory/{id}/expires";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(timestamp); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryExpires: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryExpires: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the status for an inventory entry 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <param name="inventoryStatus">The inventory status object</param> 
        /// <returns></returns>            
        public void UpdateUserInventoryStatus (int? userId, int? id, string inventoryStatus)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUserInventoryStatus");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUserInventoryStatus");
            
    
            var path = "/users/{user_id}/inventory/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(inventoryStatus); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Use an item 
        /// </summary>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param> 
        /// <param name="itemId">The id of the item</param> 
        /// <param name="sku">The specific sku of an entitlement_list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param> 
        /// <param name="info">Any additional info to add to the log about this use</param> 
        /// <returns></returns>            
        public void UseUserEntitlementItem (string userId, int? itemId, string sku, string info)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UseUserEntitlementItem");
            
            // verify the required parameter 'itemId' is set
            if (itemId == null) throw new ApiException(400, "Missing required parameter 'itemId' when calling UseUserEntitlementItem");
            
    
            var path = "/users/{user_id}/entitlements/{item_id}/use";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "item_id" + "}", ApiClient.ParameterToString(itemId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sku != null) queryParams.Add("sku", ApiClient.ParameterToString(sku)); // query parameter
 if (info != null) queryParams.Add("info", ApiClient.ParameterToString(info)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UseUserEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UseUserEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
