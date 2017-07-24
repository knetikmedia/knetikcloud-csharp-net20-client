# com.knetikcloud.Model.PollResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the poll is active | 
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Answers** | [**List&lt;PollAnswerResource&gt;**](PollAnswerResource.md) | The answers to the poll | 
**Category** | [**NestedCategory**](NestedCategory.md) | The category for the poll | 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Id** | **string** | The id of the poll | [optional] 
**Tags** | **List&lt;string&gt;** | The tags for the poll | [optional] 
**Template** | **string** | A poll template this poll is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**Text** | **string** | The text of the poll | 
**Type** | **string** | The media type of the poll | 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

