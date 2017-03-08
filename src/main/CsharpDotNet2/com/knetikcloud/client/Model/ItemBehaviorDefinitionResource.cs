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
  public class ItemBehaviorDefinitionResource {
    /// <summary>
    /// The default version of the behavior
    /// </summary>
    /// <value>The default version of the behavior</value>
    [DataMember(Name="behavior", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "behavior")]
    public Behavior Behavior { get; set; }

    /// <summary>
    /// Whether the behavior's values can be modified
    /// </summary>
    /// <value>Whether the behavior's values can be modified</value>
    [DataMember(Name="modifiable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiable")]
    public bool? Modifiable { get; set; }

    /// <summary>
    /// Whether the behavior can be removed
    /// </summary>
    /// <value>Whether the behavior can be removed</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ItemBehaviorDefinitionResource {\n");
      sb.Append("  Behavior: ").Append(Behavior).Append("\n");
      sb.Append("  Modifiable: ").Append(Modifiable).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
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
