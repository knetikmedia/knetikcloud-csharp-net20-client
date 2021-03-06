using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.Model {

  /// <summary>
  /// A occurrence of an activity (the actual game for example). Used to track scores, participants, and provide settings
  /// </summary>
  [DataContract]
  public class ActivityOccurrenceResource {
    /// <summary>
    /// The id of the activity
    /// </summary>
    /// <value>The id of the activity</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint
    /// </summary>
    /// <value>The ids of banned users that cannot join the occurrence. See occurrence-user delete endpoint</value>
    [DataMember(Name="bans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bans")]
    public List<int?> Bans { get; set; }

    /// <summary>
    /// The id of the challenge activity (as part of the event, required if eventId set)
    /// </summary>
    /// <value>The id of the challenge activity (as part of the event, required if eventId set)</value>
    [DataMember(Name="challenge_activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenge_activity_id")]
    public long? ChallengeActivityId { get; set; }

    /// <summary>
    /// Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.
    /// </summary>
    /// <value>Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.</value>
    [DataMember(Name="core_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "core_settings")]
    public CoreActivityOccurrenceSettings CoreSettings { get; set; }

    /// <summary>
    /// The date this occurrence was created, unix timestamp in seconds
    /// </summary>
    /// <value>The date this occurrence was created, unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity
    /// </summary>
    /// <value>The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity</value>
    [DataMember(Name="entitlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlement")]
    public ActivityEntitlementResource Entitlement { get; set; }

    /// <summary>
    /// The id of the event
    /// </summary>
    /// <value>The id of the event</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public long? EventId { get; set; }

    /// <summary>
    /// The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of 'non_player' if not admin as well
    /// </summary>
    /// <value>The host of the occurrence, if not a participant (will be left out of users array). Must be the caller that creates the occurrence unless admin. Requires activity/challenge to allow host_option of 'non_player' if not admin as well</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public SimpleUserResource Host { get; set; }

    /// <summary>
    /// The id of the activity occurrence
    /// </summary>
    /// <value>The id of the activity occurrence</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Indicate if the rewards have been given out already
    /// </summary>
    /// <value>Indicate if the rewards have been given out already</value>
    [DataMember(Name="reward_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_status")]
    public string RewardStatus { get; set; }

    /// <summary>
    /// The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.
    /// </summary>
    /// <value>The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<SelectedSettingResource> Settings { get; set; }

    /// <summary>
    /// Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials
    /// </summary>
    /// <value>Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials</value>
    [DataMember(Name="simulated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "simulated")]
    public bool? Simulated { get; set; }

    /// <summary>
    /// The date this occurrence was started, unix timestamp in seconds. null if not yet started
    /// </summary>
    /// <value>The date this occurrence was started, unix timestamp in seconds. null if not yet started</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }

    /// <summary>
    /// The current status of the occurrence (default: OPEN)
    /// </summary>
    /// <value>The current status of the occurrence (default: OPEN)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The date this occurrence was last updated, unix timestamp in seconds
    /// </summary>
    /// <value>The date this occurrence was last updated, unix timestamp in seconds</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission
    /// </summary>
    /// <value>The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<ActivityUserResource> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityOccurrenceResource {\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  Bans: ").Append(Bans).Append("\n");
      sb.Append("  ChallengeActivityId: ").Append(ChallengeActivityId).Append("\n");
      sb.Append("  CoreSettings: ").Append(CoreSettings).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RewardStatus: ").Append(RewardStatus).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  Simulated: ").Append(Simulated).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
