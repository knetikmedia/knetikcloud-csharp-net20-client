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
  public class ModelVideoRelationshipResource {
    /// <summary>
    /// The owner of the relationship
    /// </summary>
    /// <value>The owner of the relationship</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public ModelSimpleReferenceResourcelong From { get; set; }

    /// <summary>
    /// The id of the relationship
    /// </summary>
    /// <value>The id of the relationship</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Details about the relationship such as type or other information. Max length 10 characters
    /// </summary>
    /// <value>Details about the relationship such as type or other information. Max length 10 characters</value>
    [DataMember(Name="relationship_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationship_details")]
    public string RelationshipDetails { get; set; }

    /// <summary>
    /// The target of the relationship.
    /// </summary>
    /// <value>The target of the relationship.</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public ModelSimpleReferenceResourcelong To { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVideoRelationshipResource {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RelationshipDetails: ").Append(RelationshipDetails).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
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
