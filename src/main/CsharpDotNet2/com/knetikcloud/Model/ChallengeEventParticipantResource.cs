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
  public class ChallengeEventParticipantResource {
    /// <summary>
    /// The email address of the user
    /// </summary>
    /// <value>The email address of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The full name of the user
    /// </summary>
    /// <value>The full name of the user</value>
    [DataMember(Name="fullname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullname")]
    public string Fullname { get; set; }

    /// <summary>
    /// The user's score
    /// </summary>
    /// <value>The user's score</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public long? Score { get; set; }

    /// <summary>
    /// The id of the user
    /// </summary>
    /// <value>The id of the user</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// The username of the user
    /// </summary>
    /// <value>The username of the user</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChallengeEventParticipantResource {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Fullname: ").Append(Fullname).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
