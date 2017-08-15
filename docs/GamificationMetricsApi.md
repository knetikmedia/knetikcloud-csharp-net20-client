# com.knetikcloud..GamificationMetricsApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMetric**](GamificationMetricsApi.md#addmetric) | **POST** /metrics | Add a metric


<a name="addmetric"></a>
# **AddMetric**
> void AddMetric (MetricResource metric)

Add a metric

Post a new score/stat for an activity occurrence without ending the occurrence itself

### Example
```csharp
using System;
using System.Diagnostics;
using com.knetikcloud.Api;
using com.knetikcloud.Client;
using com.knetikcloud.Model;

namespace Example
{
    public class AddMetricExample
    {
        public void main()
        {
            
            var apiInstance = new GamificationMetricsApi();
            var metric = new MetricResource(); // MetricResource | The new metric (optional) 

            try
            {
                // Add a metric
                apiInstance.AddMetric(metric);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamificationMetricsApi.AddMetric: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metric** | [**MetricResource**](MetricResource.md)| The new metric | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

