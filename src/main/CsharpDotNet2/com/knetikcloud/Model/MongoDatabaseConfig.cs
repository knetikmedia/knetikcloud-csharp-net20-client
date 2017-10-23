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
  public class MongoDatabaseConfig {
    /// <summary>
    /// Gets or Sets DbName
    /// </summary>
    [DataMember(Name="db_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "db_name")]
    public string DbName { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public string Options { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Servers
    /// </summary>
    [DataMember(Name="servers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "servers")]
    public string Servers { get; set; }

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
      sb.Append("class MongoDatabaseConfig {\n");
      sb.Append("  DbName: ").Append(DbName).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Servers: ").Append(Servers).Append("\n");
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
