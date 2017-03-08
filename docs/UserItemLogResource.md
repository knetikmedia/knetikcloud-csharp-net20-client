# com.knetikcloud.client.Model.UserItemLogResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The log entry id | [optional] [default to null]
**Info** | **string** | Additional information defined by the type | [optional] [default to null]
**Item** | [**SimpleReferenceResourceint**](SimpleReferenceResourceint.md) | The item interacted with | [optional] [default to null]
**LogDate** | **long?** | The date/time this event occurred in seconds since epoch | [optional] [default to null]
**Type** | **string** | The type of event | [optional] [default to null]
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user making the interaction | [optional] [default to null]
**UserInventory** | **int?** | The id of the inventory entry this event is related to, if any | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

