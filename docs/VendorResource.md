# com.knetikcloud.Model.ModelVendorResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool?** | Whether the vendor is active.  Default &#x3D; true | [optional] [default to null]
**AdditionalProperties** | [**Dictionary&lt;String, ModelProperty&gt;**](ModelProperty.md) | A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template | [optional] [default to null]
**CreateDate** | **long?** | The date the vendor was added. Unix timestamp in seconds | [optional] [default to null]
**Description** | **string** | A description of the vendor | [optional] [default to null]
**Id** | **int?** | The id of the vendor | [optional] [default to null]
**ImageUrl** | **string** | The url of an image for the vendor | [optional] [default to null]
**ManualApproval** | **bool?** | Whether the vendor needs to manually approve invoices before they are paid.  A separate checkout flow is required in this case.  Default: false | [optional] [default to null]
**Name** | **string** | The name of the vendor | [default to null]
**PrimaryContactEmail** | **string** | The primary email address for the vendor | [optional] [default to null]
**PrimaryContactName** | **string** | The name of the primary contact for the vendor | [optional] [default to null]
**PrimaryContactPhone** | **string** | The primary phone number for the vendor | [optional] [default to null]
**SalesEmail** | **string** | The email address for sale inquiries for the vendor | [optional] [default to null]
**SupportEmail** | **string** | The email address for support inquiries for the vendor | [optional] [default to null]
**Template** | **string** | A user template this user is validated against (private). May be null and no validation of properties will be done | [optional] [default to null]
**UpdateDate** | **long?** | The date the vendor was last updated. Unix timestamp in seconds | [optional] [default to null]
**Url** | **string** | The url for the vendor&#39;s site | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

