# com.knetikcloud.Model.WalletTransactionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **double?** | The new balance of the wallet after the transaction | [optional] 
**CreateDate** | **long?** | The unix timestamp in seconds of the transaction | [optional] 
**CurrencyCode** | **string** | The code of the currency for the transaction | [optional] 
**Details** | **string** | The specific details of the transaction, such as a message from the admin that created it | [optional] 
**Id** | **int?** | The id of the transaction | [optional] 
**InvoiceId** | **int?** | The id of the invoice that spawned the transaction, if any | [optional] 
**IsRefunded** | **bool?** | Whether the transaction has been refunded | [optional] 
**Response** | **string** | The response | [optional] 
**Source** | **string** | The root source of the transaction | [optional] 
**Successful** | **bool?** | If the transaction was successful | [optional] 
**TransactionId** | **string** | The payment gateway (external) transaction ID | [optional] 
**Type** | **string** | The general type of the transaction | [optional] 
**TypeHint** | **string** | The table name of the subclass | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The owner of the wallet | [optional] 
**Value** | **double?** | The amount of the transaction, positive if a gain, negative if an expenditure | [optional] 
**WalletId** | **int?** | The id of the wallet this transaction affected | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

