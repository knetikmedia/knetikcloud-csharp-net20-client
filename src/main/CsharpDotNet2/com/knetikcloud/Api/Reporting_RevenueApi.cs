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
    public interface IReporting_RevenueApi
    {
        /// <summary>
        /// Get item revenue info Get basic info about revenue from sales of items and bundles (not subscriptions, shipping, etc), summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <returns>RevenueReportResource</returns>
        RevenueReportResource GetItemRevenue (string currencyCode, long? startDate, long? endDate);
        /// <summary>
        /// Get refund revenue info Get basic info about revenue loss from refunds (for all item types), summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get refund data for</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <returns>RevenueReportResource</returns>
        RevenueReportResource GetRefundRevenue (string currencyCode, long? startDate, long? endDate);
        /// <summary>
        /// Get revenue info by country Get basic info about revenue from sales of all types, summed up within a time range and split out by country. Sorted for largest revenue at the top. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceRevenueCountryReportResource</returns>
        PageResourceRevenueCountryReportResource GetRevenueByCountry (string currencyCode, long? startDate, long? endDate, int? size, int? page);
        /// <summary>
        /// Get revenue info by item Get basic info about revenue from sales of all types, summed up within a time range and split out by specific item. Sorted for largest revenue at the top. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <returns>PageResourceRevenueProductReportResource</returns>
        PageResourceRevenueProductReportResource GetRevenueByItem (string currencyCode, long? startDate, long? endDate, int? size, int? page);
        /// <summary>
        /// Get subscription revenue info Get basic info about revenue from sales of new subscriptions as well as recurring payemnts, summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param>
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param>
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param>
        /// <returns>RevenueReportResource</returns>
        RevenueReportResource GetSubscriptionRevenue (string currencyCode, long? startDate, long? endDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Reporting_RevenueApi : IReporting_RevenueApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reporting_RevenueApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Reporting_RevenueApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Reporting_RevenueApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Reporting_RevenueApi(String basePath)
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
        /// Get item revenue info Get basic info about revenue from sales of items and bundles (not subscriptions, shipping, etc), summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <returns>RevenueReportResource</returns>            
        public RevenueReportResource GetItemRevenue (string currencyCode, long? startDate, long? endDate)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetItemRevenue");
            
    
            var path = "/reporting/revenue/item-sales/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemRevenue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetItemRevenue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RevenueReportResource) ApiClient.Deserialize(response.Content, typeof(RevenueReportResource), response.Headers);
        }
    
        /// <summary>
        /// Get refund revenue info Get basic info about revenue loss from refunds (for all item types), summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get refund data for</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <returns>RevenueReportResource</returns>            
        public RevenueReportResource GetRefundRevenue (string currencyCode, long? startDate, long? endDate)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetRefundRevenue");
            
    
            var path = "/reporting/revenue/refunds/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRefundRevenue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRefundRevenue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RevenueReportResource) ApiClient.Deserialize(response.Content, typeof(RevenueReportResource), response.Headers);
        }
    
        /// <summary>
        /// Get revenue info by country Get basic info about revenue from sales of all types, summed up within a time range and split out by country. Sorted for largest revenue at the top. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceRevenueCountryReportResource</returns>            
        public PageResourceRevenueCountryReportResource GetRevenueByCountry (string currencyCode, long? startDate, long? endDate, int? size, int? page)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetRevenueByCountry");
            
    
            var path = "/reporting/revenue/countries/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRevenueByCountry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRevenueByCountry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceRevenueCountryReportResource) ApiClient.Deserialize(response.Content, typeof(PageResourceRevenueCountryReportResource), response.Headers);
        }
    
        /// <summary>
        /// Get revenue info by item Get basic info about revenue from sales of all types, summed up within a time range and split out by specific item. Sorted for largest revenue at the top. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <returns>PageResourceRevenueProductReportResource</returns>            
        public PageResourceRevenueProductReportResource GetRevenueByItem (string currencyCode, long? startDate, long? endDate, int? size, int? page)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetRevenueByItem");
            
    
            var path = "/reporting/revenue/products/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRevenueByItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRevenueByItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceRevenueProductReportResource) ApiClient.Deserialize(response.Content, typeof(PageResourceRevenueProductReportResource), response.Headers);
        }
    
        /// <summary>
        /// Get subscription revenue info Get basic info about revenue from sales of new subscriptions as well as recurring payemnts, summed up within a time range. &lt;br&gt;&lt;br&gt;&lt;b&gt;Permissions Needed:&lt;/b&gt; REPORTING_REVENUE_ADMIN
        /// </summary>
        /// <param name="currencyCode">The code for a currency to get sales data for</param> 
        /// <param name="startDate">The start of the time range to aggregate, unix timestamp in seconds. Default is beginning of time</param> 
        /// <param name="endDate">The end of the time range to aggregate, unix timestamp in seconds. Default is end of time</param> 
        /// <returns>RevenueReportResource</returns>            
        public RevenueReportResource GetSubscriptionRevenue (string currencyCode, long? startDate, long? endDate)
        {
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetSubscriptionRevenue");
            
    
            var path = "/reporting/revenue/subscription-sales/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("start_date", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("end_date", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2_client_credentials_grant", "oauth2_password_grant" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionRevenue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptionRevenue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RevenueReportResource) ApiClient.Deserialize(response.Content, typeof(RevenueReportResource), response.Headers);
        }
    
    }
}
