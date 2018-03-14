# com.knetikcloud.Model.MetricResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityOccurenceId** | **long?** | The id of the activity occurence where this score/metric occurred | 
**Tags** | **List&lt;string&gt;** | Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 10 tags and 50 characters each | [optional] 
**UserId** | **int?** | The id of the user this metric is for. Default to caller and requires METRICS_ADMIN permission to specify another | [optional] 
**Value** | **long?** | The value/score of the metric | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

