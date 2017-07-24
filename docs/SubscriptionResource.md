# com.knetikcloud.Model.SubscriptionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type. | [optional] 
**Availability** | **string** | Who can purchase this subscription | [optional] 
**Category** | **string** | A category for filtering items | [optional] 
**ConsolidationDayOfMonth** | **int?** | The day of the month 1..31 this subscription will renew | [optional] 
**CreatedDate** | **long?** | The date the item was created, unix timestamp in seconds | [optional] 
**GeoCountryList** | **List&lt;string&gt;** | A list of country iso3 codes to include in the blacklist/whitelist geo policy | [optional] 
**GeoPolicyType** | **string** | Whether to use the geo_country_list as a black list or white list for item geographical availability | [optional] 
**Id** | **int?** | The id of the item | [optional] 
**LongDescription** | **string** | A long description of the subscription | [optional] 
**Name** | **string** | The name of the item | 
**Plans** | [**List&lt;SubscriptionPlanResource&gt;**](SubscriptionPlanResource.md) | The billing options for this subscription | [optional] 
**ShortDescription** | **string** | A short description of the subscription.  Max 255 characters | [optional] 
**Sort** | **int?** | A number to use in sorting items.  Default 500 | [optional] 
**StoreEnd** | **long?** | Used to schedule removal from store.  Null means the subscription will never be removed | [optional] 
**StoreStart** | **long?** | Used to schedule appearance in store.  Null means the subscription will appear now | [optional] 
**Tags** | **List&lt;string&gt;** | List of tags used for filtering items | [optional] 
**Template** | **string** | An item template this item is validated against. May be null and no validation of additional properties will be done. | [optional] 
**UniqueKey** | **string** | The unique key for the item | [optional] 
**UpdatedDate** | **long?** | The date the item was last updated | [optional] 
**VendorId** | **int?** | The vendor who provides the item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

