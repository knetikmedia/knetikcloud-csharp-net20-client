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
    public interface IStoreSalesApi
    {
        /// <summary>
        /// Create a sale 
        /// </summary>
        /// <param name="catalogSale">The catalog sale object</param>
        /// <returns>CatalogSale</returns>
        CatalogSale CreateCatalogSale (CatalogSale catalogSale);
        /// <summary>
        /// Delete a sale 
        /// </summary>
        /// <param name="id">The id of the sale</param>
        /// <returns></returns>
        void DeleteCatalogSale (int? id);
        /// <summary>
        /// Get a single sale 
        /// </summary>
        /// <param name="id">The id of the sale</param>
        /// <returns>CatalogSale</returns>
        CatalogSale GetCatalogSale (int? id);
        /// <summary>
        /// List and search sales 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceCatalogSale</returns>
        PageResourceCatalogSale GetCatalogSales (int? size, int? page, string order);
        /// <summary>
        /// Update a sale 
        /// </summary>
        /// <param name="id">The id of the sale</param>
        /// <param name="catalogSale">The catalog sale object</param>
        /// <returns>CatalogSale</returns>
        CatalogSale UpdateCatalogSale (int? id, CatalogSale catalogSale);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreSalesApi : IStoreSalesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSalesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreSalesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSalesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreSalesApi(String basePath)
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
        /// Create a sale 
        /// </summary>
        /// <param name="catalogSale">The catalog sale object</param> 
        /// <returns>CatalogSale</returns>            
        public CatalogSale CreateCatalogSale (CatalogSale catalogSale)
        {
            
    
            var path = "/store/sales";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(catalogSale); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCatalogSale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCatalogSale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CatalogSale) ApiClient.Deserialize(response.Content, typeof(CatalogSale), response.Headers);
        }
    
        /// <summary>
        /// Delete a sale 
        /// </summary>
        /// <param name="id">The id of the sale</param> 
        /// <returns></returns>            
        public void DeleteCatalogSale (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCatalogSale");
            
    
            var path = "/store/sales/{id}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCatalogSale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCatalogSale: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single sale 
        /// </summary>
        /// <param name="id">The id of the sale</param> 
        /// <returns>CatalogSale</returns>            
        public CatalogSale GetCatalogSale (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCatalogSale");
            
    
            var path = "/store/sales/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CatalogSale) ApiClient.Deserialize(response.Content, typeof(CatalogSale), response.Headers);
        }
    
        /// <summary>
        /// List and search sales 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceCatalogSale</returns>            
        public PageResourceCatalogSale GetCatalogSales (int? size, int? page, string order)
        {
            
    
            var path = "/store/sales";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSales: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCatalogSales: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceCatalogSale) ApiClient.Deserialize(response.Content, typeof(PageResourceCatalogSale), response.Headers);
        }
    
        /// <summary>
        /// Update a sale 
        /// </summary>
        /// <param name="id">The id of the sale</param> 
        /// <param name="catalogSale">The catalog sale object</param> 
        /// <returns>CatalogSale</returns>            
        public CatalogSale UpdateCatalogSale (int? id, CatalogSale catalogSale)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCatalogSale");
            
    
            var path = "/store/sales/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(catalogSale); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCatalogSale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCatalogSale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CatalogSale) ApiClient.Deserialize(response.Content, typeof(CatalogSale), response.Headers);
        }
    
    }
}
