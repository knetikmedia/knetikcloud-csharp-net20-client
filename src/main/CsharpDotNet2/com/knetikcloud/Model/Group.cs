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
  public class Group {
    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets MemberCount
    /// </summary>
    [DataMember(Name="member_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_count")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// Gets or Sets MessageOfTheDay
    /// </summary>
    [DataMember(Name="message_of_the_day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message_of_the_day")]
    public string MessageOfTheDay { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Parent
    /// </summary>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public Group Parent { get; set; }

    /// <summary>
    /// Gets or Sets PropertiesString
    /// </summary>
    [DataMember(Name="properties_string", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties_string")]
    public string PropertiesString { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets SubMemberCount
    /// </summary>
    [DataMember(Name="sub_member_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sub_member_count")]
    public int? SubMemberCount { get; set; }

    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// Gets or Sets UniqueName
    /// </summary>
    [DataMember(Name="unique_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_name")]
    public string UniqueName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Group {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
      sb.Append("  MessageOfTheDay: ").Append(MessageOfTheDay).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  PropertiesString: ").Append(PropertiesString).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SubMemberCount: ").Append(SubMemberCount).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
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
