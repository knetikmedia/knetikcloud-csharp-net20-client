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
    public interface IDispositionsApi
    {
        /// <summary>
        /// Add a new disposition 
        /// </summary>
        /// <param name="disposition">The new disposition record</param>
        /// <returns>DispositionResource</returns>
        DispositionResource AddDisposition (DispositionResource disposition);
        /// <summary>
        /// Delete a disposition 
        /// </summary>
        /// <param name="id">The id of the disposition record</param>
        /// <returns></returns>
        void DeleteDisposition (long? id);
        /// <summary>
        /// Returns a disposition 
        /// </summary>
        /// <param name="id">The id of the disposition record</param>
        /// <returns>DispositionResource</returns>
        DispositionResource GetDisposition (long? id);
        /// <summary>
        /// Returns a list of disposition counts 
        /// </summary>
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param>
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param>
        /// <returns>List&lt;DispositionCount&gt;</returns>
        List<DispositionCount> GetDispositionCounts (string filterContext, string filterOwner);
        /// <summary>
        /// Returns a page of dispositions 
        /// </summary>
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param>
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceDispositionResource</returns>
        PageResourceDispositionResource GetDispositions (string filterContext, string filterOwner, int? size, int? page, string order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DispositionsApi : IDispositionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DispositionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DispositionsApi(String basePath)
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
        /// Add a new disposition 
        /// </summary>
        /// <param name="disposition">The new disposition record</param> 
        /// <returns>DispositionResource</returns>            
        public DispositionResource AddDisposition (DispositionResource disposition)
        {
            
    
            var path = "/dispositions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(disposition); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDisposition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDisposition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DispositionResource) ApiClient.Deserialize(response.Content, typeof(DispositionResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a disposition 
        /// </summary>
        /// <param name="id">The id of the disposition record</param> 
        /// <returns></returns>            
        public void DeleteDisposition (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDisposition");
            
    
            var path = "/dispositions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDisposition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDisposition: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns a disposition 
        /// </summary>
        /// <param name="id">The id of the disposition record</param> 
        /// <returns>DispositionResource</returns>            
        public DispositionResource GetDisposition (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDisposition");
            
    
            var path = "/dispositions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDisposition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDisposition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DispositionResource) ApiClient.Deserialize(response.Content, typeof(DispositionResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of disposition counts 
        /// </summary>
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param> 
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param> 
        /// <returns>List&lt;DispositionCount&gt;</returns>            
        public List<DispositionCount> GetDispositionCounts (string filterContext, string filterOwner)
        {
            
    
            var path = "/dispositions/count";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterContext != null) queryParams.Add("filter_context", ApiClient.ParameterToString(filterContext)); // query parameter
 if (filterOwner != null) queryParams.Add("filter_owner", ApiClient.ParameterToString(filterOwner)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDispositionCounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDispositionCounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DispositionCount>) ApiClient.Deserialize(response.Content, typeof(List<DispositionCount>), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of dispositions 
        /// </summary>
        /// <param name="filterContext">Filter for dispositions within a context type (games, articles, polls, etc). Optionally with a specific id like filter_context&#x3D;video:47</param> 
        /// <param name="filterOwner">Filter for dispositions from a specific user by id or &#39;me&#39;</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceDispositionResource</returns>            
        public PageResourceDispositionResource GetDispositions (string filterContext, string filterOwner, int? size, int? page, string order)
        {
            
    
            var path = "/dispositions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterContext != null) queryParams.Add("filter_context", ApiClient.ParameterToString(filterContext)); // query parameter
 if (filterOwner != null) queryParams.Add("filter_owner", ApiClient.ParameterToString(filterOwner)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDispositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDispositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceDispositionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceDispositionResource), response.Headers);
        }
    
    }
}
