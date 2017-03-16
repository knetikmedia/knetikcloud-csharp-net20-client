# com.knetikcloud.Model.ModelSku
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template | [optional] [default to null]
**CurrencyCode** | **string** | The currency code for the SKU, a three letter string (ISO3) | [default to null]
**Description** | **string** | The description of the SKU (Ex: An item comes in multiple sizes/colors, each needing its own unique description) | [optional] [default to null]
**Inventory** | **int?** | The number of SKUs currently in stock | [optional] [default to null]
**MinInventoryThreshold** | **int?** | Alerts vendor when SKU inventory drops below this value | [optional] [default to null]
**OriginalPrice** | **double?** | The base price before any sale | [default to null]
**Price** | **double?** | The current price of the SKU with sales, if any. Set original_price for the base | [optional] [default to null]
**Published** | **bool?** | Whether or not the SKU is currently published | [optional] [default to null]
**SaleId** | **int?** | The id of a sale affecting the price, if any | [optional] [default to null]
**SaleName** | **string** | The name of a sale affecting the price, if any | [optional] [default to null]
**Sku** | **string** | The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters | [default to null]
**StartDate** | **long?** | The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately | [optional] [default to null]
**StopDate** | **long?** | The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

