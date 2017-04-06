# com.knetikcloud.Model.ModelShippingItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template | [optional] [default to null]
**Behaviors** | [**List&lt;ModelBehavior&gt;**](ModelBehavior.md) | The behaviors linked to the item, describing various options and interactions. May not be included in item lists | [optional] [default to null]
**Category** | **string** | A category for filtering items | [optional] [default to null]
**Countries** | **List&lt;string&gt;** | A unique list of country iso3 codes that allow the shipping option | [optional] [default to null]
**CreatedDate** | **long?** | The date the item was created, unix timestamp in seconds | [optional] [default to null]
**Displayable** | **bool?** | Whether or not the item is currently displayable.  Default &#x3D; true | [optional] [default to null]
**GeoCountryList** | **List&lt;string&gt;** | A list of country ID to include in the blacklist/whitelist geo policy | [optional] [default to null]
**GeoPolicyType** | **string** | Whether to use the geo_country_list as a black list or white list for item geographical availability | [optional] [default to null]
**Id** | **int?** | The id of the item | [optional] [default to null]
**LongDescription** | **string** | A long description of the item | [optional] [default to null]
**MaxTierTotal** | **int?** | An abstract max value that the values of item&#39;s shipping_tier work against to decide whether an order can be fulfilled | [default to null]
**Name** | **string** | The name of the item | [default to null]
**ShippingTier** | **int?** | Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0 | [optional] [default to null]
**ShortDescription** | **string** | A short description of the item, max 255 chars | [optional] [default to null]
**Skus** | [**List&lt;ModelSku&gt;**](ModelSku.md) | The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart | [default to null]
**Sort** | **int?** | A number to use in sorting items.  Default 500 | [optional] [default to null]
**StoreEnd** | **long?** | The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store | [optional] [default to null]
**StoreStart** | **long?** | The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | List of tags used for filtering items | [optional] [default to null]
**Taxable** | **bool?** | Whether tax should be applied to the shipping price.  Default &#x3D; false | [optional] [default to null]
**Template** | **string** | An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null | [optional] [default to null]
**TypeHint** | **string** | The type of the item | [default to null]
**UniqueKey** | **string** | The unique key for the item | [optional] [default to null]
**UpdatedDate** | **long?** | The date the item was last updated, unix timestamp in seconds | [optional] [default to null]
**VendorId** | **int?** | The vendor who provides the item | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
