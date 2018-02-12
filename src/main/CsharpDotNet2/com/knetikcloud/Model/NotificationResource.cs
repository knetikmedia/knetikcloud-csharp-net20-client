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
  public class NotificationResource {
    /// <summary>
    /// The data to send to websockets. Also used to fill in the templates
    /// </summary>
    /// <value>The data to send to websockets. Also used to fill in the templates</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Object Data { get; set; }

    /// <summary>
    /// The id of this individual notification. Default: random
    /// </summary>
    /// <value>The id of this individual notification. Default: random</value>
    [DataMember(Name="notification_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_id")]
    public string NotificationId { get; set; }

    /// <summary>
    /// The id of the notification type which will define message templates
    /// </summary>
    /// <value>The id of the notification type which will define message templates</value>
    [DataMember(Name="notification_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_type_id")]
    public string NotificationTypeId { get; set; }

    /// <summary>
    /// The id of the recipient, dependent on the recipient_type. The user's id or the topic's id
    /// </summary>
    /// <value>The id of the recipient, dependent on the recipient_type. The user's id or the topic's id</value>
    [DataMember(Name="recipient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient")]
    public string Recipient { get; set; }

    /// <summary>
    /// The type of recipient for the notification. Either a user, or all users in a topic
    /// </summary>
    /// <value>The type of recipient for the notification. Either a user, or all users in a topic</value>
    [DataMember(Name="recipient_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_type")]
    public string RecipientType { get; set; }

    /// <summary>
    /// The date this notification was sent
    /// </summary>
    /// <value>The date this notification was sent</value>
    [DataMember(Name="send_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_date")]
    public long? SendDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationResource {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
      sb.Append("  NotificationTypeId: ").Append(NotificationTypeId).Append("\n");
      sb.Append("  Recipient: ").Append(Recipient).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
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
