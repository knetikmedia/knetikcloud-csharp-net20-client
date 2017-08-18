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
  public class PayBySavedMethodRequest {
    /// <summary>
    /// The id of the payment method to use. Must belong to the caller, be public or have PAYMENTS_ADMIN permission
    /// </summary>
    /// <value>The id of the payment method to use. Must belong to the caller, be public or have PAYMENTS_ADMIN permission</value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method")]
    public int? PaymentMethod { get; set; }

    /// <summary>
    /// The id of a user to bill. Must have PAYMENTS_ADMIN permission
    /// </summary>
    /// <value>The id of a user to bill. Must have PAYMENTS_ADMIN permission</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PayBySavedMethodRequest {\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
