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
  public class SearchReferenceMapping {
    /// <summary>
    /// Unique identifier for the mapping to protect against duplicates
    /// </summary>
    /// <value>Unique identifier for the mapping to protect against duplicates</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The field within the type that contains the id from the refType
    /// </summary>
    /// <value>The field within the type that contains the id from the refType</value>
    [DataMember(Name="ref_id_field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref_id_field")]
    public string RefIdField { get; set; }

    /// <summary>
    /// The index type that the mapping pulls data from
    /// </summary>
    /// <value>The index type that the mapping pulls data from</value>
    [DataMember(Name="ref_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref_type")]
    public string RefType { get; set; }

    /// <summary>
    /// A map whose keys are the field names in the refType and values are the field name in the type
    /// </summary>
    /// <value>A map whose keys are the field names in the refType and values are the field name in the type</value>
    [DataMember(Name="source_field_to_destination_field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_field_to_destination_field")]
    public Dictionary<String, string> SourceFieldToDestinationField { get; set; }

    /// <summary>
    /// The index type that the mapping is for
    /// </summary>
    /// <value>The index type that the mapping is for</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchReferenceMapping {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RefIdField: ").Append(RefIdField).Append("\n");
      sb.Append("  RefType: ").Append(RefType).Append("\n");
      sb.Append("  SourceFieldToDestinationField: ").Append(SourceFieldToDestinationField).Append("\n");
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
