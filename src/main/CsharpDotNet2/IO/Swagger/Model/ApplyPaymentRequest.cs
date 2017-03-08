using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApplyPaymentRequest {
    /// <summary>
    /// The id of the local invoice being paid.
    /// </summary>
    /// <value>The id of the local invoice being paid.</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// The encoded receipt string from Apple's services.
    /// </summary>
    /// <value>The encoded receipt string from Apple's services.</value>
    [DataMember(Name="receipt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receipt")]
    public string Receipt { get; set; }

    /// <summary>
    /// The id of the specific transaction from Apple's services.
    /// </summary>
    /// <value>The id of the specific transaction from Apple's services.</value>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_id")]
    public string TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplyPaymentRequest {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  Receipt: ").Append(Receipt).Append("\n");
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
