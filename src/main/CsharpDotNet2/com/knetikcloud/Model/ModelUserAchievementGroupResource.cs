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
  public class ModelUserAchievementGroupResource {
    /// <summary>
    /// The list of achievements associated with the group
    /// </summary>
    /// <value>The list of achievements associated with the group</value>
    [DataMember(Name="achievements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "achievements")]
    public List<ModelUserAchievementResource> Achievements { get; set; }

    /// <summary>
    /// The name of the group.  If used by Leveling, this will represent the level name
    /// </summary>
    /// <value>The name of the group.  If used by Leveling, this will represent the level name</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// The id of the achievement progress
    /// </summary>
    /// <value>The id of the achievement progress</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The current progress of the user on the group
    /// </summary>
    /// <value>The current progress of the user on the group</value>
    [DataMember(Name="progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress")]
    public int? Progress { get; set; }

    /// <summary>
    /// The id of the user whose progress is being tracked
    /// </summary>
    /// <value>The id of the user whose progress is being tracked</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelUserAchievementGroupResource {\n");
      sb.Append("  Achievements: ").Append(Achievements).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Progress: ").Append(Progress).Append("\n");
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
