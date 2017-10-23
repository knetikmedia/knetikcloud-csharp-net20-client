# com.knetikcloud.Model.SubscriptionPlanResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription | [optional] 
**BillingCycleLength** | **int?** | The length of the billing cycle in number of billing cycle unit | 
**BillingCycleUnit** | **string** | The time period unit to apply to the length of billing cycles | 
**Consolidated** | **bool?** | Whether this plan will be renewed on the consolidated billing cycle | 
**CurrencyCode** | **string** | The ISO3 currency code to use for the fees | 
**EndDate** | **long?** | Used to schedule plan availability end date | [optional] 
**FirstBillingCycleLength** | **int?** | Optional override for the length of the first billing cycle before the first recurring billing | [optional] 
**FirstBillingCycleUnit** | **string** | The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified | [optional] 
**GracePeriod** | **int?** | The number of late payment days before a subscription is canceled | 
**Id** | **string** | The id of the plan used to generate the SKUs | [optional] 
**InitialFee** | **decimal?** | The fee charged when the subscription is purchased | 
**InitialSku** | **string** | The SKU to be used when purchasing the subscription through the cart | [optional] 
**LatePaymentFee** | **decimal?** | The fee to add to the bill when an invoice has gone unpaid passed the grace period | 
**LatePaymentSku** | **string** | The SKU that will show on the invoice when the subscription is delinquent | [optional] 
**Locked** | **bool?** | Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed | [optional] 
**MaxBillAttempts** | **int?** | The number of charge attempts before the subscription becomes delinquent | 
**MaxCycles** | **int?** | Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached | [optional] 
**MigrateToPlan** | **string** | Automatically migrate to the specified plan when the subscription is first renewed | [optional] 
**MinCycles** | **int?** | The minimum number of renewals to charge for | [optional] 
**Name** | **string** | The name of the plan used to generate the SKUs | 
**Published** | **bool?** | Whether this plan is currently available | 
**ReactivationFee** | **decimal?** | The fee to charge when a suspended subscription is to be re-activated | 
**ReactivationSku** | **string** | The SKU that will show on the invoice when the subscription is re-activated after a suspension | [optional] 
**RecurringFee** | **decimal?** | The recurring fee to charge for each renewal | 
**RecurringSku** | **string** | The SKU that will show on the invoice when the subscription is activated | [optional] 
**StartDate** | **long?** | Used to schedule plan availability start date | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

