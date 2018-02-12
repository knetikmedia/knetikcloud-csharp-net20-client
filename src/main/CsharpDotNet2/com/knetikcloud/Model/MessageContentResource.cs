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
  public class MessageContentResource {
    /// <summary>
    /// The content of the email
    /// </summary>
    /// <value>The content of the email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The content of the mobile app push notification
    /// </summary>
    /// <value>The content of the mobile app push notification</value>
    [DataMember(Name="push", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push")]
    public string Push { get; set; }

    /// <summary>
    /// The content of the sms
    /// </summary>
    /// <value>The content of the sms</value>
    [DataMember(Name="sms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sms")]
    public string Sms { get; set; }

    /// <summary>
    /// The content of the templated email
    /// </summary>
    /// <value>The content of the templated email</value>
    [DataMember(Name="templated_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templated_email")]
    public TemplatedEmail TemplatedEmail { get; set; }

    /// <summary>
    /// The content of the websocket message
    /// </summary>
    /// <value>The content of the websocket message</value>
    [DataMember(Name="websocket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "websocket")]
    public Object Websocket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MessageContentResource {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Push: ").Append(Push).Append("\n");
      sb.Append("  Sms: ").Append(Sms).Append("\n");
      sb.Append("  TemplatedEmail: ").Append(TemplatedEmail).Append("\n");
      sb.Append("  Websocket: ").Append(Websocket).Append("\n");
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
