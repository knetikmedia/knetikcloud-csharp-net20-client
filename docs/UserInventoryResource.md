# com.knetikcloud.Model.ModelUserInventoryResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BehaviorData** | **Object** | A map of data for behaviors | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since epoch | [optional] [default to null]
**Expires** | **long?** | The date/time this resource exires in seconds since epoch. Null for no expiration. For subscriptions, this is the end of the &#39;grace period&#39; if left unpaid | [optional] [default to null]
**Id** | **int?** | The id of the inventory | [optional] [default to null]
**InvoiceId** | **int?** | The id of the invoice that resulted in this inventory, if any | [optional] [default to null]
**ItemId** | **int?** | The id of the item | [optional] [default to null]
**ItemName** | **string** | The name of the item | [optional] [default to null]
**ItemTypeHint** | **string** | The type hint of the item | [optional] [default to null]
**Status** | **string** | The status of the inventory. Pending inventory is not yet ready for use. Inactive inventory has expired or been used up | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since epoch | [optional] [default to null]
**User** | [**ModelSimpleUserResource**](ModelSimpleUserResource.md) | The id of the user this inventory belongs to | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

