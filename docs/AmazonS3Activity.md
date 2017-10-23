# com.knetikcloud.Model.AmazonS3Activity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | S3 action (i.e., &#39;PUT&#39;) associated with the activity | [optional] 
**CdnUrl** | **string** | URL for accessing the resource. Will use a CDN if configured, or direct to S3 if not | [optional] 
**CreatedDate** | **long?** | Date the resource was created in S3 | [optional] 
**Filename** | **string** | Name of the file being processed as a resource in S3 | [optional] 
**Id** | **long?** | Unique id of the S3 activity | [optional] 
**ObjectKey** | **string** | S3 object key for the resource | [optional] 
**Url** | **string** | URL that one can PUT the file to, to upload it to S3 | [optional] 
**UserId** | **int?** | The id of the user that created this S3 activity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

