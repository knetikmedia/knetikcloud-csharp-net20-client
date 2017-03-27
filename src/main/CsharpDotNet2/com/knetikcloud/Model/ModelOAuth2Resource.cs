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
  public class ModelOAuth2Resource {
    /// <summary>
    /// The access token issued by the authorization server
    /// </summary>
    /// <value>The access token issued by the authorization server</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// The lifetime in seconds of the access token
    /// </summary>
    /// <value>The lifetime in seconds of the access token</value>
    [DataMember(Name="expires_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_in")]
    public string ExpiresIn { get; set; }

    /// <summary>
    /// The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions
    /// </summary>
    /// <value>The scope of the access token. Currently these values can be ignored, as security defaults to roles and permissions</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// The type of the token issued
    /// </summary>
    /// <value>The type of the token issued</value>
    [DataMember(Name="token_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_type")]
    public string TokenType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelOAuth2Resource {\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
