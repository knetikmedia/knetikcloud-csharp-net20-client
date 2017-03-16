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
    /// Any currency rewarded to this user
    /// </summary>
    /// <value>Any currency rewarded to this user</value>
    [DataMember(Name="currency_rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_rewards")]
    public List<RewardCurrencyResource> CurrencyRewards { get; set; }

    /// <summary>
    /// Any items rewarded to this user
    /// </summary>
    /// <value>Any items rewarded to this user</value>
    [DataMember(Name="item_rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_rewards")]
    public List<RewardItemResource> ItemRewards { get; set; }

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
    /// Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each
    /// </summary>
    /// <value>Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 5 tags and 50 characters each</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// The number of users tied at this rank, including this user. 1 means no tie
    /// </summary>
    /// <value>The number of users tied at this rank, including this user. 1 means no tie</value>
    [DataMember(Name="ties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ties")]
    public int? Ties { get; set; }

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
      sb.Append("class UserActivityResultsResource {\n");
      sb.Append("  CurrencyRewards: ").Append(CurrencyRewards).Append("\n");
      sb.Append("  ItemRewards: ").Append(ItemRewards).Append("\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Ties: ").Append(Ties).Append("\n");
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
