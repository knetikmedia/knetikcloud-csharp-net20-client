# IO.Swagger.Model.CatalogSale
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyCode** | **string** | The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply | [default to null]
**DiscountType** | **string** | The way in which the price is reduced. &#39;value&#39; means subtracting directly, &#39;percentage&#39; means subtracting by the price times the discountValue (1.0 &#x3D;&#x3D; 100%) | [default to null]
**DiscountValue** | **double?** | The amount deducted from the price, in the same currencyCode as the item | [optional] [default to null]
**Id** | **int?** | The id of the sale | [optional] [default to null]
**Item** | **int?** | The id of the item this sale applies to.  Leave null to use other filters | [optional] [default to null]
**LongDescription** | **string** | The long description of the sale | [optional] [default to null]
**Name** | **string** | The name of the sale.  Max 40 characters | [default to null]
**SaleEndDate** | **long?** | The date the sale ends, null for never.  Unix timestamp in seconds | [optional] [default to null]
**SaleStartDate** | **long?** | The date the sale begins.  Unix timestamp in seconds | [default to null]
**ShortDescription** | **string** | The short description of the sale.  Max 140 characters | [optional] [default to null]
**Tag** | **string** | The tag this sale applies to.  Leave null to skip this filter (applies to all tags) | [optional] [default to null]
**Vendor** | **int?** | The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors) | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

