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
  public class ModelCatalogSale {
    /// <summary>
    /// The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply
    /// </summary>
    /// <value>The iso3 code for the currency for this discountValue.  The sku purchased will have to match for it this sale to apply</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)
    /// </summary>
    /// <value>The way in which the price is reduced. 'value' means subtracting directly, 'percentage' means subtracting by the price times the discountValue (1.0 == 100%)</value>
    [DataMember(Name="discount_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_type")]
    public string DiscountType { get; set; }

    /// <summary>
    /// The amount deducted from the price, in the same currencyCode as the item
    /// </summary>
    /// <value>The amount deducted from the price, in the same currencyCode as the item</value>
    [DataMember(Name="discount_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_value")]
    public double? DiscountValue { get; set; }

    /// <summary>
    /// The id of the sale
    /// </summary>
    /// <value>The id of the sale</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The id of the item this sale applies to.  Leave null to use other filters
    /// </summary>
    /// <value>The id of the item this sale applies to.  Leave null to use other filters</value>
    [DataMember(Name="item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item")]
    public int? Item { get; set; }

    /// <summary>
    /// The long description of the sale
    /// </summary>
    /// <value>The long description of the sale</value>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// The name of the sale.  Max 40 characters
    /// </summary>
    /// <value>The name of the sale.  Max 40 characters</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The date the sale ends, null for never.  Unix timestamp in seconds
    /// </summary>
    /// <value>The date the sale ends, null for never.  Unix timestamp in seconds</value>
    [DataMember(Name="sale_end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_end_date")]
    public long? SaleEndDate { get; set; }

    /// <summary>
    /// The date the sale begins.  Unix timestamp in seconds
    /// </summary>
    /// <value>The date the sale begins.  Unix timestamp in seconds</value>
    [DataMember(Name="sale_start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_start_date")]
    public long? SaleStartDate { get; set; }

    /// <summary>
    /// The short description of the sale.  Max 140 characters
    /// </summary>
    /// <value>The short description of the sale.  Max 140 characters</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// The tag this sale applies to.  Leave null to skip this filter (applies to all tags)
    /// </summary>
    /// <value>The tag this sale applies to.  Leave null to skip this filter (applies to all tags)</value>
    [DataMember(Name="tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tag")]
    public string Tag { get; set; }

    /// <summary>
    /// The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors)
    /// </summary>
    /// <value>The id of the vendor this sale applies to.  Leave null to skip this filter (applies to all vendors)</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public int? Vendor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCatalogSale {\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
      sb.Append("  DiscountValue: ").Append(DiscountValue).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Item: ").Append(Item).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SaleEndDate: ").Append(SaleEndDate).Append("\n");
      sb.Append("  SaleStartDate: ").Append(SaleStartDate).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
