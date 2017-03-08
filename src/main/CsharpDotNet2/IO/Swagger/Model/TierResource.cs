using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TierResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The name of the tier
    /// </summary>
    /// <value>The name of the tier</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The required progress for the tier
    /// </summary>
    /// <value>The required progress for the tier</value>
    [DataMember(Name="required_progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_progress")]
    public int? RequiredProgress { get; set; }

    /// <summary>
    /// The name of the triggered event
    /// </summary>
    /// <value>The name of the triggered event</value>
    [DataMember(Name="trigger_event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trigger_event_name")]
    public string TriggerEventName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TierResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RequiredProgress: ").Append(RequiredProgress).Append("\n");
      sb.Append("  TriggerEventName: ").Append(TriggerEventName).Append("\n");
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
