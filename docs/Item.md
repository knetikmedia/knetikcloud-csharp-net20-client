# com.knetikcloud.Model.Item
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template | [optional] 
**Behaviors** | [**List&lt;Behavior&gt;**](Behavior.md) | The behaviors linked to the item, describing various options and interactions. May not be included in item lists | [optional] 
**Category** | **string** | A category for filtering items | [optional] 
**CreatedDate** | **long?** | The date the item was created, unix timestamp in seconds | [optional] 
**Id** | **int?** | The id of the item | [optional] 
**LongDescription** | **string** | A long description of the item | [optional] 
**Name** | **string** | The name of the item | 
**ShortDescription** | **string** | A short description of the item, max 255 chars | [optional] 
**Sort** | **int?** | A number to use in sorting items.  Default 500 | [optional] 
**Tags** | **List&lt;string&gt;** | List of tags used for filtering items | [optional] 
**Template** | **string** | An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null | [optional] 
**TypeHint** | **string** | The type of the item | 
**UniqueKey** | **string** | The unique key for the item | [optional] 
**UpdatedDate** | **long?** | The date the item was last updated, unix timestamp in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

