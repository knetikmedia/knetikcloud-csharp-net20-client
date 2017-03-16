# com.knetikcloud.Model.ChallengeResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Activities** | **int?** | The number of activities allowed to this challenge | [optional] [default to null]
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**CampaignId** | **long?** | The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events | [optional] [default to null]
**CopyOf** | **long?** | The ID of the original challenge it was copied from | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**EndDate** | **long?** | The end date of this challenge in seconds since epoch. required if part of a campaign | [optional] [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**LeaderboardStrategy** | **string** | The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service. | [optional] [default to null]
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Name** | **string** | The user friendly name of that resource | [default to null]
**NextEventDate** | **long?** | The next date this challenge will be occur in seconds since epoch | [optional] [default to null]
**RewardLagMinutes** | **int?** | The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete | [optional] [default to null]
**RewardSet** | [**RewardSetResource**](RewardSetResource.md) | The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing | [optional] [default to null]
**Schedule** | [**Schedule**](Schedule.md) | The repeat schedule for the challenge | [optional] [default to null]
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**StartDate** | **long?** | The start date of this challenge in seconds since epoch. required if part of a campaign | [optional] [default to null]
**Template** | **string** | A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

