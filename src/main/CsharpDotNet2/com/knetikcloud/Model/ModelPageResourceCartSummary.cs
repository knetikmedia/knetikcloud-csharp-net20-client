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
  public class ModelPageResourceCartSummary {
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public List<ModelCartSummary> Content { get; set; }

    /// <summary>
    /// Gets or Sets First
    /// </summary>
    [DataMember(Name="first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first")]
    public bool? First { get; set; }

    /// <summary>
    /// Gets or Sets Last
    /// </summary>
    [DataMember(Name="last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last")]
    public bool? Last { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfElements
    /// </summary>
    [DataMember(Name="number_of_elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_elements")]
    public int? NumberOfElements { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }

    /// <summary>
    /// Gets or Sets Sort
    /// </summary>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public List<ModelOrder> Sort { get; set; }

    /// <summary>
    /// Gets or Sets TotalElements
    /// </summary>
    [DataMember(Name="total_elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_elements")]
    public long? TotalElements { get; set; }

    /// <summary>
    /// Gets or Sets TotalPages
    /// </summary>
    [DataMember(Name="total_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_pages")]
    public int? TotalPages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPageResourceCartSummary {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  First: ").Append(First).Append("\n");
      sb.Append("  Last: ").Append(Last).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
