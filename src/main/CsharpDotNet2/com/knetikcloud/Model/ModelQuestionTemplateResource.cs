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
  public class ModelQuestionTemplateResource {
    /// <summary>
    /// A property definition for all answers. If included each answer must match this definition's type and be valid
    /// </summary>
    /// <value>A property definition for all answers. If included each answer must match this definition's type and be valid</value>
    [DataMember(Name="answer_property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answer_property")]
    public ModelPropertyDefinitionResource AnswerProperty { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The id of the template
    /// </summary>
    /// <value>The id of the template</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the template
    /// </summary>
    /// <value>The name of the template</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The customized properties that are present
    /// </summary>
    /// <value>The customized properties that are present</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ModelPropertyDefinitionResource> Properties { get; set; }

    /// <summary>
    /// A property definition for the question itself. If included the answer must match this definition's type and be valid
    /// </summary>
    /// <value>A property definition for the question itself. If included the answer must match this definition's type and be valid</value>
    [DataMember(Name="question_property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "question_property")]
    public ModelPropertyDefinitionResource QuestionProperty { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelQuestionTemplateResource {\n");
      sb.Append("  AnswerProperty: ").Append(AnswerProperty).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  QuestionProperty: ").Append(QuestionProperty).Append("\n");
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
