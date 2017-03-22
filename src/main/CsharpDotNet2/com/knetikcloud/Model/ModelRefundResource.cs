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
  public class ModelRefundResource {
    /// <summary>
    /// The amount refunded
    /// </summary>
    /// <value>The amount refunded</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// The id of the refund transaction
    /// </summary>
    /// <value>The id of the refund transaction</value>
    [DataMember(Name="refund_transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refund_transaction_id")]
    public int? RefundTransactionId { get; set; }

    /// <summary>
    /// The id of the original transaction
    /// </summary>
    /// <value>The id of the original transaction</value>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_id")]
    public int? TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelRefundResource {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  RefundTransactionId: ").Append(RefundTransactionId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
