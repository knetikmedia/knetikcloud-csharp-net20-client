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
  public class UserAchievementResource {
    /// <summary>
    /// Flag indicating whether the user has earned the achievement
    /// </summary>
    /// <value>Flag indicating whether the user has earned the achievement</value>
    [DataMember(Name="achieved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "achieved")]
    public bool? Achieved { get; set; }

    /// <summary>
    /// The achievement being tracked.  If used for Leveling, this represents the tier name
    /// </summary>
    /// <value>The achievement being tracked.  If used for Leveling, this represents the tier name</value>
    [DataMember(Name="achievement_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "achievement_name")]
    public string AchievementName { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The date/time the achievement was earned as a unix timestamp in seconds
    /// </summary>
    /// <value>The date/time the achievement was earned as a unix timestamp in seconds</value>
    [DataMember(Name="earned_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earned_date")]
    public long? EarnedDate { get; set; }

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
      sb.Append("class UserAchievementResource {\n");
      sb.Append("  Achieved: ").Append(Achieved).Append("\n");
      sb.Append("  AchievementName: ").Append(AchievementName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EarnedDate: ").Append(EarnedDate).Append("\n");
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
