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
  public class ModelCommentSearch {
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [DataMember(Name="context_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id")]
    public int? ContextId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets OwnerId
    /// </summary>
    [DataMember(Name="owner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Gets or Sets OwnerUsername
    /// </summary>
    [DataMember(Name="owner_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_username")]
    public string OwnerUsername { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCommentSearch {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  ContextId: ").Append(ContextId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  OwnerUsername: ").Append(OwnerUsername).Append("\n");
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
