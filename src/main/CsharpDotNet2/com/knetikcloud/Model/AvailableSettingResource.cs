using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.Model {

  /// <summary>
  /// The definition of an activity parameters: ex: difficulty level
  /// </summary>
  [DataContract]
  public class AvailableSettingResource {
    /// <summary>
    /// Whether the setting is advanced. Default: false
    /// </summary>
    /// <value>Whether the setting is advanced. Default: false</value>
    [DataMember(Name="advanced_option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advanced_option")]
    public bool? AdvancedOption { get; set; }

    /// <summary>
    /// The default value of the setting (must be in options array). Ex: easy
    /// </summary>
    /// <value>The default value of the setting (must be in options array). Ex: easy</value>
    [DataMember(Name="default_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_value")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// The description of the setting: Ex: Choose the difficulty level to show more or less complicated questions (for a trivia activity)
    /// </summary>
    /// <value>The description of the setting: Ex: Choose the difficulty level to show more or less complicated questions (for a trivia activity)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The unique ID for the setting: Ex: difficulty
    /// </summary>
    /// <value>The unique ID for the setting: Ex: difficulty</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// The textual name of the setting: Ex: Difficulty Level
    /// </summary>
    /// <value>The textual name of the setting: Ex: Difficulty Level</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The set of options available for this setting, Ex: easy, medium, hard
    /// </summary>
    /// <value>The set of options available for this setting, Ex: easy, medium, hard</value>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public List<SettingOption> Options { get; set; }

    /// <summary>
    /// The type of the setting value: Ex: TEXT
    /// </summary>
    /// <value>The type of the setting value: Ex: TEXT</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AvailableSettingResource {\n");
      sb.Append("  AdvancedOption: ").Append(AdvancedOption).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
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
