# com.knetikcloud.Model.UserResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template | [optional] 
**Address** | **string** | The first line of the user&#39;s address (private) | [optional] 
**Address2** | **string** | The second line of user&#39;s address (private) | [optional] 
**AvatarUrl** | **string** | The url of the user&#39;s avatar image | [optional] 
**Children** | [**List&lt;UserRelationshipReferenceResource&gt;**](UserRelationshipReferenceResource.md) | Relationships where this user is the parent. Read-Only, manage through separate endpoints | [optional] 
**City** | **string** | The user&#39;s city (private) | [optional] 
**CountryCode** | **string** | The ISO3 code for the country from the user&#39;s address (private). Will be filled in based on GeoIP country at registration if not provided. | [optional] 
**CurrencyCode** | **string** | The code for the user&#39;s real money currency (private) | [optional] 
**DateOfBirth** | **long?** | The user&#39;s date of birth (private) as a unix timestamp | [optional] 
**Description** | **string** | The user&#39;s self description (private) | [optional] 
**DisplayName** | **string** | The chosen display name of the user, defaults to username if not present | [optional] 
**Email** | **string** | The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822) | 
**FirstName** | **string** | The user&#39;s first name (private) | [optional] 
**Fullname** | **string** | The user&#39;s full name (private) | [optional] 
**Gender** | **string** | The user&#39;s gender (private) | [optional] 
**Id** | **int?** | The id of the user | [optional] 
**LanguageCode** | **string** | The ISO3 code for the user&#39;s currency (private) | [optional] 
**LastActivity** | **long?** | The date the user last interacted with the API (private) | [optional] 
**LastName** | **string** | The user&#39;s last name (private) | [optional] 
**LastUpdated** | **long?** | The date the user&#39;s info was last updated as a unix timestamp | [optional] 
**MemberSince** | **long?** | The user&#39;s date of registration as a unix timestamp | [optional] 
**MobileNumber** | **string** | The user&#39;s mobile phone number (private) | [optional] 
**Parents** | [**List&lt;UserRelationshipReferenceResource&gt;**](UserRelationshipReferenceResource.md) | Relationships where this user is the child. Read-Only, manage through separate endpoints | [optional] 
**Password** | **string** | The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing | [optional] 
**PostalCode** | **string** | The user&#39;s postal code (private) | [optional] 
**State** | **string** | The user&#39;s state (private) | [optional] 
**Tags** | **List&lt;string&gt;** | Tags on the user. Can only be set by admin. Max length per tag is 64 characters | [optional] 
**Template** | **string** | A user template this user is validated against (private). May be null and no validation of properties will be done | [optional] 
**TimezoneCode** | **string** | The code for the user&#39;s timezone (private) | [optional] 
**Username** | **string** | The login username for the user (private). May be set to match email if system does not require usernames separately. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

