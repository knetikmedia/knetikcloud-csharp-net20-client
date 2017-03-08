using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LeaderboardEntryResource {
    /// <summary>
    /// The position of the user in the leaderboard. Null means non-compete or disqualification
    /// </summary>
    /// <value>The position of the user in the leaderboard. Null means non-compete or disqualification</value>
    [DataMember(Name="rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rank")]
    public long? Rank { get; set; }

    /// <summary>
    /// The raw score in this leaderboard. Null means non-compete or disqualification
    /// </summary>
    /// <value>The raw score in this leaderboard. Null means non-compete or disqualification</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public long? Score { get; set; }

    /// <summary>
    /// The player for this entry
    /// </summary>
    /// <value>The player for this entry</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUserResource User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LeaderboardEntryResource {\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
