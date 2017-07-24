# com.knetikcloud.Model.UserInventoryResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BehaviorData** | **Object** | A map of data for behaviors | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since epoch | [optional] 
**Expires** | **long?** | The date/time this resource exires in seconds since epoch. Null for no expiration. For subscriptions, this is the end of the &#39;grace period&#39; if left unpaid | [optional] 
**Id** | **int?** | The id of the inventory | [optional] 
**InvoiceId** | **int?** | The id of the invoice that resulted in this inventory, if any | [optional] 
**ItemId** | **int?** | The id of the item | [optional] 
**ItemName** | **string** | The name of the item | [optional] 
**ItemTypeHint** | **string** | The type hint of the item | [optional] 
**Status** | **string** | The status of the inventory. Pending inventory is not yet ready for use. Inactive inventory has expired or been used up | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since epoch | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The id of the user this inventory belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

