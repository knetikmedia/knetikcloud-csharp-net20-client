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
  public class RewardCurrencyResource {
    /// <summary>
    /// The code of the currency type to give
    /// </summary>
    /// <value>The code of the currency type to give</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The name of the currency reward to give.  Set by currency_code)
    /// </summary>
    /// <value>The name of the currency reward to give.  Set by currency_code)</value>
    [DataMember(Name="currency_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_name")]
    public string CurrencyName { get; set; }

    /// <summary>
    /// The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank
    /// </summary>
    /// <value>The highest number (worst) rank to give the reward to. Must be greater than or equal to minRank</value>
    [DataMember(Name="max_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_rank")]
    public int? MaxRank { get; set; }

    /// <summary>
    /// The lowest number (best) rank to give the reward to. Must be greater than zero
    /// </summary>
    /// <value>The lowest number (best) rank to give the reward to. Must be greater than zero</value>
    [DataMember(Name="min_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_rank")]
    public int? MinRank { get; set; }

    /// <summary>
    /// True if the value is actually a percentage of the intake
    /// </summary>
    /// <value>True if the value is actually a percentage of the intake</value>
    [DataMember(Name="percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percent")]
    public bool? Percent { get; set; }

    /// <summary>
    /// The amount of currency to give. For percentage values, 0.5 is 50%
    /// </summary>
    /// <value>The amount of currency to give. For percentage values, 0.5 is 50%</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public double? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RewardCurrencyResource {\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
      sb.Append("  MaxRank: ").Append(MaxRank).Append("\n");
      sb.Append("  MinRank: ").Append(MinRank).Append("\n");
      sb.Append("  Percent: ").Append(Percent).Append("\n");
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
