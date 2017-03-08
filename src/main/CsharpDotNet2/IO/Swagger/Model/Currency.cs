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
  public class Currency {
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name="date_created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_created")]
    public long? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateUpdated
    /// </summary>
    [DataMember(Name="date_updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_updated")]
    public long? DateUpdated { get; set; }

    /// <summary>
    /// Gets or Sets Factor
    /// </summary>
    [DataMember(Name="factor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factor")]
    public double? Factor { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets _Virtual
    /// </summary>
    [DataMember(Name="virtual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "virtual")]
    public bool? _Virtual { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Currency {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
      sb.Append("  Factor: ").Append(Factor).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  _Virtual: ").Append(_Virtual).Append("\n");
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
