# com.knetikcloud.Model.QuestionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Answers** | [**List&lt;AnswerResource&gt;**](AnswerResource.md) | The list of available answers | [optional] 
**Category** | [**NestedCategory**](NestedCategory.md) | The category for the question | 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Difficulty** | **int?** | The difficulty of the question | 
**Id** | **string** | The unique ID for that resource | [optional] 
**ImportId** | **long?** | The id of the import job that created the question, or null if not from an import | [optional] 
**PublishedDate** | **long?** | When the question becomes available, null for never, in seconds since epoch | [optional] 
**Question** | [**Property**](Property.md) | The question. Different &#39;type&#39; values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures | 
**Source1** | **string** | The first source of the question | [optional] 
**Source2** | **string** | The second source of the question | [optional] 
**Tags** | **List&lt;string&gt;** | The list of tags | [optional] 
**Template** | **string** | A question template this question is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 
**Vendor** | **string** | The supplier of the question | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

