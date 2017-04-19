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
  public class ModelCommentResource {
    /// <summary>
    /// The comment content of that resource
    /// </summary>
    /// <value>The comment content of that resource</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    /// <summary>
    /// The type of object this comment applies to (ex: video, article, etc). Required when passed to /comments
    /// </summary>
    /// <value>The type of object this comment applies to (ex: video, article, etc). Required when passed to /comments</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// The id of the object this comment applies to.  Required when passed to /comments
    /// </summary>
    /// <value>The id of the object this comment applies to.  Required when passed to /comments</value>
    [DataMember(Name="context_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id")]
    public int? ContextId { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The summary of that resource
    /// </summary>
    /// <value>The summary of that resource</value>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The user who created the comment
    /// </summary>
    /// <value>The user who created the comment</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public ModelSimpleUserResource User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCommentResource {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  ContextId: ").Append(ContextId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
