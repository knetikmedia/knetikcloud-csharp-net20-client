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
  public class ModelSavedAddressResource {
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
    /// Gets or Sets _Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public bool? _Default { get; set; }

    /// <summary>
    /// The first name of the user
    /// </summary>
    /// <value>The first name of the user</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The id of the address
    /// </summary>
    /// <value>The id of the address</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The last name of the user
    /// </summary>
    /// <value>The last name of the user</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The name of the address
    /// </summary>
    /// <value>The name of the address</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The first phone number of the user
    /// </summary>
    /// <value>The first phone number of the user</value>
    [DataMember(Name="phone1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone1")]
    public string Phone1 { get; set; }

    /// <summary>
    /// The second phone number of the user
    /// </summary>
    /// <value>The second phone number of the user</value>
    [DataMember(Name="phone2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone2")]
    public string Phone2 { get; set; }

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
      sb.Append("class ModelSavedAddressResource {\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  _Default: ").Append(_Default).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Phone1: ").Append(Phone1).Append("\n");
      sb.Append("  Phone2: ").Append(Phone2).Append("\n");
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
