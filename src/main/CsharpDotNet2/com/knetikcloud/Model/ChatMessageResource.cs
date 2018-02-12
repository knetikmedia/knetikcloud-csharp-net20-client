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
  public class ChatMessageResource {
    /// <summary>
    /// The content of the message
    /// </summary>
    /// <value>The content of the message</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public Object Content { get; set; }

    /// <summary>
    /// The date the chat message was created
    /// </summary>
    /// <value>The date the chat message was created</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Whether the message has been edited
    /// </summary>
    /// <value>Whether the message has been edited</value>
    [DataMember(Name="edited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "edited")]
    public bool? Edited { get; set; }

    /// <summary>
    /// The id for this message
    /// </summary>
    /// <value>The id for this message</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The type of the message set by the client
    /// </summary>
    /// <value>The type of the message set by the client</value>
    [DataMember(Name="message_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message_type")]
    public string MessageType { get; set; }

    /// <summary>
    /// The id of the recipient: user id or topic id
    /// </summary>
    /// <value>The id of the recipient: user id or topic id</value>
    [DataMember(Name="recipient_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_id")]
    public string RecipientId { get; set; }

    /// <summary>
    /// The recipient type of the message
    /// </summary>
    /// <value>The recipient type of the message</value>
    [DataMember(Name="recipient_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_type")]
    public string RecipientType { get; set; }

    /// <summary>
    /// The id of the sender
    /// </summary>
    /// <value>The id of the sender</value>
    [DataMember(Name="sender_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_id")]
    public int? SenderId { get; set; }

    /// <summary>
    /// The id of the thread
    /// </summary>
    /// <value>The id of the thread</value>
    [DataMember(Name="thread_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thread_id")]
    public string ThreadId { get; set; }

    /// <summary>
    /// The date the chat message was updated
    /// </summary>
    /// <value>The date the chat message was updated</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChatMessageResource {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Edited: ").Append(Edited).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MessageType: ").Append(MessageType).Append("\n");
      sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  SenderId: ").Append(SenderId).Append("\n");
      sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
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
