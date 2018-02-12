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
  public class ActivityOccurrenceSettingsResource {
    /// <summary>
    /// Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.
    /// </summary>
    /// <value>Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.</value>
    [DataMember(Name="core_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "core_settings")]
    public CoreActivityOccurrenceSettings CoreSettings { get; set; }

    /// <summary>
    /// The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.
    /// </summary>
    /// <value>The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<SelectedSettingRequest> Settings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityOccurrenceSettingsResource {\n");
      sb.Append("  CoreSettings: ").Append(CoreSettings).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
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
