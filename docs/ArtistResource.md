# IO.Swagger.Model.ArtistResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**Born** | **string** | YYYY/MM/DD when this artist was born | [optional] [default to null]
**ContributionCount** | **int?** | The current number of contributions the artist has made | [optional] [default to null]
**Contributions** | [**List&lt;ContributionResource&gt;**](ContributionResource.md) | The list of media this artist has contributed to as well as role(s) during contribution.  Use media endpoint to add contributions | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Died** | **string** | YYYY/MM/DD when this artist died | [optional] [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Name** | **string** | The user friendly name of that resource | [default to null]
**Priority** | **int?** | The sort order priority ofr the artist.  Default 100 | [optional] [default to null]
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Template** | **string** | An artist template this artist is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

