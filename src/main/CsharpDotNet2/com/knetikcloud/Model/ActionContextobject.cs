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
  public class ActionContextobject {
    /// <summary>
    /// The mapping of the action context
    /// </summary>
    /// <value>The mapping of the action context</value>
    [DataMember(Name="mapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapping")]
    public Object Mapping { get; set; }

    /// <summary>
    /// The name of the action
    /// </summary>
    /// <value>The name of the action</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionContextobject {\n");
      sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
