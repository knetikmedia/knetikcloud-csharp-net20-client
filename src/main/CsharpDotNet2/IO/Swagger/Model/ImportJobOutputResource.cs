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
  public class ImportJobOutputResource {
    /// <summary>
    /// The description of the import job
    /// </summary>
    /// <value>The description of the import job</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The line number of the import job
    /// </summary>
    /// <value>The line number of the import job</value>
    [DataMember(Name="line_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_number")]
    public long? LineNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImportJobOutputResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
