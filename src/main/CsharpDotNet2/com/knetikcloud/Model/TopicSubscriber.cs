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
  public class TopicSubscriber {
    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    [DataMember(Name="disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets JoinDate
    /// </summary>
    [DataMember(Name="join_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "join_date")]
    public long? JoinDate { get; set; }

    /// <summary>
    /// Gets or Sets MobileNumber
    /// </summary>
    [DataMember(Name="mobile_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_number")]
    public string MobileNumber { get; set; }

    /// <summary>
    /// Gets or Sets TopicId
    /// </summary>
    [DataMember(Name="topic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic_id")]
    public string TopicId { get; set; }

    /// <summary>
    /// Gets or Sets TopicSubscriberMap
    /// </summary>
    [DataMember(Name="topic_subscriber_map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic_subscriber_map")]
    public Object TopicSubscriberMap { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TopicSubscriber {\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  TopicSubscriberMap: ").Append(TopicSubscriberMap).Append("\n");
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
