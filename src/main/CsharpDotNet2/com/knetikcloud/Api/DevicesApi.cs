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
        /// Add device users &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="userResources">userResources</param>
        /// <param name="id">id</param>
        /// <returns>DeviceResource</returns>
        DeviceResource AddDeviceUsers (List<SimpleUserResource> userResources, string id);
        /// <summary>
        /// Create a device &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="device">device</param>
        /// <returns>DeviceResource</returns>
        DeviceResource CreateDevice (DeviceResource device);
        /// <summary>
        /// Create a device template Device Templates define a type of device and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="deviceTemplateResource">The device template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource CreateDeviceTemplate (TemplateResource deviceTemplateResource);
        /// <summary>
        /// Delete a device &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        void DeleteDevice (string id);
        /// <summary>
        /// Delete an device template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">The value needed to delete used templates</param>
        /// <returns></returns>
        void DeleteDeviceTemplate (string id, string cascade);
        /// <summary>
        /// Delete a device user &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the device</param>
        /// <param name="userId">The user id of the device user</param>
        /// <returns></returns>
        void DeleteDeviceUser (string id, int? userId);
        /// <summary>
        /// Delete all device users &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the device</param>
        /// <param name="filterId">Filter for device users to delete with a user id in a given comma separated list of ids</param>
        /// <returns></returns>
        void DeleteDeviceUsers (string id, string filterId);
        /// <summary>
        /// Get a single device &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>DeviceResource</returns>
        DeviceResource GetDevice (string id);
        /// <summary>
        /// Get a single device template &lt;b&gt;Permissions Needed:&lt;/b&gt; description
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>TemplateResource</returns>
        TemplateResource GetDeviceTemplate (string id);
        /// <summary>
        /// List and search device templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or DEVICES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceTemplateResource</returns>
        PageResourceTemplateResource GetDeviceTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search devices Get a list of devices with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or user
        /// </summary>
        /// <param name="filterMake">Filter for devices with specified make</param>
        /// <param name="filterModel">Filter for devices with specified model</param>
        /// <param name="filterOs">Filter for devices with specified OS</param>
        /// <param name="filterSerial">Filter for devices with specified serial</param>
        /// <param name="filterType">Filter for devices with specified type</param>
        /// <param name="filterTag">A comma separated list without spaces to filter for devices with specified tags (matches any)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceDeviceResource</returns>
        PageResourceDeviceResource GetDevices (string filterMake, string filterModel, string filterOs, string filterSerial, string filterType, string filterTag, int? size, int? page, string order);
        /// <summary>
        /// Update a device &lt;b&gt;Permissions Needed:&lt;/b&gt; CUSTOMERS_ADMIN
        /// </summary>
        /// <param name="device">device</param>
        /// <param name="id">id</param>
        /// <returns>DeviceResource</returns>
        DeviceResource UpdateDevice (DeviceResource device, string id);
        /// <summary>
        /// Update an device template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="deviceTemplateResource">The device template resource object</param>
        /// <returns>TemplateResource</returns>
        TemplateResource UpdateDeviceTemplate (string id, TemplateResource deviceTemplateResource);
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
        /// Add device users &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="userResources">userResources</param> 
        /// <param name="id">id</param> 
        /// <returns>DeviceResource</returns>            
        public DeviceResource AddDeviceUsers (List<SimpleUserResource> userResources, string id)
        {
            
            // verify the required parameter 'userResources' is set
            if (userResources == null) throw new ApiException(400, "Missing required parameter 'userResources' when calling AddDeviceUsers");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddDeviceUsers");
            
    
            var path = "/devices/{id}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(userResources); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDeviceUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDeviceUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DeviceResource) ApiClient.Deserialize(response.Content, typeof(DeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Create a device &lt;b&gt;Permissions Needed:&lt;/b&gt; ANY
        /// </summary>
        /// <param name="device">device</param> 
        /// <returns>DeviceResource</returns>            
        public DeviceResource CreateDevice (DeviceResource device)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DeviceResource) ApiClient.Deserialize(response.Content, typeof(DeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Create a device template Device Templates define a type of device and the properties they have. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="deviceTemplateResource">The device template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource CreateDeviceTemplate (TemplateResource deviceTemplateResource)
        {
            
    
            var path = "/devices/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(deviceTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDeviceTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDeviceTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a device &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns></returns>            
        public void DeleteDevice (string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an device template If cascade &#x3D; &#39;detach&#39;, it will force delete the template even if it&#39;s attached to other objects. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">The value needed to delete used templates</param> 
        /// <returns></returns>            
        public void DeleteDeviceTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDeviceTemplate");
            
    
            var path = "/devices/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a device user &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the device</param> 
        /// <param name="userId">The user id of the device user</param> 
        /// <returns></returns>            
        public void DeleteDeviceUser (string id, int? userId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDeviceUser");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling DeleteDeviceUser");
            
    
            var path = "/devices/{id}/users/{user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete all device users &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">The id of the device</param> 
        /// <param name="filterId">Filter for device users to delete with a user id in a given comma separated list of ids</param> 
        /// <returns></returns>            
        public void DeleteDeviceUsers (string id, string filterId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDeviceUsers");
            
    
            var path = "/devices/{id}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterId != null) queryParams.Add("filter_id", ApiClient.ParameterToString(filterId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDeviceUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single device &lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or owner
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>DeviceResource</returns>            
        public DeviceResource GetDevice (string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DeviceResource) ApiClient.Deserialize(response.Content, typeof(DeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single device template &lt;b&gt;Permissions Needed:&lt;/b&gt; description
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource GetDeviceTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDeviceTemplate");
            
    
            var path = "/devices/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeviceTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeviceTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search device templates &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN or DEVICES_ADMIN
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceTemplateResource</returns>            
        public PageResourceTemplateResource GetDeviceTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/devices/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeviceTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeviceTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search devices Get a list of devices with optional filtering. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; DEVICES_ADMIN or user
        /// </summary>
        /// <param name="filterMake">Filter for devices with specified make</param> 
        /// <param name="filterModel">Filter for devices with specified model</param> 
        /// <param name="filterOs">Filter for devices with specified OS</param> 
        /// <param name="filterSerial">Filter for devices with specified serial</param> 
        /// <param name="filterType">Filter for devices with specified type</param> 
        /// <param name="filterTag">A comma separated list without spaces to filter for devices with specified tags (matches any)</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceDeviceResource</returns>            
        public PageResourceDeviceResource GetDevices (string filterMake, string filterModel, string filterOs, string filterSerial, string filterType, string filterTag, int? size, int? page, string order)
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
 if (filterOs != null) queryParams.Add("filter_os", ApiClient.ParameterToString(filterOs)); // query parameter
 if (filterSerial != null) queryParams.Add("filter_serial", ApiClient.ParameterToString(filterSerial)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterTag != null) queryParams.Add("filter_tag", ApiClient.ParameterToString(filterTag)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDevices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceDeviceResource) ApiClient.Deserialize(response.Content, typeof(PageResourceDeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Update a device &lt;b&gt;Permissions Needed:&lt;/b&gt; CUSTOMERS_ADMIN
        /// </summary>
        /// <param name="device">device</param> 
        /// <param name="id">id</param> 
        /// <returns>DeviceResource</returns>            
        public DeviceResource UpdateDevice (DeviceResource device, string id)
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
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDevice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DeviceResource) ApiClient.Deserialize(response.Content, typeof(DeviceResource), response.Headers);
        }
    
        /// <summary>
        /// Update an device template &lt;b&gt;Permissions Needed:&lt;/b&gt; TEMPLATE_ADMIN
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="deviceTemplateResource">The device template resource object</param> 
        /// <returns>TemplateResource</returns>            
        public TemplateResource UpdateDeviceTemplate (string id, TemplateResource deviceTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDeviceTemplate");
            
    
            var path = "/devices/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(deviceTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDeviceTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDeviceTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TemplateResource) ApiClient.Deserialize(response.Content, typeof(TemplateResource), response.Headers);
        }
    
    }
}
