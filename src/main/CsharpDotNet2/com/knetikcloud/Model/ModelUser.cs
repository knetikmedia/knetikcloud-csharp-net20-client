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
  public class ModelUser {
    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, ModelProperty> AdditionalProperties { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or Sets Affiliate
    /// </summary>
    [DataMember(Name="affiliate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affiliate")]
    public ModelAffiliate Affiliate { get; set; }

    /// <summary>
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets Children
    /// </summary>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<ModelUserRelationship> Children { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public ModelCountry Country { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public ModelCurrency Currency { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public long? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateOfBirth
    /// </summary>
    [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_of_birth")]
    public long? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or Sets DateUpdated
    /// </summary>
    [DataMember(Name="date_updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_updated")]
    public long? DateUpdated { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets Fullname
    /// </summary>
    [DataMember(Name="fullname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullname")]
    public string Fullname { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<ModelGroupMember> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Guest
    /// </summary>
    [DataMember(Name="guest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guest")]
    public bool? Guest { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets InviteToken
    /// </summary>
    [DataMember(Name="invite_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invite_token")]
    public string InviteToken { get; set; }

    /// <summary>
    /// Gets or Sets Lang
    /// </summary>
    [DataMember(Name="lang", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lang")]
    public ModelLanguage Lang { get; set; }

    /// <summary>
    /// Gets or Sets LastActivity
    /// </summary>
    [DataMember(Name="last_activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_activity")]
    public long? LastActivity { get; set; }

    /// <summary>
    /// Gets or Sets LastLogin
    /// </summary>
    [DataMember(Name="last_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_login")]
    public long? LastLogin { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets LockoutAttempts
    /// </summary>
    [DataMember(Name="lockout_attempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockout_attempts")]
    public int? LockoutAttempts { get; set; }

    /// <summary>
    /// Gets or Sets LockoutDate
    /// </summary>
    [DataMember(Name="lockout_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockout_date")]
    public long? LockoutDate { get; set; }

    /// <summary>
    /// Gets or Sets MobileNumber
    /// </summary>
    [DataMember(Name="mobile_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_number")]
    public string MobileNumber { get; set; }

    /// <summary>
    /// Gets or Sets OldId
    /// </summary>
    [DataMember(Name="old_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "old_id")]
    public int? OldId { get; set; }

    /// <summary>
    /// Gets or Sets Parents
    /// </summary>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<ModelUserRelationship> Parents { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets PropertiesString
    /// </summary>
    [DataMember(Name="properties_string", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties_string")]
    public string PropertiesString { get; set; }

    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<ModelRole> Roles { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets TagStrings
    /// </summary>
    [DataMember(Name="tag_strings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag_strings")]
    public List<string> TagStrings { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<ModelUserTag> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// Gets or Sets Timezone
    /// </summary>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone")]
    public ModelTimezone Timezone { get; set; }

    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or Sets TypeHint
    /// </summary>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelUser {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Fullname: ").Append(Fullname).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Guest: ").Append(Guest).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InviteToken: ").Append(InviteToken).Append("\n");
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
      sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LockoutAttempts: ").Append(LockoutAttempts).Append("\n");
      sb.Append("  LockoutDate: ").Append(LockoutDate).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  OldId: ").Append(OldId).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  PropertiesString: ").Append(PropertiesString).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TagStrings: ").Append(TagStrings).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
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
