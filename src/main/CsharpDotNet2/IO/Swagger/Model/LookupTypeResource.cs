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
  public class LookupTypeResource {
    /// <summary>
    /// The description of the expression type
    /// </summary>
    /// <value>The description of the expression type</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The variable type the key expression must be, or null if it's dependent (see description for explanation in this case)
    /// </summary>
    /// <value>The variable type the key expression must be, or null if it's dependent (see description for explanation in this case)</value>
    [DataMember(Name="key_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_type")]
    public string KeyType { get; set; }

    /// <summary>
    /// The name of the expression type
    /// </summary>
    /// <value>The name of the expression type</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The variable type of the value this expression returns, or null if it's dependent (see description for explanation in this case)
    /// </summary>
    /// <value>The variable type of the value this expression returns, or null if it's dependent (see description for explanation in this case)</value>
    [DataMember(Name="value_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_type")]
    public string ValueType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupTypeResource {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  KeyType: ").Append(KeyType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
