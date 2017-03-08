using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserActionLog {
    /// <summary>
    /// A description of the action taken
    /// </summary>
    /// <value>A description of the action taken</value>
    [DataMember(Name="action_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action_description")]
    public string ActionDescription { get; set; }

    /// <summary>
    /// The name of the action taken
    /// </summary>
    /// <value>The name of the action taken</value>
    [DataMember(Name="action_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action_name")]
    public string ActionName { get; set; }

    /// <summary>
    /// The date of the action, unix timestamp in seconds
    /// </summary>
    /// <value>The date of the action, unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// A map of additional details such as the target of the action
    /// </summary>
    /// <value>A map of additional details such as the target of the action</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public Dictionary<String, string> Details { get; set; }

    /// <summary>
    /// The id of the log entry
    /// </summary>
    /// <value>The id of the log entry</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The id of the api request that spawned the action, if generated internally
    /// </summary>
    /// <value>The id of the api request that spawned the action, if generated internally</value>
    [DataMember(Name="request_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request_id")]
    public string RequestId { get; set; }

    /// <summary>
    /// The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN
    /// </summary>
    /// <value>The id of the user that took the action, if any. Read-only if not posting with LOGS_ADMIN</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserActionLog {\n");
      sb.Append("  ActionDescription: ").Append(ActionDescription).Append("\n");
      sb.Append("  ActionName: ").Append(ActionName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
