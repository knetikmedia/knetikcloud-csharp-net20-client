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
  public class SubscriptionCreditResource {
    /// <summary>
    /// The amount of the credit, negative for debt
    /// </summary>
    /// <value>The amount of the credit, negative for debt</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// The date this credit was added, unix timestamp in seconds
    /// </summary>
    /// <value>The date this credit was added, unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The id of the credit record
    /// </summary>
    /// <value>The id of the credit record</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The id of the subscription inventory entry
    /// </summary>
    /// <value>The id of the subscription inventory entry</value>
    [DataMember(Name="inventory_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_id")]
    public int? InventoryId { get; set; }

    /// <summary>
    /// The reason for the subscription credit
    /// </summary>
    /// <value>The reason for the subscription credit</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionCreditResource {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
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
