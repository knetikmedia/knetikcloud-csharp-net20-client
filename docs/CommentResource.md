# com.knetikcloud.Model.ModelCommentResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | The comment content of that resource | [default to null]
**Context** | **string** | The type of object this comment applies to (ex: video, article, etc). Required when passed to /comments | [optional] [default to null]
**ContextId** | **int?** | The id of the object this comment applies to.  Required when passed to /comments | [optional] [default to null]
**CreatedDate** | **long?** | The date/time this resource was created in seconds since epoch | [optional] [default to null]
**Id** | **long?** | The unique ID for that resource | [optional] [default to null]
**Summary** | **string** | The summary of that resource | [optional] [default to null]
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since epoch | [optional] [default to null]
**User** | [**ModelSimpleUserResource**](ModelSimpleUserResource.md) | The user who created the comment | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

