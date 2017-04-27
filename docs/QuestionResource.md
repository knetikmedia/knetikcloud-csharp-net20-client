# com.knetikcloud.Model.ModelQuestionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**Answers** | [**List&lt;ModelAnswerResource&gt;**](ModelAnswerResource.md) | The list of available answers | [optional] [default to null]
**Category** | [**ModelNestedCategory**](ModelNestedCategory.md) | The category for the question | [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Difficulty** | **int?** | The difficulty of the question | [default to null]
**Id** | **string** | The unique ID for that resource | [optional] [default to null]
**ImportId** | **long?** | The id of the import job that created the question, or null if not from an import | [optional] [default to null]
**PublishedDate** | **long?** | When the question becomes available, null for never, in seconds since epoch | [optional] [default to null]
**Question** | [**ModelProperty**](ModelProperty.md) | The question. Different &#39;type&#39; values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures | [default to null]
**Source1** | **string** | The first source of the question | [optional] [default to null]
**Source2** | **string** | The second source of the question | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | The list of tags | [optional] [default to null]
**Template** | **string** | A question template this question is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]
**Vendor** | **string** | The supplier of the question | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

