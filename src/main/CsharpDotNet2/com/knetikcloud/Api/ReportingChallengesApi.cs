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
    public interface IReportingChallengesApi
    {
        /// <summary>
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <returns>ModelPageResourceChallengeEventParticipantResource</returns>
        ModelPageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent);
        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <param name="filterEvent">A sepecific challenge event id</param>
        /// <returns>ModelPageResourceChallengeEventParticipantResource</returns>
        ModelPageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportingChallengesApi : IReportingChallengesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingChallengesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportingChallengesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingChallengesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingChallengesApi(String basePath)
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
        /// Retrieve a challenge event leaderboard details Lists all leaderboard entries with additional user details
        /// </summary>
        /// <param name="filterEvent">A sepecific challenge event id</param> 
        /// <returns>ModelPageResourceChallengeEventParticipantResource</returns>            
        public ModelPageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent)
        {
            
    
            var path = "/reporting/events/leaderboard";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterEvent != null) queryParams.Add("filter_event", ApiClient.ParameterToString(filterEvent)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEventLeaderboard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEventLeaderboard: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceChallengeEventParticipantResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceChallengeEventParticipantResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a challenge event participant details Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation
        /// </summary>
        /// <param name="filterEvent">A sepecific challenge event id</param> 
        /// <returns>ModelPageResourceChallengeEventParticipantResource</returns>            
        public ModelPageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent)
        {
            
    
            var path = "/reporting/events/participants";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterEvent != null) queryParams.Add("filter_event", ApiClient.ParameterToString(filterEvent)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEventParticipants: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetChallengeEventParticipants: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceChallengeEventParticipantResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceChallengeEventParticipantResource), response.Headers);
        }
    
    }
}