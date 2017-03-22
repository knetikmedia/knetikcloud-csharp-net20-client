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
  public class ModelEntitlementGrantRequest {
    /// <summary>
    /// The ID of the entitlement item to grant
    /// </summary>
    /// <value>The ID of the entitlement item to grant</value>
    [DataMember(Name="entitlement_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlement_id")]
    public int? EntitlementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelEntitlementGrantRequest {\n");
      sb.Append("  EntitlementId: ").Append(EntitlementId).Append("\n");
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
