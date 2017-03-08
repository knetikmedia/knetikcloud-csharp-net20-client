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
  public class Language {
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
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsPrimary
    /// </summary>
    [DataMember(Name="is_primary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_primary")]
    public bool? IsPrimary { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Language {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
      sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
