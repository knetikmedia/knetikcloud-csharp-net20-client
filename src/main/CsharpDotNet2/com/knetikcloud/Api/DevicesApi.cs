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
    public interface IDevicesApi
    {
        /// <summary>
        /// Create a device 
        /// </summary>
        /// <param name="device">device</param>
        /// <returns>ModelDeviceResource</returns>
        ModelDeviceResource CreateDevice (ModelDeviceResource device);
        /// <summary>
        /// Delete a device 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        void DeleteDevice (int? id);
        /// <summary>
        /// Get a single device 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ModelDeviceResource</returns>
        ModelDeviceResource GetDevice (int? id);
        /// <summary>
        /// List and search devices Get a list of devices with optional filtering
        /// </summary>
        /// <param name="filterMake">Filter for devices with specified make</param>
        /// <param name="filterModel">Filter for devices with specified model</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceDeviceResource</returns>
        ModelPageResourceDeviceResource GetDevices (string filterMake, string filterModel, int? size, int? page, string order);
        /// <summary>
        /// Update a device 
        /// </summary>
        /// <param name="device">device</param>
        /// <param name="id">id</param>
        /// <returns>ModelDeviceResource</returns>
        ModelDeviceResource UpdateDevice (ModelDeviceResource device, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DevicesApi : IDevicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DevicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DevicesApi(String basePath)
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
        /// Create a device 
        /// </summary>
        /// <param name="device">device</param> 
        /// <returns>ModelDeviceResource</returns>            
        public ModelDeviceResource CreateDevice (ModelDeviceResource device)
        {
            
            // verify the required parameter 'device' is set
            if (device == null) throw new ApiException(400, "Missing required parameter 'device' when calling CreateDevice");
            
    
            var path = "/devices";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(device); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDeviceResource) ApiClient.Deserialize(response.Content, typeof(ModelDeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a device 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns></returns>            
        public void DeleteDevice (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDevice");
            
    
            var path = "/devices/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single device 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ModelDeviceResource</returns>            
        public ModelDeviceResource GetDevice (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDevice");
            
    
            var path = "/devices/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDeviceResource) ApiClient.Deserialize(response.Content, typeof(ModelDeviceResource), response.Headers);
        }
    
        /// <summary>
        /// List and search devices Get a list of devices with optional filtering
        /// </summary>
        /// <param name="filterMake">Filter for devices with specified make</param> 
        /// <param name="filterModel">Filter for devices with specified model</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceDeviceResource</returns>            
        public ModelPageResourceDeviceResource GetDevices (string filterMake, string filterModel, int? size, int? page, string order)
        {
            
    
            var path = "/devices";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterMake != null) queryParams.Add("filter_make", ApiClient.ParameterToString(filterMake)); // query parameter
 if (filterModel != null) queryParams.Add("filter_model", ApiClient.ParameterToString(filterModel)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceDeviceResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceDeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Update a device 
        /// </summary>
        /// <param name="device">device</param> 
        /// <param name="id">id</param> 
        /// <returns>ModelDeviceResource</returns>            
        public ModelDeviceResource UpdateDevice (ModelDeviceResource device, int? id)
        {
            
            // verify the required parameter 'device' is set
            if (device == null) throw new ApiException(400, "Missing required parameter 'device' when calling UpdateDevice");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDevice");
            
    
            var path = "/devices/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(device); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelDeviceResource) ApiClient.Deserialize(response.Content, typeof(ModelDeviceResource), response.Headers);
        }
    
    }
}
