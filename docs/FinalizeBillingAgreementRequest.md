# com.knetikcloud.Model.FinalizeBillingAgreementRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceId** | **int?** | The ID of the invoice being paid along with the creation of this agreement | [optional] 
**NewDefault** | **bool?** | Whether the new payment method created should be the user&#39;s default | [optional] 
**PayerId** | **string** | The payer ID from PayPal (passed as a parameter in the return URL). Only required if an invoice ID was included | [optional] 
**Token** | **string** | The token from PayPal (passed as a parameter in the return URL) | 
**UserId** | **int?** | The ID of the user. Defaults to the logged in user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

