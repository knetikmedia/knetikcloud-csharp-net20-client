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
  public class ModelUserResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this user type, or be an extra not from the template</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, ModelProperty> AdditionalProperties { get; set; }

    /// <summary>
    /// The first line of the user's address (private)
    /// </summary>
    /// <value>The first line of the user's address (private)</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// The second line of user's address (private)
    /// </summary>
    /// <value>The second line of user's address (private)</value>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// The url of the user's avatar image
    /// </summary>
    /// <value>The url of the user's avatar image</value>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Relationships where this user is the parent. Read-Only, manage through separate endpoints
    /// </summary>
    /// <value>Relationships where this user is the parent. Read-Only, manage through separate endpoints</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<ModelUserRelationshipReferenceResource> Children { get; set; }

    /// <summary>
    /// The user's city (private)
    /// </summary>
    /// <value>The user's city (private)</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The ISO3 code for the country from the user's address (private). Will be filled in based on GeoIP country at registration if not provided.
    /// </summary>
    /// <value>The ISO3 code for the country from the user's address (private). Will be filled in based on GeoIP country at registration if not provided.</value>
    [DataMember(Name="country_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The code for the user's real money currency (private)
    /// </summary>
    /// <value>The code for the user's real money currency (private)</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The user's date of birth (private) as a unix timestamp
    /// </summary>
    /// <value>The user's date of birth (private) as a unix timestamp</value>
    [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_of_birth")]
    public long? DateOfBirth { get; set; }

    /// <summary>
    /// The user's self description (private)
    /// </summary>
    /// <value>The user's self description (private)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The chosen display name of the user, defaults to username if not present
    /// </summary>
    /// <value>The chosen display name of the user, defaults to username if not present</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The user's email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)
    /// </summary>
    /// <value>The user's email address (private). May be required and/or unique depending on system configuration (both on by default). Must match standard email requirements if provided (RFC 2822)</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The user's first name (private)
    /// </summary>
    /// <value>The user's first name (private)</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The user's full name (private)
    /// </summary>
    /// <value>The user's full name (private)</value>
    [DataMember(Name="fullname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullname")]
    public string Fullname { get; set; }

    /// <summary>
    /// The user's gender (private)
    /// </summary>
    /// <value>The user's gender (private)</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// The id of the user
    /// </summary>
    /// <value>The id of the user</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The ISO3 code for the user's currency (private)
    /// </summary>
    /// <value>The ISO3 code for the user's currency (private)</value>
    [DataMember(Name="language_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language_code")]
    public string LanguageCode { get; set; }

    /// <summary>
    /// The user's last name (private)
    /// </summary>
    /// <value>The user's last name (private)</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The user's mobile phone number (private)
    /// </summary>
    /// <value>The user's mobile phone number (private)</value>
    [DataMember(Name="mobile_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_number")]
    public string MobileNumber { get; set; }

    /// <summary>
    /// Relationships where this user is the child. Read-Only, manage through separate endpoints
    /// </summary>
    /// <value>Relationships where this user is the child. Read-Only, manage through separate endpoints</value>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<ModelUserRelationshipReferenceResource> Parents { get; set; }

    /// <summary>
    /// The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing
    /// </summary>
    /// <value>The plain text password for the new user account. Required for registration; ignored on profile update.  Use password specific endpoints for editing</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// The user's postal code (private)
    /// </summary>
    /// <value>The user's postal code (private)</value>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The user's state (private)
    /// </summary>
    /// <value>The user's state (private)</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Tags on the user. Can only be set by admin. Max length per tag is 64 characters
    /// </summary>
    /// <value>Tags on the user. Can only be set by admin. Max length per tag is 64 characters</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// A user template this user is validated against (private). May be null and no validation of properties will be done
    /// </summary>
    /// <value>A user template this user is validated against (private). May be null and no validation of properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The code for the user's timezone (private)
    /// </summary>
    /// <value>The code for the user's timezone (private)</value>
    [DataMember(Name="timezone_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone_code")]
    public string TimezoneCode { get; set; }

    /// <summary>
    /// The login username for the user (private). May be set to match email if system does not require usernames separately.
    /// </summary>
    /// <value>The login username for the user (private). May be set to match email if system does not require usernames separately.</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelUserResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Fullname: ").Append(Fullname).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  TimezoneCode: ").Append(TimezoneCode).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
