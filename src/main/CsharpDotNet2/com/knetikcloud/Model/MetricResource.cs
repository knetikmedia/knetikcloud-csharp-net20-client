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
  public class MetricResource {
    /// <summary>
    /// The id of the activity occurence where this score/metric occurred
    /// </summary>
    /// <value>The id of the activity occurence where this score/metric occurred</value>
    [DataMember(Name="activity_occurence_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_occurence_id")]
    public long? ActivityOccurenceId { get; set; }

    /// <summary>
    /// Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 10 tags and 50 characters each
    /// </summary>
    /// <value>Any tags for the metric. Each unique tag will translate into a unique leaderboard. Maximum 10 tags and 50 characters each</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// The id of the user this metric is for. Default to caller and requires METRICS_ADMIN permission to specify another
    /// </summary>
    /// <value>The id of the user this metric is for. Default to caller and requires METRICS_ADMIN permission to specify another</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// The value/score of the metric
    /// </summary>
    /// <value>The value/score of the metric</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public long? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetricResource {\n");
      sb.Append("  ActivityOccurenceId: ").Append(ActivityOccurenceId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
