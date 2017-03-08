# IO.Swagger.Model.CampaignResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the campaign is active or not.  Defaults to false | [optional] [default to null]
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**LeaderboardStrategy** | **string** | The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service | [optional] [default to null]
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Name** | **string** | The user friendly name of that resource | [default to null]
**NextChallenge** | **string** | The name of the next challenge coming up | [optional] [default to null]
**NextChallengeDate** | **long?** | The date/time of the next challenge coming up | [optional] [default to null]
**RewardSet** | [**RewardSetResource**](RewardSetResource.md) | The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing | [optional] [default to null]
**RewardStatus** | **string** | Indicate if the rewards have been given out already | [optional] [default to null]
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Template** | **string** | A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

