# com.knetikcloud.Model.ModelRepresentsAnActivityThatCanBeParameterizedAndTrackedThroughMetricsScoresEtc
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties keyed on the property name. Used to further describe an activity. While settings will vary from one activity occurrence (a game) to another, additional properties are shared by all the occurrences of this activity. Ex: Activity Logo, Disclaimer, Greeting, etc. Validated against template if one exists for activities | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Entitlements** | [**List&lt;ModelActivityEntitlementResource&gt;**](ModelActivityEntitlementResource.md) | The list of items that can be used for entitlement (wager amounts/etc) | [optional] [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**Launch** | **string** | Details about how to launch the activity | [optional] [default to null]
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Name** | **string** | The user friendly name of that resource | [default to null]
**RewardSet** | [**ModelRewardSetResource**](ModelRewardSetResource.md) | The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing | [optional] [default to null]
**Settings** | [**List&lt;ModelTheDefinitionOfAnActivityParametersExDifficultyLevel&gt;**](ModelTheDefinitionOfAnActivityParametersExDifficultyLevel.md) | Define what parameters are required/available to start and run an activity. For example: Difficulty, Number of Questions, Character name, Avatar, Duration, etc. Not populated when getting listing | [optional] [default to null]
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Template** | **bool?** | Whether this activity is a template for other activities. Default: false | [optional] [default to null]
**TemplateId** | **string** | An activity template this activity is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**Type** | **string** | The type of the activity | [default to null]
**UniqueKey** | **string** | The unique key (for static reference in code) of the activity | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

