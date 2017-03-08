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
  public class WalletAlterRequest {
    /// <summary>
    /// The amount of currency to add/remove. positive to add, negative to remove
    /// </summary>
    /// <value>The amount of currency to add/remove. positive to add, negative to remove</value>
    [DataMember(Name="delta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delta")]
    public double? Delta { get; set; }

    /// <summary>
    /// The id of an invoice to attribute the transaction to
    /// </summary>
    /// <value>The id of an invoice to attribute the transaction to</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// The admin entered or system generated reason
    /// </summary>
    /// <value>The admin entered or system generated reason</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The transaction type to allow for search/etc
    /// </summary>
    /// <value>The transaction type to allow for search/etc</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WalletAlterRequest {\n");
      sb.Append("  Delta: ").Append(Delta).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
