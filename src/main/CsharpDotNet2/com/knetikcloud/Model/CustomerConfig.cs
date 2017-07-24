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
  public class CustomerConfig {
    /// <summary>
    /// Gets or Sets Aliases
    /// </summary>
    [DataMember(Name="aliases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aliases")]
    public string Aliases { get; set; }

    /// <summary>
    /// Gets or Sets Database
    /// </summary>
    [DataMember(Name="database", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "database")]
    public DatabaseConfig Database { get; set; }

    /// <summary>
    /// Gets or Sets Io
    /// </summary>
    [DataMember(Name="io", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "io")]
    public IOConfig Io { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets S3Config
    /// </summary>
    [DataMember(Name="s3_config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "s3_config")]
    public S3Config S3Config { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerConfig {\n");
      sb.Append("  Aliases: ").Append(Aliases).Append("\n");
      sb.Append("  Database: ").Append(Database).Append("\n");
      sb.Append("  Io: ").Append(Io).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  S3Config: ").Append(S3Config).Append("\n");
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
