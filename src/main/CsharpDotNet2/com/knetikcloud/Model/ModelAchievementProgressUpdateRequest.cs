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
  public class ModelAchievementProgressUpdateRequest {
    /// <summary>
    /// Whether to add one to the current progress instead of setting it to progress_value. Default: false
    /// </summary>
    /// <value>Whether to add one to the current progress instead of setting it to progress_value. Default: false</value>
    [DataMember(Name="increment_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "increment_value")]
    public bool? IncrementValue { get; set; }

    /// <summary>
    /// The amount of progress towards earning the achievement. The max/target depends on the achievement. Required if increment_value is false/missing.
    /// </summary>
    /// <value>The amount of progress towards earning the achievement. The max/target depends on the achievement. Required if increment_value is false/missing.</value>
    [DataMember(Name="progress_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress_value")]
    public int? ProgressValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAchievementProgressUpdateRequest {\n");
      sb.Append("  IncrementValue: ").Append(IncrementValue).Append("\n");
      sb.Append("  ProgressValue: ").Append(ProgressValue).Append("\n");
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
