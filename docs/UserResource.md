# com.knetikcloud.Model.ModelUserResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template | [optional] [default to null]
**Address** | **string** | The first line of the user&#39;s address (private) | [optional] [default to null]
**Address2** | **string** | The second line of user&#39;s address (private) | [optional] [default to null]
**AvatarUrl** | **string** | The url of the user&#39;s avatar image | [optional] [default to null]
**Children** | [**List&lt;ModelUserRelationshipReferenceResource&gt;**](ModelUserRelationshipReferenceResource.md) | Relationships where this user is the parent. Read-Only, manage through separate endpoints | [optional] [default to null]
**City** | **string** | The user&#39;s city (private) | [optional] [default to null]
**CountryCode** | **string** | The ISO3 code for the country from the user&#39;s address (private). Will be filled in based on GeoIP country at registration if not provided. | [optional] [default to null]
**CurrencyCode** | **string** | The code for the user&#39;s real money currency (private) | [optional] [default to null]
**DateOfBirth** | **long?** | The user&#39;s date of birth (private) as a unix timestamp | [optional] [default to null]
**Description** | **string** | The user&#39;s self description (private) | [optional] [default to null]
**DisplayName** | **string** | The chosen display name of the user, defaults to username if not present | [optional] [default to null]
**Email** | **string** | The user&#39;s email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822) | [default to null]
**FirstName** | **string** | The user&#39;s first name (private) | [optional] [default to null]
**Fullname** | **string** | The user&#39;s full name (private) | [optional] [default to null]
**Gender** | **string** | The user&#39;s gender (private) | [optional] [default to null]
**Id** | **int?** | The id of the user | [optional] [default to null]
**LanguageCode** | **string** | The ISO3 code for the user&#39;s currency (private) | [optional] [default to null]
**LastName** | **string** | The user&#39;s last name (private) | [optional] [default to null]
**LastUpdated** | **long?** | The date the user&#39;s info was last updated as a unix timestamp | [optional] [default to null]
**MemberSince** | **long?** | The user&#39;s date of registration as a unix timestamp | [optional] [default to null]
**MobileNumber** | **string** | The user&#39;s mobile phone number (private) | [optional] [default to null]
**Parents** | [**List&lt;ModelUserRelationshipReferenceResource&gt;**](ModelUserRelationshipReferenceResource.md) | Relationships where this user is the child. Read-Only, manage through separate endpoints | [optional] [default to null]
**Password** | **string** | The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing | [optional] [default to null]
**PostalCode** | **string** | The user&#39;s postal code (private) | [optional] [default to null]
**State** | **string** | The user&#39;s state (private) | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | Tags on the user. Can only be set by admin. Max length per tag is 64 characters | [optional] [default to null]
**Template** | **string** | A user template this user is validated against (private). May be null and no validation of properties will be done | [optional] [default to null]
**TimezoneCode** | **string** | The code for the user&#39;s timezone (private) | [optional] [default to null]
**Username** | **string** | The login username for the user (private). May be set to match email if system does not require usernames separately. | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

