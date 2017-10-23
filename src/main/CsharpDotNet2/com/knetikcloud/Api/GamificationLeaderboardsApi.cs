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
    public interface IGamificationLeaderboardsApi
    {
        /// <summary>
        /// Retrieves leaderboard details and paginated entries The context type identifies the type of entity (i.e., &#39;activity&#39;) being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard. Sorting is based on the fields of LeaderboardEntryResource rather than the returned LeaderboardResource.
        /// </summary>
        /// <param name="contextType">The context type for the leaderboard</param>
        /// <param name="contextId">The context id for the leaderboard</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>LeaderboardResource</returns>
        LeaderboardResource GetLeaderboard (string contextType, string contextId, int? size, int? page, string order);
        /// <summary>
        /// Retrieves a specific user entry with rank The context type identifies the type of entity (i.e., &#39;activity&#39;) being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard
        /// </summary>
        /// <param name="contextType">The context type for the leaderboard</param>
        /// <param name="contextId">The context id for the leaderboard</param>
        /// <param name="id">The id of a user</param>
        /// <returns>LeaderboardEntryResource</returns>
        LeaderboardEntryResource GetLeaderboardRank (string contextType, string contextId, string id);
        /// <summary>
        /// Get a list of available leaderboard strategy names 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetLeaderboardStrategies ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GamificationLeaderboardsApi : IGamificationLeaderboardsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationLeaderboardsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GamificationLeaderboardsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationLeaderboardsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamificationLeaderboardsApi(String basePath)
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
        /// Retrieves leaderboard details and paginated entries The context type identifies the type of entity (i.e., &#39;activity&#39;) being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard. Sorting is based on the fields of LeaderboardEntryResource rather than the returned LeaderboardResource.
        /// </summary>
        /// <param name="contextType">The context type for the leaderboard</param> 
        /// <param name="contextId">The context id for the leaderboard</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>LeaderboardResource</returns>            
        public LeaderboardResource GetLeaderboard (string contextType, string contextId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'contextType' is set
            if (contextType == null) throw new ApiException(400, "Missing required parameter 'contextType' when calling GetLeaderboard");
            
            // verify the required parameter 'contextId' is set
            if (contextId == null) throw new ApiException(400, "Missing required parameter 'contextId' when calling GetLeaderboard");
            
    
            var path = "/leaderboards/{context_type}/{context_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "context_type" + "}", ApiClient.ParameterToString(contextType));
path = path.Replace("{" + "context_id" + "}", ApiClient.ParameterToString(contextId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboard: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LeaderboardResource) ApiClient.Deserialize(response.Content, typeof(LeaderboardResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a specific user entry with rank The context type identifies the type of entity (i.e., &#39;activity&#39;) being tracked on the leaderboard. The context ID is the unique ID of the actual entity tracked by the leaderboard
        /// </summary>
        /// <param name="contextType">The context type for the leaderboard</param> 
        /// <param name="contextId">The context id for the leaderboard</param> 
        /// <param name="id">The id of a user</param> 
        /// <returns>LeaderboardEntryResource</returns>            
        public LeaderboardEntryResource GetLeaderboardRank (string contextType, string contextId, string id)
        {
            
            // verify the required parameter 'contextType' is set
            if (contextType == null) throw new ApiException(400, "Missing required parameter 'contextType' when calling GetLeaderboardRank");
            
            // verify the required parameter 'contextId' is set
            if (contextId == null) throw new ApiException(400, "Missing required parameter 'contextId' when calling GetLeaderboardRank");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetLeaderboardRank");
            
    
            var path = "/leaderboards/{context_type}/{context_id}/users/{id}/rank";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "context_type" + "}", ApiClient.ParameterToString(contextType));
path = path.Replace("{" + "context_id" + "}", ApiClient.ParameterToString(contextId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardRank: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardRank: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LeaderboardEntryResource) ApiClient.Deserialize(response.Content, typeof(LeaderboardEntryResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of available leaderboard strategy names 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetLeaderboardStrategies ()
        {
            
    
            var path = "/leaderboards/strategies";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardStrategies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLeaderboardStrategies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
    }
}
