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
  public class FacebookToken {
    /// <summary>
    /// A valid access token from facebook. See facebook documention for how to obtain one.
    /// </summary>
    /// <value>A valid access token from facebook. See facebook documention for how to obtain one.</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string AccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FacebookToken {\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
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
