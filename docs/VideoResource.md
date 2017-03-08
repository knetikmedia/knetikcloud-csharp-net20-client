# IO.Swagger.Model.VideoResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the video is available, based on various factors | [optional] [default to null]
**Author** | [**SimpleReferenceResourcelong**](SimpleReferenceResourcelong.md) | The original artist of the media | [optional] [default to null]
**Authored** | **long?** | The date the media was created as a unix timestamp in seconds | [optional] [default to null]
**Banned** | **bool?** | Whether the video has been banned or not | [optional] [default to null]
**Category** | [**SimpleReferenceResourcestring**](SimpleReferenceResourcestring.md) | The category of the video | [default to null]
**Comments** | [**List&lt;CommentResource&gt;**](CommentResource.md) | The comments of the video | [optional] [default to null]
**Contributors** | [**List&lt;ContributionResource&gt;**](ContributionResource.md) | Artists that contributed to the creation. See separate endpoint to add to list | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since unix epoch | [optional] [default to null]
**Embed** | **string** | The country of an embedable version | [optional] [default to null]
**Extension** | **string** | The file extension of the media file. 1-5 characters | [default to null]
**Height** | **int?** | The height of the video in px | [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**Length** | **int?** | The length of the video in seconds | [default to null]
**Location** | **string** | The country of the media. Typically a url. Cannot be blank | [default to null]
**LongDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**MimeType** | **string** | The mime-type of the media | [optional] [default to null]
**Name** | **string** | The user friendly name of that resource | [default to null]
**Priority** | **int?** | The sort order of the video. default: 100 | [optional] [default to null]
**Privacy** | **string** | The privacy setting. default: private | [optional] [default to null]
**Published** | **bool?** | Whether the video has been made public. Default true | [optional] [default to null]
**ShortDescription** | **string** | The user friendly name of that resource. Defaults to blank string | [optional] [default to null]
**Size** | **long?** | The size of the media. Minimum 0 if supplied | [optional] [default to null]
**Tags** | **List&lt;string&gt;** | The tags for the video | [optional] [default to null]
**Thumbnail** | **string** | The country of a thumbnail version. Typically a url | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since unix epoch | [optional] [default to null]
**Uploader** | [**SimpleUserResource**](SimpleUserResource.md) | The user the media was uploaded by. May be null for system uploaded media. May only be set to a user other than the current caller if VIDEOS_ADMIN permission. Null will mean the caller is the uploader unless the caller has VIDEOS_ADMIN permission, in which case it will be set to null | [optional] [default to null]
**Views** | **long?** | The view count of the video | [optional] [default to null]
**Width** | **int?** | The width of the video in px | [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

