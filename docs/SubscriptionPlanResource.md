# com.knetikcloud.Model.SubscriptionPlanResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;String, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription | [optional] [default to null]
**BillingCycleLength** | **int?** | The length of the billing cycle in number of billing cycle unit | [default to null]
**BillingCycleUnit** | **string** | The time period unit to apply to the length of billing cycles | [default to null]
**Consolidated** | **bool?** | Whether this plan will be renewed on the consolidated billing cycle | [default to null]
**CurrencyCode** | **string** | The ISO3 currency code to use for the fees | [default to null]
**EndDate** | **long?** | Used to schedule plan availability end date | [optional] [default to null]
**FirstBillingCycleLength** | **int?** | Optional override for the length of the first billing cycle before the first recurring billing | [optional] [default to null]
**FirstBillingCycleUnit** | **string** | The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified | [optional] [default to null]
**GracePeriod** | **int?** | The number of late payment days before a subscription is canceled | [default to null]
**Id** | **string** | The id of the plan used to generate the SKUs | [optional] [default to null]
**InitialFee** | **double?** | The fee charged when the subscription is purchased | [default to null]
**InitialSku** | **string** | The SKU to be used when purchasing the subscription through the cart | [optional] [default to null]
**LatePaymentFee** | **double?** | The fee to add to the bill when an invoice has gone unpaid passed the grace period | [default to null]
**LatePaymentSku** | **string** | The SKU that will show on the invoice when the subscription is delinquent | [optional] [default to null]
**Locked** | **bool?** | Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed | [optional] [default to null]
**MaxBillAttempts** | **int?** | The number of charge attempts before the subscription becomes delinquent | [default to null]
**MaxCycles** | **int?** | Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached | [optional] [default to null]
**MigrateToPlan** | **string** | Automatically migrate to the specified plan when the subscription is first renewed | [optional] [default to null]
**MinCycles** | **int?** | The minimum number of renewals to charge for | [optional] [default to null]
**Name** | **string** | The name of the plan used to generate the SKUs | [default to null]
**Published** | **bool?** | Whether this plan is currently available | [default to null]
**ReactivationFee** | **double?** | The fee to charge when a suspended subscription is to be re-activated | [default to null]
**ReactivationSku** | **string** | The SKU that will show on the invoice when the subscription is re-activated after a suspension | [optional] [default to null]
**RecurringFee** | **double?** | The recurring fee to charge for each renewal | [default to null]
**RecurringSku** | **string** | The SKU that will show on the invoice when the subscription is activated | [optional] [default to null]
**StartDate** | **long?** | Used to schedule plan availability start date | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

