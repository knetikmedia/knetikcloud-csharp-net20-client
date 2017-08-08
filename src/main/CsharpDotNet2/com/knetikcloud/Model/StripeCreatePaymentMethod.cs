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
  public class StripeCreatePaymentMethod {
    /// <summary>
    /// Additional optional details to store on the payment method. If included, all fields in the details will override any defaults
    /// </summary>
    /// <value>Additional optional details to store on the payment method. If included, all fields in the details will override any defaults</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public PaymentMethodDetails Details { get; set; }

    /// <summary>
    /// A token from Stripe to identify payment info to be tied to the customer
    /// </summary>
    /// <value>A token from Stripe to identify payment info to be tied to the customer</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// The id of the user, if null the logged in user is used. Admin privilege need to specify other users
    /// </summary>
    /// <value>The id of the user, if null the logged in user is used. Admin privilege need to specify other users</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StripeCreatePaymentMethod {\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
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
