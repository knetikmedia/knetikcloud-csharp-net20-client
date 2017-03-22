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
  public class ModelCart {
    /// <summary>
    /// Gets or Sets AvailableShippingOptions
    /// </summary>
    [DataMember(Name="available_shipping_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "available_shipping_options")]
    public List<ModelCartShippingOption> AvailableShippingOptions { get; set; }

    /// <summary>
    /// Gets or Sets CountryTax
    /// </summary>
    [DataMember(Name="country_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_tax")]
    public double? CountryTax { get; set; }

    /// <summary>
    /// Gets or Sets Coupons
    /// </summary>
    [DataMember(Name="coupons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coupons")]
    public List<ModelCouponDefinition> Coupons { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public long? Created { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyCode
    /// </summary>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Gets or Sets DiscountTotal
    /// </summary>
    [DataMember(Name="discount_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount_total")]
    public double? DiscountTotal { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="error_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_code")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets GrandTotal
    /// </summary>
    [DataMember(Name="grand_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grand_total")]
    public double? GrandTotal { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceId
    /// </summary>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public double? InvoiceId { get; set; }

    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ModelCartLineItem> Items { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public int? Owner { get; set; }

    /// <summary>
    /// Gets or Sets SelectedShippingOptions
    /// </summary>
    [DataMember(Name="selected_shipping_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_shipping_options")]
    public List<ModelCartShippingOption> SelectedShippingOptions { get; set; }

    /// <summary>
    /// Gets or Sets Shippable
    /// </summary>
    [DataMember(Name="shippable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippable")]
    public bool? Shippable { get; set; }

    /// <summary>
    /// Gets or Sets ShippingAddress
    /// </summary>
    [DataMember(Name="shipping_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_address")]
    public ModelCartShippingAddressRequest ShippingAddress { get; set; }

    /// <summary>
    /// Gets or Sets ShippingCost
    /// </summary>
    [DataMember(Name="shipping_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipping_cost")]
    public double? ShippingCost { get; set; }

    /// <summary>
    /// Gets or Sets StateTax
    /// </summary>
    [DataMember(Name="state_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_tax")]
    public double? StateTax { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Subtotal
    /// </summary>
    [DataMember(Name="subtotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal")]
    public double? Subtotal { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public long? Updated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCart {\n");
      sb.Append("  AvailableShippingOptions: ").Append(AvailableShippingOptions).Append("\n");
      sb.Append("  CountryTax: ").Append(CountryTax).Append("\n");
      sb.Append("  Coupons: ").Append(Coupons).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  DiscountTotal: ").Append(DiscountTotal).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  SelectedShippingOptions: ").Append(SelectedShippingOptions).Append("\n");
      sb.Append("  Shippable: ").Append(Shippable).Append("\n");
      sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
      sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
      sb.Append("  StateTax: ").Append(StateTax).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
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
