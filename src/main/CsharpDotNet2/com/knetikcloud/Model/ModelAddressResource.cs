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
  public class ModelAddressResource {
    /// <summary>
    /// The first line of the address
    /// </summary>
    /// <value>The first line of the address</value>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// A second line of the address
    /// </summary>
    /// <value>A second line of the address</value>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// The city
    /// </summary>
    /// <value>The city</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The iso3 code for the country
    /// </summary>
    /// <value>The iso3 code for the country</value>
    [DataMember(Name="country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The postal code
    /// </summary>
    /// <value>The postal code</value>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The code for the state. Required if the country has states/provinces/equivalent
    /// </summary>
    /// <value>The code for the state. Required if the country has states/provinces/equivalent</value>
    [DataMember(Name="state_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_code")]
    public string StateCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAddressResource {\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  StateCode: ").Append(StateCode).Append("\n");
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
