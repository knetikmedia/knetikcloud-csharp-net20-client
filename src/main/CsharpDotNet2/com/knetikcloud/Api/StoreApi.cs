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
    public interface IStoreApi
    {
        /// <summary>
        /// Create an item template Item Templates define a type of item and the properties they have.
        /// </summary>
        /// <param name="itemTemplateResource">The new item template</param>
        /// <returns>StoreItemTemplateResource</returns>
        StoreItemTemplateResource CreateItemTemplate (StoreItemTemplateResource itemTemplateResource);
        /// <summary>
        /// Create a store item SKUs have to be unique in the entire store. If a duplicate SKU is found, a 400 error is generated and the response will have a \&quot;parameters\&quot; field that is a list of duplicates. A duplicate is an object like {item_id, offending_sku_list}. Ex:&lt;br /&gt; {..., parameters: [[{item: 1, skus: [\&quot;SKU-1\&quot;]}]]}&lt;br /&gt; If an item is brand new and has duplicate SKUs within itself, the item ID will be 0.  Item subclasses are not allowed here, you will have to use their respective endpoints.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="storeItem">The store item object</param>
        /// <returns>StoreItem</returns>
        StoreItem CreateStoreItem (bool? cascade, StoreItem storeItem);
        /// <summary>
        /// Delete an item template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <returns></returns>
        void DeleteItemTemplate (string id, string cascade);
        /// <summary>
        /// Delete a store item 
        /// </summary>
        /// <param name="id">The id of the item</param>
        /// <returns></returns>
        void DeleteStoreItem (int? id);
        /// <summary>
        /// List available item behaviors 
        /// </summary>
        /// <returns>List&lt;BehaviorDefinitionResource&gt;</returns>
        List<BehaviorDefinitionResource> GetBehaviors ();
        /// <summary>
        /// Get a single item template Item Templates define a type of item and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>StoreItemTemplateResource</returns>
        StoreItemTemplateResource GetItemTemplate (string id);
        /// <summary>
        /// List and search item templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceStoreItemTemplateResource</returns>
        PageResourceStoreItemTemplateResource GetItemTemplates (int? size, int? page, string order);
        /// <summary>
        /// Get a single store item 
        /// </summary>
        /// <param name="id">The id of the item</param>
        /// <returns>StoreItem</returns>
        StoreItem GetStoreItem (int? id);
        /// <summary>
        /// List and search store items If called without permission STORE_ADMIN the only items marked displayable, whose start and end date are null or appropriate to the current date, and whose geo policy allows the caller&#39;s country will be returned. Similarly skus will be filtered, possibly resulting in an item returned with no skus the user can purchase.
        /// </summary>
        /// <param name="filterNameSearch">Filter for items whose name starts with a given string.</param>
        /// <param name="filterUniqueKey">Filter for items whose unique_key is a given string.</param>
        /// <param name="filterPublished">Filter for skus that have been published.</param>
        /// <param name="filterDisplayable">Filter for items that are displayable.</param>
        /// <param name="filterStart">A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterEnd">A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterStopDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterSku">Filter for skus whose name starts with a given string.</param>
        /// <param name="filterPrice">A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param>
        /// <param name="filterTag">A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags.</param>
        /// <param name="filterItemsByType">Filter for item type based on its type hint.</param>
        /// <param name="filterBundledSkus">Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is &#39;bundle_item&#39;</param>
        /// <param name="filterVendor">Filter for items from a given vendor, by id.</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceStoreItem</returns>
        PageResourceStoreItem GetStoreItems (string filterNameSearch, string filterUniqueKey, bool? filterPublished, bool? filterDisplayable, string filterStart, string filterEnd, string filterStartDate, string filterStopDate, string filterSku, string filterPrice, string filterTag, string filterItemsByType, string filterBundledSkus, int? filterVendor, int? size, int? page, string order);
        /// <summary>
        /// One-step purchase and pay for a single SKU item from a user&#39;s wallet Used to create and automatically pay an invoice for a single unit of a single SKU from a user&#39;s wallet. SKU must be priced in virtual currency and must not be an item that requires shipping. PAYMENTS_ADMIN permission is required if user ID is specified and is not the ID of the currently logged in user. If invoice price does not match expected price, purchase is aborted
        /// </summary>
        /// <param name="quickBuyRequest">Quick buy details</param>
        /// <returns>InvoiceResource</returns>
        InvoiceResource QuickBuy (QuickBuyRequest quickBuyRequest);
        /// <summary>
        /// Update an item template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="itemTemplateResource">The item template resource object</param>
        /// <returns>StoreItemTemplateResource</returns>
        StoreItemTemplateResource UpdateItemTemplate (string id, StoreItemTemplateResource itemTemplateResource);
        /// <summary>
        /// Update a store item 
        /// </summary>
        /// <param name="id">The id of the item</param>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param>
        /// <param name="storeItem">The store item object</param>
        /// <returns>StoreItem</returns>
        StoreItem UpdateStoreItem (int? id, bool? cascade, StoreItem storeItem);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreApi : IStoreApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreApi(String basePath)
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
        /// Create an item template Item Templates define a type of item and the properties they have.
        /// </summary>
        /// <param name="itemTemplateResource">The new item template</param> 
        /// <returns>StoreItemTemplateResource</returns>            
        public StoreItemTemplateResource CreateItemTemplate (StoreItemTemplateResource itemTemplateResource)
        {
            
    
            var path = "/store/items/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(itemTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateItemTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateItemTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(StoreItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Create a store item SKUs have to be unique in the entire store. If a duplicate SKU is found, a 400 error is generated and the response will have a \&quot;parameters\&quot; field that is a list of duplicates. A duplicate is an object like {item_id, offending_sku_list}. Ex:&lt;br /&gt; {..., parameters: [[{item: 1, skus: [\&quot;SKU-1\&quot;]}]]}&lt;br /&gt; If an item is brand new and has duplicate SKUs within itself, the item ID will be 0.  Item subclasses are not allowed here, you will have to use their respective endpoints.
        /// </summary>
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="storeItem">The store item object</param> 
        /// <returns>StoreItem</returns>            
        public StoreItem CreateStoreItem (bool? cascade, StoreItem storeItem)
        {
            
    
            var path = "/store/items";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(storeItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStoreItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStoreItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItem) ApiClient.Deserialize(response.Content, typeof(StoreItem), response.Headers);
        }
    
        /// <summary>
        /// Delete an item template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param> 
        /// <returns></returns>            
        public void DeleteItemTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteItemTemplate");
            
    
            var path = "/store/items/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteItemTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteItemTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a store item 
        /// </summary>
        /// <param name="id">The id of the item</param> 
        /// <returns></returns>            
        public void DeleteStoreItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteStoreItem");
            
    
            var path = "/store/items/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteStoreItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteStoreItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List available item behaviors 
        /// </summary>
        /// <returns>List&lt;BehaviorDefinitionResource&gt;</returns>            
        public List<BehaviorDefinitionResource> GetBehaviors ()
        {
            
    
            var path = "/store/items/behaviors";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBehaviors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBehaviors: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BehaviorDefinitionResource>) ApiClient.Deserialize(response.Content, typeof(List<BehaviorDefinitionResource>), response.Headers);
        }
    
        /// <summary>
        /// Get a single item template Item Templates define a type of item and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>StoreItemTemplateResource</returns>            
        public StoreItemTemplateResource GetItemTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetItemTemplate");
            
    
            var path = "/store/items/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(StoreItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search item templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceStoreItemTemplateResource</returns>            
        public PageResourceStoreItemTemplateResource GetItemTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/store/items/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceStoreItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceStoreItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single store item 
        /// </summary>
        /// <param name="id">The id of the item</param> 
        /// <returns>StoreItem</returns>            
        public StoreItem GetStoreItem (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetStoreItem");
            
    
            var path = "/store/items/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoreItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoreItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItem) ApiClient.Deserialize(response.Content, typeof(StoreItem), response.Headers);
        }
    
        /// <summary>
        /// List and search store items If called without permission STORE_ADMIN the only items marked displayable, whose start and end date are null or appropriate to the current date, and whose geo policy allows the caller&#39;s country will be returned. Similarly skus will be filtered, possibly resulting in an item returned with no skus the user can purchase.
        /// </summary>
        /// <param name="filterNameSearch">Filter for items whose name starts with a given string.</param> 
        /// <param name="filterUniqueKey">Filter for items whose unique_key is a given string.</param> 
        /// <param name="filterPublished">Filter for skus that have been published.</param> 
        /// <param name="filterDisplayable">Filter for items that are displayable.</param> 
        /// <param name="filterStart">A comma separated string without spaces.  First value is the operator to search on, second value is the store start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param> 
        /// <param name="filterEnd">A comma separated string without spaces.  First value is the operator to search on, second value is the store end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param> 
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku start date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param> 
        /// <param name="filterStopDate">A comma separated string without spaces.  First value is the operator to search on, second value is the sku end date, a unix timestamp in seconds.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param> 
        /// <param name="filterSku">Filter for skus whose name starts with a given string.</param> 
        /// <param name="filterPrice">A colon separated string without spaces.  First value is the operator to search on, second value is the price of a sku.  Allowed operators: (LT, GT, LTE, GTE, EQ).</param> 
        /// <param name="filterTag">A comma separated list without spaces of the names of tags. Will only return items with at least one of the tags.</param> 
        /// <param name="filterItemsByType">Filter for item type based on its type hint.</param> 
        /// <param name="filterBundledSkus">Filter for skus inside bundles whose name starts with a given string.  Used only when type hint is &#39;bundle_item&#39;</param> 
        /// <param name="filterVendor">Filter for items from a given vendor, by id.</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceStoreItem</returns>            
        public PageResourceStoreItem GetStoreItems (string filterNameSearch, string filterUniqueKey, bool? filterPublished, bool? filterDisplayable, string filterStart, string filterEnd, string filterStartDate, string filterStopDate, string filterSku, string filterPrice, string filterTag, string filterItemsByType, string filterBundledSkus, int? filterVendor, int? size, int? page, string order)
        {
            
    
            var path = "/store/items";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterNameSearch != null) queryParams.Add("filter_name_search", ApiClient.ParameterToString(filterNameSearch)); // query parameter
 if (filterUniqueKey != null) queryParams.Add("filter_unique_key", ApiClient.ParameterToString(filterUniqueKey)); // query parameter
 if (filterPublished != null) queryParams.Add("filter_published", ApiClient.ParameterToString(filterPublished)); // query parameter
 if (filterDisplayable != null) queryParams.Add("filter_displayable", ApiClient.ParameterToString(filterDisplayable)); // query parameter
 if (filterStart != null) queryParams.Add("filter_start", ApiClient.ParameterToString(filterStart)); // query parameter
 if (filterEnd != null) queryParams.Add("filter_end", ApiClient.ParameterToString(filterEnd)); // query parameter
 if (filterStartDate != null) queryParams.Add("filter_start_date", ApiClient.ParameterToString(filterStartDate)); // query parameter
 if (filterStopDate != null) queryParams.Add("filter_stop_date", ApiClient.ParameterToString(filterStopDate)); // query parameter
 if (filterSku != null) queryParams.Add("filter_sku", ApiClient.ParameterToString(filterSku)); // query parameter
 if (filterPrice != null) queryParams.Add("filter_price", ApiClient.ParameterToString(filterPrice)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (filterItemsByType != null) queryParams.Add("filter_items_by_type", ApiClient.ParameterToString(filterItemsByType)); // query parameter
 if (filterBundledSkus != null) queryParams.Add("filter_bundled_skus", ApiClient.ParameterToString(filterBundledSkus)); // query parameter
 if (filterVendor != null) queryParams.Add("filter_vendor", ApiClient.ParameterToString(filterVendor)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoreItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStoreItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceStoreItem) ApiClient.Deserialize(response.Content, typeof(PageResourceStoreItem), response.Headers);
        }
    
        /// <summary>
        /// One-step purchase and pay for a single SKU item from a user&#39;s wallet Used to create and automatically pay an invoice for a single unit of a single SKU from a user&#39;s wallet. SKU must be priced in virtual currency and must not be an item that requires shipping. PAYMENTS_ADMIN permission is required if user ID is specified and is not the ID of the currently logged in user. If invoice price does not match expected price, purchase is aborted
        /// </summary>
        /// <param name="quickBuyRequest">Quick buy details</param> 
        /// <returns>InvoiceResource</returns>            
        public InvoiceResource QuickBuy (QuickBuyRequest quickBuyRequest)
        {
            
    
            var path = "/store/quick-buy";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(quickBuyRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickBuy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QuickBuy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceResource) ApiClient.Deserialize(response.Content, typeof(InvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// Update an item template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="itemTemplateResource">The item template resource object</param> 
        /// <returns>StoreItemTemplateResource</returns>            
        public StoreItemTemplateResource UpdateItemTemplate (string id, StoreItemTemplateResource itemTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateItemTemplate");
            
    
            var path = "/store/items/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(itemTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateItemTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateItemTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(StoreItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Update a store item 
        /// </summary>
        /// <param name="id">The id of the item</param> 
        /// <param name="cascade">Whether to cascade group changes, such as in the limited gettable behavior. A 400 error will return otherwise if the group is already in use with different values.</param> 
        /// <param name="storeItem">The store item object</param> 
        /// <returns>StoreItem</returns>            
        public StoreItem UpdateStoreItem (int? id, bool? cascade, StoreItem storeItem)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateStoreItem");
            
    
            var path = "/store/items/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                    postBody = ApiClient.Serialize(storeItem); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStoreItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStoreItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StoreItem) ApiClient.Deserialize(response.Content, typeof(StoreItem), response.Headers);
        }
    
    }
}
