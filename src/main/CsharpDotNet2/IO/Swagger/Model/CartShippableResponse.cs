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
  public class CartShippableResponse {
    /// <summary>
    /// The id of the cart
    /// </summary>
    /// <value>The id of the cart</value>
    [DataMember(Name="cart_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cart_id")]
    public int? CartId { get; set; }

    /// <summary>
    /// Whether the item is shippable
    /// </summary>
    /// <value>Whether the item is shippable</value>
    [DataMember(Name="shippable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippable")]
    public bool? Shippable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartShippableResponse {\n");
      sb.Append("  CartId: ").Append(CartId).Append("\n");
      sb.Append("  Shippable: ").Append(Shippable).Append("\n");
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
