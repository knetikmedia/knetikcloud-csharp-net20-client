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
  public class UserInventoryAddRequest {
    /// <summary>
    /// A note to be passed to the invoice or transaction
    /// </summary>
    /// <value>A note to be passed to the invoice or transaction</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// A list of behaviors to ignore explicitely.  Ex: 'limited_gettable'
    /// </summary>
    /// <value>A list of behaviors to ignore explicitely.  Ex: 'limited_gettable'</value>
    [DataMember(Name="overrides", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrides")]
    public List<string> Overrides { get; set; }

    /// <summary>
    /// If set to true will cause the endpoint to skip creation of cart and invoice to track the inventory change
    /// </summary>
    /// <value>If set to true will cause the endpoint to skip creation of cart and invoice to track the inventory change</value>
    [DataMember(Name="skip_invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skip_invoice")]
    public bool? SkipInvoice { get; set; }

    /// <summary>
    /// The specific SKU of the item to be added to the inventory
    /// </summary>
    /// <value>The specific SKU of the item to be added to the inventory</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserInventoryAddRequest {\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Overrides: ").Append(Overrides).Append("\n");
      sb.Append("  SkipInvoice: ").Append(SkipInvoice).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
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
