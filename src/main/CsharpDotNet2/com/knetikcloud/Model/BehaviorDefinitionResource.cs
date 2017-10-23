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
  public class BehaviorDefinitionResource {
    /// <summary>
    /// Description of the behavior
    /// </summary>
    /// <value>Description of the behavior</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Pre-requisite behaviors that an item must have in order to also have this behavior
    /// </summary>
    /// <value>Pre-requisite behaviors that an item must have in order to also have this behavior</value>
    [DataMember(Name="prerequisite_behaviors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prerequisite_behaviors")]
    public List<Behavior> PrerequisiteBehaviors { get; set; }

    /// <summary>
    /// Configurable properties of the behavior
    /// </summary>
    /// <value>Configurable properties of the behavior</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<PropertyFieldResource> Properties { get; set; }

    /// <summary>
    /// The behavior type
    /// </summary>
    /// <value>The behavior type</value>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BehaviorDefinitionResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  PrerequisiteBehaviors: ").Append(PrerequisiteBehaviors).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
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
