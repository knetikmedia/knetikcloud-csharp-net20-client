using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.Model {

  /// <summary>
  /// Expressions are instructions for the rule engine to resolve certain values. For example instead of &#x60;user 1&#x60; it&#39;d state &#x60;user provided by the event&#x60;. Full list and definitions available at GET /bre/expressions.
  /// </summary>
  [DataContract]
  public class UsernameLookupResource {
    /// <summary>
    /// Gets or Sets Definition
    /// </summary>
    [DataMember(Name="definition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "definition")]
    public string Definition { get; set; }

    /// <summary>
    /// Gets or Sets LookupKey
    /// </summary>
    [DataMember(Name="lookup_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookup_key")]
    public ExpressionResource LookupKey { get; set; }

    /// <summary>
    /// Gets or Sets RequiredKeyType
    /// </summary>
    [DataMember(Name="required_key_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_key_type")]
    public string RequiredKeyType { get; set; }

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
      sb.Append("class UsernameLookupResource {\n");
      sb.Append("  Definition: ").Append(Definition).Append("\n");
      sb.Append("  LookupKey: ").Append(LookupKey).Append("\n");
      sb.Append("  RequiredKeyType: ").Append(RequiredKeyType).Append("\n");
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
