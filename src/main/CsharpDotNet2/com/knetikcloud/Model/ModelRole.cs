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
  public class ModelRole {
    /// <summary>
    /// Gets or Sets ClientCount
    /// </summary>
    [DataMember(Name="client_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_count")]
    public int? ClientCount { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Locked
    /// </summary>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Role
    /// </summary>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Gets or Sets RolePermission
    /// </summary>
    [DataMember(Name="role_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role_permission")]
    public List<ModelPermission> RolePermission { get; set; }

    /// <summary>
    /// Gets or Sets UserCount
    /// </summary>
    [DataMember(Name="user_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_count")]
    public int? UserCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelRole {\n");
      sb.Append("  ClientCount: ").Append(ClientCount).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
