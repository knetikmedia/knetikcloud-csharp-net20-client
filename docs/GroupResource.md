# com.knetikcloud.Model.ModelGroupResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**Description** | **string** | A description of the group. Max 250 characters | [optional] [default to null]
**MemberCount** | **int?** | The number of users in the group | [optional] [default to null]
**MessageOfTheDay** | **string** | A message of the day for members of the group | [optional] [default to null]
**Name** | **string** | The name of the group. Max 50 characters | [default to null]
**Parent** | **string** | The unique name of another group that this group is a subset of | [optional] [default to null]
**Status** | **string** | The status which describes whether other users can freely join the group or not | [default to null]
**SubMemberCount** | **int?** | The number of users in child groups | [optional] [default to null]
**Template** | **string** | A group template this group is validated against. May be null and no validation of additional_properties will be done | [optional] [default to null]
**UniqueName** | **string** | Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

