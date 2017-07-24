# com.knetikcloud.Model.RefundRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **double?** | The amount to refund. If left off, will refund the remaining balance of the transaction or specific item balance (if SKU provided), whichever is less. | [optional] 
**BundleSku** | **string** | The SKU of a bundle item from the invoice that the target item is within. | [optional] 
**Notes** | **string** | Notes about or reason for the refund | 
**Sku** | **string** | The SKU of a specific item from the invoice to refund. Affects the maximum refund amount (not to exceed the price of this item times quantity on invoice). Transaction must be tied to an invoice if used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

