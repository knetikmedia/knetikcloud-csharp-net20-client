# com.knetikcloud.Model.ModelBreRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | [**ModelActionResource**](ModelActionResource.md) | A list of actions to execute, and the mapping for their parameters, when the rule runs. Minimum 1 | [default to null]
**Condition** | [**ModelPredicateOperation**](ModelPredicateOperation.md) | A condition expression that must be met in a given event for the rule to run. Empty to always run | [optional] [default to null]
**ConditionText** | **string** | The condition as a readable string. Filled in by the system from the condition | [optional] [default to null]
**Description** | **string** | The human readable description of the rule | [optional] [default to null]
**Enabled** | **bool?** | Whether the rule is enabled to run (in conjunction with dates). Default true | [optional] [default to null]
**EndDate** | **long?** | The date the rule ceases to take effect, or null if never. Unix timestamp in seconds | [optional] [default to null]
**EventName** | **string** | The event name of the trigger this rule runs for. Affects which parameters are available | [default to null]
**Id** | **string** | The id of the rule for later references. If left null a random guid will be generated. Must be unique. Cannot be changed | [optional] [default to null]
**Name** | **string** | The human readable name of the rule | [default to null]
**Sort** | **int?** | Used to sort rules to control the order they run in. Larger numbered sort values run first.  Default 500 | [optional] [default to null]
**StartDate** | **long?** | The date the rule begins to take effect, or null if always. Unix timestamp in seconds | [optional] [default to null]
**SystemRule** | **bool?** | Whether the rule is a default part of the system. System rules cannot be edited or deleted, but may be disabled | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

