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
  public class CountryTaxResource {
    /// <summary>
    /// The iso3 code of the country, cannot be changed
    /// </summary>
    /// <value>The iso3 code of the country, cannot be changed</value>
    [DataMember(Name="country_iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_iso3")]
    public string CountryIso3 { get; set; }

    /// <summary>
    /// The name of the tax
    /// </summary>
    /// <value>The name of the tax</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The tax rate as a percentage to a maximum of two decimal places (1.5 means 1.5%)
    /// </summary>
    /// <value>The tax rate as a percentage to a maximum of two decimal places (1.5 means 1.5%)</value>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public double? Rate { get; set; }

    /// <summary>
    /// Whether the tax applies to shipping costs
    /// </summary>
    /// <value>Whether the tax applies to shipping costs</value>
    [DataMember(Name="tax_shipping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_shipping")]
    public bool? TaxShipping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CountryTaxResource {\n");
      sb.Append("  CountryIso3: ").Append(CountryIso3).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Rate: ").Append(Rate).Append("\n");
      sb.Append("  TaxShipping: ").Append(TaxShipping).Append("\n");
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
