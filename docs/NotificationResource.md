# com.knetikcloud.Model.NotificationResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **Object** | The data to send to websockets. Also used to fill in the templates | [optional] 
**NotificationId** | **string** | The id of this individual notification. Default: random | [optional] 
**NotificationTypeId** | **string** | The id of the notification type which will define message templates | 
**Recipient** | **string** | The id of the recipient, dependent on the recipient_type. The user&#39;s id or the topic&#39;s id | 
**RecipientType** | **string** | The type of recipient for the notification. Either a user, or all users in a topic | 
**SendDate** | **long?** | The date this notification was sent | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

