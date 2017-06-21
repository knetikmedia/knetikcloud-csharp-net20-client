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
  public class ModelTimePeriodGettable : ModelBehavior {
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
    /// The time period limit
    /// </summary>
    /// <value>The time period limit</value>
    [DataMember(Name="get_limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "get_limit")]
    public int? GetLimit { get; set; }

    /// <summary>
    /// The name of a group of items. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that the other properties here will be the same for all, but this is not enforced and the item being recieved will use its settings.
    /// </summary>
    /// <value>The name of a group of items. Multiple items with the same group name will be limited together, leave null to be assigned a random unique name. It is typical that the other properties here will be the same for all, but this is not enforced and the item being recieved will use its settings.</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// The length of time
    /// </summary>
    /// <value>The length of time</value>
    [DataMember(Name="time_length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_length")]
    public int? TimeLength { get; set; }

    /// <summary>
    /// The unit of time
    /// </summary>
    /// <value>The unit of time</value>
    [DataMember(Name="unit_of_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_of_time")]
    public string UnitOfTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelTimePeriodGettable {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
      sb.Append("  GetLimit: ").Append(GetLimit).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  TimeLength: ").Append(TimeLength).Append("\n");
      sb.Append("  UnitOfTime: ").Append(UnitOfTime).Append("\n");
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
