# com.knetikcloud.Model.VideoResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the video is available, based on various factors | [optional] 
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type | [optional] 
**Author** | [**SimpleReferenceResourcelong**](SimpleReferenceResourcelong.md) | The original artist of the media | [optional] 
**Authored** | **long?** | The date the media was created as a unix timestamp in seconds | [optional] 
**Banned** | **bool?** | Whether the video has been banned or not | [optional] 
**Category** | [**SimpleReferenceResourcestring**](SimpleReferenceResourcestring.md) | The category of the video | 
**Comments** | [**List&lt;CommentResource&gt;**](CommentResource.md) | The comments of the video | [optional] 
**Contributors** | [**List&lt;ContributionResource&gt;**](ContributionResource.md) | Artists that contributed to the creation. See separate endpoint to add to list | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] 
**Embed** | **string** | The country of an embedable version | [optional] 
**Extension** | **string** | The file extension of the media file. 1-5 characters | 
**Height** | **int?** | The height of the video in px | 
**Id** | **long?** | The unique ID for that resource | [optional] 
**Length** | **int?** | The length of the video in seconds | 
**Location** | **string** | The country of the media. Typically a url. Cannot be blank | 
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**MimeType** | **string** | The mime-type of the media | [optional] 
**Name** | **string** | The user friendly name of that resource | 
**Priority** | **int?** | The sort order of the video. default: 100 | [optional] 
**Privacy** | **string** | The privacy setting. default: private | [optional] 
**Published** | **bool?** | Whether the video has been made public. Default true | [optional] 
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] 
**Size** | **long?** | The size of the media. Minimum 0 if supplied | [optional] 
**Tags** | **List&lt;string&gt;** | The tags for the video | [optional] 
**Template** | **string** | A video template this video is validated against (private). May be null and no validation of additional_properties will be done | [optional] 
**Thumbnail** | **string** | The country of a thumbnail version. Typically a url | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] 
**Uploader** | [**SimpleUserResource**](SimpleUserResource.md) | The user the media was uploaded by. May be null for system uploaded media. May only be set to a user other than the current caller if VIDEOS_ADMIN permission. Null will mean the caller is the uploader unless the caller has VIDEOS_ADMIN permission, in which case it will be set to null | [optional] 
**Views** | **long?** | The view count of the video | [optional] 
**Width** | **int?** | The width of the video in px | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

