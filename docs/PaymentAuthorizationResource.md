# com.knetikcloud.Model.PaymentAuthorizationResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Captured** | **bool?** | Whether this authorization has been captured | [optional] [default to null]
**Created** | **long?** | The date this authorization was received, unix timestamp in seconds | [optional] [default to null]
**Details** | **Object** | The details for this authorization. Format dependent on payment provider | [optional] [default to null]
**Id** | **int?** | The id of the authorization | [optional] [default to null]
**Invoice** | **int?** | The invoice this authorization is intended to pay | [optional] [default to null]
**PaymentType** | [**SimpleReferenceResourceint**](SimpleReferenceResourceint.md) | The payment type (which provider) this payment is through | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

