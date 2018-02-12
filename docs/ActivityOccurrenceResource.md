# com.knetikcloud.Model.ActivityOccurrenceResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **long?** | The id of the activity | 
**Bans** | **List&lt;int?&gt;** | The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint | [optional] 
**ChallengeActivityId** | **long?** | The id of the challenge activity (as part of the event, required if eventId set) | [optional] 
**CoreSettings** | [**CoreActivityOccurrenceSettings**](CoreActivityOccurrenceSettings.md) | Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity. | [optional] 
**CreatedDate** | **long?** | The date this occurrence was created, unix timestamp in seconds | [optional] 
**Entitlement** | [**ActivityEntitlementResource**](ActivityEntitlementResource.md) | The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity | [optional] 
**EventId** | **long?** | The id of the event | [optional] 
**Host** | [**SimpleUserResource**](SimpleUserResource.md) | The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of &#39;non_player&#39; if not admin as well | [optional] 
**Id** | **long?** | The id of the activity occurrence | [optional] 
**RewardStatus** | **string** | Indicate if the rewards have been given out already | [optional] 
**Settings** | [**List&lt;SelectedSettingResource&gt;**](SelectedSettingResource.md) | The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity. | [optional] 
**Simulated** | **bool?** | Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials | [optional] 
**StartDate** | **long?** | The date this occurrence was started, unix timestamp in seconds. null if not yet started | [optional] 
**Status** | **string** | The current status of the occurrence (default: OPEN) | [optional] 
**UpdatedDate** | **long?** | The date this occurrence was last updated, unix timestamp in seconds | [optional] 
**Users** | [**List&lt;ActivityUserResource&gt;**](ActivityUserResource.md) | The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

