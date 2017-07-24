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
  public class PredicateResource {
    /// <summary>
    /// The arguments the operator apply to. See notes for details.
    /// </summary>
    /// <value>The arguments the operator apply to. See notes for details.</value>
    [DataMember(Name="args", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "args")]
    public List<ExpressionResource> Args { get; set; }

    /// <summary>
    /// The operator to be used in this predicate. See notes for details.
    /// </summary>
    /// <value>The operator to be used in this predicate. See notes for details.</value>
    [DataMember(Name="op", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "op")]
    public string Op { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PredicateResource {\n");
      sb.Append("  Args: ").Append(Args).Append("\n");
      sb.Append("  Op: ").Append(Op).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
