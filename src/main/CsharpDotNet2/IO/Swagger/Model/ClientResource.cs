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
  public class ClientResource {
    /// <summary>
    /// The time limit of the token in seconds
    /// </summary>
    /// <value>The time limit of the token in seconds</value>
    [DataMember(Name="access_token_validity_seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token_validity_seconds")]
    public int? AccessTokenValiditySeconds { get; set; }

    /// <summary>
    /// The client key, cannot be edited once created
    /// </summary>
    /// <value>The client key, cannot be edited once created</value>
    [DataMember(Name="client_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_key")]
    public string ClientKey { get; set; }

    /// <summary>
    /// The grant types of the client
    /// </summary>
    /// <value>The grant types of the client</value>
    [DataMember(Name="grant_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grant_types")]
    public List<string> GrantTypes { get; set; }

    /// <summary>
    /// The id of the client
    /// </summary>
    /// <value>The id of the client</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Whether the client is public or not
    /// </summary>
    /// <value>Whether the client is public or not</value>
    [DataMember(Name="is_public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_public")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Whether a client is locked from being deleted
    /// </summary>
    /// <value>Whether a client is locked from being deleted</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// The name of the client
    /// </summary>
    /// <value>The name of the client</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The redirect uris of the client
    /// </summary>
    /// <value>The redirect uris of the client</value>
    [DataMember(Name="redirect_uris", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirect_uris")]
    public List<string> RedirectUris { get; set; }

    /// <summary>
    /// The time limit of the refresh token in seconds
    /// </summary>
    /// <value>The time limit of the refresh token in seconds</value>
    [DataMember(Name="refresh_token_validity_seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh_token_validity_seconds")]
    public int? RefreshTokenValiditySeconds { get; set; }

    /// <summary>
    /// The secret key of the client
    /// </summary>
    /// <value>The secret key of the client</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientResource {\n");
      sb.Append("  AccessTokenValiditySeconds: ").Append(AccessTokenValiditySeconds).Append("\n");
      sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
      sb.Append("  GrantTypes: ").Append(GrantTypes).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
      sb.Append("  RefreshTokenValiditySeconds: ").Append(RefreshTokenValiditySeconds).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
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
