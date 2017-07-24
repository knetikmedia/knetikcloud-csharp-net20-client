# com.knetikcloud.Model.ArticleResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the article is active | 
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Body** | **string** | The body of the article | 
**Category** | [**NestedCategory**](NestedCategory.md) | The category for the article | 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Id** | **string** | The id of the article | [optional] 
**Tags** | **List&lt;string&gt;** | The tags for the article | [optional] 
**Template** | **string** | An article template this article is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**Title** | **string** | The title of the article | 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

