# com.knetikcloud.Model.RewardCurrencyResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyCode** | **string** | The code of the currency type to give | 
**CurrencyName** | **string** | The name of the currency reward to give.  Set by currency_code) | [optional] 
**MaxRank** | **int?** | The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank | 
**MinRank** | **int?** | The lowest number (best) rank to give the reward to. Must be greater than zero | 
**Percent** | **bool?** | True if the value is actually a percentage of the intake | 
**Value** | **double?** | The amount of currency to give. For percentage values, 0.5 is 50% | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

