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
  public class ResourceTypeDescription {
    /// <summary>
    /// The field on the resource that the id is in
    /// </summary>
    /// <value>The field on the resource that the id is in</value>
    [DataMember(Name="id_field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id_field")]
    public string IdField { get; set; }

    /// <summary>
    /// The unique name for the resource in swagger. This serves as the unique identifier. Cannot be changed after creation
    /// </summary>
    /// <value>The unique name for the resource in swagger. This serves as the unique identifier. Cannot be changed after creation</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The base path of the service
    /// </summary>
    /// <value>The base path of the service</value>
    [DataMember(Name="service_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_path")]
    public string ServicePath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceTypeDescription {\n");
      sb.Append("  IdField: ").Append(IdField).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ServicePath: ").Append(ServicePath).Append("\n");
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
