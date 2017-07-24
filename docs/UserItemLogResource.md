# com.knetikcloud.Model.UserItemLogResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The log entry id | [optional] 
**Info** | **string** | Additional information defined by the type | [optional] 
**Item** | [**SimpleReferenceResourceint**](SimpleReferenceResourceint.md) | The item interacted with | [optional] 
**LogDate** | **long?** | The date/time this event occurred in seconds since epoch | [optional] 
**Type** | **string** | The type of event | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user making the interaction | [optional] 
**UserInventory** | **int?** | The id of the inventory entry this event is related to, if any | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

