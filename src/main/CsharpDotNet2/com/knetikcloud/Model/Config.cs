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
  public class Config {
    /// <summary>
    /// The description of the config.  Max 255 characters
    /// </summary>
    /// <value>The description of the config.  Max 255 characters</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the config
    /// </summary>
    /// <value>The name of the config</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether the config is public for viewing. True means that it can be publicly viewed by all. Default: false
    /// </summary>
    /// <value>Whether the config is public for viewing. True means that it can be publicly viewed by all. Default: false</value>
    [DataMember(Name="public_read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_read")]
    public bool? PublicRead { get; set; }

    /// <summary>
    /// The value of the config
    /// </summary>
    /// <value>The value of the config</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Config {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PublicRead: ").Append(PublicRead).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
