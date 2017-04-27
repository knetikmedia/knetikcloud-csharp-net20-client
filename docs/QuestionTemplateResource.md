# com.knetikcloud.Model.ModelQuestionTemplateResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnswerProperty** | [**ModelPropertyDefinitionResource**](ModelPropertyDefinitionResource.md) | A property definition for all answers. If included each answer must match this definition&#39;s type and be valid | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Id** | **string** | The id of the template | [optional] [default to null]
**Name** | **string** | The name of the template | [default to null]
**Properties** | [**List&lt;ModelPropertyDefinitionResource&gt;**](ModelPropertyDefinitionResource.md) | The customized properties that are present | [optional] [default to null]
**QuestionProperty** | [**ModelPropertyDefinitionResource**](ModelPropertyDefinitionResource.md) | A property definition for the question itself. If included the answer must match this definition&#39;s type and be valid | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

