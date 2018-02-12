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
  public class ChatUserThreadResource {
    /// <summary>
    /// The date the user thread was created
    /// </summary>
    /// <value>The date the user thread was created</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The number of messages read in the thread
    /// </summary>
    /// <value>The number of messages read in the thread</value>
    [DataMember(Name="read_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_count")]
    public int? ReadCount { get; set; }

    /// <summary>
    /// The details about the thread
    /// </summary>
    /// <value>The details about the thread</value>
    [DataMember(Name="thread", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thread")]
    public ChatThreadResource Thread { get; set; }

    /// <summary>
    /// The id of the thread
    /// </summary>
    /// <value>The id of the thread</value>
    [DataMember(Name="thread_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thread_id")]
    public string ThreadId { get; set; }

    /// <summary>
    /// The date the user thread was updated
    /// </summary>
    /// <value>The date the user thread was updated</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

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
      sb.Append("class ChatUserThreadResource {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  ReadCount: ").Append(ReadCount).Append("\n");
      sb.Append("  Thread: ").Append(Thread).Append("\n");
      sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
