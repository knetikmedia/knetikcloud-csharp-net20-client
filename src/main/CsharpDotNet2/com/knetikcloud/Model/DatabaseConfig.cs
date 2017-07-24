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
  public class DatabaseConfig {
    /// <summary>
    /// Gets or Sets Mongo
    /// </summary>
    [DataMember(Name="mongo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mongo")]
    public MongoDatabaseConfig Mongo { get; set; }

    /// <summary>
    /// Gets or Sets Sql
    /// </summary>
    [DataMember(Name="sql", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sql")]
    public SqlDatabaseConfig Sql { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DatabaseConfig {\n");
      sb.Append("  Mongo: ").Append(Mongo).Append("\n");
      sb.Append("  Sql: ").Append(Sql).Append("\n");
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
