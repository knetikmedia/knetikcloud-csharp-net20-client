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
  public class AnswerResource {
    /// <summary>
    /// The answer to the question. Different 'type' values indicate different structures as the answer may be test, image, etc. See information on additional properties for the list and their structures
    /// </summary>
    /// <value>The answer to the question. Different 'type' values indicate different structures as the answer may be test, image, etc. See information on additional properties for the list and their structures</value>
    [DataMember(Name="answer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answer")]
    public Property Answer { get; set; }

    /// <summary>
    /// Whether the answer is correct or not
    /// </summary>
    /// <value>Whether the answer is correct or not</value>
    [DataMember(Name="correct", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correct")]
    public bool? Correct { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnswerResource {\n");
      sb.Append("  Answer: ").Append(Answer).Append("\n");
      sb.Append("  Correct: ").Append(Correct).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
