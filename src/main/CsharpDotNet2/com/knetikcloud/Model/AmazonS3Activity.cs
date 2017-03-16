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
  public class AmazonS3Activity {
    /// <summary>
    /// S3 action (i.e., 'PUT') associated with the activity
    /// </summary>
    /// <value>S3 action (i.e., 'PUT') associated with the activity</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Date the resource was created in S3
    /// </summary>
    /// <value>Date the resource was created in S3</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Name of the file being processed as a resource in S3
    /// </summary>
    /// <value>Name of the file being processed as a resource in S3</value>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Unique id of the S3 activity
    /// </summary>
    /// <value>Unique id of the S3 activity</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// S3 object key for the resource
    /// </summary>
    /// <value>S3 object key for the resource</value>
    [DataMember(Name="object_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object_key")]
    public string ObjectKey { get; set; }

    /// <summary>
    /// URL for accessing the S3 resource
    /// </summary>
    /// <value>URL for accessing the S3 resource</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The id of the user that created this S3 activity
    /// </summary>
    /// <value>The id of the user that created this S3 activity</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AmazonS3Activity {\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ObjectKey: ").Append(ObjectKey).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
