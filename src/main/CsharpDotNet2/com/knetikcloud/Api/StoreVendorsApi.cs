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
    public interface IStoreVendorsApi
    {
        /// <summary>
        /// Create a vendor 
        /// </summary>
        /// <param name="vendor">The vendor</param>
        /// <returns>VendorResource</returns>
        VendorResource CreateVendor (VendorResource vendor);
        /// <summary>
        /// Create a vendor template Vendor Templates define a type of vendor and the properties they have.
        /// </summary>
        /// <param name="vendorTemplateResource">The new vendor template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource CreateVendorTemplate (ItemTemplateResource vendorTemplateResource);
        /// <summary>
        /// Delete a vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param>
        /// <returns></returns>
        void DeleteVendor (int? id);
        /// <summary>
        /// Delete a vendor template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param>
        /// <returns></returns>
        void DeleteVendorTemplate (string id, string cascade);
        /// <summary>
        /// Get a single vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param>
        /// <returns>VendorResource</returns>
        VendorResource GetVendor (int? id);
        /// <summary>
        /// Get a single vendor template Vendor Templates define a type of vendor and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource GetVendorTemplate (string id);
        /// <summary>
        /// List and search vendor templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceItemTemplateResource</returns>
        PageResourceItemTemplateResource GetVendorTemplates (int? size, int? page, string order);
        /// <summary>
        /// List and search vendors 
        /// </summary>
        /// <param name="filterName">Filters vendors by name starting with the text provided in the filter</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceVendorResource</returns>
        PageResourceVendorResource GetVendors (string filterName, int? size, int? page, string order);
        /// <summary>
        /// Update a vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param>
        /// <param name="vendor">The vendor</param>
        /// <returns>VendorResource</returns>
        VendorResource UpdateVendor (int? id, VendorResource vendor);
        /// <summary>
        /// Update a vendor template 
        /// </summary>
        /// <param name="id">The id of the template</param>
        /// <param name="vendorTemplateResource">The vendor template resource object</param>
        /// <returns>ItemTemplateResource</returns>
        ItemTemplateResource UpdateVendorTemplate (string id, ItemTemplateResource vendorTemplateResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StoreVendorsApi : IStoreVendorsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreVendorsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StoreVendorsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreVendorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreVendorsApi(String basePath)
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
        /// Create a vendor 
        /// </summary>
        /// <param name="vendor">The vendor</param> 
        /// <returns>VendorResource</returns>            
        public VendorResource CreateVendor (VendorResource vendor)
        {
            
    
            var path = "/vendors";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(vendor); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVendor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVendor: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VendorResource) ApiClient.Deserialize(response.Content, typeof(VendorResource), response.Headers);
        }
    
        /// <summary>
        /// Create a vendor template Vendor Templates define a type of vendor and the properties they have.
        /// </summary>
        /// <param name="vendorTemplateResource">The new vendor template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource CreateVendorTemplate (ItemTemplateResource vendorTemplateResource)
        {
            
    
            var path = "/vendors/templates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(vendorTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVendorTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateVendorTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// Delete a vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param> 
        /// <returns></returns>            
        public void DeleteVendor (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVendor");
            
    
            var path = "/vendors/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVendor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVendor: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a vendor template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="cascade">force deleting the template if it&#39;s attached to other objects, cascade &#x3D; detach</param> 
        /// <returns></returns>            
        public void DeleteVendorTemplate (string id, string cascade)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteVendorTemplate");
            
    
            var path = "/vendors/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVendorTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteVendorTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param> 
        /// <returns>VendorResource</returns>            
        public VendorResource GetVendor (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetVendor");
            
    
            var path = "/vendors/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendor: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VendorResource) ApiClient.Deserialize(response.Content, typeof(VendorResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single vendor template Vendor Templates define a type of vendor and the properties they have.
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource GetVendorTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetVendorTemplate");
            
    
            var path = "/vendors/templates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendorTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendorTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search vendor templates 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceItemTemplateResource</returns>            
        public PageResourceItemTemplateResource GetVendorTemplates (int? size, int? page, string order)
        {
            
    
            var path = "/vendors/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendorTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendorTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(PageResourceItemTemplateResource), response.Headers);
        }
    
        /// <summary>
        /// List and search vendors 
        /// </summary>
        /// <param name="filterName">Filters vendors by name starting with the text provided in the filter</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceVendorResource</returns>            
        public PageResourceVendorResource GetVendors (string filterName, int? size, int? page, string order)
        {
            
    
            var path = "/vendors";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterName != null) queryParams.Add("filter_name", ApiClient.ParameterToString(filterName)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetVendors: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceVendorResource) ApiClient.Deserialize(response.Content, typeof(PageResourceVendorResource), response.Headers);
        }
    
        /// <summary>
        /// Update a vendor 
        /// </summary>
        /// <param name="id">The id of the vendor</param> 
        /// <param name="vendor">The vendor</param> 
        /// <returns>VendorResource</returns>            
        public VendorResource UpdateVendor (int? id, VendorResource vendor)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVendor");
            
    
            var path = "/vendors/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(vendor); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVendor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVendor: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VendorResource) ApiClient.Deserialize(response.Content, typeof(VendorResource), response.Headers);
        }
    
        /// <summary>
        /// Update a vendor template 
        /// </summary>
        /// <param name="id">The id of the template</param> 
        /// <param name="vendorTemplateResource">The vendor template resource object</param> 
        /// <returns>ItemTemplateResource</returns>            
        public ItemTemplateResource UpdateVendorTemplate (string id, ItemTemplateResource vendorTemplateResource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateVendorTemplate");
            
    
            var path = "/vendors/templates/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(vendorTemplateResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVendorTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateVendorTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ItemTemplateResource) ApiClient.Deserialize(response.Content, typeof(ItemTemplateResource), response.Headers);
        }
    
    }
}
