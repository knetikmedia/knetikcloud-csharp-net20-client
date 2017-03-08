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
  public class InvoiceCreateRequest {
    /// <summary>
    /// The guid of a cart to create a new invoice for
    /// </summary>
    /// <value>The guid of a cart to create a new invoice for</value>
    [DataMember(Name="cart_guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cart_guid")]
    public string CartGuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceCreateRequest {\n");
      sb.Append("  CartGuid: ").Append(CartGuid).Append("\n");
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
