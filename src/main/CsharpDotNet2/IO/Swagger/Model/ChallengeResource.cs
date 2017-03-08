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
  public class ChallengeResource {
    /// <summary>
    /// The number of activities allowed to this challenge
    /// </summary>
    /// <value>The number of activities allowed to this challenge</value>
    [DataMember(Name="activities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activities")]
    public int? Activities { get; set; }

    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events
    /// </summary>
    /// <value>The id of the campaign this challenge is a part of. The challenge must be tied to an active campaign before it will spawn events</value>
    [DataMember(Name="campaign_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "campaign_id")]
    public long? CampaignId { get; set; }

    /// <summary>
    /// The ID of the original challenge it was copied from
    /// </summary>
    /// <value>The ID of the original challenge it was copied from</value>
    [DataMember(Name="copy_of", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copy_of")]
    public long? CopyOf { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The end date of this challenge in seconds since epoch. required if part of a campaign
    /// </summary>
    /// <value>The end date of this challenge in seconds since epoch. required if part of a campaign</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public long? EndDate { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service.
    /// </summary>
    /// <value>The strategy for calculating the leaderboard. Defaults to highest score. Value MUST come from the list of available strategies from the Leaderboard Service.</value>
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
    /// The next date this challenge will be occur in seconds since epoch
    /// </summary>
    /// <value>The next date this challenge will be occur in seconds since epoch</value>
    [DataMember(Name="next_event_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_event_date")]
    public long? NextEventDate { get; set; }

    /// <summary>
    /// The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete
    /// </summary>
    /// <value>The number of minutes minimum to wait at the end of this challenge before running rewards, to allow activities to complete</value>
    [DataMember(Name="reward_lag_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_lag_minutes")]
    public int? RewardLagMinutes { get; set; }

    /// <summary>
    /// The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing
    /// </summary>
    /// <value>The rewards to give at the end of the challenge. When creating/updating only id is used. Reward set must be pre-existing</value>
    [DataMember(Name="reward_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_set")]
    public RewardSetResource RewardSet { get; set; }

    /// <summary>
    /// The repeat schedule for the challenge
    /// </summary>
    /// <value>The repeat schedule for the challenge</value>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public Schedule Schedule { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// The start date of this challenge in seconds since epoch. required if part of a campaign
    /// </summary>
    /// <value>The start date of this challenge in seconds since epoch. required if part of a campaign</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }

    /// <summary>
    /// A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done
    /// </summary>
    /// <value>A challenge template this challenge is validated against (private). May be null and no validation of additional_properties will be done</value>
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
      sb.Append("class ChallengeResource {\n");
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
      sb.Append("  CopyOf: ").Append(CopyOf).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LeaderboardStrategy: ").Append(LeaderboardStrategy).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NextEventDate: ").Append(NextEventDate).Append("\n");
      sb.Append("  RewardLagMinutes: ").Append(RewardLagMinutes).Append("\n");
      sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
