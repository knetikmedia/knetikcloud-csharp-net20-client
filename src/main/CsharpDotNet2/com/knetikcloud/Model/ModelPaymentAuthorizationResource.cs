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
  public class ModelPaymentAuthorizationResource {
    /// <summary>
    /// Whether this authorization has been captured
    /// </summary>
    /// <value>Whether this authorization has been captured</value>
    [DataMember(Name="captured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "captured")]
    public bool? Captured { get; set; }

    /// <summary>
    /// The date this authorization was received, unix timestamp in seconds
    /// </summary>
    /// <value>The date this authorization was received, unix timestamp in seconds</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public long? Created { get; set; }

    /// <summary>
    /// The details for this authorization. Format dependent on payment provider
    /// </summary>
    /// <value>The details for this authorization. Format dependent on payment provider</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public Object Details { get; set; }

    /// <summary>
    /// The id of the authorization
    /// </summary>
    /// <value>The id of the authorization</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The invoice this authorization is intended to pay
    /// </summary>
    /// <value>The invoice this authorization is intended to pay</value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public int? Invoice { get; set; }

    /// <summary>
    /// The payment type (which provider) this payment is through
    /// </summary>
    /// <value>The payment type (which provider) this payment is through</value>
    [DataMember(Name="payment_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_type")]
    public ModelSimpleReferenceResourceint PaymentType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPaymentAuthorizationResource {\n");
      sb.Append("  Captured: ").Append(Captured).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
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
