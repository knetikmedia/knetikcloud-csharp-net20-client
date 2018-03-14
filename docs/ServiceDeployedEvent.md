# com.knetikcloud.Model.ServiceDeployedEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Client** | **string** |  | [optional] 
**Customer** | **string** |  | [optional] 
**DoNotBroadcast** | **bool?** |  | [optional] 
**Section** | **string** |  | [optional] 
**Source** | **Object** |  | [optional] 
**Specifics** | **string** |  | [optional] 
**Synchronous** | **bool?** |  | [optional] 
**Timestamp** | **long?** |  | [optional] 
**Type** | **string** | The type of the event. Used for polymorphic type recognition and thus must match an expected type | 
**Events** | [**List&lt;BreTriggerResource&gt;**](BreTriggerResource.md) | The events fired by this service | 
**Resources** | [**List&lt;ResourceTypeDescription&gt;**](ResourceTypeDescription.md) | The resources managed by this service | 
**ServiceName** | **string** | The unique name for the service. This serves as the unique identifier. Cannot be changed after creation | 
**SwaggerUrl** | **string** | The url of the swagger doc | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

