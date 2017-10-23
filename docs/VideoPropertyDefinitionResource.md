# com.knetikcloud.Model.VideoPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldList** | [**PropertyFieldListResource**](PropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] 
**Name** | **string** | The name of the property | 
**Required** | **bool?** | Whether the property is required | 
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | 
**FileType** | **string** | If provided, a file type that teh property must match | [optional] 
**MaxHeight** | **int?** | If provided, the maximum height of the video | [optional] 
**MaxLength** | **int?** | If provided, the maximum length of the video | [optional] 
**MaxWidth** | **int?** | If provided, the maximum width of the video | [optional] 
**MinHeight** | **int?** | If provided, the minimum height of the video | [optional] 
**MinLength** | **int?** | If provided, the minimum length of the video | [optional] 
**MinWidth** | **int?** | If provided, the minimum width of the video | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

