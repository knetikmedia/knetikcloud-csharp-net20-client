# com.knetikcloud.client.Model.InventorySubscriptionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillDate** | **long?** | The date the subscription will be billed | [optional] [default to null]
**Credit** | **double?** | A credit of money already applied to a subscription for the next bill, or a debt if negative | [optional] [default to null]
**CreditLog** | [**List&lt;SubscriptionCreditResource&gt;**](SubscriptionCreditResource.md) | A record of past and present credit/debt changes | [optional] [default to null]
**GraceEnd** | **long?** | The date the grace period ends | [optional] [default to null]
**InventoryId** | **int?** | The id of the inventory | [optional] [default to null]
**InventoryStatus** | **string** | The inventory status object | [optional] [default to null]
**ItemId** | **int?** | The id of the item | [optional] [default to null]
**PaymentMethod** | [**PaymentMethodResource**](PaymentMethodResource.md) | The payment method object | [optional] [default to null]
**RecurringPrice** | **double?** | The recurring price | [optional] [default to null]
**Sku** | **string** | The sku of the subscription | [optional] [default to null]
**StartDate** | **long?** | The date the subscription will start | [optional] [default to null]
**SubscriptionStatus** | **int?** | The status of the subscription | [optional] [default to null]
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

