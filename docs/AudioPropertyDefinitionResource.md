# com.knetikcloud.Model.ModelAudioPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldList** | [**ModelPropertyFieldListResource**](ModelPropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] [default to null]
**Name** | **string** | The name of the property | [default to null]
**Required** | **bool?** | Whether the property is required | [default to null]
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | [default to null]
**FileType** | **string** | If provided, a file type the property must match | [optional] [default to null]
**MaxLength** | **int?** | If provided, the maximum length of the audio | [optional] [default to null]
**MinLength** | **int?** | If provided, the minimum length of the audio | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

