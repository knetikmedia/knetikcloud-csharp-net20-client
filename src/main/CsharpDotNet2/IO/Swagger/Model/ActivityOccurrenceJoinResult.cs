using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ActivityOccurrenceJoinResult {
    /// <summary>
    /// The details on the entitlement object needed to enter the occurrence (if any)
    /// </summary>
    /// <value>The details on the entitlement object needed to enter the occurrence (if any)</value>
    [DataMember(Name="entitlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlement")]
    public ActivityEntitlementResource Entitlement { get; set; }

    /// <summary>
    /// Zero if the user was/could be added to the occurrence. Jsapi error code indicating the reason of the failure otherwise
    /// </summary>
    /// <value>Zero if the user was/could be added to the occurrence. Jsapi error code indicating the reason of the failure otherwise</value>
    [DataMember(Name="error_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_code")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// An error message if failure
    /// </summary>
    /// <value>An error message if failure</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The user's id
    /// </summary>
    /// <value>The user's id</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public long? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivityOccurrenceJoinResult {\n");
      sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
