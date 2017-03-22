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
  public class ModelSampleCountriesResponse {
    /// <summary>
    /// Gets or Sets VendorId1
    /// </summary>
    [DataMember(Name="vendor_id1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_id1")]
    public List<ModelCountry> VendorId1 { get; set; }

    /// <summary>
    /// Gets or Sets VendorId2
    /// </summary>
    [DataMember(Name="vendor_id2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_id2")]
    public List<ModelCountry> VendorId2 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSampleCountriesResponse {\n");
      sb.Append("  VendorId1: ").Append(VendorId1).Append("\n");
      sb.Append("  VendorId2: ").Append(VendorId2).Append("\n");
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
