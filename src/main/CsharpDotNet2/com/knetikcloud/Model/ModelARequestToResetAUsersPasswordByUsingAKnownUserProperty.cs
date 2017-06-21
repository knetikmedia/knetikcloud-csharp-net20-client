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
  public class ModelARequestToResetAUsersPasswordByUsingAKnownUserProperty {
    /// <summary>
    /// The user's email address
    /// </summary>
    /// <value>The user's email address</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The user's mobile phone number
    /// </summary>
    /// <value>The user's mobile phone number</value>
    [DataMember(Name="mobile_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_number")]
    public string MobileNumber { get; set; }

    /// <summary>
    /// The user's username
    /// </summary>
    /// <value>The user's username</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelARequestToResetAUsersPasswordByUsingAKnownUserProperty {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
