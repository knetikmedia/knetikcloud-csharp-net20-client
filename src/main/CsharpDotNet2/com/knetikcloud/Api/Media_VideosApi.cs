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
    public interface IMedia_VideosApi
    {
        /// <summary>
        /// Adds a user to a video&#39;s whitelist Whitelisted users can view video regardless of privacy setting. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param>
        /// <param name="userId">The user id</param>
        /// <returns></returns>
        void AddUserToVideoWhitelist (long? id, IntWrapper userId);
        /// <summary>
        /// Adds a new video in the system &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoResource">The video object</param>
        /// <returns>VideoResource</returns>
        VideoResource AddVideo (VideoResource videoResource);
        /// <summary>
        /// Add a new video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id </param>
        /// <param name="commentResource">The comment object</param>
        /// <returns>CommentResource</returns>
        CommentResource AddVideoComment (int? videoId, CommentResource commentResource);
        /// <summary>
        /// Adds a contributor to a video &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="contributionResource">The contribution object</param>
        /// <returns></returns>
        void AddVideoContributor (long? videoId, ContributionResource contributionResource);
        /// <summary>
        /// Add a new flag &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="reason">The flag reason</param>
        /// <returns>FlagResource</returns>
        FlagResource AddVideoFlag (long? videoId, StringWrapper reason);
        /// <summary>
        /// Adds one or more existing videos as related to this one &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="videoRelationshipResource">The video relationship object </param>
        /// <returns>VideoRelationshipResource</returns>
        VideoRelationshipResource AddVideoRelationships (long? videoId, VideoRelationshipResource videoRelationshipResource);
        /// <summary>
        /// Create a video disposition &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="dispositionResource">The disposition object</param>
        /// <returns>DispositionResource</returns>
        DispositionResource CreateVideoDisposition (int? videoId, DispositionResource dispositionResource);
        /// <summary>
        /// Create a video template Video Templates define a type of video and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="videoTemplateResource">The video template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateVideoTemplate (TemplateResource videoTemplateResource);
        /// <summary>
        /// Deletes a video from the system if no resources are attached to it &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param>
        /// <returns></returns>
        void DeleteVideo (long? id);
        /// <summary>
        /// Delete a video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The comment id</param>
        /// <returns></returns>
        void DeleteVideoComment (long? videoId, long? id);
        /// <summary>
        /// Delete a video disposition &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="dispositionId">The disposition id</param>
        /// <returns></returns>
        void DeleteVideoDisposition (long? dispositionId);
        /// <summary>
        /// Delete a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <returns></returns>
        void DeleteVideoFlag (long? videoId);
        /// <summary>
        /// Delete a video&#39;s relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The relationship id</param>
        /// <returns></returns>
        void DeleteVideoRelationship (long? videoId, long? id);
        /// <summary>
        /// Delete a video template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteVideoTemplate (string id, string cascade);
        /// <summary>
        /// Get user videos &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceVideoResource</returns>
        PageResourceVideoResource GetUserVideos (int? userId, bool? excludeFlagged, int? size, int? page);
        /// <summary>
        /// Loads a specific video details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param>
        /// <returns>VideoResource</returns>
        VideoResource GetVideo (long? id);
        /// <summary>
        /// Returns a page of comments for a video &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceCommentResource</returns>
        PageResourceCommentResource GetVideoComments (int? videoId, int? size, int? page);
        /// <summary>
        /// Returns a page of dispositions for a video &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceDispositionResource</returns>
        PageResourceDispositionResource GetVideoDispositions (int? videoId, int? size, int? page);
        /// <summary>
        /// Returns a page of video relationships &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceVideoRelationshipResource</returns>
        PageResourceVideoRelationshipResource GetVideoRelationships (long? videoId, int? size, int? page);
        /// <summary>
        /// Get a single video template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetVideoTemplate (string id);
        /// <summary>
        /// List and search video templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or VIDEOS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetVideoTemplates (int? size, int? page, string order);
        /// <summary>
        /// Search videos using the documented filters &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param>
        /// <param name="filterVideosByUploader">Filter for videos by uploader id</param>
        /// <param name="filterCategory">Filter for videos from a specific category by id</param>
        /// <param name="filterTagset">Filter for videos with specified tags (separated by comma)</param>
        /// <param name="filterVideosByName">Filter for videos which name *STARTS* with the given string</param>
        /// <param name="filterVideosByContributor">Filter for videos with contribution from the artist specified by ID</param>
        /// <param name="filterVideosByAuthor">Filter for videos with an artist as author specified by ID</param>
        /// <param name="filterHasAuthor">Filter for videos that have an author set if true, or that have no author if false</param>
        /// <param name="filterHasUploader">Filter for videos that have an uploader set if true, or that have no uploader if false</param>
        /// <param name="filterRelatedTo">Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well</param>
        /// <param name="filterFriends">Filter for videos uploaded by friends. &#39;true&#39; for friends of the caller (requires user token) or a user id for a specific user&#39;s friends (requires VIDEOS_ADMIN permission)</param>
        /// <param name="filterDisposition">Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or &#39;me&#39; for the caller (requires user token for &#39;me&#39;) and DISPOSITION is the name of the disposition. E.G. filter_disposition&#x3D;123:like or filter_disposition&#x3D;me:favorite</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceVideoResource</returns>
        PageResourceVideoResource GetVideos (bool? excludeFlagged, int? filterVideosByUploader, string filterCategory, string filterTagset, string filterVideosByName, int? filterVideosByContributor, int? filterVideosByAuthor, bool? filterHasAuthor, bool? filterHasUploader, string filterRelatedTo, bool? filterFriends, string filterDisposition, int? size, int? page, string order);
        /// <summary>
        /// Removes a user from a video&#39;s whitelist Remove the user with the id given in the path from the whitelist of users that can view this video regardless of privacy setting. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The user id</param>
        /// <returns></returns>
        void RemoveUserFromVideoWhitelist (long? videoId, int? id);
        /// <summary>
        /// Removes a contributor from a video &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The contributor id</param>
        /// <returns></returns>
        void RemoveVideoContributor (long? videoId, int? id);
        /// <summary>
        /// Modifies a video&#39;s details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param>
        /// <param name="videoResource">The video object</param>
        /// <returns></returns>
        void UpdateVideo (long? id, VideoResource videoResource);
        /// <summary>
        /// Update a video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="id">The comment id</param>
        /// <param name="content">The comment content</param>
        /// <returns></returns>
        void UpdateVideoComment (long? videoId, long? id, StringWrapper content);
        /// <summary>
        /// Update a video&#39;s relationship details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param>
        /// <param name="relationshipId">The relationship id</param>
        /// <param name="details">The video relationship details</param>
        /// <returns></returns>
        void UpdateVideoRelationship (long? videoId, long? relationshipId, StringWrapper details);
        /// <summary>
        /// Update a video template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="videoTemplateResource">The video template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateVideoTemplate (string id, TemplateResource videoTemplateResource);
        /// <summary>
        /// Increment a video&#39;s view count &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The video id</param>
        /// <returns></returns>
        void ViewVideo (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Media_VideosApi : IMedia_VideosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Media_VideosApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Media_VideosApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Media_VideosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Media_VideosApi(String basePath)
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
        /// Adds a user to a video&#39;s whitelist Whitelisted users can view video regardless of privacy setting. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param> 
        /// <param name="userId">The user id</param> 
        /// <returns></returns>            
        public void AddUserToVideoWhitelist (long? id, IntWrapper userId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddUserToVideoWhitelist");
            
    
            var path = "/media/videos/{id}/whitelist";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserToVideoWhitelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserToVideoWhitelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Adds a new video in the system &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoResource">The video object</param> 
        /// <returns>VideoResource</returns>            
        public VideoResource AddVideo (VideoResource videoResource)
        {
            
    
            var path = "/media/videos";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(videoResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VideoResource) ApiClient.Deserialize(response.Content, typeof(VideoResource), response.Headers);
        }
    
        /// <summary>
        /// Add a new video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id </param> 
        /// <param name="commentResource">The comment object</param> 
        /// <returns>CommentResource</returns>            
        public CommentResource AddVideoComment (int? videoId, CommentResource commentResource)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling AddVideoComment");
            
    
            var path = "/media/videos/{video_id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(commentResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommentResource) ApiClient.Deserialize(response.Content, typeof(CommentResource), response.Headers);
        }
    
        /// <summary>
        /// Adds a contributor to a video &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="contributionResource">The contribution object</param> 
        /// <returns></returns>            
        public void AddVideoContributor (long? videoId, ContributionResource contributionResource)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling AddVideoContributor");
            
    
            var path = "/media/videos/{video_id}/contributors";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(contributionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoContributor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoContributor: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a new flag &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="reason">The flag reason</param> 
        /// <returns>FlagResource</returns>            
        public FlagResource AddVideoFlag (long? videoId, StringWrapper reason)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling AddVideoFlag");
            
    
            var path = "/media/videos/{video_id}/moderation";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(reason); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlagResource) ApiClient.Deserialize(response.Content, typeof(FlagResource), response.Headers);
        }
    
        /// <summary>
        /// Adds one or more existing videos as related to this one &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="videoRelationshipResource">The video relationship object </param> 
        /// <returns>VideoRelationshipResource</returns>            
        public VideoRelationshipResource AddVideoRelationships (long? videoId, VideoRelationshipResource videoRelationshipResource)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling AddVideoRelationships");
            
    
            var path = "/media/videos/{video_id}/related";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(videoRelationshipResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoRelationships: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddVideoRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VideoRelationshipResource) ApiClient.Deserialize(response.Content, typeof(VideoRelationshipResource), response.Headers);
        }
    
        /// <summary>
        /// Create a video disposition &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="dispositionResource">The disposition object</param> 
        /// <returns>DispositionResource</returns>            
        public DispositionResource CreateVideoDisposition (int? videoId, DispositionResource dispositionResource)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling CreateVideoDisposition");
            
    
            var path = "/media/videos/{video_id}/dispositions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dispositionResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVideoDisposition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVideoDisposition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DispositionResource) ApiClient.Deserialize(response.Content, typeof(DispositionResource), response.Headers);
        }
    
        /// <summary>
        /// Create a video template Video Templates define a type of video and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="videoTemplateResource">The video template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateVideoTemplate (TemplateResource videoTemplateResource)
        {
            
    
            var path = "/media/videos/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(videoTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVideoTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVideoTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Deletes a video from the system if no resources are attached to it &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param> 
        /// <returns></returns>            
        public void DeleteVideo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVideo");
            
    
            var path = "/media/videos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="id">The comment id</param> 
        /// <returns></returns>            
        public void DeleteVideoComment (long? videoId, long? id)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling DeleteVideoComment");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVideoComment");
            
    
            var path = "/media/videos/{video_id}/comments/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a video disposition &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="dispositionId">The disposition id</param> 
        /// <returns></returns>            
        public void DeleteVideoDisposition (long? dispositionId)
        {
            
            // verify the required parameter 'dispositionId' is set
            if (dispositionId == null) throw new ApiException(400, "Missing required parameter 'dispositionId' when calling DeleteVideoDisposition");
            
    
            var path = "/media/videos/{video_id}/dispositions/{disposition_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "disposition_id" + "}", ApiClient.ParameterToString(dispositionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoDisposition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoDisposition: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a flag &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <returns></returns>            
        public void DeleteVideoFlag (long? videoId)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling DeleteVideoFlag");
            
    
            var path = "/media/videos/{video_id}/moderation";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a video&#39;s relationship &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="id">The relationship id</param> 
        /// <returns></returns>            
        public void DeleteVideoRelationship (long? videoId, long? id)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling DeleteVideoRelationship");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVideoRelationship");
            
    
            var path = "/media/videos/{video_id}/related/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a video template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteVideoTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVideoTemplate");
            
    
            var path = "/media/videos/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVideoTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get user videos &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="userId">The user id</param> 
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceVideoResource</returns>            
        public PageResourceVideoResource GetUserVideos (int? userId, bool? excludeFlagged, int? size, int? page)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserVideos");
            
    
            var path = "/users/{user_id}/videos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (excludeFlagged != null) queryParams.Add("exclude_flagged", ApiClient.ParameterToString(excludeFlagged)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserVideos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserVideos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceVideoResource) ApiClient.Deserialize(response.Content, typeof(PageResourceVideoResource), response.Headers);
        }
    
        /// <summary>
        /// Loads a specific video details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param> 
        /// <returns>VideoResource</returns>            
        public VideoResource GetVideo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetVideo");
            
    
            var path = "/media/videos/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VideoResource) ApiClient.Deserialize(response.Content, typeof(VideoResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of comments for a video &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceCommentResource</returns>            
        public PageResourceCommentResource GetVideoComments (int? videoId, int? size, int? page)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideoComments");
            
    
            var path = "/media/videos/{video_id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceCommentResource) ApiClient.Deserialize(response.Content, typeof(PageResourceCommentResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of dispositions for a video &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceDispositionResource</returns>            
        public PageResourceDispositionResource GetVideoDispositions (int? videoId, int? size, int? page)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideoDispositions");
            
    
            var path = "/media/videos/{video_id}/dispositions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoDispositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoDispositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceDispositionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceDispositionResource), response.Headers);
        }
    
        /// <summary>
        /// Returns a page of video relationships &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceVideoRelationshipResource</returns>            
        public PageResourceVideoRelationshipResource GetVideoRelationships (long? videoId, int? size, int? page)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideoRelationships");
            
    
            var path = "/media/videos/{video_id}/related";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoRelationships: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceVideoRelationshipResource) ApiClient.Deserialize(response.Content, typeof(PageResourceVideoRelationshipResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single video template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetVideoTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetVideoTemplate");
            
    
            var path = "/media/videos/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search video templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or VIDEOS_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetVideoTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/media/videos/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideoTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Search videos using the documented filters &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="excludeFlagged">Skip videos that have been flagged by the current user</param> 
        /// <param name="filterVideosByUploader">Filter for videos by uploader id</param> 
        /// <param name="filterCategory">Filter for videos from a specific category by id</param> 
        /// <param name="filterTagset">Filter for videos with specified tags (separated by comma)</param> 
        /// <param name="filterVideosByName">Filter for videos which name *STARTS* with the given string</param> 
        /// <param name="filterVideosByContributor">Filter for videos with contribution from the artist specified by ID</param> 
        /// <param name="filterVideosByAuthor">Filter for videos with an artist as author specified by ID</param> 
        /// <param name="filterHasAuthor">Filter for videos that have an author set if true, or that have no author if false</param> 
        /// <param name="filterHasUploader">Filter for videos that have an uploader set if true, or that have no uploader if false</param> 
        /// <param name="filterRelatedTo">Filter for videos that have designated a particular video as the TO of a relationship. Pattern should match VIDEO_ID or VIDEO_ID:DETAILS to match with a specific details string as well</param> 
        /// <param name="filterFriends">Filter for videos uploaded by friends. &#39;true&#39; for friends of the caller (requires user token) or a user id for a specific user&#39;s friends (requires VIDEOS_ADMIN permission)</param> 
        /// <param name="filterDisposition">Filter for videos a given user has a given disposition towards. USER_ID:DISPOSITION where USER_ID is the id of the user who has this disposition or &#39;me&#39; for the caller (requires user token for &#39;me&#39;) and DISPOSITION is the name of the disposition. E.G. filter_disposition&#x3D;123:like or filter_disposition&#x3D;me:favorite</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceVideoResource</returns>            
        public PageResourceVideoResource GetVideos (bool? excludeFlagged, int? filterVideosByUploader, string filterCategory, string filterTagset, string filterVideosByName, int? filterVideosByContributor, int? filterVideosByAuthor, bool? filterHasAuthor, bool? filterHasUploader, string filterRelatedTo, bool? filterFriends, string filterDisposition, int? size, int? page, string order)
        {
            
    
            var path = "/media/videos";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (excludeFlagged != null) queryParams.Add("exclude_flagged", ApiClient.ParameterToString(excludeFlagged)); // query parameter
 if (filterVideosByUploader != null) queryParams.Add("filter_videos_by_uploader", ApiClient.ParameterToString(filterVideosByUploader)); // query parameter
 if (filterCategory != null) queryParams.Add("filter_category", ApiClient.ParameterToString(filterCategory)); // query parameter
 if (filterTagset != null) queryParams.Add("filter_tagset", ApiClient.ParameterToString(filterTagset)); // query parameter
 if (filterVideosByName != null) queryParams.Add("filter_videos_by_name", ApiClient.ParameterToString(filterVideosByName)); // query parameter
 if (filterVideosByContributor != null) queryParams.Add("filter_videos_by_contributor", ApiClient.ParameterToString(filterVideosByContributor)); // query parameter
 if (filterVideosByAuthor != null) queryParams.Add("filter_videos_by_author", ApiClient.ParameterToString(filterVideosByAuthor)); // query parameter
 if (filterHasAuthor != null) queryParams.Add("filter_has_author", ApiClient.ParameterToString(filterHasAuthor)); // query parameter
 if (filterHasUploader != null) queryParams.Add("filter_has_uploader", ApiClient.ParameterToString(filterHasUploader)); // query parameter
 if (filterRelatedTo != null) queryParams.Add("filter_related_to", ApiClient.ParameterToString(filterRelatedTo)); // query parameter
 if (filterFriends != null) queryParams.Add("filter_friends", ApiClient.ParameterToString(filterFriends)); // query parameter
 if (filterDisposition != null) queryParams.Add("filter_disposition", ApiClient.ParameterToString(filterDisposition)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideos: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVideos: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceVideoResource) ApiClient.Deserialize(response.Content, typeof(PageResourceVideoResource), response.Headers);
        }
    
        /// <summary>
        /// Removes a user from a video&#39;s whitelist Remove the user with the id given in the path from the whitelist of users that can view this video regardless of privacy setting. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="id">The user id</param> 
        /// <returns></returns>            
        public void RemoveUserFromVideoWhitelist (long? videoId, int? id)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling RemoveUserFromVideoWhitelist");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveUserFromVideoWhitelist");
            
    
            var path = "/media/videos/{video_id}/whitelist/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserFromVideoWhitelist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserFromVideoWhitelist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a contributor from a video &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="id">The contributor id</param> 
        /// <returns></returns>            
        public void RemoveVideoContributor (long? videoId, int? id)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling RemoveVideoContributor");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RemoveVideoContributor");
            
    
            var path = "/media/videos/{video_id}/contributors/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveVideoContributor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveVideoContributor: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Modifies a video&#39;s details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="id">The video id</param> 
        /// <param name="videoResource">The video object</param> 
        /// <returns></returns>            
        public void UpdateVideo (long? id, VideoResource videoResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVideo");
            
    
            var path = "/media/videos/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(videoResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a video comment &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="id">The comment id</param> 
        /// <param name="content">The comment content</param> 
        /// <returns></returns>            
        public void UpdateVideoComment (long? videoId, long? id, StringWrapper content)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling UpdateVideoComment");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVideoComment");
            
    
            var path = "/media/videos/{video_id}/comments/{id}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(content); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a video&#39;s relationship details &lt;b&gt;Permissions Needed:&lt;/b&gt; VIDEOS_USER or VIDEOS_ADMIN
        /// </summary>
        /// <param name="videoId">The video id</param> 
        /// <param name="relationshipId">The relationship id</param> 
        /// <param name="details">The video relationship details</param> 
        /// <returns></returns>            
        public void UpdateVideoRelationship (long? videoId, long? relationshipId, StringWrapper details)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling UpdateVideoRelationship");
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling UpdateVideoRelationship");
            
    
            var path = "/media/videos/{video_id}/related/{id}/relationship_details";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "video_id" + "}", ApiClient.ParameterToString(videoId));
path = path.Replace("{" + "relationship_id" + "}", ApiClient.ParameterToString(relationshipId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(details); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoRelationship: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update a video template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="videoTemplateResource">The video template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateVideoTemplate (string id, TemplateResource videoTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVideoTemplate");
            
    
            var path = "/media/videos/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(videoTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVideoTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Increment a video&#39;s view count &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="id">The video id</param> 
        /// <returns></returns>            
        public void ViewVideo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ViewVideo");
            
    
            var path = "/media/videos/{id}/views";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ViewVideo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ViewVideo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
