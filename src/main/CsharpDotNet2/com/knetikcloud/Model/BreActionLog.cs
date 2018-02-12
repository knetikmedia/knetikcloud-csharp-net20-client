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
  public class BreActionLog {
    /// <summary>
    /// The name of the action
    /// </summary>
    /// <value>The name of the action</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The runtime of the action in milliseconds
    /// </summary>
    /// <value>The runtime of the action in milliseconds</value>
    [DataMember(Name="runtime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runtime")]
    public long? Runtime { get; set; }

    /// <summary>
    /// The status of the action (ran, failed)
    /// </summary>
    /// <value>The status of the action (ran, failed)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BreActionLog {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Runtime: ").Append(Runtime).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
