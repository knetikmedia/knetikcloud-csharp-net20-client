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
  public class ModelBillingReport {
    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public long? Created { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets LastKnownFailures
    /// </summary>
    [DataMember(Name="last_known_failures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_known_failures")]
    public List<string> LastKnownFailures { get; set; }

    /// <summary>
    /// Gets or Sets Statistics
    /// </summary>
    [DataMember(Name="statistics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statistics")]
    public Dictionary<String, int?> Statistics { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelBillingReport {\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastKnownFailures: ").Append(LastKnownFailures).Append("\n");
      sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
