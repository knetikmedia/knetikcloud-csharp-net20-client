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
  public class FlagReportResource {
    /// <summary>
    /// The context of that resource 
    /// </summary>
    /// <value>The context of that resource </value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// The context ID of that resource
    /// </summary>
    /// <value>The context ID of that resource</value>
    [DataMember(Name="context_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id")]
    public string ContextId { get; set; }

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
    /// The reason of that resource required only in case of active resolution
    /// </summary>
    /// <value>The reason of that resource required only in case of active resolution</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The resolution of that resource
    /// </summary>
    /// <value>The resolution of that resource</value>
    [DataMember(Name="resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolution")]
    public string Resolution { get; set; }

    /// <summary>
    /// The date/time this report was resolved in seconds since epoch. Null if not resolved yet
    /// </summary>
    /// <value>The date/time this report was resolved in seconds since epoch. Null if not resolved yet</value>
    [DataMember(Name="resolved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolved")]
    public long? Resolved { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlagReportResource {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  ContextId: ").Append(ContextId).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  Resolved: ").Append(Resolved).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
