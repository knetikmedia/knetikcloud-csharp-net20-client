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
  public class ChatThreadResource {
    /// <summary>
    /// The number of active users in the thread
    /// </summary>
    /// <value>The number of active users in the thread</value>
    [DataMember(Name="active_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_users")]
    public int? ActiveUsers { get; set; }

    /// <summary>
    /// The number of messages in the thread
    /// </summary>
    /// <value>The number of messages in the thread</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The date the thread was created
    /// </summary>
    /// <value>The date the thread was created</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The id for this thread
    /// </summary>
    /// <value>The id for this thread</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The id of the recipient
    /// </summary>
    /// <value>The id of the recipient</value>
    [DataMember(Name="recipient_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_id")]
    public string RecipientId { get; set; }

    /// <summary>
    /// The recipient type of the thread
    /// </summary>
    /// <value>The recipient type of the thread</value>
    [DataMember(Name="recipient_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_type")]
    public string RecipientType { get; set; }

    /// <summary>
    /// The subject of the thread
    /// </summary>
    /// <value>The subject of the thread</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// The date the thread was updated
    /// </summary>
    /// <value>The date the thread was updated</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChatThreadResource {\n");
      sb.Append("  ActiveUsers: ").Append(ActiveUsers).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
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
