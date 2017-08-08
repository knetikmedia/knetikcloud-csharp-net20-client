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
  public class PaymentMethodDetails {
    /// <summary>
    /// Gets or Sets _Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public bool? _Default { get; set; }

    /// <summary>
    /// The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods
    /// </summary>
    /// <value>The expiration date for the payment method, expressed as seconds since epoch. Typically used for credit card payment methods</value>
    [DataMember(Name="expiration_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration_date")]
    public long? ExpirationDate { get; set; }

    /// <summary>
    /// The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods
    /// </summary>
    /// <value>The expiration month (1 - 12) for the payment method. Typically used for credit card payment methods</value>
    [DataMember(Name="expiration_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration_month")]
    public int? ExpirationMonth { get; set; }

    /// <summary>
    /// The expiration year for the payment method. Typically used for credit card payment methods
    /// </summary>
    /// <value>The expiration year for the payment method. Typically used for credit card payment methods</value>
    [DataMember(Name="expiration_year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration_year")]
    public int? ExpirationYear { get; set; }

    /// <summary>
    /// The last 4 digits of the account number for the payment method. Typically used for credit card payment methods
    /// </summary>
    /// <value>The last 4 digits of the account number for the payment method. Typically used for credit card payment methods</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// The sort value for the payment method
    /// </summary>
    /// <value>The sort value for the payment method</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// An optional unique identifier
    /// </summary>
    /// <value>An optional unique identifier</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentMethodDetails {\n");
      sb.Append("  _Default: ").Append(_Default).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
      sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
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
