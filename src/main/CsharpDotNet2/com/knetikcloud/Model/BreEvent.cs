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
  public class BreEvent {
    /// <summary>
    /// The event name of the trigger to be fired
    /// </summary>
    /// <value>The event name of the trigger to be fired</value>
    [DataMember(Name="event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_name")]
    public string EventName { get; set; }

    /// <summary>
    /// The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.
    /// </summary>
    /// <value>The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.</value>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public Object _Params { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BreEvent {\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  _Params: ").Append(_Params).Append("\n");
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
