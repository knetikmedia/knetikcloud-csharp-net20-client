# com.knetikcloud.Model.ClientResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessTokenValiditySeconds** | **int?** | The expiration time of an initial oauth token in seconds | [optional] [default to null]
**ClientKey** | **string** | The client_id field of the oauth token request | [default to null]
**GrantTypes** | **List&lt;string&gt;** | The oauth grant type as in: password (username/password auth), client_credentials (server-to-server, private clients), refresh_token (to allow clients to refresh their initial token), facebook, google, etc) See documentation for a compelte list. | [optional] [default to null]
**Id** | **int?** | Generated unique ID for the client | [optional] [default to null]
**IsPublic** | **bool?** | Set to true if the client is public i.e the secret key can be secured | [optional] [default to null]
**Locked** | **bool?** | Used to flag system clients that are not meant to be tinkered with | [optional] [default to null]
**Name** | **string** | The friendly name of the client | [default to null]
**RedirectUris** | **List&lt;string&gt;** | A redirection URL to use when granting access to third-parties (seldomly used) | [optional] [default to null]
**RefreshTokenValiditySeconds** | **int?** | The expiration time of a refresh oauth token in seconds | [optional] [default to null]
**Secret** | **string** | The client-secret field of the oauth request when creating a private client | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

