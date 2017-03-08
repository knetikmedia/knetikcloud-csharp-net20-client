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
  public class XsollaPaymentRequest {
    /// <summary>
    /// The id of an invoice to pay
    /// </summary>
    /// <value>The id of an invoice to pay</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// The endpoint URL xsolla should forward the user to after they pay
    /// </summary>
    /// <value>The endpoint URL xsolla should forward the user to after they pay</value>
    [DataMember(Name="return_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_url")]
    public string ReturnUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class XsollaPaymentRequest {\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
