# com.knetikcloud.Model.MapPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldList** | [**PropertyFieldListResource**](PropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] 
**Name** | **string** | The name of the property | 
**Required** | **bool?** | Whether the property is required | 
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | 
**AllowAdditional** | **bool?** | Whether to allow additional properties beyond those specified or not | [optional] 
**Properties** | [**List&lt;PropertyDefinitionResource&gt;**](PropertyDefinitionResource.md) | If provided, a list of property definitions for each map entry | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

