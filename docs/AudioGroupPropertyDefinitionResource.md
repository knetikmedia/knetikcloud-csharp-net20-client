# com.knetikcloud.Model.AudioGroupPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldList** | [**PropertyFieldListResource**](PropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] 
**Name** | **string** | The name of the property | 
**Required** | **bool?** | Whether the property is required | 
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | 
**FileType** | **string** | If provided, a file type that the property must match | [optional] 
**MaxCount** | **int?** | If provided, the maximum number of files in the group | [optional] 
**MaxFileSize** | **long?** | If provided, the maximum allowed size per file in bytes | [optional] 
**MinCount** | **int?** | If provided, the minimum number of files in the group | [optional] 
**MaxLength** | **int?** | If provided, the maximum length of the audio | [optional] 
**MinLength** | **int?** | If provided, the minimum length of the audio | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

