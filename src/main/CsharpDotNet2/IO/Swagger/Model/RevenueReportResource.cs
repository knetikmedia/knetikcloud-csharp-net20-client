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
  public class RevenueReportResource {
    /// <summary>
    /// Gets or Sets CustomerCount
    /// </summary>
    [DataMember(Name="customer_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_count")]
    public long? CustomerCount { get; set; }

    /// <summary>
    /// Gets or Sets SaleCount
    /// </summary>
    [DataMember(Name="sale_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_count")]
    public long? SaleCount { get; set; }

    /// <summary>
    /// Gets or Sets SalesAverage
    /// </summary>
    [DataMember(Name="sales_average", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sales_average")]
    public double? SalesAverage { get; set; }

    /// <summary>
    /// Gets or Sets SalesTotal
    /// </summary>
    [DataMember(Name="sales_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sales_total")]
    public double? SalesTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RevenueReportResource {\n");
      sb.Append("  CustomerCount: ").Append(CustomerCount).Append("\n");
      sb.Append("  SaleCount: ").Append(SaleCount).Append("\n");
      sb.Append("  SalesAverage: ").Append(SalesAverage).Append("\n");
      sb.Append("  SalesTotal: ").Append(SalesTotal).Append("\n");
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
