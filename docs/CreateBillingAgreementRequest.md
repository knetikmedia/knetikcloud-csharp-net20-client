# IO.Swagger.Model.CreateBillingAgreementRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelUrl** | **string** | The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement | [default to null]
**ReturnUrl** | **string** | The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step | [default to null]
**UserId** | **int?** | The ID of the user. Defaults to the logged in user | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

