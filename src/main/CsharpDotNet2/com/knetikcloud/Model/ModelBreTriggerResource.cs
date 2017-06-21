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
  public class ModelBreTriggerResource {
    /// <summary>
    /// The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'
    /// </summary>
    /// <value>The category this trigger belongs to. See endpoints for related asset information. All new triggers are in category 'custom'</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// The unique name for the event. This serves as the unique identifier. Cannot be changed after creation
    /// </summary>
    /// <value>The unique name for the event. This serves as the unique identifier. Cannot be changed after creation</value>
    [DataMember(Name="event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_name")]
    public string EventName { get; set; }

    /// <summary>
    /// A list of parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types
    /// </summary>
    /// <value>A list of parameters that will be sent with the event when the trigger is fired. These must be included in the event and match the described types</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<ModelBreTriggerParameterDefinition> Parameters { get; set; }

    /// <summary>
    /// Where this trigger came from. System triggers cannot be removed or updated
    /// </summary>
    /// <value>Where this trigger came from. System triggers cannot be removed or updated</value>
    [DataMember(Name="system_trigger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_trigger")]
    public bool? SystemTrigger { get; set; }

    /// <summary>
    /// A list of tags for filtering
    /// </summary>
    /// <value>A list of tags for filtering</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// A description of the trigger
    /// </summary>
    /// <value>A description of the trigger</value>
    [DataMember(Name="trigger_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trigger_description")]
    public string TriggerDescription { get; set; }

    /// <summary>
    /// A human readable name for this trigger
    /// </summary>
    /// <value>A human readable name for this trigger</value>
    [DataMember(Name="trigger_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trigger_name")]
    public string TriggerName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelBreTriggerResource {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  SystemTrigger: ").Append(SystemTrigger).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  TriggerDescription: ").Append(TriggerDescription).Append("\n");
      sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
