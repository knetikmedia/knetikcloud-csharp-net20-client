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
  public class ModelCartSummary {
    /// <summary>
    /// The date/time this resource was created in seconds since unix epoch
    /// </summary>
    /// <value>The date/time this resource was created in seconds since unix epoch</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The unique id code for the currency used in the cart
    /// </summary>
    /// <value>The unique id code for the currency used in the cart</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The grand total for the cart
    /// </summary>
    /// <value>The grand total for the cart</value>
    [DataMember(Name="grand_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grand_total")]
    public double? GrandTotal { get; set; }

    /// <summary>
    /// The unique ID for the cart
    /// </summary>
    /// <value>The unique ID for the cart</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The ID of the invoice associated with this cart
    /// </summary>
    /// <value>The ID of the invoice associated with this cart</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public double? InvoiceId { get; set; }

    /// <summary>
    /// The number of items in the cart
    /// </summary>
    /// <value>The number of items in the cart</value>
    [DataMember(Name="items_in_cart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items_in_cart")]
    public int? ItemsInCart { get; set; }

    /// <summary>
    /// The status of the cart
    /// </summary>
    /// <value>The status of the cart</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The subtotal of all items in the cart
    /// </summary>
    /// <value>The subtotal of all items in the cart</value>
    [DataMember(Name="subtotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtotal")]
    public double? Subtotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCartSummary {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  ItemsInCart: ").Append(ItemsInCart).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
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
