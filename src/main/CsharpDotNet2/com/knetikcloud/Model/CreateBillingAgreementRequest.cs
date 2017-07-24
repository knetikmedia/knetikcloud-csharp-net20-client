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
  public class CreateBillingAgreementRequest {
    /// <summary>
    /// The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement
    /// </summary>
    /// <value>The endpoint URL to which PayPal should forward the user if they cancel (do not accept) the agreement</value>
    [DataMember(Name="cancel_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_url")]
    public string CancelUrl { get; set; }

    /// <summary>
    /// The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step
    /// </summary>
    /// <value>The endpoint URL to which PayPal should forward the user after they accept the agreement. This endpoint will receive information needed for the next step</value>
    [DataMember(Name="return_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_url")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// The ID of the user. Defaults to the logged in user
    /// </summary>
    /// <value>The ID of the user. Defaults to the logged in user</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateBillingAgreementRequest {\n");
      sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
