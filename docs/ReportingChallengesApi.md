# IO.Swagger..ReportingChallengesApi

All URIs are relative to *https://sandbox.knetikcloud.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChallengeEventLeaderboard**](ReportingChallengesApi.md#getchallengeeventleaderboard) | **GET** /reporting/events/leaderboard | Retrieve a challenge event leaderboard details
[**GetChallengeEventParticipants**](ReportingChallengesApi.md#getchallengeeventparticipants) | **GET** /reporting/events/participants | Retrieve a challenge event participant details


<a name="getchallengeeventleaderboard"></a>
# **GetChallengeEventLeaderboard**
> PageResourceChallengeEventParticipantResource GetChallengeEventLeaderboard (long? filterEvent)

Retrieve a challenge event leaderboard details

Lists all leaderboard entries with additional user details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventLeaderboardExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 

            try
            {
                // Retrieve a challenge event leaderboard details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventLeaderboard(filterEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventLeaderboard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchallengeeventparticipants"></a>
# **GetChallengeEventParticipants**
> PageResourceChallengeEventParticipantResource GetChallengeEventParticipants (long? filterEvent)

Retrieve a challenge event participant details

Lists all user submitted scores sorted by value, including those that do not apear in the leaderboard due to value or aggregation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChallengeEventParticipantsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportingChallengesApi();
            var filterEvent = 789;  // long? | A sepecific challenge event id (optional) 

            try
            {
                // Retrieve a challenge event participant details
                PageResourceChallengeEventParticipantResource result = apiInstance.GetChallengeEventParticipants(filterEvent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingChallengesApi.GetChallengeEventParticipants: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterEvent** | **long?**| A sepecific challenge event id | [optional] 

### Return type

[**PageResourceChallengeEventParticipantResource**](PageResourceChallengeEventParticipantResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

