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
  public class ModelPropertyFieldResource {
    /// <summary>
    /// A description of the field
    /// </summary>
    /// <value>A description of the field</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The type of values within a 'list' type field
    /// </summary>
    /// <value>The type of values within a 'list' type field</value>
    [DataMember(Name="inner_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inner_type")]
    public string InnerType { get; set; }

    /// <summary>
    /// A description of fields within objects within a 'list' type field, when inner_type is 'object'
    /// </summary>
    /// <value>A description of fields within objects within a 'list' type field, when inner_type is 'object'</value>
    [DataMember(Name="inner_type_fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inner_type_fields")]
    public List<ModelPropertyFieldResource> InnerTypeFields { get; set; }

    /// <summary>
    /// The name of the field
    /// </summary>
    /// <value>The name of the field</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether the field is required
    /// </summary>
    /// <value>Whether the field is required</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The type of the field
    /// </summary>
    /// <value>The type of the field</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// A list of valid values for 'enum' type fields
    /// </summary>
    /// <value>A list of valid values for 'enum' type fields</value>
    [DataMember(Name="valid_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid_values")]
    public List<string> ValidValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPropertyFieldResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  InnerType: ").Append(InnerType).Append("\n");
      sb.Append("  InnerTypeFields: ").Append(InnerTypeFields).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ValidValues: ").Append(ValidValues).Append("\n");
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
