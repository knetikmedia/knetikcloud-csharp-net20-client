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
  public class ModelCartShippingOption {
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
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets OriginalPrice
    /// </summary>
    [DataMember(Name="original_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_price")]
    public double? OriginalPrice { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// Gets or Sets ShippingItemId
    /// </summary>
    [DataMember(Name="shipping_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_item_id")]
    public int? ShippingItemId { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets Taxable
    /// </summary>
    [DataMember(Name="taxable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxable")]
    public bool? Taxable { get; set; }

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
      sb.Append("class ModelCartShippingOption {\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  ShippingItemId: ").Append(ShippingItemId).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Taxable: ").Append(Taxable).Append("\n");
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
