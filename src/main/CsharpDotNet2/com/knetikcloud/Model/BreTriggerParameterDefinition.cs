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
  public class BreTriggerParameterDefinition {
    /// <summary>
    /// Whether this parameter is implicitely derived from another. Internal use only.
    /// </summary>
    /// <value>Whether this parameter is implicitely derived from another. Internal use only.</value>
    [DataMember(Name="implicit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implicit")]
    public bool? _Implicit { get; set; }

    /// <summary>
    /// The name of the parameter. This is used as the unique identifier of this parameter
    /// </summary>
    /// <value>The name of the parameter. This is used as the unique identifier of this parameter</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether this parameter can be left off when firing the event. Default false
    /// </summary>
    /// <value>Whether this parameter can be left off when firing the event. Default false</value>
    [DataMember(Name="optional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optional")]
    public bool? Optional { get; set; }

    /// <summary>
    /// The variable type of this parameter. See Bre Variables endpoint for list
    /// </summary>
    /// <value>The variable type of this parameter. See Bre Variables endpoint for list</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BreTriggerParameterDefinition {\n");
      sb.Append("  _Implicit: ").Append(_Implicit).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Optional: ").Append(Optional).Append("\n");
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
