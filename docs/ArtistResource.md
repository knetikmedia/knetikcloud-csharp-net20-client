# com.knetikcloud.Model.ArtistResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Born** | **string** | YYYY/MM/DD when this artist was born | [optional] 
**ContributionCount** | **int?** | The current number of contributions the artist has made | [optional] 
**Contributions** | [**List&lt;ContributionResource&gt;**](ContributionResource.md) | The list of media this artist has contributed to as well as role(s) during contribution.  Use media endpoint to add contributions | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Died** | **string** | YYYY/MM/DD when this artist died | [optional] 
**Id** | **long?** | The unique ID for that resource | [optional] 
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**Name** | **string** | The user friendly name of that resource | 
**Priority** | **int?** | The sort order priority ofr the artist.  Default 100 | [optional] 
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**Template** | **string** | An artist template this artist is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

