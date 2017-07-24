# com.knetikcloud.Model.DeviceResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Authorization** | **string** | The authorization code for the device | [optional] 
**Condition** | **string** | The current condition of the device (New, Defective, Reconditioned) | [optional] 
**CreatedDate** | **long?** | The date the device log was created | [optional] 
**Data** | **Dictionary&lt;string, string&gt;** | The key/value pairs for extended data | [optional] 
**Description** | **string** | The description of the device | [optional] 
**DeviceType** | **string** | The type of the device | [optional] 
**Id** | **int?** | The unique ID for this device. Cannot be changed once created | 
**Location** | **string** | The location of the device | [optional] 
**MacAddress** | **string** | The MAC (media access control) address of the device | [optional] 
**Make** | **string** | The make of the device | [optional] 
**Model** | **string** | The model of the device | [optional] 
**Name** | **string** | The name of the device | [optional] 
**Os** | **string** | The OS (operating system) on the device | [optional] 
**Serial** | **string** | The serial number of the device | [optional] 
**Status** | **string** | The current status the device (Active, Pending Active, Inactive, Repair | [optional] 
**UpdatedDate** | **long?** | The date the device log was updated | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user that owns the device | [optional] 
**Users** | [**List&lt;SimpleUserResource&gt;**](SimpleUserResource.md) | The users currently using the device | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

