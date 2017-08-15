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
    public interface IGamificationAchievementsApi
    {
        /// <summary>
        /// Create a new achievement definition If the definition contains a trigger event name, a BRE rule is created, so that tracking logic is executed when the triggering event occurs. If no trigger event name is specified, the user&#39;s achievement status must manually be updated via the API.
        /// </summary>
        /// <param name="achievement">The achievement definition</param>
        /// <returns>AchievementDefinitionResource</returns>
        AchievementDefinitionResource CreateAchievement (AchievementDefinitionResource achievement);
        /// <summary>
        /// Create an achievement template Achievement templates define a type of achievement and the properties they have
        /// </summary>
        /// <param name="template">The achievement template to be created</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateAchievementTemplate (TemplateResource template);
        /// <summary>
        /// Delete an achievement definition Will also disable the associated generated rule, if any.
        /// </summary>
        /// <param name="name">The name of the achievement</param>
        /// <returns></returns>
        void DeleteAchievement (string name);
        /// <summary>
        /// Delete an achievement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteAchievementTemplate (string id, string cascade);
        /// <summary>
        /// Get a single achievement definition 
        /// </summary>
        /// <param name="name">The name of the achievement</param>
        /// <returns>AchievementDefinitionResource</returns>
        AchievementDefinitionResource GetAchievement (string name);
        /// <summary>
        /// Get a single achievement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetAchievementTemplate (string id);
        /// <summary>
        /// List and search achievement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetAchievementTemplates (int? size, int? page, string order);
        /// <summary>
        /// Get the list of triggers that can be used to trigger an achievement progress update 
        /// </summary>
        /// <returns>List&lt;BreTriggerResource&gt;</returns>
        List<BreTriggerResource> GetAchievementTriggers ();
        /// <summary>
        /// Get all achievement definitions in the system 
        /// </summary>
        /// <param name="filterTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterName">Filter for achievements whose name contains a string</param>
        /// <param name="filterHidden">Filter for achievements that are hidden or not</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <param name="filterDerived">Filter for achievements that are derived from other services</param>
        /// <returns>PageResourceAchievementDefinitionResource</returns>
        PageResourceAchievementDefinitionResource GetAchievements (string filterTagset, string filterName, bool? filterHidden, int? size, int? page, string order, bool? filterDerived);
        /// <summary>
        /// Get a list of derived achievements Used by other services that depend on achievements
        /// </summary>
        /// <param name="name">The name of the derived achievement</param>
        /// <returns>List&lt;AchievementDefinitionResource&gt;</returns>
        List<AchievementDefinitionResource> GetDerivedAchievements (string name);
        /// <summary>
        /// Retrieve progress on a given achievement for a given user Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <returns>UserAchievementGroupResource</returns>
        UserAchievementGroupResource GetUserAchievementProgress (int? userId, string achievementName);
        /// <summary>
        /// Retrieve progress on achievements for a given user Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUserAchievementGroupResource</returns>
        PageResourceUserAchievementGroupResource GetUserAchievementsProgress (int? userId, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page);
        /// <summary>
        /// Retrieve progress on a given achievement for all users Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.
        /// </summary>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUserAchievementGroupResource</returns>
        PageResourceUserAchievementGroupResource GetUsersAchievementProgress (string achievementName, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page);
        /// <summary>
        /// Retrieve progress on achievements for all users Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.
        /// </summary>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param>
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param>
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceUserAchievementGroupResource</returns>
        PageResourceUserAchievementGroupResource GetUsersAchievementsProgress (bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page);
        /// <summary>
        /// Increment an achievement progress record for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated and the provided value added to the existing progress. May be negative. If progress meets or exceeds the achievement&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <param name="progress">The amount to add to the progress value</param>
        /// <returns>UserAchievementGroupResource</returns>
        UserAchievementGroupResource IncrementAchievementProgress (int? userId, string achievementName, IntWrapper progress);
        /// <summary>
        /// Set an achievement progress record for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated and progress set to the provided value. If progress meets or exceeds the achievement&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param>
        /// <param name="achievementName">The achievement&#39;s name</param>
        /// <param name="progress">The new progress value</param>
        /// <returns>UserAchievementGroupResource</returns>
        UserAchievementGroupResource SetAchievementProgress (int? userId, string achievementName, IntWrapper progress);
        /// <summary>
        /// Update an achievement definition The existing generated rule, if any, will be deleted. A new rule will be created if a trigger event name is specified in the new version.
        /// </summary>
        /// <param name="name">The name of the achievement</param>
        /// <param name="achievement">The achievement definition</param>
        /// <returns>AchievementDefinitionResource</returns>
        AchievementDefinitionResource UpdateAchievement (string name, AchievementDefinitionResource achievement);
        /// <summary>
        /// Update an achievement template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="template">The updated template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateAchievementTemplate (string id, TemplateResource template);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GamificationAchievementsApi : IGamificationAchievementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationAchievementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GamificationAchievementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationAchievementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamificationAchievementsApi(String basePath)
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
        /// Create a new achievement definition If the definition contains a trigger event name, a BRE rule is created, so that tracking logic is executed when the triggering event occurs. If no trigger event name is specified, the user&#39;s achievement status must manually be updated via the API.
        /// </summary>
        /// <param name="achievement">The achievement definition</param> 
        /// <returns>AchievementDefinitionResource</returns>            
        public AchievementDefinitionResource CreateAchievement (AchievementDefinitionResource achievement)
        {
            
    
            var path = "/achievements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(achievement); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAchievement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAchievement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AchievementDefinitionResource) ApiClient.Deserialize(response.Content, typeof(AchievementDefinitionResource), response.Headers);
        }
    
        /// <summary>
        /// Create an achievement template Achievement templates define a type of achievement and the properties they have
        /// </summary>
        /// <param name="template">The achievement template to be created</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateAchievementTemplate (TemplateResource template)
        {
            
    
            var path = "/achievements/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAchievementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAchievementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an achievement definition Will also disable the associated generated rule, if any.
        /// </summary>
        /// <param name="name">The name of the achievement</param> 
        /// <returns></returns>            
        public void DeleteAchievement (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAchievement");
            
    
            var path = "/achievements/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAchievement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAchievement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an achievement template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteAchievementTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAchievementTemplate");
            
    
            var path = "/achievements/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAchievementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAchievementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single achievement definition 
        /// </summary>
        /// <param name="name">The name of the achievement</param> 
        /// <returns>AchievementDefinitionResource</returns>            
        public AchievementDefinitionResource GetAchievement (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetAchievement");
            
    
            var path = "/achievements/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AchievementDefinitionResource) ApiClient.Deserialize(response.Content, typeof(AchievementDefinitionResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single achievement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetAchievementTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAchievementTemplate");
            
    
            var path = "/achievements/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search achievement templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetAchievementTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/achievements/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Get the list of triggers that can be used to trigger an achievement progress update 
        /// </summary>
        /// <returns>List&lt;BreTriggerResource&gt;</returns>            
        public List<BreTriggerResource> GetAchievementTriggers ()
        {
            
    
            var path = "/achievements/triggers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTriggers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievementTriggers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<BreTriggerResource>) ApiClient.Deserialize(response.Content, typeof(List<BreTriggerResource>), response.Headers);
        }
    
        /// <summary>
        /// Get all achievement definitions in the system 
        /// </summary>
        /// <param name="filterTagset">Filter for achievements with specified tags (separated by comma)</param> 
        /// <param name="filterName">Filter for achievements whose name contains a string</param> 
        /// <param name="filterHidden">Filter for achievements that are hidden or not</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <param name="filterDerived">Filter for achievements that are derived from other services</param> 
        /// <returns>PageResourceAchievementDefinitionResource</returns>            
        public PageResourceAchievementDefinitionResource GetAchievements (string filterTagset, string filterName, bool? filterHidden, int? size, int? page, string order, bool? filterDerived)
        {
            
    
            var path = "/achievements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterHidden != null) queryParams.Add("filter_hidden", ApiClient.ParameterToString(filterHidden)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
 if (filterDerived != null) queryParams.Add("filter_derived", ApiClient.ParameterToString(filterDerived)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAchievements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceAchievementDefinitionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceAchievementDefinitionResource), response.Headers);
        }
    
        /// <summary>
        /// Get a list of derived achievements Used by other services that depend on achievements
        /// </summary>
        /// <param name="name">The name of the derived achievement</param> 
        /// <returns>List&lt;AchievementDefinitionResource&gt;</returns>            
        public List<AchievementDefinitionResource> GetDerivedAchievements (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetDerivedAchievements");
            
    
            var path = "/achievements/derived/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDerivedAchievements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDerivedAchievements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AchievementDefinitionResource>) ApiClient.Deserialize(response.Content, typeof(List<AchievementDefinitionResource>), response.Headers);
        }
    
        /// <summary>
        /// Retrieve progress on a given achievement for a given user Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <param name="achievementName">The achievement&#39;s name</param> 
        /// <returns>UserAchievementGroupResource</returns>            
        public UserAchievementGroupResource GetUserAchievementProgress (int? userId, string achievementName)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserAchievementProgress");
            
            // verify the required parameter 'achievementName' is set
            if (achievementName == null) throw new ApiException(400, "Missing required parameter 'achievementName' when calling GetUserAchievementProgress");
            
    
            var path = "/users/{user_id}/achievements/{achievement_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "achievement_name" + "}", ApiClient.ParameterToString(achievementName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserAchievementProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserAchievementProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(UserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve progress on achievements for a given user Assets will not be filled in on the resources returned. Use &#39;Get a single poll&#39; to retrieve the full resource with assets for a given item as needed.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param> 
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param> 
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUserAchievementGroupResource</returns>            
        public PageResourceUserAchievementGroupResource GetUserAchievementsProgress (int? userId, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserAchievementsProgress");
            
    
            var path = "/users/{user_id}/achievements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterAchievementDerived != null) queryParams.Add("filter_achievement_derived", ApiClient.ParameterToString(filterAchievementDerived)); // query parameter
 if (filterAchievementTagset != null) queryParams.Add("filter_achievement_tagset", ApiClient.ParameterToString(filterAchievementTagset)); // query parameter
 if (filterAchievementName != null) queryParams.Add("filter_achievement_name", ApiClient.ParameterToString(filterAchievementName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserAchievementsProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserAchievementsProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve progress on a given achievement for all users Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.
        /// </summary>
        /// <param name="achievementName">The achievement&#39;s name</param> 
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param> 
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param> 
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUserAchievementGroupResource</returns>            
        public PageResourceUserAchievementGroupResource GetUsersAchievementProgress (string achievementName, bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)
        {
            
            // verify the required parameter 'achievementName' is set
            if (achievementName == null) throw new ApiException(400, "Missing required parameter 'achievementName' when calling GetUsersAchievementProgress");
            
    
            var path = "/users/achievements/{achievement_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "achievement_name" + "}", ApiClient.ParameterToString(achievementName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterAchievementDerived != null) queryParams.Add("filter_achievement_derived", ApiClient.ParameterToString(filterAchievementDerived)); // query parameter
 if (filterAchievementTagset != null) queryParams.Add("filter_achievement_tagset", ApiClient.ParameterToString(filterAchievementTagset)); // query parameter
 if (filterAchievementName != null) queryParams.Add("filter_achievement_name", ApiClient.ParameterToString(filterAchievementName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersAchievementProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersAchievementProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve progress on achievements for all users Assets will not be filled in on the resources returned. Use &#39;Get single achievement progress for user&#39; to retrieve the full resource with assets for a given user as needed.
        /// </summary>
        /// <param name="filterAchievementDerived">Filter for achievements that are derived from other services</param> 
        /// <param name="filterAchievementTagset">Filter for achievements with specified tags (separated by comma)</param> 
        /// <param name="filterAchievementName">Filter for achievements whose name contains a string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceUserAchievementGroupResource</returns>            
        public PageResourceUserAchievementGroupResource GetUsersAchievementsProgress (bool? filterAchievementDerived, string filterAchievementTagset, string filterAchievementName, int? size, int? page)
        {
            
    
            var path = "/users/achievements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterAchievementDerived != null) queryParams.Add("filter_achievement_derived", ApiClient.ParameterToString(filterAchievementDerived)); // query parameter
 if (filterAchievementTagset != null) queryParams.Add("filter_achievement_tagset", ApiClient.ParameterToString(filterAchievementTagset)); // query parameter
 if (filterAchievementName != null) queryParams.Add("filter_achievement_name", ApiClient.ParameterToString(filterAchievementName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersAchievementsProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersAchievementsProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(PageResourceUserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Increment an achievement progress record for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated and the provided value added to the existing progress. May be negative. If progress meets or exceeds the achievement&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <param name="achievementName">The achievement&#39;s name</param> 
        /// <param name="progress">The amount to add to the progress value</param> 
        /// <returns>UserAchievementGroupResource</returns>            
        public UserAchievementGroupResource IncrementAchievementProgress (int? userId, string achievementName, IntWrapper progress)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling IncrementAchievementProgress");
            
            // verify the required parameter 'achievementName' is set
            if (achievementName == null) throw new ApiException(400, "Missing required parameter 'achievementName' when calling IncrementAchievementProgress");
            
    
            var path = "/users/{user_id}/achievements/{achievement_name}/progress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "achievement_name" + "}", ApiClient.ParameterToString(achievementName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(progress); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementAchievementProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IncrementAchievementProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(UserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Set an achievement progress record for a user If no progress record yet exists for the user, it will be created. Otherwise it will be updated and progress set to the provided value. If progress meets or exceeds the achievement&#39;s max_value it will be marked as earned and a BRE event will be triggered for the &lt;code&gt;BreAchievementEarnedTrigger&lt;/code&gt;.
        /// </summary>
        /// <param name="userId">The user&#39;s id</param> 
        /// <param name="achievementName">The achievement&#39;s name</param> 
        /// <param name="progress">The new progress value</param> 
        /// <returns>UserAchievementGroupResource</returns>            
        public UserAchievementGroupResource SetAchievementProgress (int? userId, string achievementName, IntWrapper progress)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetAchievementProgress");
            
            // verify the required parameter 'achievementName' is set
            if (achievementName == null) throw new ApiException(400, "Missing required parameter 'achievementName' when calling SetAchievementProgress");
            
    
            var path = "/users/{user_id}/achievements/{achievement_name}/progress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "achievement_name" + "}", ApiClient.ParameterToString(achievementName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(progress); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetAchievementProgress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetAchievementProgress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAchievementGroupResource) ApiClient.Deserialize(response.Content, typeof(UserAchievementGroupResource), response.Headers);
        }
    
        /// <summary>
        /// Update an achievement definition The existing generated rule, if any, will be deleted. A new rule will be created if a trigger event name is specified in the new version.
        /// </summary>
        /// <param name="name">The name of the achievement</param> 
        /// <param name="achievement">The achievement definition</param> 
        /// <returns>AchievementDefinitionResource</returns>            
        public AchievementDefinitionResource UpdateAchievement (string name, AchievementDefinitionResource achievement)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateAchievement");
            
    
            var path = "/achievements/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(achievement); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAchievement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAchievement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AchievementDefinitionResource) ApiClient.Deserialize(response.Content, typeof(AchievementDefinitionResource), response.Headers);
        }
    
        /// <summary>
        /// Update an achievement template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="template">The updated template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateAchievementTemplate (string id, TemplateResource template)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAchievementTemplate");
            
    
            var path = "/achievements/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(template); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAchievementTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAchievementTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
