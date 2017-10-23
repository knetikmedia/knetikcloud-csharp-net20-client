# com.knetikcloud.Model.CouponItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template | [optional] 
**Behaviors** | [**List&lt;Behavior&gt;**](Behavior.md) | The behaviors linked to the item, describing various options and interactions. May not be included in item lists | [optional] 
**Category** | **string** | A category for filtering items | [optional] 
**CreatedDate** | **long?** | The date the item was created, unix timestamp in seconds | [optional] 
**Id** | **int?** | The id of the item | [optional] 
**LongDescription** | **string** | A long description of the item | [optional] 
**Name** | **string** | The name of the item | 
**ShortDescription** | **string** | A short description of the item, max 255 chars | [optional] 
**Sort** | **int?** | A number to use in sorting items.  Default 500 | [optional] 
**Tags** | **List&lt;string&gt;** | List of tags used for filtering items | [optional] 
**Template** | **string** | An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default &#x3D; null | [optional] 
**TypeHint** | **string** | The type of the item | 
**UniqueKey** | **string** | The unique key for the item | [optional] 
**UpdatedDate** | **long?** | The date the item was last updated, unix timestamp in seconds | [optional] 
**Displayable** | **bool?** | Whether or not the item is currently visible to users. Does not block purchase; Use store_start or store_end to block purchase.  Default &#x3D; true | [optional] 
**GeoCountryList** | **List&lt;string&gt;** | A list of country ID to include in the blacklist/whitelist geo policy | [optional] 
**GeoPolicyType** | **string** | Whether to use the geo_country_list as a black list or white list for item geographical availability | [optional] 
**ShippingTier** | **int?** | Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0 | [optional] 
**Skus** | [**List&lt;Sku&gt;**](Sku.md) | The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart | 
**StoreEnd** | **long?** | The date the item will become hidden and unavailable for purchase, unix timestamp in seconds.  If set to null, item will never leave the store | [optional] 
**StoreStart** | **long?** | The date the item will become visible (if displayable) and available for purchase, unix timestamp in seconds.  If set to null, item will appear in store immediately | [optional] 
**VendorId** | **int?** | The vendor who provides the item | 
**CouponTypeHint** | **string** | The type of coupon | 
**DiscountMax** | **decimal?** | The amount this coupon is maxed out at.  Applies if coupon_type_hint is coupon_cart | [optional] 
**DiscountMinCartValue** | **decimal?** | The minimium amount needed in the cart for the coupon to apply.  Applies if coupon_type_hint is coupon_cart | [optional] 
**DiscountType** | **string** | The type of discount in terms of how it deducts price. Value based discount not available for coupon_cart type coupons | 
**DiscountValue** | **decimal?** | The amount the coupon will discount the item. If discount_type is &#39;value&#39; this will be a flat amount of currency. If discount type is &#39;percentage&#39; this will be a fraction (0.2 for 20% off) multiplied by the price of the matching item or items. | 
**Exclusive** | **bool?** | Whether this coupon is exclusive or not (true means cannot be in same cart as another).  Default &#x3D; false | [optional] 
**ItemId** | **int?** | The id of the item the coupon is applied to.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher | [optional] 
**MaxQuantity** | **int?** | The maximum quantity of items the coupon can apply to, null if no limit and minimum 1 otherwise.  Applies if coupon_type_hint is coupon_single_item or coupon_voucher | [optional] 
**SelfExclusive** | **bool?** | Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default &#x3D; false | [optional] 
**ValidForTags** | **List&lt;string&gt;** | A list of tags for a coupon.  The coupon can only apply to an item that has at least one of these tags.  Applies if coupon_type_hint is coupon_tag | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

