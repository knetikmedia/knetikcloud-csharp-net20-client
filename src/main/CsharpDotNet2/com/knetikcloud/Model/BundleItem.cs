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
  public class BundleItem {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The behaviors linked to the item, describing various options and interactions. May not be included in item lists
    /// </summary>
    /// <value>The behaviors linked to the item, describing various options and interactions. May not be included in item lists</value>
    [DataMember(Name="behaviors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "behaviors")]
    public List<Behavior> Behaviors { get; set; }

    /// <summary>
    /// The skus of items to be included in this bundle, and how they influence the bundle total price.  Must have at least one SKU
    /// </summary>
    /// <value>The skus of items to be included in this bundle, and how they influence the bundle total price.  Must have at least one SKU</value>
    [DataMember(Name="bundled_skus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bundled_skus")]
    public List<BundledSku> BundledSkus { get; set; }

    /// <summary>
    /// A category for filtering items
    /// </summary>
    /// <value>A category for filtering items</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// The date the item was created, unix timestamp in seconds
    /// </summary>
    /// <value>The date the item was created, unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Whether or not the item is currently displayable.  Default = true
    /// </summary>
    /// <value>Whether or not the item is currently displayable.  Default = true</value>
    [DataMember(Name="displayable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayable")]
    public bool? Displayable { get; set; }

    /// <summary>
    /// A list of country ID to include in the blacklist/whitelist geo policy
    /// </summary>
    /// <value>A list of country ID to include in the blacklist/whitelist geo policy</value>
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
    /// A long description of the item
    /// </summary>
    /// <value>A long description of the item</value>
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
    /// Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default = 0
    /// </summary>
    /// <value>Provides the abstract shipping needs if this item is physical and can be shipped.  A value of zero means no shipping needed.  Default = 0</value>
    [DataMember(Name="shipping_tier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_tier")]
    public int? ShippingTier { get; set; }

    /// <summary>
    /// A short description of the item, max 255 chars
    /// </summary>
    /// <value>A short description of the item, max 255 chars</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart
    /// </summary>
    /// <value>The skus for the item. Each defines a unique configuration for the item to be purchased (Large-Blue, Small-Green, etc). These are what is ultimately selected in the store and added to the cart</value>
    [DataMember(Name="skus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skus")]
    public List<Sku> Skus { get; set; }

    /// <summary>
    /// A number to use in sorting items.  Default 500
    /// </summary>
    /// <value>A number to use in sorting items.  Default 500</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store
    /// </summary>
    /// <value>The date the item will leave the store, unix timestamp in seconds.  If set to null, item will never leave the store</value>
    [DataMember(Name="store_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_end")]
    public long? StoreEnd { get; set; }

    /// <summary>
    /// The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately
    /// </summary>
    /// <value>The date the item will appear in the store, unix timestamp in seconds.  If set to null, item will appear in store immediately</value>
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
    /// An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default = null
    /// </summary>
    /// <value>An item template this item is validated against.  May be null and no validation of additional_properties will be done.  Default = null</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// The type of the item
    /// </summary>
    /// <value>The type of the item</value>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }

    /// <summary>
    /// The unique key for the item
    /// </summary>
    /// <value>The unique key for the item</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// The date the item was last updated, unix timestamp in seconds
    /// </summary>
    /// <value>The date the item was last updated, unix timestamp in seconds</value>
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
      sb.Append("class BundleItem {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
      sb.Append("  BundledSkus: ").Append(BundledSkus).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Displayable: ").Append(Displayable).Append("\n");
      sb.Append("  GeoCountryList: ").Append(GeoCountryList).Append("\n");
      sb.Append("  GeoPolicyType: ").Append(GeoPolicyType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShippingTier: ").Append(ShippingTier).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Skus: ").Append(Skus).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  StoreEnd: ").Append(StoreEnd).Append("\n");
      sb.Append("  StoreStart: ").Append(StoreStart).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
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
