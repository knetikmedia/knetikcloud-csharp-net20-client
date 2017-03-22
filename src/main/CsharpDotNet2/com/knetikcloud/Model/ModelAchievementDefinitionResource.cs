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
  public class ModelAchievementDefinitionResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this resource type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, ModelProperty> AdditionalProperties { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The description of the achievement. Must be at least 2 characters in length.
    /// </summary>
    /// <value>The description of the achievement. Must be at least 2 characters in length.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether the achievement is hidden from the user
    /// </summary>
    /// <value>Whether the achievement is hidden from the user</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// The name of the achievement. Must be at least 6 characters in length. IMMUTABLE
    /// </summary>
    /// <value>The name of the achievement. Must be at least 6 characters in length. IMMUTABLE</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The required progress for the achievement definition
    /// </summary>
    /// <value>The required progress for the achievement definition</value>
    [DataMember(Name="required_progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_progress")]
    public int? RequiredProgress { get; set; }

    /// <summary>
    /// The id of the rule generated for this achievement
    /// </summary>
    /// <value>The id of the rule generated for this achievement</value>
    [DataMember(Name="rule_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule_id")]
    public string RuleId { get; set; }

    /// <summary>
    /// The tags for the achievement definition
    /// </summary>
    /// <value>The tags for the achievement definition</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done
    /// </summary>
    /// <value>An achievement template this achievement is validated against (private). May be null and no validation of additional_properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The name of the trigger event associated with this achievement
    /// </summary>
    /// <value>The name of the trigger event associated with this achievement</value>
    [DataMember(Name="trigger_event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trigger_event_name")]
    public string TriggerEventName { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAchievementDefinitionResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RequiredProgress: ").Append(RequiredProgress).Append("\n");
      sb.Append("  RuleId: ").Append(RuleId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  TriggerEventName: ").Append(TriggerEventName).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
