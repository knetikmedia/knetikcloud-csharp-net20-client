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
  public class Batch {
    /// <summary>
    /// The list of batch requests
    /// </summary>
    /// <value>The list of batch requests</value>
    [DataMember(Name="batch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch")]
    public List<BatchRequest> _Batch { get; set; }

    /// <summary>
    /// The amount of time before a request token is returned instead of the batch result.  Default is 60.  Range is 0-300
    /// </summary>
    /// <value>The amount of time before a request token is returned instead of the batch result.  Default is 60.  Range is 0-300</value>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public int? Timeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Batch {\n");
      sb.Append("  _Batch: ").Append(_Batch).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
