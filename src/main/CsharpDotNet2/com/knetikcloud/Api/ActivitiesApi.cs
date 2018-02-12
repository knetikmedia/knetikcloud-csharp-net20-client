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
    public interface IActivitiesApi
    {
        /// <summary>
        /// Add a user to an occurrence If called with no body, defaults to the user making the call.
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="test">if true, indicates that the user should NOT be added. This can be used to test for eligibility</param>
        /// <param name="bypassRestrictions">if true, indicates that restrictions such as max player count should be ignored. Can only be used with ACTIVITIES_ADMIN</param>
        /// <param name="userId">The id of the user, or null for &#39;caller&#39;</param>
        /// <returns>ActivityOccurrenceResource</returns>
        ActivityOccurrenceResource AddUser (long? activityOccurrenceId, bool? test, bool? bypassRestrictions, IntWrapper userId);
        /// <summary>
        /// Create an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="activityResource">The activity resource object</param>
        /// <returns>ActivityResource</returns>
        ActivityResource CreateActivity (ActivityResource activityResource);
        /// <summary>
        /// Create a new activity occurrence. Ex: start a game Has to enforce extra rules if not used as an admin. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_USER or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="test">if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings</param>
        /// <param name="activityOccurrenceResource">The activity occurrence object</param>
        /// <returns>ActivityOccurrenceResource</returns>
        ActivityOccurrenceResource CreateActivityOccurrence (bool? test, CreateActivityOccurrenceRequest activityOccurrenceResource);
        /// <summary>
        /// Create a activity template Activity Templates define a type of activity and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="activityTemplateResource">The activity template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateActivityTemplate (TemplateResource activityTemplateResource);
        /// <summary>
        /// Delete an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the activity</param>
        /// <returns></returns>
        void DeleteActivity (long? id);
        /// <summary>
        /// Delete a activity template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteActivityTemplate (string id, string cascade);
        /// <summary>
        /// List activity definitions &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterTemplate">Filter for activities that are templates, or specifically not if false</param>
        /// <param name="filterName">Filter for activities that have a name starting with specified string</param>
        /// <param name="filterId">Filter for activities with an id in the given comma separated list of ids</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceBareActivityResource</returns>
        PageResourceBareActivityResource GetActivities (bool? filterTemplate, string filterName, string filterId, int? size, int? page, string order);
        /// <summary>
        /// Get a single activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The id of the activity</param>
        /// <returns>ActivityResource</returns>
        ActivityResource GetActivity (long? id);
        /// <summary>
        /// Load a single activity occurrence details &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <returns>ActivityOccurrenceResource</returns>
        ActivityOccurrenceResource GetActivityOccurrenceDetails (long? activityOccurrenceId);
        /// <summary>
        /// Get a single activity template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetActivityTemplate (string id);
        /// <summary>
        /// List and search activity templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetActivityTemplates (int? size, int? page, string order);
        /// <summary>
        /// List activity occurrences &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="filterActivity">Filter for occurrences of the given activity ID</param>
        /// <param name="filterStatus">Filter for occurrences in the given status</param>
        /// <param name="filterEvent">Filter for occurrences played during the given event</param>
        /// <param name="filterChallenge">Filter for occurrences played within the given challenge</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceActivityOccurrenceResource</returns>
        PageResourceActivityOccurrenceResource ListActivityOccurrences (string filterActivity, string filterStatus, int? filterEvent, int? filterChallenge, int? size, int? page, string order);
        /// <summary>
        /// Remove a user from an occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="userId">The id of the user, or &#39;me&#39;</param>
        /// <param name="ban">if true, indicates that the user should not be allowed to re-join. Can only be set by host or admin</param>
        /// <param name="bypassRestrictions">if true, indicates that restrictions such as current status should be ignored. Can only be used with ACTIVITIES_ADMIN</param>
        /// <returns></returns>
        void RemoveUser (long? activityOccurrenceId, string userId, bool? ban, bool? bypassRestrictions);
        /// <summary>
        /// Sets the status of an activity occurrence to FINISHED and logs metrics In addition to user permissions requirements there is security based on the core_settings.results_trust setting.
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityOccurrenceResults">The activity occurrence object</param>
        /// <returns>ActivityOccurrenceResults</returns>
        ActivityOccurrenceResults SetActivityOccurrenceResults (long? activityOccurrenceId, ActivityOccurrenceResultsResource activityOccurrenceResults);
        /// <summary>
        /// Sets the settings of an activity occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="settings">The new settings</param>
        /// <returns>ActivityOccurrenceResource</returns>
        ActivityOccurrenceResource SetActivityOccurrenceSettings (long? activityOccurrenceId, ActivityOccurrenceSettingsResource settings);
        /// <summary>
        /// Set a user&#39;s status within an occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="userId">The id of the user</param>
        /// <param name="status">The new status</param>
        /// <returns>ActivityUserResource</returns>
        ActivityUserResource SetUserStatus (long? activityOccurrenceId, string userId, string status);
        /// <summary>
        /// Update an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the activity</param>
        /// <param name="activityResource">The activity resource object</param>
        /// <returns>ActivityResource</returns>
        ActivityResource UpdateActivity (long? id, ActivityResource activityResource);
        /// <summary>
        /// Update the status of an activity occurrence If setting to &#39;FINISHED&#39; reward will be run based on current metrics that have been recorded already. Alternatively, see results endpoint to finish and record all metrics at once. Can be called by non-host participants if non_host_status_control is true
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param>
        /// <param name="activityOccurrenceStatus">The activity occurrence status object</param>
        /// <returns></returns>
        void UpdateActivityOccurrenceStatus (long? activityOccurrenceId, ValueWrapperstring activityOccurrenceStatus);
        /// <summary>
        /// Update an activity template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="activityTemplateResource">The activity template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateActivityTemplate (string id, TemplateResource activityTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActivitiesApi : IActivitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActivitiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActivitiesApi(String basePath)
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
        /// Add a user to an occurrence If called with no body, defaults to the user making the call.
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="test">if true, indicates that the user should NOT be added. This can be used to test for eligibility</param> 
        /// <param name="bypassRestrictions">if true, indicates that restrictions such as max player count should be ignored. Can only be used with ACTIVITIES_ADMIN</param> 
        /// <param name="userId">The id of the user, or null for &#39;caller&#39;</param> 
        /// <returns>ActivityOccurrenceResource</returns>            
        public ActivityOccurrenceResource AddUser (long? activityOccurrenceId, bool? test, bool? bypassRestrictions, IntWrapper userId)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling AddUser");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (test != null) queryParams.Add("test", ApiClient.ParameterToString(test)); // query parameter
 if (bypassRestrictions != null) queryParams.Add("bypass_restrictions", ApiClient.ParameterToString(bypassRestrictions)); // query parameter
                                    postBody = ApiClient.Serialize(userId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityOccurrenceResource) ApiClient.Deserialize(response.Content, typeof(ActivityOccurrenceResource), response.Headers);
        }
    
        /// <summary>
        /// Create an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="activityResource">The activity resource object</param> 
        /// <returns>ActivityResource</returns>            
        public ActivityResource CreateActivity (ActivityResource activityResource)
        {
            
    
            var path = "/activities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityResource) ApiClient.Deserialize(response.Content, typeof(ActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Create a new activity occurrence. Ex: start a game Has to enforce extra rules if not used as an admin. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_USER or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="test">if true, indicates that the occurrence should NOT be created. This can be used to test for eligibility and valid settings</param> 
        /// <param name="activityOccurrenceResource">The activity occurrence object</param> 
        /// <returns>ActivityOccurrenceResource</returns>            
        public ActivityOccurrenceResource CreateActivityOccurrence (bool? test, CreateActivityOccurrenceRequest activityOccurrenceResource)
        {
            
    
            var path = "/activity-occurrences";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (test != null) queryParams.Add("test", ApiClient.ParameterToString(test)); // query parameter
                                    postBody = ApiClient.Serialize(activityOccurrenceResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivityOccurrence: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivityOccurrence: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityOccurrenceResource) ApiClient.Deserialize(response.Content, typeof(ActivityOccurrenceResource), response.Headers);
        }
    
        /// <summary>
        /// Create a activity template Activity Templates define a type of activity and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="activityTemplateResource">The activity template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateActivityTemplate (TemplateResource activityTemplateResource)
        {
            
    
            var path = "/activities/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivityTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateActivityTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the activity</param> 
        /// <returns></returns>            
        public void DeleteActivity (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteActivity");
            
    
            var path = "/activities/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a activity template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteActivityTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteActivityTemplate");
            
    
            var path = "/activities/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cascade != null) queryParams.Add("cascade", ApiClient.ParameterToString(cascade)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActivityTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActivityTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List activity definitions &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="filterTemplate">Filter for activities that are templates, or specifically not if false</param> 
        /// <param name="filterName">Filter for activities that have a name starting with specified string</param> 
        /// <param name="filterId">Filter for activities with an id in the given comma separated list of ids</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceBareActivityResource</returns>            
        public PageResourceBareActivityResource GetActivities (bool? filterTemplate, string filterName, string filterId, int? size, int? page, string order)
        {
            
    
            var path = "/activities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterTemplate != null) queryParams.Add("filter_template", ApiClient.ParameterToString(filterTemplate)); // query parameter
 if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (filterId != null) queryParams.Add("filter_id", ApiClient.ParameterToString(filterId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBareActivityResource) ApiClient.Deserialize(response.Content, typeof(PageResourceBareActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The id of the activity</param> 
        /// <returns>ActivityResource</returns>            
        public ActivityResource GetActivity (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetActivity");
            
    
            var path = "/activities/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityResource) ApiClient.Deserialize(response.Content, typeof(ActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Load a single activity occurrence details &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <returns>ActivityOccurrenceResource</returns>            
        public ActivityOccurrenceResource GetActivityOccurrenceDetails (long? activityOccurrenceId)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling GetActivityOccurrenceDetails");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityOccurrenceDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityOccurrenceDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityOccurrenceResource) ApiClient.Deserialize(response.Content, typeof(ActivityOccurrenceResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single activity template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetActivityTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetActivityTemplate");
            
    
            var path = "/activities/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search activity templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetActivityTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/activities/templates";
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActivityTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List activity occurrences &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="filterActivity">Filter for occurrences of the given activity ID</param> 
        /// <param name="filterStatus">Filter for occurrences in the given status</param> 
        /// <param name="filterEvent">Filter for occurrences played during the given event</param> 
        /// <param name="filterChallenge">Filter for occurrences played within the given challenge</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceActivityOccurrenceResource</returns>            
        public PageResourceActivityOccurrenceResource ListActivityOccurrences (string filterActivity, string filterStatus, int? filterEvent, int? filterChallenge, int? size, int? page, string order)
        {
            
    
            var path = "/activity-occurrences";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterActivity != null) queryParams.Add("filter_activity", ApiClient.ParameterToString(filterActivity)); // query parameter
 if (filterStatus != null) queryParams.Add("filter_status", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (filterEvent != null) queryParams.Add("filter_event", ApiClient.ParameterToString(filterEvent)); // query parameter
 if (filterChallenge != null) queryParams.Add("filter_challenge", ApiClient.ParameterToString(filterChallenge)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListActivityOccurrences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListActivityOccurrences: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceActivityOccurrenceResource) ApiClient.Deserialize(response.Content, typeof(PageResourceActivityOccurrenceResource), response.Headers);
        }
    
        /// <summary>
        /// Remove a user from an occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="userId">The id of the user, or &#39;me&#39;</param> 
        /// <param name="ban">if true, indicates that the user should not be allowed to re-join. Can only be set by host or admin</param> 
        /// <param name="bypassRestrictions">if true, indicates that restrictions such as current status should be ignored. Can only be used with ACTIVITIES_ADMIN</param> 
        /// <returns></returns>            
        public void RemoveUser (long? activityOccurrenceId, string userId, bool? ban, bool? bypassRestrictions)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling RemoveUser");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling RemoveUser");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/users/{user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ban != null) queryParams.Add("ban", ApiClient.ParameterToString(ban)); // query parameter
 if (bypassRestrictions != null) queryParams.Add("bypass_restrictions", ApiClient.ParameterToString(bypassRestrictions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the status of an activity occurrence to FINISHED and logs metrics In addition to user permissions requirements there is security based on the core_settings.results_trust setting.
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="activityOccurrenceResults">The activity occurrence object</param> 
        /// <returns>ActivityOccurrenceResults</returns>            
        public ActivityOccurrenceResults SetActivityOccurrenceResults (long? activityOccurrenceId, ActivityOccurrenceResultsResource activityOccurrenceResults)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling SetActivityOccurrenceResults");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/results";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityOccurrenceResults); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetActivityOccurrenceResults: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetActivityOccurrenceResults: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityOccurrenceResults) ApiClient.Deserialize(response.Content, typeof(ActivityOccurrenceResults), response.Headers);
        }
    
        /// <summary>
        /// Sets the settings of an activity occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="settings">The new settings</param> 
        /// <returns>ActivityOccurrenceResource</returns>            
        public ActivityOccurrenceResource SetActivityOccurrenceSettings (long? activityOccurrenceId, ActivityOccurrenceSettingsResource settings)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling SetActivityOccurrenceSettings");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/settings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(settings); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetActivityOccurrenceSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetActivityOccurrenceSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityOccurrenceResource) ApiClient.Deserialize(response.Content, typeof(ActivityOccurrenceResource), response.Headers);
        }
    
        /// <summary>
        /// Set a user&#39;s status within an occurrence 
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="userId">The id of the user</param> 
        /// <param name="status">The new status</param> 
        /// <returns>ActivityUserResource</returns>            
        public ActivityUserResource SetUserStatus (long? activityOccurrenceId, string userId, string status)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling SetUserStatus");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling SetUserStatus");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/users/{user_id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(status); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUserStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityUserResource) ApiClient.Deserialize(response.Content, typeof(ActivityUserResource), response.Headers);
        }
    
        /// <summary>
        /// Update an activity &lt;b&gt;Permissions Needed:&lt;/b&gt; ACTIVITIES_ADMIN
        /// </summary>
        /// <param name="id">The id of the activity</param> 
        /// <param name="activityResource">The activity resource object</param> 
        /// <returns>ActivityResource</returns>            
        public ActivityResource UpdateActivity (long? id, ActivityResource activityResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateActivity");
            
    
            var path = "/activities/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActivityResource) ApiClient.Deserialize(response.Content, typeof(ActivityResource), response.Headers);
        }
    
        /// <summary>
        /// Update the status of an activity occurrence If setting to &#39;FINISHED&#39; reward will be run based on current metrics that have been recorded already. Alternatively, see results endpoint to finish and record all metrics at once. Can be called by non-host participants if non_host_status_control is true
        /// </summary>
        /// <param name="activityOccurrenceId">The id of the activity occurrence</param> 
        /// <param name="activityOccurrenceStatus">The activity occurrence status object</param> 
        /// <returns></returns>            
        public void UpdateActivityOccurrenceStatus (long? activityOccurrenceId, ValueWrapperstring activityOccurrenceStatus)
        {
            
            // verify the required parameter 'activityOccurrenceId' is set
            if (activityOccurrenceId == null) throw new ApiException(400, "Missing required parameter 'activityOccurrenceId' when calling UpdateActivityOccurrenceStatus");
            
    
            var path = "/activity-occurrences/{activity_occurrence_id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activity_occurrence_id" + "}", ApiClient.ParameterToString(activityOccurrenceId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityOccurrenceStatus); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityOccurrenceStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityOccurrenceStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an activity template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="activityTemplateResource">The activity template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateActivityTemplate (string id, TemplateResource activityTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateActivityTemplate");
            
    
            var path = "/activities/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(activityTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActivityTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
