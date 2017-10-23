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
  public class PaymentMethodTypeResource {
    /// <summary>
    /// The id of the payment method type
    /// </summary>
    /// <value>The id of the payment method type</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The maximum timelimit in hours for an invoice in the processing status while waiting on this payment method type. Defaults to the global config invoice.processing_expiration_hours if null
    /// </summary>
    /// <value>The maximum timelimit in hours for an invoice in the processing status while waiting on this payment method type. Defaults to the global config invoice.processing_expiration_hours if null</value>
    [DataMember(Name="invoice_processing_hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_processing_hours")]
    public int? InvoiceProcessingHours { get; set; }

    /// <summary>
    /// The name of the payment method type
    /// </summary>
    /// <value>The name of the payment method type</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether the payment handler supports the authorize and capture flow
    /// </summary>
    /// <value>Whether the payment handler supports the authorize and capture flow</value>
    [DataMember(Name="supports_capture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_capture")]
    public bool? SupportsCapture { get; set; }

    /// <summary>
    /// Whether the payment handler supports paying for part of an invoice, rather than the full grand_total
    /// </summary>
    /// <value>Whether the payment handler supports paying for part of an invoice, rather than the full grand_total</value>
    [DataMember(Name="supports_partial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_partial")]
    public bool? SupportsPartial { get; set; }

    /// <summary>
    /// Whether the payment handler supports rebilling the method later (for saved payments or subscriptions)
    /// </summary>
    /// <value>Whether the payment handler supports rebilling the method later (for saved payments or subscriptions)</value>
    [DataMember(Name="supports_rebill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_rebill")]
    public bool? SupportsRebill { get; set; }

    /// <summary>
    /// Whether the payment handler supports refunding
    /// </summary>
    /// <value>Whether the payment handler supports refunding</value>
    [DataMember(Name="supports_refunds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supports_refunds")]
    public bool? SupportsRefunds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethodTypeResource {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceProcessingHours: ").Append(InvoiceProcessingHours).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SupportsCapture: ").Append(SupportsCapture).Append("\n");
      sb.Append("  SupportsPartial: ").Append(SupportsPartial).Append("\n");
      sb.Append("  SupportsRebill: ").Append(SupportsRebill).Append("\n");
      sb.Append("  SupportsRefunds: ").Append(SupportsRefunds).Append("\n");
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
