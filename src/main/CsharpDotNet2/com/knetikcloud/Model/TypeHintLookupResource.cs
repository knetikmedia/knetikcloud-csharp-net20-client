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
  public class TypeHintLookupResource {
    /// <summary>
    /// Gets or Sets LookupKey
    /// </summary>
    [DataMember(Name="lookup_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookup_key")]
    public ExpressionResource LookupKey { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets ValueType
    /// </summary>
    [DataMember(Name="value_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_type")]
    public string ValueType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TypeHintLookupResource {\n");
      sb.Append("  LookupKey: ").Append(LookupKey).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
