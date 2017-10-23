# com.knetikcloud.Model.CommentResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | The comment content of that resource | 
**Context** | **string** | The type of object this comment applies to (ex: video, article, etc). Required when passed to /comments | [optional] 
**ContextId** | **int?** | The id of the object this comment applies to.  Required when passed to /comments | [optional] 
**CreatedDate** | **long?** | The date/time this resource was created in seconds since epoch | [optional] 
**Id** | **long?** | The unique ID for that resource | [optional] 
**Summary** | **string** | The summary of that resource | [optional] 
**UpdatedDate** | **long?** | The date/time this resource was last updated in seconds since epoch | [optional] 
**User** | [**SimpleUserResource**](SimpleUserResource.md) | The user who created the comment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

