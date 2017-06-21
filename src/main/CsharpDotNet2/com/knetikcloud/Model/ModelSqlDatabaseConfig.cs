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
  public class ModelSqlDatabaseConfig {
    /// <summary>
    /// Gets or Sets ConnectionPoolSize
    /// </summary>
    [DataMember(Name="connection_pool_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connection_pool_size")]
    public int? ConnectionPoolSize { get; set; }

    /// <summary>
    /// Gets or Sets DbName
    /// </summary>
    [DataMember(Name="db_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "db_name")]
    public string DbName { get; set; }

    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    [DataMember(Name="hostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public int? Port { get; set; }

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
      sb.Append("class ModelSqlDatabaseConfig {\n");
      sb.Append("  ConnectionPoolSize: ").Append(ConnectionPoolSize).Append("\n");
      sb.Append("  DbName: ").Append(DbName).Append("\n");
      sb.Append("  Hostname: ").Append(Hostname).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
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
