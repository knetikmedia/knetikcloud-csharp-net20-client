# com.knetikcloud.Model.ModelLimitedGettableGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveOnly** | **bool?** | Whether to get active items only | [default to null]
**Name** | **string** | The name of the group. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that owned_limit and active_only will be the same for all, but this is not enforced and the item being recieved will use its settings. | [optional] [default to null]
**OwnedLimit** | **int?** | The max number of items that can be purchased | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

