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
    public interface IMediaArtistsApi
    {
        /// <summary>
        /// Adds a new artist in the system Adds a new artist in the system. Use specific media contributions endpoint to add contributions
        /// </summary>
        /// <param name="artistResource">The new artist</param>
        /// <returns>ModelArtistResource</returns>
        ModelArtistResource AddArtist (ModelArtistResource artistResource);
        /// <summary>
        /// Create an artist template Artist Templates define a type of artist and the properties they have
        /// </summary>
        /// <param name="artistTemplateResource">The artist template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource CreateArtistTemplate (ModelTemplateResource artistTemplateResource);
        /// <summary>
        /// Removes an artist from the system IF no resources are attached to it 
        /// </summary>
        /// <param name="id">The artist id</param>
        /// <returns></returns>
        void DeleteArtist (long? id);
        /// <summary>
        /// Delete an artist template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteArtistTemplate (string id, string cascade);
        /// <summary>
        /// Loads a specific artist details 
        /// </summary>
        /// <param name="id">The artist id</param>
        /// <param name="showContributions">The number of contributions to show fetch</param>
        /// <returns>ModelArtistResource</returns>
        ModelArtistResource GetArtist (long? id, int? showContributions);
        /// <summary>
        /// Get a single artist template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource GetArtistTemplate (string id);
        /// <summary>
        /// List and search artist templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceTemplateResource</returns>
        ModelPageResourceTemplateResource GetArtistTemplates (int? size, int? page, string order);
        /// <summary>
        /// Search for artists 
        /// </summary>
        /// <param name="filterArtistsByName">Filter for artists which name *STARTS* with the given string</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceArtistResource</returns>
        ModelPageResourceArtistResource GetArtists (string filterArtistsByName, int? size, int? page, string order);
        /// <summary>
        /// Modifies an artist details 
        /// </summary>
        /// <param name="id">The artist id</param>
        /// <param name="artistResource">The new artist</param>
        /// <returns></returns>
        void UpdateArtist (long? id, ModelArtistResource artistResource);
        /// <summary>
        /// Update an artist template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="artistTemplateResource">The artist template resource object</param>
        /// <returns>ModelTemplateResource</returns>
        ModelTemplateResource UpdateArtistTemplate (string id, ModelTemplateResource artistTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MediaArtistsApi : IMediaArtistsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaArtistsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MediaArtistsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaArtistsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaArtistsApi(String basePath)
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
        /// Adds a new artist in the system Adds a new artist in the system. Use specific media contributions endpoint to add contributions
        /// </summary>
        /// <param name="artistResource">The new artist</param> 
        /// <returns>ModelArtistResource</returns>            
        public ModelArtistResource AddArtist (ModelArtistResource artistResource)
        {
            
    
            var path = "/media/artists";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(artistResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddArtist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddArtist: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelArtistResource) ApiClient.Deserialize(response.Content, typeof(ModelArtistResource), response.Headers);
        }
    
        /// <summary>
        /// Create an artist template Artist Templates define a type of artist and the properties they have
        /// </summary>
        /// <param name="artistTemplateResource">The artist template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource CreateArtistTemplate (ModelTemplateResource artistTemplateResource)
        {
            
    
            var path = "/media/artists/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(artistTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArtistTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateArtistTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Removes an artist from the system IF no resources are attached to it 
        /// </summary>
        /// <param name="id">The artist id</param> 
        /// <returns></returns>            
        public void DeleteArtist (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteArtist");
            
    
            var path = "/media/artists/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArtist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArtist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an artist template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteArtistTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteArtistTemplate");
            
    
            var path = "/media/artists/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArtistTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteArtistTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Loads a specific artist details 
        /// </summary>
        /// <param name="id">The artist id</param> 
        /// <param name="showContributions">The number of contributions to show fetch</param> 
        /// <returns>ModelArtistResource</returns>            
        public ModelArtistResource GetArtist (long? id, int? showContributions)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetArtist");
            
    
            var path = "/media/artists/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showContributions != null) queryParams.Add("show_contributions", ApiClient.ParameterToString(showContributions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtist: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelArtistResource) ApiClient.Deserialize(response.Content, typeof(ModelArtistResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single artist template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource GetArtistTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetArtistTemplate");
            
    
            var path = "/media/artists/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtistTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtistTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search artist templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceTemplateResource</returns>            
        public ModelPageResourceTemplateResource GetArtistTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/media/artists/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtistTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtistTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Search for artists 
        /// </summary>
        /// <param name="filterArtistsByName">Filter for artists which name *STARTS* with the given string</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceArtistResource</returns>            
        public ModelPageResourceArtistResource GetArtists (string filterArtistsByName, int? size, int? page, string order)
        {
            
    
            var path = "/media/artists";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterArtistsByName != null) queryParams.Add("filter_artists_by_name", ApiClient.ParameterToString(filterArtistsByName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtists: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetArtists: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceArtistResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceArtistResource), response.Headers);
        }
    
        /// <summary>
        /// Modifies an artist details 
        /// </summary>
        /// <param name="id">The artist id</param> 
        /// <param name="artistResource">The new artist</param> 
        /// <returns></returns>            
        public void UpdateArtist (long? id, ModelArtistResource artistResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateArtist");
            
    
            var path = "/media/artists/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(artistResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArtist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArtist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an artist template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="artistTemplateResource">The artist template resource object</param> 
        /// <returns>ModelTemplateResource</returns>            
        public ModelTemplateResource UpdateArtistTemplate (string id, ModelTemplateResource artistTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateArtistTemplate");
            
    
            var path = "/media/artists/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(artistTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArtistTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateArtistTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelTemplateResource) ApiClient.Deserialize(response.Content, typeof(ModelTemplateResource), response.Headers);
        }
    
    }
}
