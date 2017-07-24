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
  public class BreEventLog {
    /// <summary>
    /// The customer of the BRE event log
    /// </summary>
    /// <value>The customer of the BRE event log</value>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public string Customer { get; set; }

    /// <summary>
    /// The event id of the BRE event log
    /// </summary>
    /// <value>The event id of the BRE event log</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public string EventId { get; set; }

    /// <summary>
    /// The event name of the BRE event log
    /// </summary>
    /// <value>The event name of the BRE event log</value>
    [DataMember(Name="event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_name")]
    public string EventName { get; set; }

    /// <summary>
    /// The event start date of the BRE event log
    /// </summary>
    /// <value>The event start date of the BRE event log</value>
    [DataMember(Name="event_start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_start_date")]
    public long? EventStartDate { get; set; }

    /// <summary>
    /// The id of the BRE event log
    /// </summary>
    /// <value>The id of the BRE event log</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The event paramters of the BRE event log
    /// </summary>
    /// <value>The event paramters of the BRE event log</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public Object Parameters { get; set; }

    /// <summary>
    /// The rules of the BRE event log
    /// </summary>
    /// <value>The rules of the BRE event log</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<BreRuleLog> Rules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BreEventLog {\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventStartDate: ").Append(EventStartDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Rules: ").Append(Rules).Append("\n");
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
