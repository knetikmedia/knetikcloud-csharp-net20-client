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
  public class Maintenance {
    /// <summary>
    /// Whether access to the system has been locked
    /// </summary>
    /// <value>Whether access to the system has been locked</value>
    [DataMember(Name="access_locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_locked")]
    public bool? AccessLocked { get; set; }

    /// <summary>
    /// A simple object of any schema for client side use and processing
    /// </summary>
    /// <value>A simple object of any schema for client side use and processing</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public Object Details { get; set; }

    /// <summary>
    /// User displayable message about the maintenance
    /// </summary>
    /// <value>User displayable message about the maintenance</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Maintenance {\n");
      sb.Append("  AccessLocked: ").Append(AccessLocked).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
