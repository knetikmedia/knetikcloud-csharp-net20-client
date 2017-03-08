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
  public class RewardSetResource {
    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The currency to give as rewards
    /// </summary>
    /// <value>The currency to give as rewards</value>
    [DataMember(Name="currency_rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_rewards")]
    public List<RewardCurrencyResource> CurrencyRewards { get; set; }

    /// <summary>
    /// The assigned unique ID for this reward set
    /// </summary>
    /// <value>The assigned unique ID for this reward set</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The items to give as rewards
    /// </summary>
    /// <value>The items to give as rewards</value>
    [DataMember(Name="item_rewards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_rewards")]
    public List<RewardItemResource> ItemRewards { get; set; }

    /// <summary>
    /// A longer describe the reward set, usually included in details
    /// </summary>
    /// <value>A longer describe the reward set, usually included in details</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The maximum placing that will receive a reward
    /// </summary>
    /// <value>The maximum placing that will receive a reward</value>
    [DataMember(Name="max_placing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_placing")]
    public int? MaxPlacing { get; set; }

    /// <summary>
    /// The user friendly name for this reward set
    /// </summary>
    /// <value>The user friendly name for this reward set</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A short paragraph to describe the reward set, usually included in listings.  Max 255 characters
    /// </summary>
    /// <value>A short paragraph to describe the reward set, usually included in listings.  Max 255 characters</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// A provided unique key for this reward set
    /// </summary>
    /// <value>A provided unique key for this reward set</value>
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
      sb.Append("class RewardSetResource {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CurrencyRewards: ").Append(CurrencyRewards).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ItemRewards: ").Append(ItemRewards).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  MaxPlacing: ").Append(MaxPlacing).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
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
