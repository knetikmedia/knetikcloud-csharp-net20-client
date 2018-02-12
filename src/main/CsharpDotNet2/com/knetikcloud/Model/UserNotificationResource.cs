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
  public class UserNotificationResource {
    /// <summary>
    /// The data to send and fill templates
    /// </summary>
    /// <value>The data to send and fill templates</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Object Data { get; set; }

    /// <summary>
    /// The id of the notification
    /// </summary>
    /// <value>The id of the notification</value>
    [DataMember(Name="notification_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_id")]
    public string NotificationId { get; set; }

    /// <summary>
    /// The id of the notification type
    /// </summary>
    /// <value>The id of the notification type</value>
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
    /// The date this notification was first retrieved
    /// </summary>
    /// <value>The date this notification was first retrieved</value>
    [DataMember(Name="retrieve_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retrieve_date")]
    public long? RetrieveDate { get; set; }

    /// <summary>
    /// The date this notification was sent
    /// </summary>
    /// <value>The date this notification was sent</value>
    [DataMember(Name="send_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_date")]
    public long? SendDate { get; set; }

    /// <summary>
    /// The user's status for this notification
    /// </summary>
    /// <value>The user's status for this notification</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The id of the user
    /// </summary>
    /// <value>The id of the user</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserNotificationResource {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
      sb.Append("  NotificationTypeId: ").Append(NotificationTypeId).Append("\n");
      sb.Append("  Recipient: ").Append(Recipient).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  RetrieveDate: ").Append(RetrieveDate).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
