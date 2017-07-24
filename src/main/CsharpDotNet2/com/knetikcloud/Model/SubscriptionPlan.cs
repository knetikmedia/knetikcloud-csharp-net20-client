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
  public class SubscriptionPlan {
    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<string, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// Gets or Sets Availability
    /// </summary>
    [DataMember(Name="availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability")]
    public string Availability { get; set; }

    /// <summary>
    /// Gets or Sets BillGraceDays
    /// </summary>
    [DataMember(Name="bill_grace_days", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bill_grace_days")]
    public int? BillGraceDays { get; set; }

    /// <summary>
    /// Gets or Sets Consolidated
    /// </summary>
    [DataMember(Name="consolidated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consolidated")]
    public bool? Consolidated { get; set; }

    /// <summary>
    /// Gets or Sets FirstBill
    /// </summary>
    [DataMember(Name="first_bill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_bill")]
    public int? FirstBill { get; set; }

    /// <summary>
    /// Gets or Sets FirstBillUnitOfTime
    /// </summary>
    [DataMember(Name="first_bill_unit_of_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_bill_unit_of_time")]
    public string FirstBillUnitOfTime { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets LatePaymentSku
    /// </summary>
    [DataMember(Name="late_payment_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "late_payment_sku")]
    public string LatePaymentSku { get; set; }

    /// <summary>
    /// Gets or Sets Locked
    /// </summary>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Gets or Sets MaxAutoRenew
    /// </summary>
    [DataMember(Name="max_auto_renew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_auto_renew")]
    public int? MaxAutoRenew { get; set; }

    /// <summary>
    /// Gets or Sets MaxBillAttempts
    /// </summary>
    [DataMember(Name="max_bill_attempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_bill_attempts")]
    public int? MaxBillAttempts { get; set; }

    /// <summary>
    /// Gets or Sets MigrationPlan
    /// </summary>
    [DataMember(Name="migration_plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "migration_plan")]
    public string MigrationPlan { get; set; }

    /// <summary>
    /// Gets or Sets MinimumTerm
    /// </summary>
    [DataMember(Name="minimum_term", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_term")]
    public int? MinimumTerm { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PrimarySku
    /// </summary>
    [DataMember(Name="primary_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary_sku")]
    public string PrimarySku { get; set; }

    /// <summary>
    /// Gets or Sets ReactivationSku
    /// </summary>
    [DataMember(Name="reactivation_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactivation_sku")]
    public string ReactivationSku { get; set; }

    /// <summary>
    /// Gets or Sets RecurringSku
    /// </summary>
    [DataMember(Name="recurring_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring_sku")]
    public string RecurringSku { get; set; }

    /// <summary>
    /// Gets or Sets RenewPeriod
    /// </summary>
    [DataMember(Name="renew_period", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renew_period")]
    public int? RenewPeriod { get; set; }

    /// <summary>
    /// Gets or Sets RenewPeriodUnitOfTime
    /// </summary>
    [DataMember(Name="renew_period_unit_of_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renew_period_unit_of_time")]
    public string RenewPeriodUnitOfTime { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionId
    /// </summary>
    [DataMember(Name="subscription_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_id")]
    public int? SubscriptionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionPlan {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Availability: ").Append(Availability).Append("\n");
      sb.Append("  BillGraceDays: ").Append(BillGraceDays).Append("\n");
      sb.Append("  Consolidated: ").Append(Consolidated).Append("\n");
      sb.Append("  FirstBill: ").Append(FirstBill).Append("\n");
      sb.Append("  FirstBillUnitOfTime: ").Append(FirstBillUnitOfTime).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LatePaymentSku: ").Append(LatePaymentSku).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  MaxAutoRenew: ").Append(MaxAutoRenew).Append("\n");
      sb.Append("  MaxBillAttempts: ").Append(MaxBillAttempts).Append("\n");
      sb.Append("  MigrationPlan: ").Append(MigrationPlan).Append("\n");
      sb.Append("  MinimumTerm: ").Append(MinimumTerm).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PrimarySku: ").Append(PrimarySku).Append("\n");
      sb.Append("  ReactivationSku: ").Append(ReactivationSku).Append("\n");
      sb.Append("  RecurringSku: ").Append(RecurringSku).Append("\n");
      sb.Append("  RenewPeriod: ").Append(RenewPeriod).Append("\n");
      sb.Append("  RenewPeriodUnitOfTime: ").Append(RenewPeriodUnitOfTime).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
