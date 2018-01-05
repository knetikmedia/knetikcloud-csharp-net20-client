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
  public class ListPropertyDefinitionResource : PropertyDefinitionResource {
    /// <summary>
    /// The description of the property
    /// </summary>
    /// <value>The description of the property</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// A list of the fields on both the property definition and property of this type
    /// </summary>
    /// <value>A list of the fields on both the property definition and property of this type</value>
    [DataMember(Name="field_list", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field_list")]
    public PropertyFieldListResource FieldList { get; set; }

    /// <summary>
    /// The friendly front-facing name of the property
    /// </summary>
    /// <value>The friendly front-facing name of the property</value>
    [DataMember(Name="friendly_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friendly_name")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// The name of the property
    /// </summary>
    /// <value>The name of the property</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The JSON path to the option label
    /// </summary>
    /// <value>The JSON path to the option label</value>
    [DataMember(Name="option_label_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_label_path")]
    public string OptionLabelPath { get; set; }

    /// <summary>
    /// The JSON path to the option value
    /// </summary>
    /// <value>The JSON path to the option value</value>
    [DataMember(Name="option_value_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "option_value_path")]
    public string OptionValuePath { get; set; }

    /// <summary>
    /// URL of service containing the property options (assumed JSON array)
    /// </summary>
    /// <value>URL of service containing the property options (assumed JSON array)</value>
    [DataMember(Name="options_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options_url")]
    public string OptionsUrl { get; set; }

    /// <summary>
    /// Whether the property is required
    /// </summary>
    /// <value>Whether the property is required</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
    /// </summary>
    /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// If provided, the maximum number of files in the group
    /// </summary>
    /// <value>If provided, the maximum number of files in the group</value>
    [DataMember(Name="max_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_count")]
    public int? MaxCount { get; set; }

    /// <summary>
    /// If provided, the minimum number of files in the group
    /// </summary>
    /// <value>If provided, the minimum number of files in the group</value>
    [DataMember(Name="min_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_count")]
    public int? MinCount { get; set; }

    /// <summary>
    /// If provided, a property definition for validating values within list
    /// </summary>
    /// <value>If provided, a property definition for validating values within list</value>
    [DataMember(Name="value_definition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_definition")]
    public PropertyDefinitionResource ValueDefinition { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListPropertyDefinitionResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FieldList: ").Append(FieldList).Append("\n");
      sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OptionLabelPath: ").Append(OptionLabelPath).Append("\n");
      sb.Append("  OptionValuePath: ").Append(OptionValuePath).Append("\n");
      sb.Append("  OptionsUrl: ").Append(OptionsUrl).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MaxCount: ").Append(MaxCount).Append("\n");
      sb.Append("  MinCount: ").Append(MinCount).Append("\n");
      sb.Append("  ValueDefinition: ").Append(ValueDefinition).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
