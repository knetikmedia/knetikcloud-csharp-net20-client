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
  public class CreateActivityOccurrenceRequest {
    /// <summary>
    /// The id of the activity, only needed when outside of challenge/event
    /// </summary>
    /// <value>The id of the activity, only needed when outside of challenge/event</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// The id of the challenge activity (required if playing in a challenge/event). Note that this is the challenge_activity_id in case the same activity apears twice in the challenge.
    /// </summary>
    /// <value>The id of the challenge activity (required if playing in a challenge/event). Note that this is the challenge_activity_id in case the same activity apears twice in the challenge.</value>
    [DataMember(Name="challenge_activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenge_activity_id")]
    public long? ChallengeActivityId { get; set; }

    /// <summary>
    /// The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity
    /// </summary>
    /// <value>The entitlement item required to enter the occurrence. Required if not part of an event. Must come from the set of entitlement items listed in the activity</value>
    [DataMember(Name="entitlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlement")]
    public ItemIdRequest Entitlement { get; set; }

    /// <summary>
    /// The id of the event this occurence is a part of, if any
    /// </summary>
    /// <value>The id of the event this occurence is a part of, if any</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public long? EventId { get; set; }

    /// <summary>
    /// The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.
    /// </summary>
    /// <value>The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<SelectedSettingRequest> Settings { get; set; }

    /// <summary>
    /// Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials
    /// </summary>
    /// <value>Whether this occurrence will be ran as a simulation. Simulations will not be rewarded. Useful for bot play or trials</value>
    [DataMember(Name="simulated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "simulated")]
    public bool? Simulated { get; set; }

    /// <summary>
    /// The current status of the occurrence (default: SETUP).
    /// </summary>
    /// <value>The current status of the occurrence (default: SETUP).</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission
    /// </summary>
    /// <value>The list of users participating in this occurrence. Can only be set directly with ACTIVITIES_ADMIN permission</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<Participant> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateActivityOccurrenceRequest {\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  ChallengeActivityId: ").Append(ChallengeActivityId).Append("\n");
      sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  Simulated: ").Append(Simulated).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
