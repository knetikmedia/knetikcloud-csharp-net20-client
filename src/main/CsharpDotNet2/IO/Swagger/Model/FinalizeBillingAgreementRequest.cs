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
  public class FinalizeBillingAgreementRequest {
    /// <summary>
    /// The ID of the invoice being paid along with the creation of this agreement
    /// </summary>
    /// <value>The ID of the invoice being paid along with the creation of this agreement</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// Whether the new payment method created should be the user's default
    /// </summary>
    /// <value>Whether the new payment method created should be the user's default</value>
    [DataMember(Name="new_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_default")]
    public bool? NewDefault { get; set; }

    /// <summary>
    /// The payer ID from PayPal (passed as a parameter in the return URL). Only required if an invoice ID was included
    /// </summary>
    /// <value>The payer ID from PayPal (passed as a parameter in the return URL). Only required if an invoice ID was included</value>
    [DataMember(Name="payer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payer_id")]
    public string PayerId { get; set; }

    /// <summary>
    /// The token from PayPal (passed as a parameter in the return URL)
    /// </summary>
    /// <value>The token from PayPal (passed as a parameter in the return URL)</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// The ID of the user. Defaults to the logged in user
    /// </summary>
    /// <value>The ID of the user. Defaults to the logged in user</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FinalizeBillingAgreementRequest {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  NewDefault: ").Append(NewDefault).Append("\n");
      sb.Append("  PayerId: ").Append(PayerId).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
