# com.knetikcloud.Model.CurrencyResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the currency is active. Default true | [optional] 
**Code** | **string** | The unique id code for the currency. Maximum 5 characters | 
**CreatedDate** | **long?** | The unix timestamp in seconds the currency was added to the system | [optional] 
**DefaultCurrency** | **bool?** | Whether this is the default currency. All real money wallets will be in this currency, and the &#39;factor&#39; on each currency is in relation to the default. There must be one default currency and the current will be changed if you set another as the default. Cannot be combined with virtual currency. Take extreme caution when changing | [optional] 
**Factor** | **decimal?** | The decimal to multiply the default currency to localize to this one. Should be 1 for the default currency itself. | 
**Icon** | **string** | The url for an icon of the currency | [optional] 
**Name** | **string** | The name of the currency | 
**Type** | **string** | The type of currency. Default &#39;real&#39; | [optional] 
**UpdatedDate** | **long?** | The unix timestamp in seconds the currency was last updated in the system. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

