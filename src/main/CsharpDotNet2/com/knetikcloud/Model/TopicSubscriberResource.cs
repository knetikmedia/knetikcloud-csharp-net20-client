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
  public class TopicSubscriberResource {
    /// <summary>
    /// Whether the user has disabled messages from the topic
    /// </summary>
    /// <value>Whether the user has disabled messages from the topic</value>
    [DataMember(Name="disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The ID for this topic
    /// </summary>
    /// <value>The ID for this topic</value>
    [DataMember(Name="topic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic_id")]
    public string TopicId { get; set; }

    /// <summary>
    /// The user ID subscribed to the topic
    /// </summary>
    /// <value>The user ID subscribed to the topic</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// The username subscribed to the topic
    /// </summary>
    /// <value>The username subscribed to the topic</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TopicSubscriberResource {\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
