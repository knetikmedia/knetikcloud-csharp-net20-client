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
  public class ImageProperty : FileProperty {
    /// <summary>
    /// The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.
    /// </summary>
    /// <value>The type of the property. Used for polymorphic type recognition and thus must match an expected type with additional properties.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// A crc value for file integrity verification
    /// </summary>
    /// <value>A crc value for file integrity verification</value>
    [DataMember(Name="crc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crc")]
    public string Crc { get; set; }

    /// <summary>
    /// A description of the file
    /// </summary>
    /// <value>A description of the file</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The type of file such as txt, mp3, mov or csv
    /// </summary>
    /// <value>The type of file such as txt, mp3, mov or csv</value>
    [DataMember(Name="file_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file_type")]
    public string FileType { get; set; }

    /// <summary>
    /// The url of the file
    /// </summary>
    /// <value>The url of the file</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImageProperty {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Crc: ").Append(Crc).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FileType: ").Append(FileType).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
