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
  public class DeltaResource {
    /// <summary>
    /// The id of the category for question
    /// </summary>
    /// <value>The id of the category for question</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public string CategoryId { get; set; }

    /// <summary>
    /// The media type of the question
    /// </summary>
    /// <value>The media type of the question</value>
    [DataMember(Name="media_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media_type")]
    public string MediaType { get; set; }

    /// <summary>
    /// The id of the question
    /// </summary>
    /// <value>The id of the question</value>
    [DataMember(Name="question_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "question_id")]
    public string QuestionId { get; set; }

    /// <summary>
    /// Whether the question was updated or removed
    /// </summary>
    /// <value>Whether the question was updated or removed</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The tags for the question
    /// </summary>
    /// <value>The tags for the question</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// The date this question was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date this question was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeltaResource {\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  MediaType: ").Append(MediaType).Append("\n");
      sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
