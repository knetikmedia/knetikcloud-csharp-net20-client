# com.knetikcloud.Model.ModelImageGroupPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldList** | [**ModelPropertyFieldListResource**](ModelPropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] [default to null]
**Name** | **string** | The name of the property | [default to null]
**Required** | **bool?** | Whether the property is required | [default to null]
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | [default to null]
**FileType** | **string** | If provided, a file type that the property must match | [optional] [default to null]
**MaxCount** | **int?** | If provided, the maximum number of files in the group | [optional] [default to null]
**MaxFileSize** | **long?** | If provided, the maximum allowed size per file in bytes | [optional] [default to null]
**MinCount** | **int?** | If provided, the minimum number of files in the group | [optional] [default to null]
**MaxHeight** | **int?** | If provided, the maximum height of each image | [optional] [default to null]
**MaxWidth** | **int?** | If provided, the maximum width of each image | [optional] [default to null]
**MinHeight** | **int?** | If provided, the minimum height of each image | [optional] [default to null]
**MinWidth** | **int?** | If provided, the minumum width of each image | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

