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
  public class PaymentMethodResource {
    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets _Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public bool? _Default { get; set; }

    /// <summary>
    /// Whether this payment method is disabled or not
    /// </summary>
    /// <value>Whether this payment method is disabled or not</value>
    [DataMember(Name="disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabled")]
    public bool? Disabled { get; set; }

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
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The last 4 digits of the account number for the payment method. Typically used for credit card payment methods
    /// </summary>
    /// <value>The last 4 digits of the account number for the payment method. Typically used for credit card payment methods</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The user friendly name of that resource
    /// </summary>
    /// <value>The user friendly name of that resource</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The type of payment method. Must be a pre-existing value
    /// </summary>
    /// <value>The type of payment method. Must be a pre-existing value</value>
    [DataMember(Name="payment_method_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_method_type")]
    public PaymentMethodTypeResource PaymentMethodType { get; set; }

    /// <summary>
    /// The generic payment type. Default is card
    /// </summary>
    /// <value>The generic payment type. Default is card</value>
    [DataMember(Name="payment_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment_type")]
    public string PaymentType { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// The sort value for the payment method
    /// </summary>
    /// <value>The sort value for the payment method</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// The unique token for the payment method
    /// </summary>
    /// <value>The unique token for the payment method</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// An optional unique identifier
    /// </summary>
    /// <value>An optional unique identifier</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The user's id. If null, indicates a shared payment method that any user can use (i.e., 'wallet')
    /// </summary>
    /// <value>The user's id. If null, indicates a shared payment method that any user can use (i.e., 'wallet')</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

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
      sb.Append("class PaymentMethodResource {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  _Default: ").Append(_Default).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
      sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
      sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
