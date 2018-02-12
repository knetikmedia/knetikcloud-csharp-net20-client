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
  public class MessageResource {
    /// <summary>
    /// The content of the message in various formats
    /// </summary>
    /// <value>The content of the message in various formats</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public MessageContentResource Content { get; set; }

    /// <summary>
    /// The id of the recipient, dependent on the recipient_type. The user's id or the topic's id. Required if sending directly to messaging service
    /// </summary>
    /// <value>The id of the recipient, dependent on the recipient_type. The user's id or the topic's id. Required if sending directly to messaging service</value>
    [DataMember(Name="recipient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient")]
    public string Recipient { get; set; }

    /// <summary>
    /// The type of recipient for the message. Either a user, or all users in a topic. Required if sending directly to messaging service
    /// </summary>
    /// <value>The type of recipient for the message. Either a user, or all users in a topic. Required if sending directly to messaging service</value>
    [DataMember(Name="recipient_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_type")]
    public string RecipientType { get; set; }

    /// <summary>
    /// The subject of the message. Required for email messages
    /// </summary>
    /// <value>The subject of the message. Required for email messages</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// The type of message for websocket type hinting. will be added to the payload with the key _type
    /// </summary>
    /// <value>The type of message for websocket type hinting. will be added to the payload with the key _type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MessageResource {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Recipient: ").Append(Recipient).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
