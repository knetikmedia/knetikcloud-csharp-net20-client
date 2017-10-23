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
    public interface IReportingOrdersApi
    {
        /// <summary>
        /// Retrieve invoice counts aggregated by time ranges 
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="granularity">The time duration to aggregate by</param>
        /// <param name="filterPaymentStatus">A payment status to filter results by, can be a comma separated list</param>
        /// <param name="filterFulfillmentStatus">An invoice fulfillment status to filter results by, can be a comma separated list</param>
        /// <param name="startDate">The start of the time range to return, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to return, unix timestamp in seconds. Default is end of time</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <returns>PageResourceAggregateInvoiceReportResource</returns>
        PageResourceAggregateInvoiceReportResource GetInvoiceReports (string currencyCode, string granularity, string filterPaymentStatus, string filterFulfillmentStatus, long? startDate, long? endDate, int? size, int? page);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportingOrdersApi : IReportingOrdersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingOrdersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportingOrdersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingOrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportingOrdersApi(String basePath)
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
        /// Retrieve invoice counts aggregated by time ranges 
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param> 
        /// <param name="granularity">The time duration to aggregate by</param> 
        /// <param name="filterPaymentStatus">A payment status to filter results by, can be a comma separated list</param> 
        /// <param name="filterFulfillmentStatus">An invoice fulfillment status to filter results by, can be a comma separated list</param> 
        /// <param name="startDate">The start of the time range to return, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to return, unix timestamp in seconds. Default is end of time</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <returns>PageResourceAggregateInvoiceReportResource</returns>            
        public PageResourceAggregateInvoiceReportResource GetInvoiceReports (string currencyCode, string granularity, string filterPaymentStatus, string filterFulfillmentStatus, long? startDate, long? endDate, int? size, int? page)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetInvoiceReports");
            
    
            var path = "/reporting/orders/count/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (granularity != null) queryParams.Add("granularity", ApiClient.ParameterToString(granularity)); // query parameter
 if (filterPaymentStatus != null) queryParams.Add("filter_payment_status", ApiClient.ParameterToString(filterPaymentStatus)); // query parameter
 if (filterFulfillmentStatus != null) queryParams.Add("filter_fulfillment_status", ApiClient.ParameterToString(filterFulfillmentStatus)); // query parameter
 if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInvoiceReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceAggregateInvoiceReportResource) ApiClient.Deserialize(response.Content, typeof(PageResourceAggregateInvoiceReportResource), response.Headers);
        }
    
    }
}
