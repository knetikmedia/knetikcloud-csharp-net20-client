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
    public interface IAmazon_Web_Services_S3Api
    {
        /// <summary>
        /// Get a temporary signed S3 URL for download To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </summary>
        /// <param name="bucket">S3 bucket name</param>
        /// <param name="path">The path to the file relative to the bucket (the s3 object key)</param>
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60</param>
        /// <returns>string</returns>
        string GetDownloadURL (string bucket, string path, int? expiration);
        /// <summary>
        /// Get a signed S3 URL for upload Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
        /// </summary>
        /// <param name="filename">The file name</param>
        /// <param name="contentType">The content type</param>
        /// <returns>AmazonS3Activity</returns>
        AmazonS3Activity GetSignedS3URL (string filename, string contentType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Amazon_Web_Services_S3Api : IAmazon_Web_Services_S3Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon_Web_Services_S3Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Amazon_Web_Services_S3Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Amazon_Web_Services_S3Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Amazon_Web_Services_S3Api(String basePath)
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
        /// Get a temporary signed S3 URL for download To give access to files in your own S3 account, you will need to grant KnetikcCloud access to the file by adjusting your bucket policy accordingly. See S3 documentation for details. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_ADMIN
        /// </summary>
        /// <param name="bucket">S3 bucket name</param> 
        /// <param name="path">The path to the file relative to the bucket (the s3 object key)</param> 
        /// <param name="expiration">The number of seconds this URL will be valid. Default to 60</param> 
        /// <returns>string</returns>            
        public string GetDownloadURL (string bucket, string path, int? expiration)
        {
            
    
            var path = "/amazon/s3/downloadurl";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (bucket != null) queryParams.Add("bucket", ApiClient.ParameterToString(bucket)); // query parameter
 if (path != null) queryParams.Add("path", ApiClient.ParameterToString(path)); // query parameter
 if (expiration != null) queryParams.Add("expiration", ApiClient.ParameterToString(expiration)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDownloadURL: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDownloadURL: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get a signed S3 URL for upload Requires the file name and file content type (i.e., &#39;video/mpeg&#39;). Make a PUT to the resulting url to upload the file and use the cdn_url to retrieve it after. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; S3_USER or S3_ADMIN
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
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
