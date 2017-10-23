# com.knetikcloud.Model.GroupResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Description** | **string** | A description of the group. Max 250 characters | [optional] 
**MemberCount** | **int?** | The number of users in the group | [optional] 
**MessageOfTheDay** | **string** | A message of the day for members of the group | [optional] 
**Name** | **string** | The name of the group. Max 50 characters | 
**Parent** | **string** | The unique name of another group that this group is a subset of | [optional] 
**Status** | **string** | The status which describes whether other users can freely join the group or not | 
**SubMemberCount** | **int?** | The number of users in child groups | [optional] 
**Template** | **string** | A group template this group is validated against. May be null and no validation of additional_properties will be done | [optional] 
**UniqueName** | **string** | Unique name used in url and references. Uppercase, lowercase, numbers and hyphens only. Max 50 characters. Cannot be altered once created | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

