# com.knetikcloud.Model.ImportJobResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryId** | **string** | The id of the category to assign all questions in the import to | 
**CreatedDate** | **long?** | The date the job was created in seconds since unix epoc | [optional] 
**Id** | **long?** | The id of the job | [optional] 
**Name** | **string** | A name for this import for later reference | 
**Output** | [**List&lt;ImportJobOutputResource&gt;**](ImportJobOutputResource.md) | Error information from validation | [optional] 
**RecordCount** | **long?** | The number of questions form the CSV file. Filled in after validation | [optional] 
**Status** | **string** | The status of the job | [optional] 
**UpdatedDate** | **long?** | The date the job was last updated in seconds since unix epoc | [optional] 
**Url** | **string** | The url of a CSV file to pull trivia questions from. Cannot be changed after initial POST | 
**Vendor** | **string** | The vendor who supplied this set of questions | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

