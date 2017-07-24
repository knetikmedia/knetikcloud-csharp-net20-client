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
  public class ReactivateSubscriptionRequest {
    /// <summary>
    /// The inventory to reactivate. Only required if using the deprecated subscriptions service
    /// </summary>
    /// <value>The inventory to reactivate. Only required if using the deprecated subscriptions service</value>
    [DataMember(Name="inventory_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_id")]
    public int? InventoryId { get; set; }

    /// <summary>
    /// Whether to add the additional reactivation fee in addition to the recurring fee
    /// </summary>
    /// <value>Whether to add the additional reactivation fee in addition to the recurring fee</value>
    [DataMember(Name="reactivation_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactivation_fee")]
    public bool? ReactivationFee { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReactivateSubscriptionRequest {\n");
      sb.Append("  InventoryId: ").Append(InventoryId).Append("\n");
      sb.Append("  ReactivationFee: ").Append(ReactivationFee).Append("\n");
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
