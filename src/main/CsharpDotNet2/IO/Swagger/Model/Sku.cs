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
  public class Sku {
    /// <summary>
    /// A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template
    /// </summary>
    /// <value>A map of additional properties, keyed on the property name.  Must match the names and types defined in the template for this item type, or be an extra not from the template</value>
    [DataMember(Name="additional_properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_properties")]
    public Dictionary<String, Property> AdditionalProperties { get; set; }

    /// <summary>
    /// The currency code for the SKU, a three letter string (ISO3)
    /// </summary>
    /// <value>The currency code for the SKU, a three letter string (ISO3)</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The description of the SKU (Ex: An item comes in multiple sizes/colors, each needing its own unique description)
    /// </summary>
    /// <value>The description of the SKU (Ex: An item comes in multiple sizes/colors, each needing its own unique description)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The number of SKUs currently in stock
    /// </summary>
    /// <value>The number of SKUs currently in stock</value>
    [DataMember(Name="inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory")]
    public int? Inventory { get; set; }

    /// <summary>
    /// Alerts vendor when SKU inventory drops below this value
    /// </summary>
    /// <value>Alerts vendor when SKU inventory drops below this value</value>
    [DataMember(Name="min_inventory_threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_inventory_threshold")]
    public int? MinInventoryThreshold { get; set; }

    /// <summary>
    /// The base price before any sale
    /// </summary>
    /// <value>The base price before any sale</value>
    [DataMember(Name="original_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_price")]
    public double? OriginalPrice { get; set; }

    /// <summary>
    /// The current price of the SKU with sales, if any. Set original_price for the base
    /// </summary>
    /// <value>The current price of the SKU with sales, if any. Set original_price for the base</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// Whether or not the SKU is currently published
    /// </summary>
    /// <value>Whether or not the SKU is currently published</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// The id of a sale affecting the price, if any
    /// </summary>
    /// <value>The id of a sale affecting the price, if any</value>
    [DataMember(Name="sale_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_id")]
    public int? SaleId { get; set; }

    /// <summary>
    /// The name of a sale affecting the price, if any
    /// </summary>
    /// <value>The name of a sale affecting the price, if any</value>
    [DataMember(Name="sale_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sale_name")]
    public string SaleName { get; set; }

    /// <summary>
    /// The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters
    /// </summary>
    /// <value>The stock keeping unit (SKU), a unique identifier for a given product.  Max 40 characters</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately
    /// </summary>
    /// <value>The date the sku becomes available, unix timestamp in seconds.  If set to null, sku will become available immediately</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }

    /// <summary>
    /// The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available
    /// </summary>
    /// <value>The date the sku becomes unavailable, unix timestamp in seconds.  If set to null, sku is always available</value>
    [DataMember(Name="stop_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stop_date")]
    public long? StopDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Sku {\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Inventory: ").Append(Inventory).Append("\n");
      sb.Append("  MinInventoryThreshold: ").Append(MinInventoryThreshold).Append("\n");
      sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  SaleId: ").Append(SaleId).Append("\n");
      sb.Append("  SaleName: ").Append(SaleName).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StopDate: ").Append(StopDate).Append("\n");
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
