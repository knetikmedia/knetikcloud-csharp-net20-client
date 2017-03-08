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
  public class StateResource {
    /// <summary>
    /// The code of the state
    /// </summary>
    /// <value>The code of the state</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The iso3 of the country this state is in
    /// </summary>
    /// <value>The iso3 of the country this state is in</value>
    [DataMember(Name="country_code_iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_code_iso3")]
    public string CountryCodeIso3 { get; set; }

    /// <summary>
    /// The unique ID for the state
    /// </summary>
    /// <value>The unique ID for the state</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the state
    /// </summary>
    /// <value>The name of the state</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StateResource {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  CountryCodeIso3: ").Append(CountryCodeIso3).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
