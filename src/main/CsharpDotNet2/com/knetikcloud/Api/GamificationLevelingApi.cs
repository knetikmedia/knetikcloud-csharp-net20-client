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
    public interface IGamificationLevelingApi
    {
        /// <summary>
        /// Create a level schema 
        /// </summary>
        /// <param name="level">The level schema definition</param>
        /// <returns>LevelingResource</returns>
        LevelingResource CreateLevel (LevelingResource level);
        /// <summary>
        /// Delete a level 
        /// </summary>
        /// <param name="name">The level schema name</param>
        /// <returns></returns>
        void DeleteLevel (string name);
        /// <summary>
        /// Retrieve a level 
        /// </summary>
        /// <param name="name">The level schema name</param>
        /// <returns>LevelingResource</returns>
        LevelingResource GetLevel (string name);
        /// <summary>
        /// Get the list of triggers that can be used to trigger a leveling progress update 
        /// </summary>
        /// <returns>List&lt;BreTriggerResource&gt;</returns>
        List<BreTriggerResource> GetLevelTriggers ();
        /// <summary>
        /// List and search levels Get a list of levels schemas with optional filtering
        /// </summary>
        /// <param name="filterName">Filter for level schemas whose name contains a given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceLevelingResource</returns>
        PageResourceLevelingResource GetLevels (string filterName, int? size, int? page, string order);
        /// <summary>
        /// Get a user&#39;s progress for a given level schema 
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="name">The level schema name</param>
        /// <returns>UserLevelingResource</returns>
        UserLevelingResource GetUserLevel (int? userId, string name);
        /// <summary>
        /// Get a user&#39;s progress for all level schemas Filtering and sorting is based on the LevelingResource object, not the UserLevelingResource that is returned here.
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="filterName">Filter for level schemas whose name contains a given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceUserLevelingResource</returns>
        PageResourceUserLevelingResource GetUserLevels (int? userId, string filterName, int? size, int? page, string order);
        /// <summary>
        /// Update or create a leveling progress record for a user If no progress record yet exists for the user, it will be created. Otherwise the provided value will be added to it. May be negative. If progress meets or exceeds the level&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="name">The level schema name</param>
        /// <param name="progress">The amount of progress to add</param>
        /// <returns></returns>
        void IncrementProgress (int? userId, string name, IntWrapper progress);
        /// <summary>
        /// Set leveling progress for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated to the provided value. If progress meets or exceeds the level&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The id of the user</param>
        /// <param name="name">The level schema name</param>
        /// <param name="progress">The new progress amount</param>
        /// <returns></returns>
        void SetProgress (int? userId, string name, IntWrapper progress);
        /// <summary>
        /// Update a level 
        /// </summary>
        /// <param name="name">The level schema name</param>
        /// <param name="newLevel">The level schema definition</param>
        /// <returns>LevelingResource</returns>
        LevelingResource UpdateLevel (string name, LevelingResource newLevel);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GamificationLevelingApi : IGamificationLevelingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationLevelingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GamificationLevelingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationLevelingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamificationLevelingApi(String basePath)
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
        /// Create a level schema 
        /// </summary>
        /// <param name="level">The level schema definition</param> 
        /// <returns>LevelingResource</returns>            
        public LevelingResource CreateLevel (LevelingResource level)
        {
            
    
            var path = "/leveling";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(level); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLevel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LevelingResource) ApiClient.Deserialize(response.Content, typeof(LevelingResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a level 
        /// </summary>
        /// <param name="name">The level schema name</param> 
        /// <returns></returns>            
        public void DeleteLevel (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteLevel");
            
    
            var path = "/leveling/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLevel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve a level 
        /// </summary>
        /// <param name="name">The level schema name</param> 
        /// <returns>LevelingResource</returns>            
        public LevelingResource GetLevel (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetLevel");
            
    
            var path = "/leveling/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LevelingResource) ApiClient.Deserialize(response.Content, typeof(LevelingResource), response.Headers);
        }
    
        /// <summary>
        /// Get the list of triggers that can be used to trigger a leveling progress update 
        /// </summary>
        /// <returns>List&lt;BreTriggerResource&gt;</returns>            
        public List<BreTriggerResource> GetLevelTriggers ()
        {
            
    
            var path = "/leveling/triggers";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevelTriggers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevelTriggers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BreTriggerResource>) ApiClient.Deserialize(response.Content, typeof(List<BreTriggerResource>), response.Headers);
        }
    
        /// <summary>
        /// List and search levels Get a list of levels schemas with optional filtering
        /// </summary>
        /// <param name="filterName">Filter for level schemas whose name contains a given string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceLevelingResource</returns>            
        public PageResourceLevelingResource GetLevels (string filterName, int? size, int? page, string order)
        {
            
    
            var path = "/leveling";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLevels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceLevelingResource) ApiClient.Deserialize(response.Content, typeof(PageResourceLevelingResource), response.Headers);
        }
    
        /// <summary>
        /// Get a user&#39;s progress for a given level schema 
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="name">The level schema name</param> 
        /// <returns>UserLevelingResource</returns>            
        public UserLevelingResource GetUserLevel (int? userId, string name)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserLevel");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetUserLevel");
            
    
            var path = "/users/{user_id}/leveling/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLevel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserLevelingResource) ApiClient.Deserialize(response.Content, typeof(UserLevelingResource), response.Headers);
        }
    
        /// <summary>
        /// Get a user&#39;s progress for all level schemas Filtering and sorting is based on the LevelingResource object, not the UserLevelingResource that is returned here.
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="filterName">Filter for level schemas whose name contains a given string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceUserLevelingResource</returns>            
        public PageResourceUserLevelingResource GetUserLevels (int? userId, string filterName, int? size, int? page, string order)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserLevels");
            
    
            var path = "/users/{user_id}/leveling";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLevels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLevels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserLevelingResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserLevelingResource), response.Headers);
        }
    
        /// <summary>
        /// Update or create a leveling progress record for a user If no progress record yet exists for the user, it will be created. Otherwise the provided value will be added to it. May be negative. If progress meets or exceeds the level&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="name">The level schema name</param> 
        /// <param name="progress">The amount of progress to add</param> 
        /// <returns></returns>            
        public void IncrementProgress (int? userId, string name, IntWrapper progress)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling IncrementProgress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling IncrementProgress");
            
    
            var path = "/users/{user_id}/leveling/{name}/progress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(progress); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set leveling progress for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated to the provided value. If progress meets or exceeds the level&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The id of the user</param> 
        /// <param name="name">The level schema name</param> 
        /// <param name="progress">The new progress amount</param> 
        /// <returns></returns>            
        public void SetProgress (int? userId, string name, IntWrapper progress)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetProgress");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling SetProgress");
            
    
            var path = "/users/{user_id}/leveling/{name}/progress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(progress); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a level 
        /// </summary>
        /// <param name="name">The level schema name</param> 
        /// <param name="newLevel">The level schema definition</param> 
        /// <returns>LevelingResource</returns>            
        public LevelingResource UpdateLevel (string name, LevelingResource newLevel)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateLevel");
            
    
            var path = "/leveling/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(newLevel); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLevel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LevelingResource) ApiClient.Deserialize(response.Content, typeof(LevelingResource), response.Headers);
        }
    
    }
}
