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
  public class CouponDefinition {
    /// <summary>
    /// A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced.
    /// </summary>
    /// <value>A unique identifier for the discount. Can be used to remove the discount, and uniqueness within the cart will be enforced.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// A description for the discount.
    /// </summary>
    /// <value>A description for the discount.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The type of discount in terms of how it deducts price.
    /// </summary>
    /// <value>The type of discount in terms of how it deducts price.</value>
    [DataMember(Name="discount_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_type")]
    public string DiscountType { get; set; }

    /// <summary>
    /// Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default=false
    /// </summary>
    /// <value>Whether this discount is exclusive and cannot be used in conjunction with other discounts/coupons. default=false</value>
    [DataMember(Name="exclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclusive")]
    public bool? Exclusive { get; set; }

    /// <summary>
    /// For coupon_cart, a minimum total price that the cart must meet to be valid.
    /// </summary>
    /// <value>For coupon_cart, a minimum total price that the cart must meet to be valid.</value>
    [DataMember(Name="max_discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_discount")]
    public decimal? MaxDiscount { get; set; }

    /// <summary>
    /// The maximum number of items to count this discount for (not for cart_coupon).
    /// </summary>
    /// <value>The maximum number of items to count this discount for (not for cart_coupon).</value>
    [DataMember(Name="max_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_quantity")]
    public int? MaxQuantity { get; set; }

    /// <summary>
    /// For coupon_cart, a minimum total price that the cart must meet to be valid.
    /// </summary>
    /// <value>For coupon_cart, a minimum total price that the cart must meet to be valid.</value>
    [DataMember(Name="min_cart_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_cart_total")]
    public decimal? MinCartTotal { get; set; }

    /// <summary>
    /// A name for the discount.
    /// </summary>
    /// <value>A name for the discount.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default = false
    /// </summary>
    /// <value>Whether this coupon is exclusive to itself or not (true means cannot add two of this same coupon to the same cart).  Default = false</value>
    [DataMember(Name="self_exclusive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self_exclusive")]
    public bool? SelfExclusive { get; set; }

    /// <summary>
    /// The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher.
    /// </summary>
    /// <value>The id of the item this discount applies to, which must be present in the cart. Applies if coupon_type_hint is coupon_single_item or coupon_voucher.</value>
    [DataMember(Name="target_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target_item_id")]
    public int? TargetItemId { get; set; }

    /// <summary>
    /// The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.
    /// </summary>
    /// <value>The type of discount in terms of what it applies to. coupon_cart applies to the cart as a whole, other types apply to specific items based on different criteria.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// A unique identifier string for the discount.
    /// </summary>
    /// <value>A unique identifier string for the discount.</value>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag.
    /// </summary>
    /// <value>Which tags this applies for (item must have at least one of them), if coupon_type is coupon_tag.</value>
    [DataMember(Name="valid_for_tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid_for_tags")]
    public List<string> ValidForTags { get; set; }

    /// <summary>
    /// The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price).
    /// </summary>
    /// <value>The amount of the discount. If discount_type is value then this is the raw currency amount to remove. If discount_type is percentage then this will be multiplied by the cart total or item price to get the discount amount (0.5 is half price).</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public decimal? Value { get; set; }

    /// <summary>
    /// Which vendor this applies for, if coupon_type is coupon_vendor.
    /// </summary>
    /// <value>Which vendor this applies for, if coupon_type is coupon_vendor.</value>
    [DataMember(Name="vendor_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_id")]
    public int? VendorId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CouponDefinition {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
      sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
      sb.Append("  MaxDiscount: ").Append(MaxDiscount).Append("\n");
      sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
      sb.Append("  MinCartTotal: ").Append(MinCartTotal).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SelfExclusive: ").Append(SelfExclusive).Append("\n");
      sb.Append("  TargetItemId: ").Append(TargetItemId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
      sb.Append("  ValidForTags: ").Append(ValidForTags).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
