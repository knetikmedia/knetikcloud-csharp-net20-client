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
        /// Adds an item to the user inventory The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <param name="userInventoryAddRequest">The user inventory add request object</param>
        /// <returns>InvoiceResource</returns>
        InvoiceResource AddItemToUserInventory (int? id, UserInventoryAddRequest userInventoryAddRequest);
        /// <summary>
        /// Check for access to an item without consuming Useful for pre-check and accounts for all various buisness rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the user to check for or &#39;me&#39; for logged in user</param>
        /// <param name="itemId">The id of the item</param>
        /// <param name="sku">The specific sku of an entitlement list addition to check entitlement for. This is of very limited and specific use and should generally be left out</param>
        /// <returns></returns>
        void CheckUserEntitlementItem (string userId, int? itemId, string sku);
        /// <summary>
        /// Create an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <returns>EntitlementItem</returns>
        EntitlementItem CreateEntitlementItem (bool? cascade, EntitlementItem entitlementItem);
        /// <summary>
        /// Create an entitlement template Entitlement templates define a type of entitlement and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="template">The entitlement template to be created</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource CreateEntitlementTemplate (ItemTemplateResource template);
        /// <summary>
        /// Delete an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <returns></returns>
        void DeleteEntitlementItem (int? entitlementId);
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteEntitlementTemplate (string id, string cascade);
        /// <summary>
        /// Get a single entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <returns>EntitlementItem</returns>
        EntitlementItem GetEntitlementItem (int? entitlementId);
        /// <summary>
        /// List and search entitlement items &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterTemplate">Filter for entitlements using a specified template</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceEntitlementItem</returns>
        PageResourceEntitlementItem GetEntitlementItems (string filterTemplate, int? size, int? page, string order);
        /// <summary>
        /// Get a single entitlement template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACHIEVEMENTS_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource GetEntitlementTemplate (string id);
        /// <summary>
        /// List and search entitlement templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACHIEVEMENTS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceItemTemplateResource</returns>
        PageResourceItemTemplateResource GetEntitlementTemplates (int? size, int? page, string order);
        /// <summary>
        /// List the user inventory entries for a given user &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
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
        /// <returns>PageResourceUserInventoryResource</returns>
        PageResourceUserInventoryResource GetUserInventories (int? id, bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate);
        /// <summary>
        /// Get an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <returns>UserInventoryResource</returns>
        UserInventoryResource GetUserInventory (string userId, int? id);
        /// <summary>
        /// List the log entries for this inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUserItemLogResource</returns>
        PageResourceUserItemLogResource GetUserInventoryLog (string userId, int? id, int? size, int? page);
        /// <summary>
        /// List the user inventory entries for all users &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="inactive">If true, accepts inactive user inventories</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="filterItemName">Filter by items whose name starts with a string</param>
        /// <param name="filterItemId">Filter by item id</param>
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param>
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param>
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <returns>PageResourceUserInventoryResource</returns>
        PageResourceUserInventoryResource GetUsersInventory (bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate);
        /// <summary>
        /// Grant an entitlement &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the user to grant the entitlement to</param>
        /// <param name="grantRequest">grantRequest</param>
        /// <returns></returns>
        void GrantUserEntitlement (int? userId, EntitlementGrantRequest grantRequest);
        /// <summary>
        /// Update an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="entitlementItem">The entitlement item object</param>
        /// <returns></returns>
        void UpdateEntitlementItem (int? entitlementId, bool? cascade, EntitlementItem entitlementItem);
        /// <summary>
        /// Update an entitlement template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource UpdateEntitlementTemplate (string id, ItemTemplateResource template);
        /// <summary>
        /// Set the behavior data for an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="data">The data map</param>
        /// <returns></returns>
        void UpdateUserInventoryBehaviorData (int? userId, int? id, Object data);
        /// <summary>
        /// Set the expiration date Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill). &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">user_id</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="timestamp">The new expiration date as a unix timestamp in seconds. May be null (no body).</param>
        /// <returns></returns>
        void UpdateUserInventoryExpires (int? userId, int? id, long? timestamp);
        /// <summary>
        /// Set the status for an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="id">The id of the user inventory</param>
        /// <param name="inventoryStatus">The inventory status object</param>
        /// <returns></returns>
        void UpdateUserInventoryStatus (int? userId, int? id, string inventoryStatus);
        /// <summary>
        /// Use an item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
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
        /// Adds an item to the user inventory The inventory is fulfilled asynchronously UNLESS the invoice is explicitely skipped. Depending on the use case, it might require the client to verify that the entitlement was added after the fact or configure a BRE rule to get a notification in real time. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="id">The id of the user</param> 
        /// <param name="userInventoryAddRequest">The user inventory add request object</param> 
        /// <returns>InvoiceResource</returns>            
        public InvoiceResource AddItemToUserInventory (int? id, UserInventoryAddRequest userInventoryAddRequest)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToUserInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToUserInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceResource) ApiClient.Deserialize(response.Content, typeof(InvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// Check for access to an item without consuming Useful for pre-check and accounts for all various buisness rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckUserEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckUserEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="entitlementItem">The entitlement item object</param> 
        /// <returns>EntitlementItem</returns>            
        public EntitlementItem CreateEntitlementItem (bool? cascade, EntitlementItem entitlementItem)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EntitlementItem) ApiClient.Deserialize(response.Content, typeof(EntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// Create an entitlement template Entitlement templates define a type of entitlement and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="template">The entitlement template to be created</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource CreateEntitlementTemplate (ItemTemplateResource template)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an entitlement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <returns>EntitlementItem</returns>            
        public EntitlementItem GetEntitlementItem (int? entitlementId)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EntitlementItem) ApiClient.Deserialize(response.Content, typeof(EntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// List and search entitlement items &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterTemplate">Filter for entitlements using a specified template</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceEntitlementItem</returns>            
        public PageResourceEntitlementItem GetEntitlementItems (string filterTemplate, int? size, int? page, string order)
        {
            
    
            var path = "/entitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTemplate != null) queryParams.Add("filter_template", ApiClient.ParameterToString(filterTemplate)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceEntitlementItem) ApiClient.Deserialize(response.Content, typeof(PageResourceEntitlementItem), response.Headers);
        }
    
        /// <summary>
        /// Get a single entitlement template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACHIEVEMENTS_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource GetEntitlementTemplate (string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search entitlement templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACHIEVEMENTS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceItemTemplateResource</returns>            
        public PageResourceItemTemplateResource GetEntitlementTemplates (int? size, int? page, string order)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEntitlementTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List the user inventory entries for a given user &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
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
        /// <returns>PageResourceUserInventoryResource</returns>            
        public PageResourceUserInventoryResource GetUserInventories (int? id, bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserInventoryResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// Get an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <returns>UserInventoryResource</returns>            
        public UserInventoryResource GetUserInventory (string userId, int? id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserInventoryResource) ApiClient.Deserialize(response.Content, typeof(UserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// List the log entries for this inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
        /// </summary>
        /// <param name="userId">The id of the inventory owner or &#39;me&#39; for the logged in user</param> 
        /// <param name="id">The id of the user inventory</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUserItemLogResource</returns>            
        public PageResourceUserItemLogResource GetUserInventoryLog (string userId, int? id, int? size, int? page)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventoryLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInventoryLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserItemLogResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserItemLogResource), response.Headers);
        }
    
        /// <summary>
        /// List the user inventory entries for all users &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="inactive">If true, accepts inactive user inventories</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="filterItemName">Filter by items whose name starts with a string</param> 
        /// <param name="filterItemId">Filter by item id</param> 
        /// <param name="filterUsername">Filter by entries owned by the user with the specified username</param> 
        /// <param name="filterGroup">Filter by entries owned by the users in a given group, by unique name</param> 
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <returns>PageResourceUserInventoryResource</returns>            
        public PageResourceUserInventoryResource GetUsersInventory (bool? inactive, int? size, int? page, string filterItemName, int? filterItemId, string filterUsername, string filterGroup, string filterDate)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersInventory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersInventory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserInventoryResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserInventoryResource), response.Headers);
        }
    
        /// <summary>
        /// Grant an entitlement &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="userId">The id of the user to grant the entitlement to</param> 
        /// <param name="grantRequest">grantRequest</param> 
        /// <returns></returns>            
        public void GrantUserEntitlement (int? userId, EntitlementGrantRequest grantRequest)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GrantUserEntitlement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GrantUserEntitlement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an entitlement item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
        /// </summary>
        /// <param name="entitlementId">The id of the entitlement</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="entitlementItem">The entitlement item object</param> 
        /// <returns></returns>            
        public void UpdateEntitlementItem (int? entitlementId, bool? cascade, EntitlementItem entitlementItem)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an entitlement template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The updated template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource UpdateEntitlementTemplate (string id, ItemTemplateResource template)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEntitlementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Set the behavior data for an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryBehaviorData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryBehaviorData: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the expiration date Will change the current grace period for a subscription but not the bill date (possibly even ending before having the chance to re-bill). &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryExpires: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryExpires: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the status for an inventory entry &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserInventoryStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Use an item &lt;b&gt;Permissions Needed:&lt;/b&gt; INVENTORY_ADMIN or owner
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
