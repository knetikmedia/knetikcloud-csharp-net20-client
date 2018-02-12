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
  public class ChatMessageRequest {
    /// <summary>
    /// The content of the message
    /// </summary>
    /// <value>The content of the message</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public Object Content { get; set; }

    /// <summary>
    /// The type of the message set by the client
    /// </summary>
    /// <value>The type of the message set by the client</value>
    [DataMember(Name="message_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message_type")]
    public string MessageType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChatMessageRequest {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
