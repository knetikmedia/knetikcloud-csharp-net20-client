# com.knetikcloud.Model.PaymentMethodResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**_Default** | **bool?** |  | [optional] 
**Disabled** | **bool?** | Whether this payment method is disabled or not | [optional] 
**ExpirationDate** | **long?** | The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods | [optional] 
**ExpirationMonth** | **int?** | The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods | [optional] 
**ExpirationYear** | **int?** | The expiration year for the payment method. Typically used for credit card payment methods | [optional] 
**Id** | **long?** | The unique ID of the resource | [optional] 
**Last4** | **string** | The last 4 digits of the account number for the payment method. Typically used for credit card payment methods | [optional] 
**Name** | **string** | The user friendly name of the resource | 
**PaymentMethodType** | [**PaymentMethodTypeResource**](PaymentMethodTypeResource.md) | The type of payment method. Must be a pre-existing value | 
**PaymentType** | **string** | The generic payment type. Default is card | [optional] 
**Sort** | **int?** | The sort value for the payment method | [optional] 
**Token** | **string** | The unique token for the payment method | [optional] 
**UniqueKey** | **string** | An optional unique identifier | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 
**UserId** | **int?** | The user&#39;s id. If null, indicates a shared payment method that any user can use (i.e., &#39;wallet&#39;) | [optional] 
**Verified** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

