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
  public class ModelS3Config {
    /// <summary>
    /// Gets or Sets BucketName
    /// </summary>
    [DataMember(Name="bucket_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucket_name")]
    public string BucketName { get; set; }

    /// <summary>
    /// Gets or Sets CdnUrl
    /// </summary>
    [DataMember(Name="cdn_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cdn_url")]
    public string CdnUrl { get; set; }

    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// Gets or Sets UploadPrefix
    /// </summary>
    [DataMember(Name="upload_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upload_prefix")]
    public string UploadPrefix { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelS3Config {\n");
      sb.Append("  BucketName: ").Append(BucketName).Append("\n");
      sb.Append("  CdnUrl: ").Append(CdnUrl).Append("\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
      sb.Append("  UploadPrefix: ").Append(UploadPrefix).Append("\n");
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
