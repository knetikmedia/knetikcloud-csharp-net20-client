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
  public class QuestionResource {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The list of available answers
    /// </summary>
    /// <value>The list of available answers</value>
    [DataMember(Name="answers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answers")]
    public List<AnswerResource> Answers { get; set; }

    /// <summary>
    /// The category for the question
    /// </summary>
    /// <value>The category for the question</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public NestedCategory Category { get; set; }

    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The difficulty of the question
    /// </summary>
    /// <value>The difficulty of the question</value>
    [DataMember(Name="difficulty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "difficulty")]
    public int? Difficulty { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The id of the import job that created the question, or null if not from an import
    /// </summary>
    /// <value>The id of the import job that created the question, or null if not from an import</value>
    [DataMember(Name="import_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_id")]
    public long? ImportId { get; set; }

    /// <summary>
    /// When the question becomes available, null for never, in seconds since epoch
    /// </summary>
    /// <value>When the question becomes available, null for never, in seconds since epoch</value>
    [DataMember(Name="published_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published_date")]
    public long? PublishedDate { get; set; }

    /// <summary>
    /// The question. Different 'type' values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures
    /// </summary>
    /// <value>The question. Different 'type' values indicate different structures as the question may be test, image, etc. See information on additional properties for the list and their structures</value>
    [DataMember(Name="question", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "question")]
    public Property Question { get; set; }

    /// <summary>
    /// The first source of the question
    /// </summary>
    /// <value>The first source of the question</value>
    [DataMember(Name="source1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source1")]
    public string Source1 { get; set; }

    /// <summary>
    /// The second source of the question
    /// </summary>
    /// <value>The second source of the question</value>
    [DataMember(Name="source2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source2")]
    public string Source2 { get; set; }

    /// <summary>
    /// The list of tags
    /// </summary>
    /// <value>The list of tags</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// A question template this question is validated against (private). May be null and no validation of additional_properties will be done
    /// </summary>
    /// <value>A question template this question is validated against (private). May be null and no validation of additional_properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The date/time this resource was last updated in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The supplier of the question
    /// </summary>
    /// <value>The supplier of the question</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public string Vendor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuestionResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Answers: ").Append(Answers).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ImportId: ").Append(ImportId).Append("\n");
      sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
      sb.Append("  Question: ").Append(Question).Append("\n");
      sb.Append("  Source1: ").Append(Source1).Append("\n");
      sb.Append("  Source2: ").Append(Source2).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
