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
  public class ChatBlacklistResource {
    /// <summary>
    /// The user that is blacklisted
    /// </summary>
    /// <value>The user that is blacklisted</value>
    [DataMember(Name="blacklisted_user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blacklisted_user")]
    public SimpleUserResource BlacklistedUser { get; set; }

    /// <summary>
    /// The date the user was blacklisted
    /// </summary>
    /// <value>The date the user was blacklisted</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The unique ID for this chat message blacklist
    /// </summary>
    /// <value>The unique ID for this chat message blacklist</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The user that has blacklisted someone
    /// </summary>
    /// <value>The user that has blacklisted someone</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChatBlacklistResource {\n");
      sb.Append("  BlacklistedUser: ").Append(BlacklistedUser).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
