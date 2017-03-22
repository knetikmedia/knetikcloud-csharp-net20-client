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
  public class ModelActivityUserResource {
    /// <summary>
    /// Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)
    /// </summary>
    /// <value>Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public bool? Host { get; set; }

    /// <summary>
    /// The id of the activity user entry
    /// </summary>
    /// <value>The id of the activity user entry</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The date this user last joined the occurrence, unix timestamp in seconds
    /// </summary>
    /// <value>The date this user last joined the occurrence, unix timestamp in seconds</value>
    [DataMember(Name="joined_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joined_date")]
    public long? JoinedDate { get; set; }

    /// <summary>
    /// The date this user last left the occurrence, unix timestamp in seconds. Null if still present
    /// </summary>
    /// <value>The date this user last left the occurrence, unix timestamp in seconds. Null if still present</value>
    [DataMember(Name="left_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left_date")]
    public long? LeftDate { get; set; }

    /// <summary>
    /// The metric for the user's results, after the game is over
    /// </summary>
    /// <value>The metric for the user's results, after the game is over</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public ModelMetricResource Metric { get; set; }

    /// <summary>
    /// The current status of the user in the occurrence (default: present)
    /// </summary>
    /// <value>The current status of the user in the occurrence (default: present)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The user
    /// </summary>
    /// <value>The user</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public ModelSimpleUserResource User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelActivityUserResource {\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  JoinedDate: ").Append(JoinedDate).Append("\n");
      sb.Append("  LeftDate: ").Append(LeftDate).Append("\n");
      sb.Append("  Metric: ").Append(Metric).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
