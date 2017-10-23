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
  public class OperationDefinitionResource {
    /// <summary>
    /// Gets or Sets Arguments
    /// </summary>
    [DataMember(Name="arguments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arguments")]
    public List<ArgumentResource> Arguments { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets _Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public ModelOperator _Operator { get; set; }

    /// <summary>
    /// Gets or Sets ReturnType
    /// </summary>
    [DataMember(Name="return_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_type")]
    public string ReturnType { get; set; }

    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationDefinitionResource {\n");
      sb.Append("  Arguments: ").Append(Arguments).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  ReturnType: ").Append(ReturnType).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
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
