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
  public class WebsocketRemoveTopicEvent : BroadcastableEvent {
    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public string _Client { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public string Customer { get; set; }

    /// <summary>
    /// Gets or Sets DoNotBroadcast
    /// </summary>
    [DataMember(Name="do_not_broadcast", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "do_not_broadcast")]
    public bool? DoNotBroadcast { get; set; }

    /// <summary>
    /// Gets or Sets Section
    /// </summary>
    [DataMember(Name="section", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "section")]
    public string Section { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public Object Source { get; set; }

    /// <summary>
    /// Gets or Sets Specifics
    /// </summary>
    [DataMember(Name="specifics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specifics")]
    public string Specifics { get; set; }

    /// <summary>
    /// Gets or Sets Synchronous
    /// </summary>
    [DataMember(Name="synchronous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synchronous")]
    public bool? Synchronous { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public long? Timestamp { get; set; }

    /// <summary>
    /// The type of the event. Used for polymorphic type recognition and thus must match an expected type
    /// </summary>
    /// <value>The type of the event. Used for polymorphic type recognition and thus must match an expected type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Topic
    /// </summary>
    [DataMember(Name="topic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic")]
    public Topic Topic { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebsocketRemoveTopicEvent {\n");
      sb.Append("  _Client: ").Append(_Client).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  DoNotBroadcast: ").Append(DoNotBroadcast).Append("\n");
      sb.Append("  Section: ").Append(Section).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Specifics: ").Append(Specifics).Append("\n");
      sb.Append("  Synchronous: ").Append(Synchronous).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Topic: ").Append(Topic).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
