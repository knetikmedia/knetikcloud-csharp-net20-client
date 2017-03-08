# com.knetikcloud.Model.UserActionLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionDescription** | **string** | A description of the action taken | [default to null]
**ActionName** | **string** | The name of the action taken | [default to null]
**CreatedDate** | **long?** | The date of the action, unix timestamp in seconds | [optional] [default to null]
**Details** | **Dictionary&lt;String, string&gt;** | A map of additional details such as the target of the action | [optional] [default to null]
**Id** | **string** | The id of the log entry | [optional] [default to null]
**RequestId** | **string** | The id of the api request that spawned the action, if generated internally | [optional] [default to null]
**UserId** | **int?** | The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

