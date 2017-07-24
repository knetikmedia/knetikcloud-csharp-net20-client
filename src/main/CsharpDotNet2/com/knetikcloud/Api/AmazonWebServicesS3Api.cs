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
    public interface IAmazonWebServicesS3Api
    {
        /// <summary>
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <param name="filename">The file name</param>
        /// <param name="contentType">The content type</param>
        /// <returns>AmazonS3Activity</returns>
        AmazonS3Activity GetSignedS3URL (string filename, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AmazonWebServicesS3Api : IAmazonWebServicesS3Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonWebServicesS3Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AmazonWebServicesS3Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonWebServicesS3Api"/> class.
        /// </summary>
        /// <returns></returns>
        public AmazonWebServicesS3Api(String basePath)
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
        /// Get a signed S3 URL Requires the file name and file content type (i.e., &#39;video/mpeg&#39;)
        /// </summary>
        /// <param name="filename">The file name</param> 
        /// <param name="contentType">The content type</param> 
        /// <returns>AmazonS3Activity</returns>            
        public AmazonS3Activity GetSignedS3URL (string filename, string contentType)
        {
            
    
            var path = "/amazon/s3/signedposturl";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
 if (contentType != null) queryParams.Add("content_type", ApiClient.ParameterToString(contentType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSignedS3URL: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSignedS3URL: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AmazonS3Activity) ApiClient.Deserialize(response.Content, typeof(AmazonS3Activity), response.Headers);
        }
    
    }
}
