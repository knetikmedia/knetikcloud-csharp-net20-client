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
    public interface ILogsApi
    {
        /// <summary>
        /// Add a user log entry 
        /// </summary>
        /// <param name="logEntry">The user log entry to be added</param>
        /// <returns></returns>
        void AddUserLog (UserActionLog logEntry);
        /// <summary>
        /// Get an existing BRE event log entry by id 
        /// </summary>
        /// <param name="id">The BRE event log entry id</param>
        /// <returns>BreEventLog</returns>
        BreEventLog GetBREEventLog (string id);
        /// <summary>
        /// Returns a list of BRE event log entries 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterEventName">Filter event logs by event name</param>
        /// <param name="filterEventId">Filter event logs by request id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceBreEventLog</returns>
        PageResourceBreEventLog GetBREEventLogs (string filterStartDate, string filterEventName, string filterEventId, int? size, int? page, string order);
        /// <summary>
        /// Get an existing forward log entry by id 
        /// </summary>
        /// <param name="id">The forward log entry id</param>
        /// <returns>ForwardLog</returns>
        ForwardLog GetBREForwardLog (string id);
        /// <summary>
        /// Returns a list of forward log entries 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterEndDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterStatusCode">Filter forward logs by http status code</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceForwardLog</returns>
        PageResourceForwardLog GetBREForwardLogs (string filterStartDate, string filterEndDate, int? filterStatusCode, int? size, int? page, string order);
        /// <summary>
        /// Returns a user log entry by id 
        /// </summary>
        /// <param name="id">The user log entry id</param>
        /// <returns>UserActionLog</returns>
        UserActionLog GetUserLog (string id);
        /// <summary>
        /// Returns a page of user logs entries 
        /// </summary>
        /// <param name="filterUser">Filter for actions taken by a specific user by id</param>
        /// <param name="filterActionName">Filter for actions of a specific name</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceUserActionLog</returns>
        PageResourceUserActionLog GetUserLogs (int? filterUser, string filterActionName, int? size, int? page, string order);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LogsApi : ILogsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LogsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LogsApi(String basePath)
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
        /// Add a user log entry 
        /// </summary>
        /// <param name="logEntry">The user log entry to be added</param> 
        /// <returns></returns>            
        public void AddUserLog (UserActionLog logEntry)
        {
            
    
            var path = "/audit/logs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(logEntry); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an existing BRE event log entry by id 
        /// </summary>
        /// <param name="id">The BRE event log entry id</param> 
        /// <returns>BreEventLog</returns>            
        public BreEventLog GetBREEventLog (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBREEventLog");
            
    
            var path = "/bre/logs/event-log/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREEventLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREEventLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BreEventLog) ApiClient.Deserialize(response.Content, typeof(BreEventLog), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of BRE event log entries 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the event log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterEventName">Filter event logs by event name</param> 
        /// <param name="filterEventId">Filter event logs by request id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceBreEventLog</returns>            
        public PageResourceBreEventLog GetBREEventLogs (string filterStartDate, string filterEventName, string filterEventId, int? size, int? page, string order)
        {
            
    
            var path = "/bre/logs/event-log";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterStartDate != null) queryParams.Add("filter_start_date", ApiClient.ParameterToString(filterStartDate)); // query parameter
 if (filterEventName != null) queryParams.Add("filter_event_name", ApiClient.ParameterToString(filterEventName)); // query parameter
 if (filterEventId != null) queryParams.Add("filter_event_id", ApiClient.ParameterToString(filterEventId)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREEventLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREEventLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceBreEventLog) ApiClient.Deserialize(response.Content, typeof(PageResourceBreEventLog), response.Headers);
        }
    
        /// <summary>
        /// Get an existing forward log entry by id 
        /// </summary>
        /// <param name="id">The forward log entry id</param> 
        /// <returns>ForwardLog</returns>            
        public ForwardLog GetBREForwardLog (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBREForwardLog");
            
    
            var path = "/bre/logs/forward-log/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREForwardLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREForwardLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ForwardLog) ApiClient.Deserialize(response.Content, typeof(ForwardLog), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of forward log entries 
        /// </summary>
        /// <param name="filterStartDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterEndDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log end date, a unix timestamp in seconds.  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterStatusCode">Filter forward logs by http status code</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceForwardLog</returns>            
        public PageResourceForwardLog GetBREForwardLogs (string filterStartDate, string filterEndDate, int? filterStatusCode, int? size, int? page, string order)
        {
            
    
            var path = "/bre/logs/forward-log";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterStartDate != null) queryParams.Add("filter_start_date", ApiClient.ParameterToString(filterStartDate)); // query parameter
 if (filterEndDate != null) queryParams.Add("filter_end_date", ApiClient.ParameterToString(filterEndDate)); // query parameter
 if (filterStatusCode != null) queryParams.Add("filter_status_code", ApiClient.ParameterToString(filterStatusCode)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREForwardLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBREForwardLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceForwardLog) ApiClient.Deserialize(response.Content, typeof(PageResourceForwardLog), response.Headers);
        }
    
        /// <summary>
        /// Returns a user log entry by id 
        /// </summary>
        /// <param name="id">The user log entry id</param> 
        /// <returns>UserActionLog</returns>            
        public UserActionLog GetUserLog (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUserLog");
            
    
            var path = "/audit/logs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserActionLog) ApiClient.Deserialize(response.Content, typeof(UserActionLog), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of user logs entries 
        /// </summary>
        /// <param name="filterUser">Filter for actions taken by a specific user by id</param> 
        /// <param name="filterActionName">Filter for actions of a specific name</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceUserActionLog</returns>            
        public PageResourceUserActionLog GetUserLogs (int? filterUser, string filterActionName, int? size, int? page, string order)
        {
            
    
            var path = "/audit/logs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterUser != null) queryParams.Add("filter_user", ApiClient.ParameterToString(filterUser)); // query parameter
 if (filterActionName != null) queryParams.Add("filter_action_name", ApiClient.ParameterToString(filterActionName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceUserActionLog) ApiClient.Deserialize(response.Content, typeof(PageResourceUserActionLog), response.Headers);
        }
    
    }
}
