using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InventorySubscriptionResource {
    /// <summary>
    /// The date the subscription will be billed
    /// </summary>
    /// <value>The date the subscription will be billed</value>
    [DataMember(Name="bill_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bill_date")]
    public long? BillDate { get; set; }

    /// <summary>
    /// A credit of money already applied to a subscription for the next bill, or a debt if negative
    /// </summary>
    /// <value>A credit of money already applied to a subscription for the next bill, or a debt if negative</value>
    [DataMember(Name="credit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit")]
    public double? Credit { get; set; }

    /// <summary>
    /// A record of past and present credit/debt changes
    /// </summary>
    /// <value>A record of past and present credit/debt changes</value>
    [DataMember(Name="credit_log", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credit_log")]
    public List<SubscriptionCreditResource> CreditLog { get; set; }

    /// <summary>
    /// The date the grace period ends
    /// </summary>
    /// <value>The date the grace period ends</value>
    [DataMember(Name="grace_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grace_end")]
    public long? GraceEnd { get; set; }

    /// <summary>
    /// The id of the inventory
    /// </summary>
    /// <value>The id of the inventory</value>
    [DataMember(Name="inventory_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_id")]
    public int? InventoryId { get; set; }

    /// <summary>
    /// The inventory status object
    /// </summary>
    /// <value>The inventory status object</value>
    [DataMember(Name="inventory_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_status")]
    public string InventoryStatus { get; set; }

    /// <summary>
    /// The id of the item
    /// </summary>
    /// <value>The id of the item</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public int? ItemId { get; set; }

    /// <summary>
    /// The payment method object
    /// </summary>
    /// <value>The payment method object</value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method")]
    public PaymentMethodResource PaymentMethod { get; set; }

    /// <summary>
    /// The recurring price
    /// </summary>
    /// <value>The recurring price</value>
    [DataMember(Name="recurring_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurring_price")]
    public double? RecurringPrice { get; set; }

    /// <summary>
    /// The sku of the subscription
    /// </summary>
    /// <value>The sku of the subscription</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// The date the subscription will start
    /// </summary>
    /// <value>The date the subscription will start</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }

    /// <summary>
    /// The status of the subscription
    /// </summary>
    /// <value>The status of the subscription</value>
    [DataMember(Name="subscription_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_status")]
    public int? SubscriptionStatus { get; set; }

    /// <summary>
    /// The user
    /// </summary>
    /// <value>The user</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUserResource User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InventorySubscriptionResource {\n");
      sb.Append("  BillDate: ").Append(BillDate).Append("\n");
      sb.Append("  Credit: ").Append(Credit).Append("\n");
      sb.Append("  CreditLog: ").Append(CreditLog).Append("\n");
      sb.Append("  GraceEnd: ").Append(GraceEnd).Append("\n");
      sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
      sb.Append("  InventoryStatus: ").Append(InventoryStatus).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  RecurringPrice: ").Append(RecurringPrice).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  SubscriptionStatus: ").Append(SubscriptionStatus).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
