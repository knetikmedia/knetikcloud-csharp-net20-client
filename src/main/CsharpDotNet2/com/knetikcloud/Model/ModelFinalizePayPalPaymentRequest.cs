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
  public class ModelFinalizePayPalPaymentRequest {
    /// <summary>
    /// The ID of the invoice that is being paid. Must match the invoice sent in originally
    /// </summary>
    /// <value>The ID of the invoice that is being paid. Must match the invoice sent in originally</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// The ID of the payer that PayPal returned with the user at the return URL
    /// </summary>
    /// <value>The ID of the payer that PayPal returned with the user at the return URL</value>
    [DataMember(Name="payer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payer_id")]
    public string PayerId { get; set; }

    /// <summary>
    /// The token that PayPal returned with the user in the return URL
    /// </summary>
    /// <value>The token that PayPal returned with the user in the return URL</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelFinalizePayPalPaymentRequest {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  PayerId: ").Append(PayerId).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
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
