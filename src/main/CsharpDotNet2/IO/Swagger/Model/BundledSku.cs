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
  public class BundledSku {
    /// <summary>
    /// The amount this item will cost inside the bundle instead of its regular price
    /// </summary>
    /// <value>The amount this item will cost inside the bundle instead of its regular price</value>
    [DataMember(Name="price_override", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_override")]
    public double? PriceOverride { get; set; }

    /// <summary>
    /// The quantity of this item within the bundle
    /// </summary>
    /// <value>The quantity of this item within the bundle</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// The stock keeping unit (SKU) for an item included in the bundle
    /// </summary>
    /// <value>The stock keeping unit (SKU) for an item included in the bundle</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BundledSku {\n");
      sb.Append("  PriceOverride: ").Append(PriceOverride).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
