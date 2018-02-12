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
  public class ChallengeActivityResource {
    /// <summary>
    /// The id of the activity
    /// </summary>
    /// <value>The id of the activity</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public long? ActivityId { get; set; }

    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<string, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The id of the challenge
    /// </summary>
    /// <value>The id of the challenge</value>
    [DataMember(Name="challenge_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenge_id")]
    public long? ChallengeId { get; set; }

    /// <summary>
    /// Defines core settings about the activity that affect how it can be created/played by users. Values may be left null to inherit from parent activity.
    /// </summary>
    /// <value>Defines core settings about the activity that affect how it can be created/played by users. Values may be left null to inherit from parent activity.</value>
    [DataMember(Name="core_settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "core_settings")]
    public CoreChallengeActivitySettings CoreSettings { get; set; }

    /// <summary>
    /// The entitlement item needed to participate in the activity as part of this event. Null indicates free entry. When creating/updating only id is used. Item must be pre-existing
    /// </summary>
    /// <value>The entitlement item needed to participate in the activity as part of this event. Null indicates free entry. When creating/updating only id is used. Item must be pre-existing</value>
    [DataMember(Name="entitlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlement")]
    public ActivityEntitlementResource Entitlement { get; set; }

    /// <summary>
    /// The unique ID for this resource
    /// </summary>
    /// <value>The unique ID for this resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing
    /// </summary>
    /// <value>The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing</value>
    [DataMember(Name="reward_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_set")]
    public RewardSetResource RewardSet { get; set; }

    /// <summary>
    /// The list of settings and the select options
    /// </summary>
    /// <value>The list of settings and the select options</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<SelectedSettingResource> Settings { get; set; }

    /// <summary>
    /// A challenge activity template this challenge activity is validated against (private). May be null and no validation of additional_properties will be done
    /// </summary>
    /// <value>A challenge activity template this challenge activity is validated against (private). May be null and no validation of additional_properties will be done</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChallengeActivityResource {\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  ChallengeId: ").Append(ChallengeId).Append("\n");
      sb.Append("  CoreSettings: ").Append(CoreSettings).Append("\n");
      sb.Append("  Entitlement: ").Append(Entitlement).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
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
