# com.knetikcloud.Model.MapPropertyDefinitionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of the property | [optional] 
**FieldList** | [**PropertyFieldListResource**](PropertyFieldListResource.md) | A list of the fields on both the property definition and property of this type | [optional] 
**FriendlyName** | **string** | The friendly front-facing name of the property | [optional] 
**Name** | **string** | The name of the property | 
**OptionLabelPath** | **string** | The JSON path to the option label | [optional] 
**OptionValuePath** | **string** | The JSON path to the option value | [optional] 
**OptionsUrl** | **string** | URL of service containing the property options (assumed JSON array) | [optional] 
**Required** | **bool?** | Whether the property is required | 
**Type** | **string** | The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties. | 
**AllowAdditional** | **bool?** | Whether to allow additional properties beyond those specified or not | [optional] 
**Properties** | [**List&lt;PropertyDefinitionResource&gt;**](PropertyDefinitionResource.md) | If provided, a list of property definitions for each map entry | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

