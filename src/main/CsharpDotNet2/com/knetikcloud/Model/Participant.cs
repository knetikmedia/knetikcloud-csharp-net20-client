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
  public class Participant {
    /// <summary>
    /// Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)
    /// </summary>
    /// <value>Whether this user is the 'host' of the occurrence and has increased access to settings/etc (default: false)</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public bool? Host { get; set; }

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
    public IdRef User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Participant {\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
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
