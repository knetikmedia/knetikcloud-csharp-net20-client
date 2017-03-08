using System;
using System.Collections.Generic;
using RestSharp;
using com.knetikcloud.client.Client;
using com.knetikcloud.client.Model;

namespace com.knetikcloud.client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsWalletsApi
    {
        /// <summary>
        /// Returns the user&#39;s wallet for the given currency code 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet is being retrieved</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <returns>SimpleWallet</returns>
        SimpleWallet GetUserWallet (int? userId, string currencyCode);
        /// <summary>
        /// Retrieve a user&#39;s wallet transactions 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet transactions are being retrieved</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <param name="filterType">Filter for transactions with specified type</param>
        /// <param name="filterMaxDate">Filter for transactions from no earlier than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterMinDate">Filter for transactions from no later than the specified date as a unix timestamp in seconds</param>
        /// <param name="filterSign">Filter for transactions with amount with the given sign.  Allowable values: (&#39;positive&#39;, &#39;negative&#39;)</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceWalletTransactionResource</returns>
        PageResourceWalletTransactionResource GetUserWalletTransactions (int? userId, string currencyCode, string filterType, long? filterMaxDate, long? filterMinDate, string filterSign, int? size, int? page, string order);
        /// <summary>
        /// List all of a user&#39;s wallets 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallets are being retrieved</param>
        /// <returns>List&lt;SimpleWallet&gt;</returns>
        List<SimpleWallet> GetUserWallets (int? userId);
        /// <summary>
        /// Retrieves a summation of wallet balances by currency code 
        /// </summary>
        /// <returns>PageResourceWalletTotalResponse</returns>
        PageResourceWalletTotalResponse GetWalletBalances ();
        /// <summary>
        /// Retrieve wallet transactions across the system 
        /// </summary>
        /// <param name="filterInvoice">Filter for transactions from a specific invoice</param>
        /// <param name="filterType">Filter for transactions with specified type</param>
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param>
        /// <param name="filterSign">Filter for transactions with amount with the given sign</param>
        /// <param name="filterUserId">Filter for transactions for specific userId</param>
        /// <param name="filterUsername">Filter for transactions for specific username that start with the given string</param>
        /// <param name="filterDetails">Filter for transactions for specific details that start with the given string</param>
        /// <param name="filterCurrencyCode">Filter for transactions for specific currency code</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceWalletTransactionResource</returns>
        PageResourceWalletTransactionResource GetWalletTransactions (int? filterInvoice, string filterType, string filterDate, string filterSign, int? filterUserId, string filterUsername, string filterDetails, string filterCurrencyCode, int? size, int? page, string order);
        /// <summary>
        /// Retrieve a list of wallets across the system 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned, starting with 1</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>PageResourceSimpleWallet</returns>
        PageResourceSimpleWallet GetWallets (int? size, int? page, string order);
        /// <summary>
        /// Updates the balance for a user&#39;s wallet 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet is being modified</param>
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param>
        /// <param name="request">The requested balance modification to be made to the user&#39;s wallet</param>
        /// <returns>WalletTransactionResource</returns>
        WalletTransactionResource UpdateWalletBalance (int? userId, string currencyCode, WalletAlterRequest request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsWalletsApi : IPaymentsWalletsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsWalletsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsWalletsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsWalletsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsWalletsApi(String basePath)
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
        /// Returns the user&#39;s wallet for the given currency code 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet is being retrieved</param> 
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param> 
        /// <returns>SimpleWallet</returns>            
        public SimpleWallet GetUserWallet (int? userId, string currencyCode)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserWallet");
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetUserWallet");
            
    
            var path = "/users/{user_id}/wallets/{currency_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWallet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWallet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleWallet) ApiClient.Deserialize(response.Content, typeof(SimpleWallet), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a user&#39;s wallet transactions 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet transactions are being retrieved</param> 
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param> 
        /// <param name="filterType">Filter for transactions with specified type</param> 
        /// <param name="filterMaxDate">Filter for transactions from no earlier than the specified date as a unix timestamp in seconds</param> 
        /// <param name="filterMinDate">Filter for transactions from no later than the specified date as a unix timestamp in seconds</param> 
        /// <param name="filterSign">Filter for transactions with amount with the given sign.  Allowable values: (&#39;positive&#39;, &#39;negative&#39;)</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceWalletTransactionResource</returns>            
        public PageResourceWalletTransactionResource GetUserWalletTransactions (int? userId, string currencyCode, string filterType, long? filterMaxDate, long? filterMinDate, string filterSign, int? size, int? page, string order)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserWalletTransactions");
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling GetUserWalletTransactions");
            
    
            var path = "/users/{user_id}/wallets/{currency_code}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterMaxDate != null) queryParams.Add("filter_max_date", ApiClient.ParameterToString(filterMaxDate)); // query parameter
 if (filterMinDate != null) queryParams.Add("filter_min_date", ApiClient.ParameterToString(filterMinDate)); // query parameter
 if (filterSign != null) queryParams.Add("filter_sign", ApiClient.ParameterToString(filterSign)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWalletTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWalletTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceWalletTransactionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceWalletTransactionResource), response.Headers);
        }
    
        /// <summary>
        /// List all of a user&#39;s wallets 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallets are being retrieved</param> 
        /// <returns>List&lt;SimpleWallet&gt;</returns>            
        public List<SimpleWallet> GetUserWallets (int? userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserWallets");
            
    
            var path = "/users/{user_id}/wallets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWallets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserWallets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleWallet>) ApiClient.Deserialize(response.Content, typeof(List<SimpleWallet>), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a summation of wallet balances by currency code 
        /// </summary>
        /// <returns>PageResourceWalletTotalResponse</returns>            
        public PageResourceWalletTotalResponse GetWalletBalances ()
        {
            
    
            var path = "/wallets/totals";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWalletBalances: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWalletBalances: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceWalletTotalResponse) ApiClient.Deserialize(response.Content, typeof(PageResourceWalletTotalResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieve wallet transactions across the system 
        /// </summary>
        /// <param name="filterInvoice">Filter for transactions from a specific invoice</param> 
        /// <param name="filterType">Filter for transactions with specified type</param> 
        /// <param name="filterDate">A comma separated string without spaces.  First value is the operator to search on, second value is the log start date, a unix timestamp in seconds. Can be repeated for a range, eg: GT,123,LT,456  Allowed operators: (GT, LT, EQ, GOE, LOE).</param> 
        /// <param name="filterSign">Filter for transactions with amount with the given sign</param> 
        /// <param name="filterUserId">Filter for transactions for specific userId</param> 
        /// <param name="filterUsername">Filter for transactions for specific username that start with the given string</param> 
        /// <param name="filterDetails">Filter for transactions for specific details that start with the given string</param> 
        /// <param name="filterCurrencyCode">Filter for transactions for specific currency code</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceWalletTransactionResource</returns>            
        public PageResourceWalletTransactionResource GetWalletTransactions (int? filterInvoice, string filterType, string filterDate, string filterSign, int? filterUserId, string filterUsername, string filterDetails, string filterCurrencyCode, int? size, int? page, string order)
        {
            
    
            var path = "/wallets/transactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterInvoice != null) queryParams.Add("filter_invoice", ApiClient.ParameterToString(filterInvoice)); // query parameter
 if (filterType != null) queryParams.Add("filter_type", ApiClient.ParameterToString(filterType)); // query parameter
 if (filterDate != null) queryParams.Add("filter_date", ApiClient.ParameterToString(filterDate)); // query parameter
 if (filterSign != null) queryParams.Add("filter_sign", ApiClient.ParameterToString(filterSign)); // query parameter
 if (filterUserId != null) queryParams.Add("filter_user_id", ApiClient.ParameterToString(filterUserId)); // query parameter
 if (filterUsername != null) queryParams.Add("filter_username", ApiClient.ParameterToString(filterUsername)); // query parameter
 if (filterDetails != null) queryParams.Add("filter_details", ApiClient.ParameterToString(filterDetails)); // query parameter
 if (filterCurrencyCode != null) queryParams.Add("filter_currency_code", ApiClient.ParameterToString(filterCurrencyCode)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWalletTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWalletTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceWalletTransactionResource) ApiClient.Deserialize(response.Content, typeof(PageResourceWalletTransactionResource), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a list of wallets across the system 
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned, starting with 1</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>PageResourceSimpleWallet</returns>            
        public PageResourceSimpleWallet GetWallets (int? size, int? page, string order)
        {
            
    
            var path = "/wallets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWallets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWallets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PageResourceSimpleWallet) ApiClient.Deserialize(response.Content, typeof(PageResourceSimpleWallet), response.Headers);
        }
    
        /// <summary>
        /// Updates the balance for a user&#39;s wallet 
        /// </summary>
        /// <param name="userId">The ID of the user for whom wallet is being modified</param> 
        /// <param name="currencyCode">Currency code of the user&#39;s wallet</param> 
        /// <param name="request">The requested balance modification to be made to the user&#39;s wallet</param> 
        /// <returns>WalletTransactionResource</returns>            
        public WalletTransactionResource UpdateWalletBalance (int? userId, string currencyCode, WalletAlterRequest request)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateWalletBalance");
            
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null) throw new ApiException(400, "Missing required parameter 'currencyCode' when calling UpdateWalletBalance");
            
    
            var path = "/users/{user_id}/wallets/{currency_code}/balance";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "user_id" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "currency_code" + "}", ApiClient.ParameterToString(currencyCode));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWalletBalance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWalletBalance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WalletTransactionResource) ApiClient.Deserialize(response.Content, typeof(WalletTransactionResource), response.Headers);
        }
    
    }
}
