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
  public class ModelChallengeEventResource {
    /// <summary>
    /// The id of the challenge
    /// </summary>
    /// <value>The id of the challenge</value>
    [DataMember(Name="challenge_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenge_id")]
    public long? ChallengeId { get; set; }

    /// <summary>
    /// The end date in seconds
    /// </summary>
    /// <value>The end date in seconds</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public long? EndDate { get; set; }

    /// <summary>
    /// The id of the challenge event
    /// </summary>
    /// <value>The id of the challenge event</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Indicate if the rewards have been given out already 
    /// </summary>
    /// <value>Indicate if the rewards have been given out already </value>
    [DataMember(Name="reward_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_status")]
    public string RewardStatus { get; set; }

    /// <summary>
    /// The start date in seconds
    /// </summary>
    /// <value>The start date in seconds</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelChallengeEventResource {\n");
      sb.Append("  ChallengeId: ").Append(ChallengeId).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
