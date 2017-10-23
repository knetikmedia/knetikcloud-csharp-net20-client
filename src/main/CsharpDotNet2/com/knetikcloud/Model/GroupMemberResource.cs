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
    /// The url of the user's avatar image
    /// </summary>
    /// <value>The url of the user's avatar image</value>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// The public username of the user
    /// </summary>
    /// <value>The public username of the user</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The id of the user
    /// </summary>
    /// <value>The id of the user</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// The username of the user
    /// </summary>
    /// <value>The username of the user</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupMemberResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
