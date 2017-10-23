# com.knetikcloud.Model.BreTriggerResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category &#39;custom&#39; | [optional] 
**EventName** | **string** | The unique name for the event. This serves as the unique identifier. Cannot be changed after creation | 
**Parameters** | [**List&lt;BreTriggerParameterDefinition&gt;**](BreTriggerParameterDefinition.md) | A list of parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types | [optional] 
**SystemTrigger** | **bool?** | Where this trigger came from. System triggers cannot be removed or updated | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for filtering | [optional] 
**TriggerDescription** | **string** | A description of the trigger | 
**TriggerName** | **string** | A human readable name for this trigger | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

