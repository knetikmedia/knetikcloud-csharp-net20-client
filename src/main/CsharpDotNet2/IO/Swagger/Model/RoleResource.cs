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
  public class RoleResource {
    /// <summary>
    /// The number of clients this role is assigned to
    /// </summary>
    /// <value>The number of clients this role is assigned to</value>
    [DataMember(Name="client_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_count")]
    public int? ClientCount { get; set; }

    /// <summary>
    /// The date the role was added. Unix timestamp in seconds
    /// </summary>
    /// <value>The date the role was added. Unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Whether a role is locked from being deleted
    /// </summary>
    /// <value>Whether a role is locked from being deleted</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// The name of the role used for display purposes
    /// </summary>
    /// <value>The name of the role used for display purposes</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The keyword that defines the role
    /// </summary>
    /// <value>The keyword that defines the role</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// The list of permissions this role has
    /// </summary>
    /// <value>The list of permissions this role has</value>
    [DataMember(Name="role_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role_permission")]
    public List<PermissionResource> RolePermission { get; set; }

    /// <summary>
    /// The number of users this role is assigned to
    /// </summary>
    /// <value>The number of users this role is assigned to</value>
    [DataMember(Name="user_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_count")]
    public int? UserCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RoleResource {\n");
      sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  RolePermission: ").Append(RolePermission).Append("\n");
      sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
