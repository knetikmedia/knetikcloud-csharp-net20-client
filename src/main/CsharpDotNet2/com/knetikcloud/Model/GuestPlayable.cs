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
  public class GuestPlayable : Behavior {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Used for polymorphic type recognition and thus must match an expected type with additional properties
    /// </summary>
    /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }

    /// <summary>
    /// Whether guests are allowed to use items
    /// </summary>
    /// <value>Whether guests are allowed to use items</value>
    [DataMember(Name="allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed")]
    public bool? Allowed { get; set; }

    /// <summary>
    /// Whether guests are allowed on the leaderboard
    /// </summary>
    /// <value>Whether guests are allowed on the leaderboard</value>
    [DataMember(Name="leaderboard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leaderboard")]
    public bool? Leaderboard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GuestPlayable {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
      sb.Append("  Allowed: ").Append(Allowed).Append("\n");
      sb.Append("  Leaderboard: ").Append(Leaderboard).Append("\n");
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
