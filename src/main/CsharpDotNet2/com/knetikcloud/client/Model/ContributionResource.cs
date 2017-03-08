using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ContributionResource {
    /// <summary>
    /// A reference to the contributing artist
    /// </summary>
    /// <value>A reference to the contributing artist</value>
    [DataMember(Name="artist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artist")]
    public SimpleReferenceResourcelong Artist { get; set; }

    /// <summary>
    /// A reference to the media being contributed to
    /// </summary>
    /// <value>A reference to the media being contributed to</value>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public SimpleReferenceResourcelong Media { get; set; }

    /// <summary>
    /// The nature of the contribution (role of the artist as in 'producer', 'performer', etc)
    /// </summary>
    /// <value>The nature of the contribution (role of the artist as in 'producer', 'performer', etc)</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContributionResource {\n");
      sb.Append("  Artist: ").Append(Artist).Append("\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
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
