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
  public class SubscriptionResource {
    /// <summary>
    /// A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type.
    /// </summary>
    /// <value>A map of item additional properties, keyed on the property name. Must match the names and types defined in the template for this item type.</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<string, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// Who can purchase this subscription
    /// </summary>
    /// <value>Who can purchase this subscription</value>
    [DataMember(Name="availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability")]
    public string Availability { get; set; }

    /// <summary>
    /// The behaviors linked to the item, describing various options and interactions. May not be included in item lists
    /// </summary>
    /// <value>The behaviors linked to the item, describing various options and interactions. May not be included in item lists</value>
    [DataMember(Name="behaviors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "behaviors")]
    public List<Behavior> Behaviors { get; set; }

    /// <summary>
    /// A category for filtering items
    /// </summary>
    /// <value>A category for filtering items</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// The day of the month 1..31 this subscription will renew
    /// </summary>
    /// <value>The day of the month 1..31 this subscription will renew</value>
    [DataMember(Name="consolidation_day_of_month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consolidation_day_of_month")]
    public int? ConsolidationDayOfMonth { get; set; }

    /// <summary>
    /// The date the item was created, unix timestamp in seconds
    /// </summary>
    /// <value>The date the item was created, unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// A list of country iso3 codes to include in the blacklist/whitelist geo policy
    /// </summary>
    /// <value>A list of country iso3 codes to include in the blacklist/whitelist geo policy</value>
    [DataMember(Name="geo_country_list", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geo_country_list")]
    public List<string> GeoCountryList { get; set; }

    /// <summary>
    /// Whether to use the geo_country_list as a black list or white list for item geographical availability
    /// </summary>
    /// <value>Whether to use the geo_country_list as a black list or white list for item geographical availability</value>
    [DataMember(Name="geo_policy_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geo_policy_type")]
    public string GeoPolicyType { get; set; }

    /// <summary>
    /// The id of the item
    /// </summary>
    /// <value>The id of the item</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// A long description of the subscription
    /// </summary>
    /// <value>A long description of the subscription</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The name of the item
    /// </summary>
    /// <value>The name of the item</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The billing options for this subscription
    /// </summary>
    /// <value>The billing options for this subscription</value>
    [DataMember(Name="plans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plans")]
    public List<SubscriptionPlanResource> Plans { get; set; }

    /// <summary>
    /// A short description of the subscription.  Max 255 characters
    /// </summary>
    /// <value>A short description of the subscription.  Max 255 characters</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// A number to use in sorting items.  Default 500
    /// </summary>
    /// <value>A number to use in sorting items.  Default 500</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// Used to schedule removal from store.  Null means the subscription will never be removed
    /// </summary>
    /// <value>Used to schedule removal from store.  Null means the subscription will never be removed</value>
    [DataMember(Name="store_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_end")]
    public long? StoreEnd { get; set; }

    /// <summary>
    /// Used to schedule appearance in store.  Null means the subscription will appear now
    /// </summary>
    /// <value>Used to schedule appearance in store.  Null means the subscription will appear now</value>
    [DataMember(Name="store_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_start")]
    public long? StoreStart { get; set; }

    /// <summary>
    /// List of tags used for filtering items
    /// </summary>
    /// <value>List of tags used for filtering items</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// An item template this item is validated against. May be null and no validation of additional properties will be done.
    /// </summary>
    /// <value>An item template this item is validated against. May be null and no validation of additional properties will be done.</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The unique key for the item
    /// </summary>
    /// <value>The unique key for the item</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// The date the item was last updated
    /// </summary>
    /// <value>The date the item was last updated</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The vendor who provides the item
    /// </summary>
    /// <value>The vendor who provides the item</value>
    [DataMember(Name="vendor_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_id")]
    public int? VendorId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionResource {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Availability: ").Append(Availability).Append("\n");
      sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  ConsolidationDayOfMonth: ").Append(ConsolidationDayOfMonth).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  GeoCountryList: ").Append(GeoCountryList).Append("\n");
      sb.Append("  GeoPolicyType: ").Append(GeoPolicyType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Plans: ").Append(Plans).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  StoreEnd: ").Append(StoreEnd).Append("\n");
      sb.Append("  StoreStart: ").Append(StoreStart).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
