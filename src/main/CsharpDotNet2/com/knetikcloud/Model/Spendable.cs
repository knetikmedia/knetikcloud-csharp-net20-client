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
  public class Spendable : Behavior {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Used for polymorphic type recognition and thus must match an expected type with additional properties
    /// </summary>
    /// <value>Used for polymorphic type recognition and thus must match an expected type with additional properties</value>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }

    /// <summary>
    /// The code of the currency
    /// </summary>
    /// <value>The code of the currency</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The spendable value
    /// </summary>
    /// <value>The spendable value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Spendable {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
