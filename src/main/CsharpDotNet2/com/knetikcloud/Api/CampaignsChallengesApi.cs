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
    public interface ICampaignsChallengesApi
    {
        /// <summary>
        /// Create a challenge Challenges do not run on their own.  They must be added to a campaign before events will spawn.
        /// </summary>
        /// <param name="challengeResource">The challenge resource object</param>
        /// <returns>ChallengeResource</returns>
        ChallengeResource CreateChallenge (ChallengeResource challengeResource);
        /// <summary>
        /// Create a challenge activity 
        /// </summary>
        /// <param name="challengeId">The challenge id</param>
        /// <param name="challengeActivityResource">The challenge activity resource object</param>
        /// <param name="validateSettings">Whether to validate the settings being sent against the available settings on the base activity.</param>
        /// <returns>ChallengeActivityResource</returns>
        ChallengeActivityResource CreateChallengeActivity (long? challengeId, ChallengeActivityResource challengeActivityResource, bool? validateSettings);
        /// <summary>
        /// Create a challenge template Challenge Templates define a type of challenge and the properties they have
        /// </summary>
        /// <param name="challengeTemplateResource">The challenge template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateChallengeTemplate (TemplateResource challengeTemplateResource);
        /// <summary>
        /// Delete a challenge 
        /// </summary>
        /// <param name="id">The challenge id</param>
        /// <returns></returns>
        void DeleteChallenge (long? id);
        /// <summary>
        /// Delete a challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param>
        /// <param name="challengeId">The challenge id</param>
        /// <returns></returns>
        void DeleteChallengeActivity (long? activityId, long? challengeId);
        /// <summary>
        /// Delete a challenge event 
        /// </summary>
        /// <param name="id">The challenge event id</param>
        /// <returns></returns>
        void DeleteChallengeEvent (long? id);
        /// <summary>
        /// Delete a challenge template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteChallengeTemplate (string id, string cascade);
        /// <summary>
        /// Retrieve a challenge 
        /// </summary>
        /// <param name="id">The challenge id</param>
        /// <returns>ChallengeResource</returns>
        ChallengeResource GetChallenge (long? id);
        /// <summary>
        /// List and search challenge activities 
        /// </summary>
        /// <param name="challengeId">The challenge id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceBareChallengeActivityResource</returns>
        PageResourceBareChallengeActivityResource GetChallengeActivities (long? challengeId, int? size, int? page, string order);
        /// <summary>
        /// Get a single challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param>
        /// <returns>ChallengeActivityResource</returns>
        ChallengeActivityResource GetChallengeActivity (long? activityId);
        /// <summary>
        /// Retrieve a single challenge event details 
        /// </summary>
        /// <param name="id">The challenge event id</param>
        /// <returns>ChallengeEventResource</returns>
        ChallengeEventResource GetChallengeEvent (long? id);
        /// <summary>
        /// Retrieve a list of challenge events 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterEndDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterCampaigns">check only for events from currently running campaigns</param>
        /// <param name="filterChallenge">check only for events from the challenge specified by id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceChallengeEventResource</returns>
        PageResourceChallengeEventResource GetChallengeEvents (string filterStartDate, string filterEndDate, bool? filterCampaigns, long? filterChallenge, int? size, int? page, string order);
        /// <summary>
        /// Get a single challenge template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetChallengeTemplate (string id);
        /// <summary>
        /// List and search challenge templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetChallengeTemplates (int? size, int? page, string order);
        /// <summary>
        /// Retrieve a list of challenges 
        /// </summary>
        /// <param name="filterTemplate">Filter for challenges that are not tied to campaigns (templates)</param>
        /// <param name="filterActiveCampaign">Filter for challenges that are tied to active campaigns</param>
        /// <returns>PageResourceChallengeResource</returns>
        PageResourceChallengeResource GetChallenges (bool? filterTemplate, bool? filterActiveCampaign);
        /// <summary>
        /// Update a challenge If the challenge is a copy, changes will propagate to all the related challenges
        /// </summary>
        /// <param name="id">The challenge id</param>
        /// <param name="challengeResource">The challenge resource object</param>
        /// <returns>ChallengeResource</returns>
        ChallengeResource UpdateChallenge (long? id, ChallengeResource challengeResource);
        /// <summary>
        /// Update a challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param>
        /// <param name="challengeId">The challenge id</param>
        /// <param name="challengeActivityResource">The challenge activity resource object</param>
        /// <returns>ChallengeActivityResource</returns>
        ChallengeActivityResource UpdateChallengeActivity (long? activityId, long? challengeId, ChallengeActivityResource challengeActivityResource);
        /// <summary>
        /// Update a challenge template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="challengeTemplateResource">The challenge template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateChallengeTemplate (string id, TemplateResource challengeTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CampaignsChallengesApi : ICampaignsChallengesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsChallengesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CampaignsChallengesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsChallengesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CampaignsChallengesApi(String basePath)
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
        /// Create a challenge Challenges do not run on their own.  They must be added to a campaign before events will spawn.
        /// </summary>
        /// <param name="challengeResource">The challenge resource object</param> 
        /// <returns>ChallengeResource</returns>            
        public ChallengeResource CreateChallenge (ChallengeResource challengeResource)
        {
            
    
            var path = "/challenges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(challengeResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeResource) ApiClient.Deserialize(response.Content, typeof(ChallengeResource), response.Headers);
        }
    
        /// <summary>
        /// Create a challenge activity 
        /// </summary>
        /// <param name="challengeId">The challenge id</param> 
        /// <param name="challengeActivityResource">The challenge activity resource object</param> 
        /// <param name="validateSettings">Whether to validate the settings being sent against the available settings on the base activity.</param> 
        /// <returns>ChallengeActivityResource</returns>            
        public ChallengeActivityResource CreateChallengeActivity (long? challengeId, ChallengeActivityResource challengeActivityResource, bool? validateSettings)
        {
            
            // verify the required parameter 'challengeId' is set
            if (challengeId == null) throw new ApiException(400, "Missing required parameter 'challengeId' when calling CreateChallengeActivity");
            
    
            var path = "/challenges/{challenge_id}/activities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "challenge_id" + "}", ApiClient.ParameterToString(challengeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (validateSettings != null) queryParams.Add("validateSettings", ApiClient.ParameterToString(validateSettings)); // query parameter
                                    postBody = ApiClient.Serialize(challengeActivityResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallengeActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallengeActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeActivityResource) ApiClient.Deserialize(response.Content, typeof(ChallengeActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Create a challenge template Challenge Templates define a type of challenge and the properties they have
        /// </summary>
        /// <param name="challengeTemplateResource">The challenge template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateChallengeTemplate (TemplateResource challengeTemplateResource)
        {
            
    
            var path = "/challenges/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(challengeTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallengeTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateChallengeTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a challenge 
        /// </summary>
        /// <param name="id">The challenge id</param> 
        /// <returns></returns>            
        public void DeleteChallenge (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteChallenge");
            
    
            var path = "/challenges/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param> 
        /// <param name="challengeId">The challenge id</param> 
        /// <returns></returns>            
        public void DeleteChallengeActivity (long? activityId, long? challengeId)
        {
            
            // verify the required parameter 'activityId' is set
            if (activityId == null) throw new ApiException(400, "Missing required parameter 'activityId' when calling DeleteChallengeActivity");
            
            // verify the required parameter 'challengeId' is set
            if (challengeId == null) throw new ApiException(400, "Missing required parameter 'challengeId' when calling DeleteChallengeActivity");
            
    
            var path = "/challenges/{challenge_id}/activities/{activity_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_id" + "}", ApiClient.ParameterToString(activityId));
path = path.Replace("{" + "challenge_id" + "}", ApiClient.ParameterToString(challengeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a challenge event 
        /// </summary>
        /// <param name="id">The challenge event id</param> 
        /// <returns></returns>            
        public void DeleteChallengeEvent (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteChallengeEvent");
            
    
            var path = "/challenges/events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a challenge template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteChallengeTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteChallengeTemplate");
            
    
            var path = "/challenges/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteChallengeTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve a challenge 
        /// </summary>
        /// <param name="id">The challenge id</param> 
        /// <returns>ChallengeResource</returns>            
        public ChallengeResource GetChallenge (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetChallenge");
            
    
            var path = "/challenges/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeResource) ApiClient.Deserialize(response.Content, typeof(ChallengeResource), response.Headers);
        }
    
        /// <summary>
        /// List and search challenge activities 
        /// </summary>
        /// <param name="challengeId">The challenge id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceBareChallengeActivityResource</returns>            
        public PageResourceBareChallengeActivityResource GetChallengeActivities (long? challengeId, int? size, int? page, string order)
        {
            
            // verify the required parameter 'challengeId' is set
            if (challengeId == null) throw new ApiException(400, "Missing required parameter 'challengeId' when calling GetChallengeActivities");
            
    
            var path = "/challenges/{challenge_id}/activities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "challenge_id" + "}", ApiClient.ParameterToString(challengeId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeActivities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeActivities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBareChallengeActivityResource) ApiClient.Deserialize(response.Content, typeof(PageResourceBareChallengeActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param> 
        /// <returns>ChallengeActivityResource</returns>            
        public ChallengeActivityResource GetChallengeActivity (long? activityId)
        {
            
            // verify the required parameter 'activityId' is set
            if (activityId == null) throw new ApiException(400, "Missing required parameter 'activityId' when calling GetChallengeActivity");
            
    
            var path = "/challenges/{challenge_id}/activities/{activity_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_id" + "}", ApiClient.ParameterToString(activityId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeActivityResource) ApiClient.Deserialize(response.Content, typeof(ChallengeActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a single challenge event details 
        /// </summary>
        /// <param name="id">The challenge event id</param> 
        /// <returns>ChallengeEventResource</returns>            
        public ChallengeEventResource GetChallengeEvent (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetChallengeEvent");
            
    
            var path = "/challenges/events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEvent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeEventResource) ApiClient.Deserialize(response.Content, typeof(ChallengeEventResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a list of challenge events 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterEndDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterCampaigns">check only for events from currently running campaigns</param> 
        /// <param name="filterChallenge">check only for events from the challenge specified by id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceChallengeEventResource</returns>            
        public PageResourceChallengeEventResource GetChallengeEvents (string filterStartDate, string filterEndDate, bool? filterCampaigns, long? filterChallenge, int? size, int? page, string order)
        {
            
    
            var path = "/challenges/events";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterStartDate != null) queryParams.Add("filter_start_date", ApiClient.ParameterToString(filterStartDate)); // query parameter
 if (filterEndDate != null) queryParams.Add("filter_end_date", ApiClient.ParameterToString(filterEndDate)); // query parameter
 if (filterCampaigns != null) queryParams.Add("filter_campaigns", ApiClient.ParameterToString(filterCampaigns)); // query parameter
 if (filterChallenge != null) queryParams.Add("filter_challenge", ApiClient.ParameterToString(filterChallenge)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChallengeEventResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChallengeEventResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single challenge template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetChallengeTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetChallengeTemplate");
            
    
            var path = "/challenges/templates/{id}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search challenge templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetChallengeTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/challenges/templates";
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
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a list of challenges 
        /// </summary>
        /// <param name="filterTemplate">Filter for challenges that are not tied to campaigns (templates)</param> 
        /// <param name="filterActiveCampaign">Filter for challenges that are tied to active campaigns</param> 
        /// <returns>PageResourceChallengeResource</returns>            
        public PageResourceChallengeResource GetChallenges (bool? filterTemplate, bool? filterActiveCampaign)
        {
            
    
            var path = "/challenges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTemplate != null) queryParams.Add("filter_template", ApiClient.ParameterToString(filterTemplate)); // query parameter
 if (filterActiveCampaign != null) queryParams.Add("filter_active_campaign", ApiClient.ParameterToString(filterActiveCampaign)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallenges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallenges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceChallengeResource) ApiClient.Deserialize(response.Content, typeof(PageResourceChallengeResource), response.Headers);
        }
    
        /// <summary>
        /// Update a challenge If the challenge is a copy, changes will propagate to all the related challenges
        /// </summary>
        /// <param name="id">The challenge id</param> 
        /// <param name="challengeResource">The challenge resource object</param> 
        /// <returns>ChallengeResource</returns>            
        public ChallengeResource UpdateChallenge (long? id, ChallengeResource challengeResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateChallenge");
            
    
            var path = "/challenges/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(challengeResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeResource) ApiClient.Deserialize(response.Content, typeof(ChallengeResource), response.Headers);
        }
    
        /// <summary>
        /// Update a challenge activity 
        /// </summary>
        /// <param name="activityId">The activity id</param> 
        /// <param name="challengeId">The challenge id</param> 
        /// <param name="challengeActivityResource">The challenge activity resource object</param> 
        /// <returns>ChallengeActivityResource</returns>            
        public ChallengeActivityResource UpdateChallengeActivity (long? activityId, long? challengeId, ChallengeActivityResource challengeActivityResource)
        {
            
            // verify the required parameter 'activityId' is set
            if (activityId == null) throw new ApiException(400, "Missing required parameter 'activityId' when calling UpdateChallengeActivity");
            
            // verify the required parameter 'challengeId' is set
            if (challengeId == null) throw new ApiException(400, "Missing required parameter 'challengeId' when calling UpdateChallengeActivity");
            
    
            var path = "/challenges/{challenge_id}/activities/{activity_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_id" + "}", ApiClient.ParameterToString(activityId));
path = path.Replace("{" + "challenge_id" + "}", ApiClient.ParameterToString(challengeId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(challengeActivityResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallengeActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallengeActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ChallengeActivityResource) ApiClient.Deserialize(response.Content, typeof(ChallengeActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Update a challenge template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="challengeTemplateResource">The challenge template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateChallengeTemplate (string id, TemplateResource challengeTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateChallengeTemplate");
            
    
            var path = "/challenges/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(challengeTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallengeTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateChallengeTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
