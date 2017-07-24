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
  public class GooglePaymentRequest {
    /// <summary>
    /// The json payload exactly as sent from Google
    /// </summary>
    /// <value>The json payload exactly as sent from Google</value>
    [DataMember(Name="json_payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "json_payload")]
    public string JsonPayload { get; set; }

    /// <summary>
    /// The signature from Google to verify the payload
    /// </summary>
    /// <value>The signature from Google to verify the payload</value>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GooglePaymentRequest {\n");
      sb.Append("  JsonPayload: ").Append(JsonPayload).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
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
