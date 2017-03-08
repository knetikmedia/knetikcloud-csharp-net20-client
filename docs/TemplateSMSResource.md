# com.knetikcloud.client.Model.TemplateSMSResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | The phone number to attribute the outgoing message to. Optional if the config text.out_number is set. | [optional] [default to null]
**Localizer** | [**Localizer**](Localizer.md) |  | [optional] [default to null]
**Recipients** | **List&lt;int?&gt;** | A list of user ids to send the message to. | [default to null]
**TemplateKey** | **string** | The key for the template. | [default to null]
**TemplateVars** | **List&lt;string&gt;** | A list of values to fill in the template. Order matters. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

