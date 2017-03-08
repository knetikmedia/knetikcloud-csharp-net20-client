using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrenciesApi
    {
        /// <summary>
        /// Create a currency 
        /// </summary>
        /// <param name="currency">The currency object</param>
        /// <returns>CurrencyResource</returns>
        CurrencyResource CreateCurrency (CurrencyResource currency);
        /// <summary>
        /// Delete a currency 
        /// </summary>
        /// <param name="code">The currency code</param>
        /// <returns></returns>
        void DeleteCurrency (string code);
        /// <summary>
        /// List and search currencies 
        /// </summary>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config</param>
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceCurrencyResource</returns>
        PageResourceCurrencyResource GetCurrencies (bool? filterEnabledCurrencies, string filterType, int? size, int? page, string order);
        /// <summary>
        /// Get a single currency 
        /// </summary>
        /// <param name="code">The currency code</param>
        /// <returns>CurrencyResource</returns>
        CurrencyResource GetCurrency (string code);
        /// <summary>
        /// Update a currency 
        /// </summary>
        /// <param name="code">The currency code</param>
        /// <param name="currency">The currency object</param>
        /// <returns></returns>
        void UpdateCurrency (string code, CurrencyResource currency);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CurrenciesApi : ICurrenciesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CurrenciesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrenciesApi(String basePath)
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
        /// Create a currency 
        /// </summary>
        /// <param name="currency">The currency object</param> 
        /// <returns>CurrencyResource</returns>            
        public CurrencyResource CreateCurrency (CurrencyResource currency)
        {
            
    
            var path = "/currencies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(currency); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CurrencyResource) ApiClient.Deserialize(response.Content, typeof(CurrencyResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a currency 
        /// </summary>
        /// <param name="code">The currency code</param> 
        /// <returns></returns>            
        public void DeleteCurrency (string code)
        {
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling DeleteCurrency");
            
    
            var path = "/currencies/{code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "code" + "}", ApiClient.ParameterToString(code));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List and search currencies 
        /// </summary>
        /// <param name="filterEnabledCurrencies">Filter for alternate currencies setup explicitely in system config</param> 
        /// <param name="filterType">Filter currencies by type.  Allowable values: (&#39;virtual&#39;, &#39;real&#39;)</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceCurrencyResource</returns>            
        public PageResourceCurrencyResource GetCurrencies (bool? filterEnabledCurrencies, string filterType, int? size, int? page, string order)
        {
            
    
            var path = "/currencies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterEnabledCurrencies != null) queryParams.Add("filter_enabled_currencies", ApiClient.ParameterToString(filterEnabledCurrencies)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrencies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrencies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceCurrencyResource) ApiClient.Deserialize(response.Content, typeof(PageResourceCurrencyResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single currency 
        /// </summary>
        /// <param name="code">The currency code</param> 
        /// <returns>CurrencyResource</returns>            
        public CurrencyResource GetCurrency (string code)
        {
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling GetCurrency");
            
    
            var path = "/currencies/{code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "code" + "}", ApiClient.ParameterToString(code));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CurrencyResource) ApiClient.Deserialize(response.Content, typeof(CurrencyResource), response.Headers);
        }
    
        /// <summary>
        /// Update a currency 
        /// </summary>
        /// <param name="code">The currency code</param> 
        /// <param name="currency">The currency object</param> 
        /// <returns></returns>            
        public void UpdateCurrency (string code, CurrencyResource currency)
        {
            
            // verify the required parameter 'code' is set
            if (code == null) throw new ApiException(400, "Missing required parameter 'code' when calling UpdateCurrency");
            
    
            var path = "/currencies/{code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "code" + "}", ApiClient.ParameterToString(code));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(currency); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCurrency: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCurrency: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
