# com.knetikcloud.Model.SubscriptionResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The additional properties for the subscription | [optional] 
**Availability** | **string** | Who can purchase this subscription | [optional] 
**Behaviors** | [**List&lt;Behavior&gt;**](Behavior.md) | The behaviors linked to the item, describing various options and interactions. May not be included in item lists | [optional] 
**Category** | **string** | The category of the subscription | [optional] 
**ConsolidationDayOfMonth** | **int?** | The day of the month 1..31 this subscription will renew | [optional] 
**CreatedDate** | **long?** | The date the item was created, unix timestamp in seconds | [optional] 
**Displayable** | **bool?** | Whether or not the item is currently visible to users. Does not block purchase; Use store_start or store_end to block purchase.  Default &#x3D; true | [optional] 
**GeoCountryList** | **List&lt;string&gt;** | The geo country list for the subscription | [optional] 
**GeoPolicyType** | **string** | The geo policy type for the subscription | [optional] 
**Id** | **int?** | The id of the item | [optional] 
**LongDescription** | **string** | A long description of the subscription | [optional] 
**Name** | **string** | The name of the item | 
**Plans** | [**List&lt;SubscriptionPlanResource&gt;**](SubscriptionPlanResource.md) | The billing options for this subscription | [optional] 
**ShortDescription** | **string** | A short description of the subscription.  Max 255 characters | [optional] 
**Sort** | **int?** | A number to use in sorting items.  Default 500 | [optional] 
**StoreEnd** | **long?** | Used to schedule removal from store.  Null means the subscription will never be removed | [optional] 
**StoreStart** | **long?** | Used to schedule appearance in store.  Null means the subscription will appear now | [optional] 
**Tags** | **List&lt;string&gt;** | The tags for the subscription | [optional] 
**Template** | **string** | The template being used | [optional] 
**UniqueKey** | **string** | The unique key of the subscription | [optional] 
**UpdatedDate** | **long?** | The date the item was last updated | [optional] 
**VendorId** | **int?** | The id of the vendor | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

