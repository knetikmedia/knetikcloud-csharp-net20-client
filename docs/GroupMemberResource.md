# com.knetikcloud.Model.GroupMemberResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template | [optional] 
**Group** | [**SimpleGroupResource**](SimpleGroupResource.md) | The group. Id is the unique name | [optional] 
**_Implicit** | **bool?** | Whether this membership is explicit (the user was added directly to the group) or implicit (the user was added only to one or more child groups) | [optional] 
**MembershipId** | **long?** | The id of the membership entry | [optional] 
**Order** | **string** | The position of the member in the group if applicable. Read notes for details | [optional] 
**Status** | **string** | The member&#39;s access level. Default: member | [optional] 
**Template** | **string** | A template this member additional properties are validated against (private). May be null and no validation of properties will be done | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

