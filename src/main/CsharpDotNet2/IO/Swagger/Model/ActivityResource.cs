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
  public class ActivityResource {
    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The list of items that can be used for entitlement (wager amounts/etc)
    /// </summary>
    /// <value>The list of items that can be used for entitlement (wager amounts/etc)</value>
    [DataMember(Name="entitlements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entitlements")]
    public List<ActivityEntitlementResource> Entitlements { get; set; }

    /// <summary>
    /// The unique ID for that resource
    /// </summary>
    /// <value>The unique ID for that resource</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Details about how to launch the activity
    /// </summary>
    /// <value>Details about how to launch the activity</value>
    [DataMember(Name="launch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "launch")]
    public string Launch { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The user friendly name of that resource
    /// </summary>
    /// <value>The user friendly name of that resource</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing
    /// </summary>
    /// <value>The rewards to give at the end of each occurence of the activity. When creating/updating only id is used. Reward set must be pre-existing</value>
    [DataMember(Name="reward_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward_set")]
    public RewardSetResource RewardSet { get; set; }

    /// <summary>
    /// The list of settings and their options available for this activity. Not populated when getting listing
    /// </summary>
    /// <value>The list of settings and their options available for this activity. Not populated when getting listing</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<AvailableSettingResource> Settings { get; set; }

    /// <summary>
    /// The user friendly name of that resource. Defaults to blank string
    /// </summary>
    /// <value>The user friendly name of that resource. Defaults to blank string</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Whether this activity is a template for other activities. Default: false
    /// </summary>
    /// <value>Whether this activity is a template for other activities. Default: false</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public bool? Template { get; set; }

    /// <summary>
    /// The type of the activity
    /// </summary>
    /// <value>The type of the activity</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The unique key (for static reference in code) of the activity
    /// </summary>
    /// <value>The unique key (for static reference in code) of the activity</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

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
      sb.Append("class ActivityResource {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Entitlements: ").Append(Entitlements).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Launch: ").Append(Launch).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RewardSet: ").Append(RewardSet).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
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
