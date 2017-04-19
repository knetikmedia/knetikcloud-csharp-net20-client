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
  public class ModelCountryResource {
    /// <summary>
    /// The iso2 of the country
    /// </summary>
    /// <value>The iso2 of the country</value>
    [DataMember(Name="iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso2")]
    public string Iso2 { get; set; }

    /// <summary>
    /// The iso3 of the country
    /// </summary>
    /// <value>The iso3 of the country</value>
    [DataMember(Name="iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso3")]
    public string Iso3 { get; set; }

    /// <summary>
    /// The name of the country resource
    /// </summary>
    /// <value>The name of the country resource</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCountryResource {\n");
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
