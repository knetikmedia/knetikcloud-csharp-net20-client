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
  public class UserItemLogResource {
    /// <summary>
    /// The log entry id
    /// </summary>
    /// <value>The log entry id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Additional information defined by the type
    /// </summary>
    /// <value>Additional information defined by the type</value>
    [DataMember(Name="info", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "info")]
    public string Info { get; set; }

    /// <summary>
    /// The item interacted with
    /// </summary>
    /// <value>The item interacted with</value>
    [DataMember(Name="item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item")]
    public SimpleReferenceResourceint Item { get; set; }

    /// <summary>
    /// The date/time this event occurred in seconds since epoch
    /// </summary>
    /// <value>The date/time this event occurred in seconds since epoch</value>
    [DataMember(Name="log_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "log_date")]
    public long? LogDate { get; set; }

    /// <summary>
    /// The type of event
    /// </summary>
    /// <value>The type of event</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The user making the interaction
    /// </summary>
    /// <value>The user making the interaction</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUserResource User { get; set; }

    /// <summary>
    /// The id of the inventory entry this event is related to, if any
    /// </summary>
    /// <value>The id of the inventory entry this event is related to, if any</value>
    [DataMember(Name="user_inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_inventory")]
    public int? UserInventory { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserItemLogResource {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Info: ").Append(Info).Append("\n");
      sb.Append("  Item: ").Append(Item).Append("\n");
      sb.Append("  LogDate: ").Append(LogDate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  UserInventory: ").Append(UserInventory).Append("\n");
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
