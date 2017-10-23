# com.knetikcloud.Model.MobileDeviceResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template if one is specified | [optional] 
**CreatedDate** | **long?** | The date the device log was created | [optional] 
**Description** | **string** | The description of the device | [optional] 
**DeviceType** | **string** | The type of device. Use mobile to specifically register mobile devices. This particular type will be used to send and receive notifications | [optional] 
**Id** | **string** | The unique ID for this device | [optional] 
**Location** | **string** | The physical location of the device, coordinates or named place (office, living room, etc) | [optional] 
**MacAddress** | **string** | The MAC (media access control) address of the device | [optional] 
**Make** | **string** | The make of the device | [optional] 
**Model** | **string** | The model of the device | [optional] 
**Name** | **string** | The name of the device | [optional] 
**Os** | **string** | The OS (operating system) on the device | [optional] 
**Owner** | [**SimpleUserResource**](SimpleUserResource.md) | The user that owns the device | [optional] 
**Serial** | **string** | The serial number of the device | [optional] 
**Tags** | **List&lt;string&gt;** | Random tags to facilitate search | [optional] 
**Template** | **string** | Use to describe and validate custom properties (custom schema). May be null and no validation of additional_properties will be done | [optional] 
**UpdatedDate** | **long?** | The date the device log was updated | [optional] 
**Users** | [**List&lt;SimpleUserResource&gt;**](SimpleUserResource.md) | The users currently using the device | [optional] 
**Authorization** | **string** | The authorization code for push notifications provided by the provider platform (APNS, GCM, etc). | [optional] 
**Imei** | **string** |  | [optional] 
**NotificationPlatform** | **string** | The platform used for push notifications. Only Apple and Android are supported at the moment. | [optional] 
**Number** | **string** | The phone number associated with this device if applicable, in international format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

