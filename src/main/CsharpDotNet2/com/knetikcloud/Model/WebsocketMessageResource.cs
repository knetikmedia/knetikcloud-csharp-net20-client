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
  public class WebsocketMessageResource {
    /// <summary>
    /// The body of the outgoing message.
    /// </summary>
    /// <value>The body of the outgoing message.</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public Object Content { get; set; }

    /// <summary>
    /// A message type to inform websocket recipient how to parse content
    /// </summary>
    /// <value>A message type to inform websocket recipient how to parse content</value>
    [DataMember(Name="message_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message_type")]
    public string MessageType { get; set; }

    /// <summary>
    /// A list of user ids to send the message to.
    /// </summary>
    /// <value>A list of user ids to send the message to.</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<int?> Recipients { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebsocketMessageResource {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  MessageType: ").Append(MessageType).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
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
