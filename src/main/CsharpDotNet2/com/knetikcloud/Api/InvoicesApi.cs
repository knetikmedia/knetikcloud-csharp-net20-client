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
    public interface IInvoicesApi
    {
        /// <summary>
        /// Create an invoice Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor.
        /// </summary>
        /// <param name="req">Invoice to be created</param>
        /// <returns>List&lt;InvoiceResource&gt;</returns>
        List<InvoiceResource> CreateInvoice (InvoiceCreateRequest req);
        /// <summary>
        /// Lists available fulfillment statuses 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetFulFillmentStatuses ();
        /// <summary>
        /// Retrieve an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <returns>InvoiceResource</returns>
        InvoiceResource GetInvoice (int? id);
        /// <summary>
        /// List invoice logs 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceInvoiceLogEntry</returns>
        PageResourceInvoiceLogEntry GetInvoiceLogs (int? id, int? size, int? page);
        /// <summary>
        /// Retrieve invoices Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user&#39;s invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices.
        /// </summary>
        /// <param name="filterUser">The id of a user to get invoices for. Automtically added if not being called with admin permissions.</param>
        /// <param name="filterEmail">Filters invoices by customer&#39;s email. Admins only.</param>
        /// <param name="filterFulfillmentStatus">Filters invoices by fulfillment status type. Can be a comma separated list of statuses</param>
        /// <param name="filterPaymentStatus">Filters invoices by payment status type. Can be a comma separated list of statuses</param>
        /// <param name="filterItemName">Filters invoices by item name containing the given string</param>
        /// <param name="filterExternalRef">Filters invoices by external reference.</param>
        /// <param name="filterCreatedDate">Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874</param>
        /// <param name="filterVendorIds">Filters invoices for ones from one of the vendors whose id is in the given comma separated list</param>
        /// <param name="filterCurrency">Filters invoices by currency. ISO3 currency code</param>
        /// <param name="filterShippingStateName">Filters invoices by shipping address: Exact match state name</param>
        /// <param name="filterShippingCountryName">Filters invoices by shipping address: Exact match country name</param>
        /// <param name="filterShipping">Filters invoices by shipping price</param>
        /// <param name="filterVendorName">Filters invoices by vendor name starting with given string</param>
        /// <param name="filterSku">Filters invoices by item sku</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceInvoiceResource</returns>
        PageResourceInvoiceResource GetInvoices (int? filterUser, string filterEmail, string filterFulfillmentStatus, string filterPaymentStatus, string filterItemName, string filterExternalRef, string filterCreatedDate, string filterVendorIds, string filterCurrency, string filterShippingStateName, string filterShippingCountryName, float? filterShipping, string filterVendorName, string filterSku, int? size, int? page, string order);
        /// <summary>
        /// Lists available payment statuses 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetPaymentStatuses ();
        /// <summary>
        /// Trigger payment of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="request">Payment info</param>
        /// <returns></returns>
        void PayInvoice (int? id, PayBySavedMethodRequest request);
        /// <summary>
        /// Set the external reference of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="externalRef">External reference info</param>
        /// <returns></returns>
        void SetExternalRef (int? id, string externalRef);
        /// <summary>
        /// Set the fulfillment status of an invoice item This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which.
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="sku">The sku of an item in the invoice</param>
        /// <param name="status">The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39;</param>
        /// <returns></returns>
        void SetInvoiceItemFulfillmentStatus (int? id, string sku, string status);
        /// <summary>
        /// Set the order notes of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="orderNotes">Payment status info</param>
        /// <returns></returns>
        void SetOrderNotes (int? id, string orderNotes);
        /// <summary>
        /// Set the payment status of an invoice This may trigger fulfillment if setting the status to &#39;paid&#39;. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which.
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="request">Payment status info</param>
        /// <returns></returns>
        void SetPaymentStatus (int? id, InvoicePaymentStatusRequest request);
        /// <summary>
        /// Set or update billing info 
        /// </summary>
        /// <param name="id">The id of the invoice</param>
        /// <param name="billingInfoRequest">Address info</param>
        /// <returns></returns>
        void UpdateBillingInfo (int? id, AddressResource billingInfoRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoicesApi : IInvoicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesApi(String basePath)
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
        /// Create an invoice Create an invoice(s) by providing a cart GUID. Note that there may be multiple invoices created, one per vendor.
        /// </summary>
        /// <param name="req">Invoice to be created</param> 
        /// <returns>List&lt;InvoiceResource&gt;</returns>            
        public List<InvoiceResource> CreateInvoice (InvoiceCreateRequest req)
        {
            
    
            var path = "/invoices";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(req); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<InvoiceResource>) ApiClient.Deserialize(response.Content, typeof(List<InvoiceResource>), response.Headers);
        }
    
        /// <summary>
        /// Lists available fulfillment statuses 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetFulFillmentStatuses ()
        {
            
    
            var path = "/invoices/fulfillment-statuses";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulFillmentStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFulFillmentStatuses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Retrieve an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <returns>InvoiceResource</returns>            
        public InvoiceResource GetInvoice (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetInvoice");
            
    
            var path = "/invoices/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceResource) ApiClient.Deserialize(response.Content, typeof(InvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// List invoice logs 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceInvoiceLogEntry</returns>            
        public PageResourceInvoiceLogEntry GetInvoiceLogs (int? id, int? size, int? page)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetInvoiceLogs");
            
    
            var path = "/invoices/{id}/logs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceInvoiceLogEntry) ApiClient.Deserialize(response.Content, typeof(PageResourceInvoiceLogEntry), response.Headers);
        }
    
        /// <summary>
        /// Retrieve invoices Without INVOICES_ADMIN permission the results are automatically filtered for only the logged in user&#39;s invoices. It is recomended however that filter_user be added to avoid issues for admin users accidentally getting additional invoices.
        /// </summary>
        /// <param name="filterUser">The id of a user to get invoices for. Automtically added if not being called with admin permissions.</param> 
        /// <param name="filterEmail">Filters invoices by customer&#39;s email. Admins only.</param> 
        /// <param name="filterFulfillmentStatus">Filters invoices by fulfillment status type. Can be a comma separated list of statuses</param> 
        /// <param name="filterPaymentStatus">Filters invoices by payment status type. Can be a comma separated list of statuses</param> 
        /// <param name="filterItemName">Filters invoices by item name containing the given string</param> 
        /// <param name="filterExternalRef">Filters invoices by external reference.</param> 
        /// <param name="filterCreatedDate">Filters invoices by creation date. Multiple values possible for range search. Format: filter_created_date&#x3D;OP,ts&amp;... where OP in (GT, LT, GOE, LOE, EQ) and ts is a unix timestamp in seconds. Ex: filter_created_date&#x3D;GT,1452154258,LT,1554254874</param> 
        /// <param name="filterVendorIds">Filters invoices for ones from one of the vendors whose id is in the given comma separated list</param> 
        /// <param name="filterCurrency">Filters invoices by currency. ISO3 currency code</param> 
        /// <param name="filterShippingStateName">Filters invoices by shipping address: Exact match state name</param> 
        /// <param name="filterShippingCountryName">Filters invoices by shipping address: Exact match country name</param> 
        /// <param name="filterShipping">Filters invoices by shipping price</param> 
        /// <param name="filterVendorName">Filters invoices by vendor name starting with given string</param> 
        /// <param name="filterSku">Filters invoices by item sku</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceInvoiceResource</returns>            
        public PageResourceInvoiceResource GetInvoices (int? filterUser, string filterEmail, string filterFulfillmentStatus, string filterPaymentStatus, string filterItemName, string filterExternalRef, string filterCreatedDate, string filterVendorIds, string filterCurrency, string filterShippingStateName, string filterShippingCountryName, float? filterShipping, string filterVendorName, string filterSku, int? size, int? page, string order)
        {
            
    
            var path = "/invoices";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterUser != null) queryParams.Add("filter_user", ApiClient.ParameterToString(filterUser)); // query parameter
 if (filterEmail != null) queryParams.Add("filter_email", ApiClient.ParameterToString(filterEmail)); // query parameter
 if (filterFulfillmentStatus != null) queryParams.Add("filter_fulfillment_status", ApiClient.ParameterToString(filterFulfillmentStatus)); // query parameter
 if (filterPaymentStatus != null) queryParams.Add("filter_payment_status", ApiClient.ParameterToString(filterPaymentStatus)); // query parameter
 if (filterItemName != null) queryParams.Add("filter_item_name", ApiClient.ParameterToString(filterItemName)); // query parameter
 if (filterExternalRef != null) queryParams.Add("filter_external_ref", ApiClient.ParameterToString(filterExternalRef)); // query parameter
 if (filterCreatedDate != null) queryParams.Add("filter_created_date", ApiClient.ParameterToString(filterCreatedDate)); // query parameter
 if (filterVendorIds != null) queryParams.Add("filter_vendor_ids", ApiClient.ParameterToString(filterVendorIds)); // query parameter
 if (filterCurrency != null) queryParams.Add("filter_currency", ApiClient.ParameterToString(filterCurrency)); // query parameter
 if (filterShippingStateName != null) queryParams.Add("filter_shipping_state_name", ApiClient.ParameterToString(filterShippingStateName)); // query parameter
 if (filterShippingCountryName != null) queryParams.Add("filter_shipping_country_name", ApiClient.ParameterToString(filterShippingCountryName)); // query parameter
 if (filterShipping != null) queryParams.Add("filter_shipping", ApiClient.ParameterToString(filterShipping)); // query parameter
 if (filterVendorName != null) queryParams.Add("filter_vendor_name", ApiClient.ParameterToString(filterVendorName)); // query parameter
 if (filterSku != null) queryParams.Add("filter_sku", ApiClient.ParameterToString(filterSku)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceInvoiceResource) ApiClient.Deserialize(response.Content, typeof(PageResourceInvoiceResource), response.Headers);
        }
    
        /// <summary>
        /// Lists available payment statuses 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetPaymentStatuses ()
        {
            
    
            var path = "/invoices/payment-statuses";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentStatuses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Trigger payment of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="request">Payment info</param> 
        /// <returns></returns>            
        public void PayInvoice (int? id, PayBySavedMethodRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PayInvoice");
            
    
            var path = "/invoices/{id}/payments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PayInvoice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PayInvoice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the external reference of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="externalRef">External reference info</param> 
        /// <returns></returns>            
        public void SetExternalRef (int? id, string externalRef)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetExternalRef");
            
    
            var path = "/invoices/{id}/external-ref";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(externalRef); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetExternalRef: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetExternalRef: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the fulfillment status of an invoice item This allows external fulfillment systems to report success or failure. Fulfillment status changes are restricted by a specific flow determining which status can lead to which.
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="sku">The sku of an item in the invoice</param> 
        /// <param name="status">The new fulfillment status for the item. Additional options may be available based on configuration.  Allowable values:  &#39;unfulfilled&#39;, &#39;fulfilled&#39;, &#39;not fulfillable&#39;, &#39;failed&#39;, &#39;processing&#39;, &#39;failed_permanent&#39;, &#39;delayed&#39;</param> 
        /// <returns></returns>            
        public void SetInvoiceItemFulfillmentStatus (int? id, string sku, string status)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetInvoiceItemFulfillmentStatus");
            
            // verify the required parameter 'sku' is set
            if (sku == null) throw new ApiException(400, "Missing required parameter 'sku' when calling SetInvoiceItemFulfillmentStatus");
            
            // verify the required parameter 'status' is set
            if (status == null) throw new ApiException(400, "Missing required parameter 'status' when calling SetInvoiceItemFulfillmentStatus");
            
    
            var path = "/invoices/{id}/items/{sku}/fulfillment-status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sku" + "}", ApiClient.ParameterToString(sku));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(status); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetInvoiceItemFulfillmentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetInvoiceItemFulfillmentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the order notes of an invoice 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="orderNotes">Payment status info</param> 
        /// <returns></returns>            
        public void SetOrderNotes (int? id, string orderNotes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetOrderNotes");
            
    
            var path = "/invoices/{id}/order-notes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(orderNotes); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetOrderNotes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetOrderNotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set the payment status of an invoice This may trigger fulfillment if setting the status to &#39;paid&#39;. This is mainly intended to support external payment systems that cannot be incorporated into the payment method system. Payment status changes are restricted by a specific flow determining which status can lead to which.
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="request">Payment status info</param> 
        /// <returns></returns>            
        public void SetPaymentStatus (int? id, InvoicePaymentStatusRequest request)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetPaymentStatus");
            
    
            var path = "/invoices/{id}/payment-status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPaymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPaymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set or update billing info 
        /// </summary>
        /// <param name="id">The id of the invoice</param> 
        /// <param name="billingInfoRequest">Address info</param> 
        /// <returns></returns>            
        public void UpdateBillingInfo (int? id, AddressResource billingInfoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateBillingInfo");
            
    
            var path = "/invoices/{id}/billing-address";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(billingInfoRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBillingInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBillingInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
