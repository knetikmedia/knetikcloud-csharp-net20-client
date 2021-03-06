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
  public class GoogleToken {
    /// <summary>
    /// A valid authorization code from google. See google documention for how to obtain one.
    /// </summary>
    /// <value>A valid authorization code from google. See google documention for how to obtain one.</value>
    [DataMember(Name="authorization_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorization_code")]
    public string AuthorizationCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GoogleToken {\n");
      sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
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
