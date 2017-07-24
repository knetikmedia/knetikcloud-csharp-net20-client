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
  public class PollResponseResource {
    /// <summary>
    /// The answer to the poll
    /// </summary>
    /// <value>The answer to the poll</value>
    [DataMember(Name="answer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answer")]
    public string Answer { get; set; }

    /// <summary>
    /// The date the poll was answered, in seconds since unix epoc
    /// </summary>
    /// <value>The date the poll was answered, in seconds since unix epoc</value>
    [DataMember(Name="answered_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answered_date")]
    public long? AnsweredDate { get; set; }

    /// <summary>
    /// The id of the poll response
    /// </summary>
    /// <value>The id of the poll response</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The id of the poll
    /// </summary>
    /// <value>The id of the poll</value>
    [DataMember(Name="poll_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poll_id")]
    public string PollId { get; set; }

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
      sb.Append("class PollResponseResource {\n");
      sb.Append("  Answer: ").Append(Answer).Append("\n");
      sb.Append("  AnsweredDate: ").Append(AnsweredDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PollId: ").Append(PollId).Append("\n");
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
