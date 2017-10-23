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
  public class ClientResource {
    /// <summary>
    /// The expiration time of an initial oauth token in seconds
    /// </summary>
    /// <value>The expiration time of an initial oauth token in seconds</value>
    [DataMember(Name="access_token_validity_seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token_validity_seconds")]
    public int? AccessTokenValiditySeconds { get; set; }

    /// <summary>
    /// The client_id field of the oauth token request
    /// </summary>
    /// <value>The client_id field of the oauth token request</value>
    [DataMember(Name="client_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_key")]
    public string ClientKey { get; set; }

    /// <summary>
    /// The oauth grant type as in: password (username/password auth), client_credentials (server-to-server, private clients), refresh_token (to allow clients to refresh their initial token), facebook, google, etc) See documentation for a complete list. Use dedicated endpoint PUT /grant-types to edit this list
    /// </summary>
    /// <value>The oauth grant type as in: password (username/password auth), client_credentials (server-to-server, private clients), refresh_token (to allow clients to refresh their initial token), facebook, google, etc) See documentation for a complete list. Use dedicated endpoint PUT /grant-types to edit this list</value>
    [DataMember(Name="grant_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grant_types")]
    public List<string> GrantTypes { get; set; }

    /// <summary>
    /// Generated unique ID for the client
    /// </summary>
    /// <value>Generated unique ID for the client</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Set to true if the client is public i.e the secret key can be secured
    /// </summary>
    /// <value>Set to true if the client is public i.e the secret key can be secured</value>
    [DataMember(Name="is_public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_public")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Used to flag system clients that are not meant to be tinkered with
    /// </summary>
    /// <value>Used to flag system clients that are not meant to be tinkered with</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// The friendly name of the client
    /// </summary>
    /// <value>The friendly name of the client</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A redirection URL to use when granting access to third-parties (seldomly used)
    /// </summary>
    /// <value>A redirection URL to use when granting access to third-parties (seldomly used)</value>
    [DataMember(Name="redirect_uris", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirect_uris")]
    public List<string> RedirectUris { get; set; }

    /// <summary>
    /// The expiration time of a refresh oauth token in seconds
    /// </summary>
    /// <value>The expiration time of a refresh oauth token in seconds</value>
    [DataMember(Name="refresh_token_validity_seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refresh_token_validity_seconds")]
    public int? RefreshTokenValiditySeconds { get; set; }

    /// <summary>
    /// The client-secret field of the oauth request when creating a private client
    /// </summary>
    /// <value>The client-secret field of the oauth request when creating a private client</value>
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
