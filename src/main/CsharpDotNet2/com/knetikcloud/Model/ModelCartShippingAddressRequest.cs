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
  public class ModelCartShippingAddressRequest {
    /// <summary>
    /// The city of the user
    /// </summary>
    /// <value>The city of the user</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The country code of the user
    /// </summary>
    /// <value>The country code of the user</value>
    [DataMember(Name="country_code_iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code_iso3")]
    public string CountryCodeIso3 { get; set; }

    /// <summary>
    /// The email of the user
    /// </summary>
    /// <value>The email of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The first name of the user
    /// </summary>
    /// <value>The first name of the user</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the user
    /// </summary>
    /// <value>The last name of the user</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets NamePrefix
    /// </summary>
    [DataMember(Name="name_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name_prefix")]
    public string NamePrefix { get; set; }

    /// <summary>
    /// The order notes the user
    /// </summary>
    /// <value>The order notes the user</value>
    [DataMember(Name="order_notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_notes")]
    public string OrderNotes { get; set; }

    /// <summary>
    /// The phone number of the user
    /// </summary>
    /// <value>The phone number of the user</value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The postal state code of the user
    /// </summary>
    /// <value>The postal state code of the user</value>
    [DataMember(Name="postal_state_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_state_code")]
    public string PostalStateCode { get; set; }

    /// <summary>
    /// The shipping address of the user, first line
    /// </summary>
    /// <value>The shipping address of the user, first line</value>
    [DataMember(Name="shipping_address_line1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address_line1")]
    public string ShippingAddressLine1 { get; set; }

    /// <summary>
    /// The shipping address of the user, second line
    /// </summary>
    /// <value>The shipping address of the user, second line</value>
    [DataMember(Name="shipping_address_line2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address_line2")]
    public string ShippingAddressLine2 { get; set; }

    /// <summary>
    /// The zipcode of the user
    /// </summary>
    /// <value>The zipcode of the user</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCartShippingAddressRequest {\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CountryCodeIso3: ").Append(CountryCodeIso3).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
      sb.Append("  OrderNotes: ").Append(OrderNotes).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  PostalStateCode: ").Append(PostalStateCode).Append("\n");
      sb.Append("  ShippingAddressLine1: ").Append(ShippingAddressLine1).Append("\n");
      sb.Append("  ShippingAddressLine2: ").Append(ShippingAddressLine2).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
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
