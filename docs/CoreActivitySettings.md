# com.knetikcloud.Model.CoreActivitySettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootInPlay** | **bool?** | Whether the host can boot a user while the status is PLAYING. Default false | [optional] 
**CustomLaunchAddressAllowed** | **bool?** | Restriction for whether the host creating an occurrence can specify a custom launch address (such as their own ip address). Default &#39;false&#39; | [optional] 
**HostOption** | **string** | Restriction for who can host an occurrence. admin disallows regular users, player means the user must also be a player in the occurrence if not admin, non-player means the user has the option to host without being a player. Default &#39;player&#39; | [optional] 
**HostStatusControl** | **bool?** | Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Default &#39;false&#39; | [optional] 
**JoinInPlay** | **bool?** | Whether users can join while the status is PLAYING. Default false | [optional] 
**LeaveInPlay** | **bool?** | Whether users can leave while the status is PLAYING. Default false | [optional] 
**MaxPlayers** | **int?** | The maximum number of players the game can hold | [optional] 
**MinPlayers** | **int?** | The minimum number of players the game can hold | [optional] 
**ResultsTrust** | **string** | Restriction for who is able to report game end and results. Admin is always able to send results as well. Default &#39;none&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

