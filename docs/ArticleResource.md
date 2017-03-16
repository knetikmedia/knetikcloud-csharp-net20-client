# com.knetikcloud.Model.ArticleResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the article is active | [default to null]
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] [default to null]
**Body** | **string** | The body of the article | [default to null]
**Category** | [**NestedCategory**](NestedCategory.md) | The category for the article | [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Id** | **string** | The id of the article | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | The tags for the article | [optional] [default to null]
**Template** | **string** | An article template this article is validated against (private). May be null and no validation of additional_properties will be done | [optional] [default to null]
**Title** | **string** | The title of the article | [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

