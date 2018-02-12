# com.knetikcloud.Model.NotificationTypeResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDate** | **long?** | The date the type was created, as a unix timestamp in seconds | [optional] 
**EmailBodyTemplateExternal** | **bool?** | Whether the email body should be resolved. If true, the external email delivery system will be expected to handle the templating (Mandrill/Mailchimp). default: false | [optional] 
**EmailBodyTemplateId** | **string** | The id of a message template to resolve the email body. If null, no websocket message wil be sent | [optional] 
**EmailSubjectTemplateId** | **string** | The id of a message template to resolve the email subject. If null, no websocket message wil be sent | [optional] 
**Id** | **string** | The id of the notification type. Default: random | [optional] 
**Name** | **string** | The name of the notification type | 
**SmsTemplateId** | **string** | The id of a message template to resolve the SMS message. If null, no sms message wil be sent | [optional] 
**UpdatedDate** | **long?** | The date the type was last updated, as a unix timestamp in seconds | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

