# com.knetikcloud.Model.Subscription
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
**Displayable** | **bool?** | Whether or not the item is currently displayable.  Default &#x3D; true | [optional] 
**GeoCountryList** | **List&lt;string&gt;** | A list of country ID to include in the blacklist/whitelist geo policy | [optional] 
**GeoPolicyType** | **string** | Whether to use the geo_country_list as a black list or white list for item geographical availability | [optional] 
**ShippingTier** | **int?** | Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default &#x3D; 0 | [optional] 
**Skus** | [**List&lt;Sku&gt;**](Sku.md) | The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart | 
**StoreEnd** | **long?** | The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store | [optional] 
**StoreStart** | **long?** | The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately | [optional] 
**VendorId** | **int?** | The vendor who provides the item | 
**Availability** | **string** |  | [optional] 
**ConsolidationDayOfMonth** | **int?** |  | [optional] 
**SubscriptionPlans** | [**List&lt;SubscriptionPlan&gt;**](SubscriptionPlan.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

