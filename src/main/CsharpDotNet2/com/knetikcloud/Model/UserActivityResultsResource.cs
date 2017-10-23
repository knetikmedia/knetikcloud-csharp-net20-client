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
  public class UserActivityResultsResource {
    /// <summary>
    /// The raw score. Null means non-compete or disqualification
    /// </summary>
    /// <value>The raw score. Null means non-compete or disqualification</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public long? Score { get; set; }

    /// <summary>
    /// Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each
    /// </summary>
    /// <value>Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// The id of the player
    /// </summary>
    /// <value>The id of the player</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserActivityResultsResource {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
