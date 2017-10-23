# com.knetikcloud.Model.PaymentAuthorizationResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Captured** | **bool?** | Whether this authorization has been captured | [optional] 
**Created** | **long?** | The date this authorization was received, unix timestamp in seconds | [optional] 
**Details** | **Object** | The details for this authorization. Format dependent on payment provider | [optional] 
**Id** | **int?** | The id of the authorization | [optional] 
**Invoice** | **int?** | The invoice this authorization is intended to pay | [optional] 
**PaymentType** | [**SimpleReferenceResourceint**](SimpleReferenceResourceint.md) | The payment type (which provider) this payment is through | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

