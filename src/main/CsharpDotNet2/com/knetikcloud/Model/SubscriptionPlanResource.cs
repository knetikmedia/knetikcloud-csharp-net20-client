using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubscriptionPlanResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this subscription</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The length of the billing cycle in number of billing cycle unit
    /// </summary>
    /// <value>The length of the billing cycle in number of billing cycle unit</value>
    [DataMember(Name="billing_cycle_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_cycle_length")]
    public int? BillingCycleLength { get; set; }

    /// <summary>
    /// The time period unit to apply to the length of billing cycles
    /// </summary>
    /// <value>The time period unit to apply to the length of billing cycles</value>
    [DataMember(Name="billing_cycle_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_cycle_unit")]
    public string BillingCycleUnit { get; set; }

    /// <summary>
    /// Whether this plan will be renewed on the consolidated billing cycle
    /// </summary>
    /// <value>Whether this plan will be renewed on the consolidated billing cycle</value>
    [DataMember(Name="consolidated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consolidated")]
    public bool? Consolidated { get; set; }

    /// <summary>
    /// The ISO3 currency code to use for the fees
    /// </summary>
    /// <value>The ISO3 currency code to use for the fees</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Used to schedule plan availability end date
    /// </summary>
    /// <value>Used to schedule plan availability end date</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public long? EndDate { get; set; }

    /// <summary>
    /// Optional override for the length of the first billing cycle before the first recurring billing
    /// </summary>
    /// <value>Optional override for the length of the first billing cycle before the first recurring billing</value>
    [DataMember(Name="first_billing_cycle_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_billing_cycle_length")]
    public int? FirstBillingCycleLength { get; set; }

    /// <summary>
    /// The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified
    /// </summary>
    /// <value>The time period unit to apply to the length of the first billing cycle. Required when first_billing_cycle_length is specified</value>
    [DataMember(Name="first_billing_cycle_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_billing_cycle_unit")]
    public string FirstBillingCycleUnit { get; set; }

    /// <summary>
    /// The number of late payment days before a subscription is canceled
    /// </summary>
    /// <value>The number of late payment days before a subscription is canceled</value>
    [DataMember(Name="grace_period", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grace_period")]
    public int? GracePeriod { get; set; }

    /// <summary>
    /// The id of the plan used to generate the SKUs
    /// </summary>
    /// <value>The id of the plan used to generate the SKUs</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The fee charged when the subscription is purchased
    /// </summary>
    /// <value>The fee charged when the subscription is purchased</value>
    [DataMember(Name="initial_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initial_fee")]
    public double? InitialFee { get; set; }

    /// <summary>
    /// The SKU to be used when purchasing the subscription through the cart
    /// </summary>
    /// <value>The SKU to be used when purchasing the subscription through the cart</value>
    [DataMember(Name="initial_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initial_sku")]
    public string InitialSku { get; set; }

    /// <summary>
    /// The fee to add to the bill when an invoice has gone unpaid passed the grace period
    /// </summary>
    /// <value>The fee to add to the bill when an invoice has gone unpaid passed the grace period</value>
    [DataMember(Name="late_payment_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "late_payment_fee")]
    public double? LatePaymentFee { get; set; }

    /// <summary>
    /// The SKU that will show on the invoice when the subscription is delinquent
    /// </summary>
    /// <value>The SKU that will show on the invoice when the subscription is delinquent</value>
    [DataMember(Name="late_payment_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "late_payment_sku")]
    public string LatePaymentSku { get; set; }

    /// <summary>
    /// Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed
    /// </summary>
    /// <value>Whether this plan is locked because it has been purchased by at least one user.  When locked, a number of properties can no longer be changed</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// The number of charge attempts before the subscription becomes delinquent
    /// </summary>
    /// <value>The number of charge attempts before the subscription becomes delinquent</value>
    [DataMember(Name="max_bill_attempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_bill_attempts")]
    public int? MaxBillAttempts { get; set; }

    /// <summary>
    /// Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached
    /// </summary>
    /// <value>Maximum number of renewals. If a migration plan is provided, the subscription will automatically switch to it when this limit is reached</value>
    [DataMember(Name="max_cycles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_cycles")]
    public int? MaxCycles { get; set; }

    /// <summary>
    /// Automatically migrate to the specified plan when the subscription is first renewed
    /// </summary>
    /// <value>Automatically migrate to the specified plan when the subscription is first renewed</value>
    [DataMember(Name="migrate_to_plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "migrate_to_plan")]
    public string MigrateToPlan { get; set; }

    /// <summary>
    /// The minimum number of renewals to charge for
    /// </summary>
    /// <value>The minimum number of renewals to charge for</value>
    [DataMember(Name="min_cycles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_cycles")]
    public int? MinCycles { get; set; }

    /// <summary>
    /// The name of the plan used to generate the SKUs
    /// </summary>
    /// <value>The name of the plan used to generate the SKUs</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether this plan is currently available
    /// </summary>
    /// <value>Whether this plan is currently available</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// The fee to charge when a suspended subscription is to be re-activated
    /// </summary>
    /// <value>The fee to charge when a suspended subscription is to be re-activated</value>
    [DataMember(Name="reactivation_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactivation_fee")]
    public double? ReactivationFee { get; set; }

    /// <summary>
    /// The SKU that will show on the invoice when the subscription is re-activated after a suspension
    /// </summary>
    /// <value>The SKU that will show on the invoice when the subscription is re-activated after a suspension</value>
    [DataMember(Name="reactivation_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactivation_sku")]
    public string ReactivationSku { get; set; }

    /// <summary>
    /// The recurring fee to charge for each renewal
    /// </summary>
    /// <value>The recurring fee to charge for each renewal</value>
    [DataMember(Name="recurring_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring_fee")]
    public double? RecurringFee { get; set; }

    /// <summary>
    /// The SKU that will show on the invoice when the subscription is activated
    /// </summary>
    /// <value>The SKU that will show on the invoice when the subscription is activated</value>
    [DataMember(Name="recurring_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring_sku")]
    public string RecurringSku { get; set; }

    /// <summary>
    /// Used to schedule plan availability start date
    /// </summary>
    /// <value>Used to schedule plan availability start date</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionPlanResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  BillingCycleLength: ").Append(BillingCycleLength).Append("\n");
      sb.Append("  BillingCycleUnit: ").Append(BillingCycleUnit).Append("\n");
      sb.Append("  Consolidated: ").Append(Consolidated).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FirstBillingCycleLength: ").Append(FirstBillingCycleLength).Append("\n");
      sb.Append("  FirstBillingCycleUnit: ").Append(FirstBillingCycleUnit).Append("\n");
      sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InitialFee: ").Append(InitialFee).Append("\n");
      sb.Append("  InitialSku: ").Append(InitialSku).Append("\n");
      sb.Append("  LatePaymentFee: ").Append(LatePaymentFee).Append("\n");
      sb.Append("  LatePaymentSku: ").Append(LatePaymentSku).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  MaxBillAttempts: ").Append(MaxBillAttempts).Append("\n");
      sb.Append("  MaxCycles: ").Append(MaxCycles).Append("\n");
      sb.Append("  MigrateToPlan: ").Append(MigrateToPlan).Append("\n");
      sb.Append("  MinCycles: ").Append(MinCycles).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  ReactivationFee: ").Append(ReactivationFee).Append("\n");
      sb.Append("  ReactivationSku: ").Append(ReactivationSku).Append("\n");
      sb.Append("  RecurringFee: ").Append(RecurringFee).Append("\n");
      sb.Append("  RecurringSku: ").Append(RecurringSku).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
