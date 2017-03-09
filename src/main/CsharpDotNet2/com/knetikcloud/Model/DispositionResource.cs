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
  public class DispositionResource {
    /// <summary>
    /// The context of that resource. Required when passed to /dispositions rather than context specific endpoint
    /// </summary>
    /// <value>The context of that resource. Required when passed to /dispositions rather than context specific endpoint</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// The context_id of that resource. Required when passed to /dispositions rather than context specific endpoint
    /// </summary>
    /// <value>The context_id of that resource. Required when passed to /dispositions rather than context specific endpoint</value>
    [DataMember(Name="context_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id")]
    public string ContextId { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
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
    /// The name of the disposition, 1-20 characters. (ex: like/dislike/favorite, etc)
    /// </summary>
    /// <value>The name of the disposition, 1-20 characters. (ex: like/dislike/favorite, etc)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

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
      sb.Append("class DispositionResource {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  ContextId: ").Append(ContextId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
