# IO.Swagger.Model.UserActivityResultsResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyRewards** | [**List&lt;RewardCurrencyResource&gt;**](RewardCurrencyResource.md) | Any currency rewarded to this user | [optional] [default to null]
**ItemRewards** | [**List&lt;RewardItemResource&gt;**](RewardItemResource.md) | Any items rewarded to this user | [optional] [default to null]
**Rank** | **long?** | The position of the user in the leaderboard. Null means non-compete or disqualification | [optional] [default to null]
**Score** | **long?** | The raw score in this leaderboard. Null means non-compete or disqualification | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each | [optional] [default to null]
**Ties** | **int?** | The number of users tied at this rank, including this user. 1 means no tie | [optional] [default to null]
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The player for this entry | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

