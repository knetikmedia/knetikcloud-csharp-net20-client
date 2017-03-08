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
  public class Order {
    /// <summary>
    /// Gets or Sets Ascending
    /// </summary>
    [DataMember(Name="ascending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ascending")]
    public bool? Ascending { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreCase
    /// </summary>
    [DataMember(Name="ignore_case", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignore_case")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// Gets or Sets NullHandling
    /// </summary>
    [DataMember(Name="null_handling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "null_handling")]
    public string NullHandling { get; set; }

    /// <summary>
    /// Gets or Sets Property
    /// </summary>
    [DataMember(Name="property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property")]
    public string Property { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Order {\n");
      sb.Append("  Ascending: ").Append(Ascending).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
      sb.Append("  NullHandling: ").Append(NullHandling).Append("\n");
      sb.Append("  Property: ").Append(Property).Append("\n");
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
