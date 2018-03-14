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
    public interface IStore_Shopping_CartsApi
    {
        /// <summary>
        /// Adds a custom discount to the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="customDiscount">The details of the discount to add</param>
        /// <returns></returns>
        void AddCustomDiscount (string id, CouponDefinition customDiscount);
        /// <summary>
        /// Adds a discount coupon to the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="skuRequest">The request of the sku</param>
        /// <returns></returns>
        void AddDiscountToCart (string id, SkuRequest skuRequest);
        /// <summary>
        /// Add an item to the cart Currently, carts cannot contain virtual and real currency items at the same time. Furthermore, the API only support a single virtual item at the moment. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="cartItemRequest">The cart item request object</param>
        /// <returns></returns>
        void AddItemToCart (string id, CartItemRequest cartItemRequest);
        /// <summary>
        /// Create a cart You don&#39;t have to have a user to create a cart but the API requires authentication to checkout. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="owner">Set the owner of a cart. If not specified, defaults to the calling user&#39;s id. If specified and is not the calling user&#39;s id, SHOPPING_CARTS_ADMIN permission is required</param>
        /// <param name="currencyCode">Set the currency for the cart, by currency code. May be disallowed by site settings.</param>
        /// <returns>string</returns>
        string CreateCart (int? owner, string currencyCode);
        /// <summary>
        /// Returns the cart with the given GUID &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <returns>Cart</returns>
        Cart GetCart (string id);
        /// <summary>
        /// Get a list of carts &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="filterOwnerId">Filter by the id of the owner</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceCartSummary</returns>
        PageResourceCartSummary GetCarts (int? filterOwnerId, int? size, int? page, string order);
        /// <summary>
        /// Returns whether a cart requires shipping &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <returns>CartShippableResponse</returns>
        CartShippableResponse GetShippable (string id);
        /// <summary>
        /// Get the list of available shipping countries per vendor Since a cart can have multiple vendors with different shipping options, the countries are broken down by vendors. Please see notes about the response object as the fields are variable. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <returns>SampleCountriesResponse</returns>
        SampleCountriesResponse GetShippingCountries (string id);
        /// <summary>
        /// Removes a discount coupon from the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="code">The SKU code of the coupon to remove</param>
        /// <returns></returns>
        void RemoveDiscountFromCart (string id, string code);
        /// <summary>
        /// Sets the currency to use for the cart May be disallowed by site settings. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="currencyCode">The code of the currency</param>
        /// <returns></returns>
        void SetCartCurrency (string id, StringWrapper currencyCode);
        /// <summary>
        /// Sets the owner of a cart if none is set already &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="userId">The id of the user</param>
        /// <returns></returns>
        void SetCartOwner (string id, IntWrapper userId);
        /// <summary>
        /// Changes the quantity of an item already in the cart A quantity of zero will remove the item from the cart altogether. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="cartItemRequest">The cart item request object</param>
        /// <returns></returns>
        void UpdateItemInCart (string id, CartItemRequest cartItemRequest);
        /// <summary>
        /// Modifies or sets the order shipping address &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param>
        /// <param name="cartShippingAddressRequest">The cart shipping address request object</param>
        /// <returns></returns>
        void UpdateShippingAddress (string id, CartShippingAddressRequest cartShippingAddressRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Store_Shopping_CartsApi : IStore_Shopping_CartsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store_Shopping_CartsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Store_Shopping_CartsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Store_Shopping_CartsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Store_Shopping_CartsApi(String basePath)
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
        /// Adds a custom discount to the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="customDiscount">The details of the discount to add</param> 
        /// <returns></returns>            
        public void AddCustomDiscount (string id, CouponDefinition customDiscount)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddCustomDiscount");
            
    
            var path = "/carts/{id}/custom-discounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(customDiscount); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCustomDiscount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCustomDiscount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Adds a discount coupon to the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="skuRequest">The request of the sku</param> 
        /// <returns></returns>            
        public void AddDiscountToCart (string id, SkuRequest skuRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddDiscountToCart");
            
    
            var path = "/carts/{id}/discounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(skuRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDiscountToCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDiscountToCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add an item to the cart Currently, carts cannot contain virtual and real currency items at the same time. Furthermore, the API only support a single virtual item at the moment. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="cartItemRequest">The cart item request object</param> 
        /// <returns></returns>            
        public void AddItemToCart (string id, CartItemRequest cartItemRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddItemToCart");
            
    
            var path = "/carts/{id}/items";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cartItemRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddItemToCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a cart You don&#39;t have to have a user to create a cart but the API requires authentication to checkout. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="owner">Set the owner of a cart. If not specified, defaults to the calling user&#39;s id. If specified and is not the calling user&#39;s id, SHOPPING_CARTS_ADMIN permission is required</param> 
        /// <param name="currencyCode">Set the currency for the cart, by currency code. May be disallowed by site settings.</param> 
        /// <returns>string</returns>            
        public string CreateCart (int? owner, string currencyCode)
        {
            
    
            var path = "/carts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (owner != null) queryParams.Add("owner", ApiClient.ParameterToString(owner)); // query parameter
 if (currencyCode != null) queryParams.Add("currency_code", ApiClient.ParameterToString(currencyCode)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Returns the cart with the given GUID &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <returns>Cart</returns>            
        public Cart GetCart (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCart");
            
    
            var path = "/carts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Cart) ApiClient.Deserialize(response.Content, typeof(Cart), response.Headers);
        }
    
        /// <summary>
        /// Get a list of carts &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="filterOwnerId">Filter by the id of the owner</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceCartSummary</returns>            
        public PageResourceCartSummary GetCarts (int? filterOwnerId, int? size, int? page, string order)
        {
            
    
            var path = "/carts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterOwnerId != null) queryParams.Add("filter_owner_id", ApiClient.ParameterToString(filterOwnerId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCarts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCarts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceCartSummary) ApiClient.Deserialize(response.Content, typeof(PageResourceCartSummary), response.Headers);
        }
    
        /// <summary>
        /// Returns whether a cart requires shipping &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <returns>CartShippableResponse</returns>            
        public CartShippableResponse GetShippable (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetShippable");
            
    
            var path = "/carts/{id}/shippable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CartShippableResponse) ApiClient.Deserialize(response.Content, typeof(CartShippableResponse), response.Headers);
        }
    
        /// <summary>
        /// Get the list of available shipping countries per vendor Since a cart can have multiple vendors with different shipping options, the countries are broken down by vendors. Please see notes about the response object as the fields are variable. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <returns>SampleCountriesResponse</returns>            
        public SampleCountriesResponse GetShippingCountries (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetShippingCountries");
            
    
            var path = "/carts/{id}/countries";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingCountries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingCountries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SampleCountriesResponse) ApiClient.Deserialize(response.Content, typeof(SampleCountriesResponse), response.Headers);
        }
    
        /// <summary>
        /// Removes a discount coupon from the cart &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="code">The SKU code of the coupon to remove</param> 
        /// <returns></returns>            
        public void RemoveDiscountFromCart (string id, string code)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveDiscountFromCart");
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling RemoveDiscountFromCart");
            
    
            var path = "/carts/{id}/discounts/{code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "code" + "}", ApiClient.ParameterToString(code));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveDiscountFromCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveDiscountFromCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the currency to use for the cart May be disallowed by site settings. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="currencyCode">The code of the currency</param> 
        /// <returns></returns>            
        public void SetCartCurrency (string id, StringWrapper currencyCode)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetCartCurrency");
            
    
            var path = "/carts/{id}/currency";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(currencyCode); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCartCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCartCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the owner of a cart if none is set already &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="userId">The id of the user</param> 
        /// <returns></returns>            
        public void SetCartOwner (string id, IntWrapper userId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetCartOwner");
            
    
            var path = "/carts/{id}/owner";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCartOwner: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCartOwner: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Changes the quantity of an item already in the cart A quantity of zero will remove the item from the cart altogether. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="cartItemRequest">The cart item request object</param> 
        /// <returns></returns>            
        public void UpdateItemInCart (string id, CartItemRequest cartItemRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateItemInCart");
            
    
            var path = "/carts/{id}/items";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cartItemRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateItemInCart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateItemInCart: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Modifies or sets the order shipping address &lt;b&gt;Permissions Needed:&lt;/b&gt; SHOPPING_CARTS_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the cart</param> 
        /// <param name="cartShippingAddressRequest">The cart shipping address request object</param> 
        /// <returns></returns>            
        public void UpdateShippingAddress (string id, CartShippingAddressRequest cartShippingAddressRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateShippingAddress");
            
    
            var path = "/carts/{id}/shipping-address";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cartShippingAddressRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
