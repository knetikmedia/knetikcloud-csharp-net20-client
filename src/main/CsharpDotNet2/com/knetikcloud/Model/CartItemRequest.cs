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
  public class CartItemRequest {
    /// <summary>
    /// The affiliate key of the item
    /// </summary>
    /// <value>The affiliate key of the item</value>
    [DataMember(Name="affiliate_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affiliate_key")]
    public string AffiliateKey { get; set; }

    /// <summary>
    /// The catalog SKU of the item
    /// </summary>
    /// <value>The catalog SKU of the item</value>
    [DataMember(Name="catalog_sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "catalog_sku")]
    public string CatalogSku { get; set; }

    /// <summary>
    /// Allows to override the price of an item, if the behavior configuration permits it
    /// </summary>
    /// <value>Allows to override the price of an item, if the behavior configuration permits it</value>
    [DataMember(Name="price_override", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_override")]
    public decimal? PriceOverride { get; set; }

    /// <summary>
    /// The quantity of the item
    /// </summary>
    /// <value>The quantity of the item</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartItemRequest {\n");
      sb.Append("  AffiliateKey: ").Append(AffiliateKey).Append("\n");
      sb.Append("  CatalogSku: ").Append(CatalogSku).Append("\n");
      sb.Append("  PriceOverride: ").Append(PriceOverride).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
