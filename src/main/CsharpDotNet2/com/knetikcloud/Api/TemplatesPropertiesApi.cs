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
    public interface ITemplatesPropertiesApi
    {
        /// <summary>
        /// Get details for a template property type 
        /// </summary>
        /// <param name="type">type</param>
        /// <returns>PropertyFieldListResource</returns>
        PropertyFieldListResource GetTemplatePropertyType (string type);
        /// <summary>
        /// List template property types 
        /// </summary>
        /// <returns>List&lt;PropertyFieldListResource&gt;</returns>
        List<PropertyFieldListResource> GetTemplatePropertyTypes ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TemplatesPropertiesApi : ITemplatesPropertiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesPropertiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TemplatesPropertiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesPropertiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplatesPropertiesApi(String basePath)
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
        /// Get details for a template property type 
        /// </summary>
        /// <param name="type">type</param> 
        /// <returns>PropertyFieldListResource</returns>            
        public PropertyFieldListResource GetTemplatePropertyType (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetTemplatePropertyType");
            
    
            var path = "/templates/properties/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplatePropertyType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplatePropertyType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PropertyFieldListResource) ApiClient.Deserialize(response.Content, typeof(PropertyFieldListResource), response.Headers);
        }
    
        /// <summary>
        /// List template property types 
        /// </summary>
        /// <returns>List&lt;PropertyFieldListResource&gt;</returns>            
        public List<PropertyFieldListResource> GetTemplatePropertyTypes ()
        {
            
    
            var path = "/templates/properties";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplatePropertyTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplatePropertyTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PropertyFieldListResource>) ApiClient.Deserialize(response.Content, typeof(List<PropertyFieldListResource>), response.Headers);
        }
    
    }
}
