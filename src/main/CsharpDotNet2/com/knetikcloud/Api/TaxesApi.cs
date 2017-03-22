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
    public interface ITaxesApi
    {
        /// <summary>
        /// Create a country tax 
        /// </summary>
        /// <param name="taxResource">The tax object</param>
        /// <returns>ModelCountryTaxResource</returns>
        ModelCountryTaxResource CreateCountryTax (ModelCountryTaxResource taxResource);
        /// <summary>
        /// Create a state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="taxResource">The tax object</param>
        /// <returns>ModelStateTaxResource</returns>
        ModelStateTaxResource CreateStateTax (string countryCodeIso3, ModelStateTaxResource taxResource);
        /// <summary>
        /// Delete an existing tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns></returns>
        void DeleteCountryTax (string countryCodeIso3);
        /// <summary>
        /// Delete an existing state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <returns></returns>
        void DeleteStateTax (string countryCodeIso3, string stateCode);
        /// <summary>
        /// Get a single tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>ModelCountryTaxResource</returns>
        ModelCountryTaxResource GetCountryTax (string countryCodeIso3);
        /// <summary>
        /// List and search taxes Get a list of taxes
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceCountryTaxResource</returns>
        ModelPageResourceCountryTaxResource GetCountryTaxes (int? size, int? page, string order);
        /// <summary>
        /// Get a single state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <returns>ModelStateTaxResource</returns>
        ModelStateTaxResource GetStateTax (string countryCodeIso3, string stateCode);
        /// <summary>
        /// List and search taxes across all countries Get a list of taxes
        /// </summary>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceStateTaxResource</returns>
        ModelPageResourceStateTaxResource GetStateTaxesForCountries (int? size, int? page, string order);
        /// <summary>
        /// List and search taxes within a country Get a list of taxes
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="size">The number of objects returned per page</param>
        /// <param name="page">The number of the page returned</param>
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param>
        /// <returns>ModelPageResourceStateTaxResource</returns>
        ModelPageResourceStateTaxResource GetStateTaxesForCountry (string countryCodeIso3, int? size, int? page, string order);
        /// <summary>
        /// Create or update a tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="taxResource">The tax object</param>
        /// <returns>ModelCountryTaxResource</returns>
        ModelCountryTaxResource UpdateCountryTax (string countryCodeIso3, ModelCountryTaxResource taxResource);
        /// <summary>
        /// Create or update a state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <param name="stateCode">The code of the state</param>
        /// <param name="taxResource">The tax object</param>
        /// <returns>ModelStateTaxResource</returns>
        ModelStateTaxResource UpdateStateTax (string countryCodeIso3, string stateCode, ModelStateTaxResource taxResource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TaxesApi : ITaxesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TaxesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxesApi(String basePath)
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
        /// Create a country tax 
        /// </summary>
        /// <param name="taxResource">The tax object</param> 
        /// <returns>ModelCountryTaxResource</returns>            
        public ModelCountryTaxResource CreateCountryTax (ModelCountryTaxResource taxResource)
        {
            
    
            var path = "/tax/countries";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taxResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCountryTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCountryTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCountryTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelCountryTaxResource), response.Headers);
        }
    
        /// <summary>
        /// Create a state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="taxResource">The tax object</param> 
        /// <returns>ModelStateTaxResource</returns>            
        public ModelStateTaxResource CreateStateTax (string countryCodeIso3, ModelStateTaxResource taxResource)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling CreateStateTax");
            
    
            var path = "/tax/countries/{country_code_iso3}/states";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taxResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStateTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateStateTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelStateTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelStateTaxResource), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <returns></returns>            
        public void DeleteCountryTax (string countryCodeIso3)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling DeleteCountryTax");
            
    
            var path = "/tax/countries/{country_code_iso3}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCountryTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCountryTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an existing state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="stateCode">The code of the state</param> 
        /// <returns></returns>            
        public void DeleteStateTax (string countryCodeIso3, string stateCode)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling DeleteStateTax");
            
            // verify the required parameter 'stateCode' is set
            if (stateCode == null) throw new ApiException(400, "Missing required parameter 'stateCode' when calling DeleteStateTax");
            
    
            var path = "/tax/countries/{country_code_iso3}/states/{state_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
path = path.Replace("{" + "state_code" + "}", ApiClient.ParameterToString(stateCode));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteStateTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteStateTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a single tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <returns>ModelCountryTaxResource</returns>            
        public ModelCountryTaxResource GetCountryTax (string countryCodeIso3)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling GetCountryTax");
            
    
            var path = "/tax/countries/{country_code_iso3}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCountryTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelCountryTaxResource), response.Headers);
        }
    
        /// <summary>
        /// List and search taxes Get a list of taxes
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceCountryTaxResource</returns>            
        public ModelPageResourceCountryTaxResource GetCountryTaxes (int? size, int? page, string order)
        {
            
    
            var path = "/tax/countries";
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryTaxes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryTaxes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceCountryTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceCountryTaxResource), response.Headers);
        }
    
        /// <summary>
        /// Get a single state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="stateCode">The code of the state</param> 
        /// <returns>ModelStateTaxResource</returns>            
        public ModelStateTaxResource GetStateTax (string countryCodeIso3, string stateCode)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling GetStateTax");
            
            // verify the required parameter 'stateCode' is set
            if (stateCode == null) throw new ApiException(400, "Missing required parameter 'stateCode' when calling GetStateTax");
            
    
            var path = "/tax/countries/{country_code_iso3}/states/{state_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
path = path.Replace("{" + "state_code" + "}", ApiClient.ParameterToString(stateCode));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelStateTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelStateTaxResource), response.Headers);
        }
    
        /// <summary>
        /// List and search taxes across all countries Get a list of taxes
        /// </summary>
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceStateTaxResource</returns>            
        public ModelPageResourceStateTaxResource GetStateTaxesForCountries (int? size, int? page, string order)
        {
            
    
            var path = "/tax/states";
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
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTaxesForCountries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTaxesForCountries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceStateTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceStateTaxResource), response.Headers);
        }
    
        /// <summary>
        /// List and search taxes within a country Get a list of taxes
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="size">The number of objects returned per page</param> 
        /// <param name="page">The number of the page returned</param> 
        /// <param name="order">A comma separated list of sorting requirements in priority order, each entry matching PROPERTY_NAME:[ASC|DESC]</param> 
        /// <returns>ModelPageResourceStateTaxResource</returns>            
        public ModelPageResourceStateTaxResource GetStateTaxesForCountry (string countryCodeIso3, int? size, int? page, string order)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling GetStateTaxesForCountry");
            
    
            var path = "/tax/countries/{country_code_iso3}/states";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTaxesForCountry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStateTaxesForCountry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelPageResourceStateTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelPageResourceStateTaxResource), response.Headers);
        }
    
        /// <summary>
        /// Create or update a tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="taxResource">The tax object</param> 
        /// <returns>ModelCountryTaxResource</returns>            
        public ModelCountryTaxResource UpdateCountryTax (string countryCodeIso3, ModelCountryTaxResource taxResource)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling UpdateCountryTax");
            
    
            var path = "/tax/countries/{country_code_iso3}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taxResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCountryTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCountryTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCountryTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelCountryTaxResource), response.Headers);
        }
    
        /// <summary>
        /// Create or update a state tax 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <param name="stateCode">The code of the state</param> 
        /// <param name="taxResource">The tax object</param> 
        /// <returns>ModelStateTaxResource</returns>            
        public ModelStateTaxResource UpdateStateTax (string countryCodeIso3, string stateCode, ModelStateTaxResource taxResource)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling UpdateStateTax");
            
            // verify the required parameter 'stateCode' is set
            if (stateCode == null) throw new ApiException(400, "Missing required parameter 'stateCode' when calling UpdateStateTax");
            
    
            var path = "/tax/countries/{country_code_iso3}/states/{state_code}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "country_code_iso3" + "}", ApiClient.ParameterToString(countryCodeIso3));
path = path.Replace("{" + "state_code" + "}", ApiClient.ParameterToString(stateCode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taxResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "OAuth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStateTax: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStateTax: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelStateTaxResource) ApiClient.Deserialize(response.Content, typeof(ModelStateTaxResource), response.Headers);
        }
    
    }
}
