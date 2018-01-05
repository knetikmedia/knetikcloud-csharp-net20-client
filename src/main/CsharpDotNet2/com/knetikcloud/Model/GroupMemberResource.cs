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
  public class GroupMemberResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name (private). Must match the names and types defined in the template for this type, or be an extra not from the template</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<string, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The group. Id is the unique name
    /// </summary>
    /// <value>The group. Id is the unique name</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public SimpleGroupResource Group { get; set; }

    /// <summary>
    /// Whether this membership is explicit (the user was added directly to the group) or implicit (the user was added only to one or more child groups)
    /// </summary>
    /// <value>Whether this membership is explicit (the user was added directly to the group) or implicit (the user was added only to one or more child groups)</value>
    [DataMember(Name="implicit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implicit")]
    public bool? _Implicit { get; set; }

    /// <summary>
    /// The id of the membership entry
    /// </summary>
    /// <value>The id of the membership entry</value>
    [DataMember(Name="membership_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membership_id")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// The position of the member in the group if applicable. Read notes for details
    /// </summary>
    /// <value>The position of the member in the group if applicable. Read notes for details</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public string Order { get; set; }

    /// <summary>
    /// The member's access level. Default: member
    /// </summary>
    /// <value>The member's access level. Default: member</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// A template this member additional properties are validated against (private). May be null and no validation of properties will be done
    /// </summary>
    /// <value>A template this member additional properties are validated against (private). May be null and no validation of properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The user
    /// </summary>
    /// <value>The user</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUserResource User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupMemberResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  _Implicit: ").Append(_Implicit).Append("\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
