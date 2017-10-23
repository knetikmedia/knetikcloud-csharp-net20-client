# com.knetikcloud.Model.StripePaymentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | The amount to pay, if not the full remaining balance (leave out to pay in full, but be careful no other partial payment has been started) | [optional] 
**InvoiceId** | **int?** | The id of the invoice to pay | 
**Token** | **string** | A token from Stripe to identify payment info to be tied to the customer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

