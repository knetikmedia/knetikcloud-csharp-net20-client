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
  public class BareChallengeActivityResource {
    /// <summary>
    /// The id of the activity
    /// </summary>
    /// <value>The id of the activity</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// The id of the challenge
    /// </summary>
    /// <value>The id of the challenge</value>
    [DataMember(Name="challenge_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenge_id")]
    public long? ChallengeId { get; set; }

    /// <summary>
    /// The unique ID for this resource
    /// </summary>
    /// <value>The unique ID for this resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BareChallengeActivityResource {\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  ChallengeId: ").Append(ChallengeId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
