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
  public class ModelCampaignResource {
    /// <summary>
    /// Whether the campaign is active or not.  Defaults to false
    /// </summary>
    /// <value>Whether the campaign is active or not.  Defaults to false</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, ModelProperty> AdditionalProperties { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service
    /// </summary>
    /// <value>The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service</value>
    [DataMember(Name="leaderboard_strategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leaderboard_strategy")]
    public string LeaderboardStrategy { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The user friendly name of that resource
    /// </summary>
    /// <value>The user friendly name of that resource</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The name of the next challenge coming up
    /// </summary>
    /// <value>The name of the next challenge coming up</value>
    [DataMember(Name="next_challenge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_challenge")]
    public string NextChallenge { get; set; }

    /// <summary>
    /// The date/time of the next challenge coming up
    /// </summary>
    /// <value>The date/time of the next challenge coming up</value>
    [DataMember(Name="next_challenge_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_challenge_date")]
    public long? NextChallengeDate { get; set; }

    /// <summary>
    /// The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing
    /// </summary>
    /// <value>The rewards to give at the end of the campaign. When creating/updating only id is used. Reward set must be pre-existing</value>
    [DataMember(Name="reward_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_set")]
    public ModelRewardSetResource RewardSet { get; set; }

    /// <summary>
    /// Indicate if the rewards have been given out already
    /// </summary>
    /// <value>Indicate if the rewards have been given out already</value>
    [DataMember(Name="reward_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_status")]
    public string RewardStatus { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done
    /// </summary>
    /// <value>A campaign template this campaign is validated against (private). May be null and no validation of additional_properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCampaignResource {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LeaderboardStrategy: ").Append(LeaderboardStrategy).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NextChallenge: ").Append(NextChallenge).Append("\n");
      sb.Append("  NextChallengeDate: ").Append(NextChallengeDate).Append("\n");
      sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
      sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
