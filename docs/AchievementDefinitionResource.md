# com.knetikcloud.Model.AchievementDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Description** | **string** | The description of the achievement. Must be at least 2 characters in length. | [optional] [default to null]
**Hidden** | **bool?** | Whether the achievement is hidden from the user | [default to null]
**Name** | **string** | The name of the achievement. Must be at least 6 characters in length. IMMUTABLE | [default to null]
**RequiredProgress** | **int?** | The required progress for the achievement definition | [default to null]
**RuleId** | **string** | The id of the rule generated for this achievement | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | The tags for the achievement definition | [optional] [default to null]
**Template** | **string** | An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**TriggerEventName** | **string** | The name of the trigger event associated with this achievement | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

