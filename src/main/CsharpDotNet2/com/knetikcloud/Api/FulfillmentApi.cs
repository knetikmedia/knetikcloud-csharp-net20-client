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
    public interface IFulfillmentApi
    {
        /// <summary>
        /// Create a fulfillment type 
        /// </summary>
        /// <param name="type">The fulfillment type</param>
        /// <returns>FulfillmentType</returns>
        FulfillmentType CreateFulfillmentType (FulfillmentType type);
        /// <summary>
        /// Delete a fulfillment type 
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        void DeleteFulfillmentType (int? id);
        /// <summary>
        /// Get a single fulfillment type 
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>FulfillmentType</returns>
        FulfillmentType GetFulfillmentType (int? id);
        /// <summary>
        /// List and search fulfillment types 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceFulfillmentType</returns>
        PageResourceFulfillmentType GetFulfillmentTypes (int? size, int? page, string order);
        /// <summary>
        /// Update a fulfillment type 
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="fulfillmentType">The fulfillment type</param>
        /// <returns></returns>
        void UpdateFulfillmentType (int? id, FulfillmentType fulfillmentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FulfillmentApi : IFulfillmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FulfillmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentApi(String basePath)
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
        /// Create a fulfillment type 
        /// </summary>
        /// <param name="type">The fulfillment type</param> 
        /// <returns>FulfillmentType</returns>            
        public FulfillmentType CreateFulfillmentType (FulfillmentType type)
        {
            
    
            var path = "/store/fulfillment/types";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(type); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateFulfillmentType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateFulfillmentType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FulfillmentType) ApiClient.Deserialize(response.Content, typeof(FulfillmentType), response.Headers);
        }
    
        /// <summary>
        /// Delete a fulfillment type 
        /// </summary>
        /// <param name="id">The id</param> 
        /// <returns></returns>            
        public void DeleteFulfillmentType (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteFulfillmentType");
            
    
            var path = "/store/fulfillment/types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFulfillmentType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFulfillmentType: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single fulfillment type 
        /// </summary>
        /// <param name="id">The id</param> 
        /// <returns>FulfillmentType</returns>            
        public FulfillmentType GetFulfillmentType (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFulfillmentType");
            
    
            var path = "/store/fulfillment/types/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulfillmentType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulfillmentType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FulfillmentType) ApiClient.Deserialize(response.Content, typeof(FulfillmentType), response.Headers);
        }
    
        /// <summary>
        /// List and search fulfillment types 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceFulfillmentType</returns>            
        public PageResourceFulfillmentType GetFulfillmentTypes (int? size, int? page, string order)
        {
            
    
            var path = "/store/fulfillment/types";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulfillmentTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulfillmentTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceFulfillmentType) ApiClient.Deserialize(response.Content, typeof(PageResourceFulfillmentType), response.Headers);
        }
    
        /// <summary>
        /// Update a fulfillment type 
        /// </summary>
        /// <param name="id">The id</param> 
        /// <param name="fulfillmentType">The fulfillment type</param> 
        /// <returns></returns>            
        public void UpdateFulfillmentType (int? id, FulfillmentType fulfillmentType)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateFulfillmentType");
            
    
            var path = "/store/fulfillment/types/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(fulfillmentType); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateFulfillmentType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateFulfillmentType: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
