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
    public interface ICampaignsRewardsApi
    {
        /// <summary>
        /// Create a reward set 
        /// </summary>
        /// <param name="rewardSetResource">The reward set resource object</param>
        /// <returns>RewardSetResource</returns>
        RewardSetResource CreateRewardSet (RewardSetResource rewardSetResource);
        /// <summary>
        /// Delete a reward set 
        /// </summary>
        /// <param name="id">The reward id</param>
        /// <returns></returns>
        void DeleteRewardSet (int? id);
        /// <summary>
        /// Get a single reward set 
        /// </summary>
        /// <param name="id">The reward id</param>
        /// <returns>RewardSetResource</returns>
        RewardSetResource GetRewardSet (int? id);
        /// <summary>
        /// List and search reward sets 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceRewardSetResource</returns>
        PageResourceRewardSetResource GetRewardSets (int? size, int? page, string order);
        /// <summary>
        /// Update a reward set 
        /// </summary>
        /// <param name="id">The reward id</param>
        /// <param name="rewardSetResource">The reward set resource object</param>
        /// <returns>RewardSetResource</returns>
        RewardSetResource UpdateRewardSet (int? id, RewardSetResource rewardSetResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CampaignsRewardsApi : ICampaignsRewardsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsRewardsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CampaignsRewardsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsRewardsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CampaignsRewardsApi(String basePath)
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
        /// Create a reward set 
        /// </summary>
        /// <param name="rewardSetResource">The reward set resource object</param> 
        /// <returns>RewardSetResource</returns>            
        public RewardSetResource CreateRewardSet (RewardSetResource rewardSetResource)
        {
            
    
            var path = "/rewards";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rewardSetResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRewardSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRewardSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RewardSetResource) ApiClient.Deserialize(response.Content, typeof(RewardSetResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a reward set 
        /// </summary>
        /// <param name="id">The reward id</param> 
        /// <returns></returns>            
        public void DeleteRewardSet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteRewardSet");
            
    
            var path = "/rewards/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRewardSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRewardSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single reward set 
        /// </summary>
        /// <param name="id">The reward id</param> 
        /// <returns>RewardSetResource</returns>            
        public RewardSetResource GetRewardSet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetRewardSet");
            
    
            var path = "/rewards/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRewardSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRewardSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RewardSetResource) ApiClient.Deserialize(response.Content, typeof(RewardSetResource), response.Headers);
        }
    
        /// <summary>
        /// List and search reward sets 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceRewardSetResource</returns>            
        public PageResourceRewardSetResource GetRewardSets (int? size, int? page, string order)
        {
            
    
            var path = "/rewards";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRewardSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRewardSets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceRewardSetResource) ApiClient.Deserialize(response.Content, typeof(PageResourceRewardSetResource), response.Headers);
        }
    
        /// <summary>
        /// Update a reward set 
        /// </summary>
        /// <param name="id">The reward id</param> 
        /// <param name="rewardSetResource">The reward set resource object</param> 
        /// <returns>RewardSetResource</returns>            
        public RewardSetResource UpdateRewardSet (int? id, RewardSetResource rewardSetResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateRewardSet");
            
    
            var path = "/rewards/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rewardSetResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRewardSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRewardSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RewardSetResource) ApiClient.Deserialize(response.Content, typeof(RewardSetResource), response.Headers);
        }
    
    }
}
