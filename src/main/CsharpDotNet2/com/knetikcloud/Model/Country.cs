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
  public class Country {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Iso2
    /// </summary>
    [DataMember(Name="iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso2")]
    public string Iso2 { get; set; }

    /// <summary>
    /// Gets or Sets Iso3
    /// </summary>
    [DataMember(Name="iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso3")]
    public string Iso3 { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Country {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Iso2: ").Append(Iso2).Append("\n");
      sb.Append("  Iso3: ").Append(Iso3).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
