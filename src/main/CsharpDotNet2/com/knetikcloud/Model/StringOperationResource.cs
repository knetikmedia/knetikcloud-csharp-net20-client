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
  public class StringOperationResource {
    /// <summary>
    /// The arguments the operator apply to. See notes for details.
    /// </summary>
    /// <value>The arguments the operator apply to. See notes for details.</value>
    [DataMember(Name="args", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "args")]
    public List<ExpressionResource> Args { get; set; }

    /// <summary>
    /// Gets or Sets Definition
    /// </summary>
    [DataMember(Name="definition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "definition")]
    public string Definition { get; set; }

    /// <summary>
    /// The operator to be used in this predicate. See notes for details.
    /// </summary>
    /// <value>The operator to be used in this predicate. See notes for details.</value>
    [DataMember(Name="op", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "op")]
    public string Op { get; set; }

    /// <summary>
    /// Gets or Sets ReturnType
    /// </summary>
    [DataMember(Name="return_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_type")]
    public string ReturnType { get; set; }

    /// <summary>
    /// The operators supported by this expression
    /// </summary>
    /// <value>The operators supported by this expression</value>
    [DataMember(Name="supported_operators", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supported_operators")]
    public List<OperationDefinitionResource> SupportedOperators { get; set; }

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
      sb.Append("class StringOperationResource {\n");
      sb.Append("  Args: ").Append(Args).Append("\n");
      sb.Append("  Definition: ").Append(Definition).Append("\n");
      sb.Append("  Op: ").Append(Op).Append("\n");
      sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
      sb.Append("  SupportedOperators: ").Append(SupportedOperators).Append("\n");
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
