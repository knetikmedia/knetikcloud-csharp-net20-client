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
  public class CartLineItem {
    /// <summary>
    /// Gets or Sets CurrencyCode
    /// </summary>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Discount
    /// </summary>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public Discount Discount { get; set; }

    /// <summary>
    /// Gets or Sets LineTotal
    /// </summary>
    [DataMember(Name="line_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line_total")]
    public decimal? LineTotal { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets OriginalLineTotal
    /// </summary>
    [DataMember(Name="original_line_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_line_total")]
    public decimal? OriginalLineTotal { get; set; }

    /// <summary>
    /// Gets or Sets OriginalUnitPrice
    /// </summary>
    [DataMember(Name="original_unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_unit_price")]
    public decimal? OriginalUnitPrice { get; set; }

    /// <summary>
    /// Gets or Sets Qty
    /// </summary>
    [DataMember(Name="qty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qty")]
    public int? Qty { get; set; }

    /// <summary>
    /// Gets or Sets SaleName
    /// </summary>
    [DataMember(Name="sale_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_name")]
    public string SaleName { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets SkuDescription
    /// </summary>
    [DataMember(Name="sku_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku_description")]
    public string SkuDescription { get; set; }

    /// <summary>
    /// Gets or Sets StoreItemId
    /// </summary>
    [DataMember(Name="store_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store_item_id")]
    public int? StoreItemId { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets ThumbUrl
    /// </summary>
    [DataMember(Name="thumb_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumb_url")]
    public string ThumbUrl { get; set; }

    /// <summary>
    /// Gets or Sets UniqueKey
    /// </summary>
    [DataMember(Name="unique_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique_key")]
    public string UniqueKey { get; set; }

    /// <summary>
    /// Gets or Sets UnitPrice
    /// </summary>
    [DataMember(Name="unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_price")]
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Gets or Sets VendorId
    /// </summary>
    [DataMember(Name="vendor_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_id")]
    public int? VendorId { get; set; }

    /// <summary>
    /// Gets or Sets VendorName
    /// </summary>
    [DataMember(Name="vendor_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor_name")]
    public string VendorName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartLineItem {\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  LineTotal: ").Append(LineTotal).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OriginalLineTotal: ").Append(OriginalLineTotal).Append("\n");
      sb.Append("  OriginalUnitPrice: ").Append(OriginalUnitPrice).Append("\n");
      sb.Append("  Qty: ").Append(Qty).Append("\n");
      sb.Append("  SaleName: ").Append(SaleName).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  SkuDescription: ").Append(SkuDescription).Append("\n");
      sb.Append("  StoreItemId: ").Append(StoreItemId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  ThumbUrl: ").Append(ThumbUrl).Append("\n");
      sb.Append("  UniqueKey: ").Append(UniqueKey).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
      sb.Append("  VendorId: ").Append(VendorId).Append("\n");
      sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
