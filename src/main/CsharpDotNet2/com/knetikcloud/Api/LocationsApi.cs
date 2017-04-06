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
    public interface ILocationsApi
    {
        /// <summary>
        /// Get a list of countries 
        /// </summary>
        /// <returns>List&lt;ModelCountryResource&gt;</returns>
        List<ModelCountryResource> GetCountries ();
        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <returns>string</returns>
        string GetCountryByGeoLocation ();
        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param>
        /// <returns>List&lt;ModelStateResource&gt;</returns>
        List<ModelStateResource> GetCountryStates (string countryCodeIso3);
        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <returns>ModelCurrencyResource</returns>
        ModelCurrencyResource GetCurrencyByGeoLocation ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationsApi : ILocationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LocationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi(String basePath)
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
        /// Get a list of countries 
        /// </summary>
        /// <returns>List&lt;ModelCountryResource&gt;</returns>            
        public List<ModelCountryResource> GetCountries ()
        {
            
    
            var path = "/location/countries";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelCountryResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelCountryResource>), response.Headers);
        }
    
        /// <summary>
        /// Get the iso3 code of your country Determined by geo ip location
        /// </summary>
        /// <returns>string</returns>            
        public string GetCountryByGeoLocation ()
        {
            
    
            var path = "/location/geolocation/country";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryByGeoLocation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryByGeoLocation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get a list of a country&#39;s states 
        /// </summary>
        /// <param name="countryCodeIso3">The iso3 code of the country</param> 
        /// <returns>List&lt;ModelStateResource&gt;</returns>            
        public List<ModelStateResource> GetCountryStates (string countryCodeIso3)
        {
            
            // verify the required parameter 'countryCodeIso3' is set
            if (countryCodeIso3 == null) throw new ApiException(400, "Missing required parameter 'countryCodeIso3' when calling GetCountryStates");
            
    
            var path = "/location/countries/{country_code_iso3}/states";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryStates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCountryStates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelStateResource>) ApiClient.Deserialize(response.Content, typeof(List<ModelStateResource>), response.Headers);
        }
    
        /// <summary>
        /// Get the currency information of your country Determined by geo ip location, currency to country mapping and a fallback setting
        /// </summary>
        /// <returns>ModelCurrencyResource</returns>            
        public ModelCurrencyResource GetCurrencyByGeoLocation ()
        {
            
    
            var path = "/location/geolocation/currency";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrencyByGeoLocation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCurrencyByGeoLocation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCurrencyResource) ApiClient.Deserialize(response.Content, typeof(ModelCurrencyResource), response.Headers);
        }
    
    }
}