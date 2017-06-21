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
  public class ModelGlobalCheckAndIncrementResource {
    /// <summary>
    /// Gets or Sets CheckValueResource
    /// </summary>
    [DataMember(Name="check_value_resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "check_value_resource")]
    public ModelExpressionResource CheckValueResource { get; set; }

    /// <summary>
    /// Gets or Sets GlobalResource
    /// </summary>
    [DataMember(Name="global_resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "global_resource")]
    public ModelExpressionResource GlobalResource { get; set; }

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
      sb.Append("class ModelGlobalCheckAndIncrementResource {\n");
      sb.Append("  CheckValueResource: ").Append(CheckValueResource).Append("\n");
      sb.Append("  GlobalResource: ").Append(GlobalResource).Append("\n");
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
