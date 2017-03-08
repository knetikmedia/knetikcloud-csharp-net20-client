using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.knetikcloud.client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TransactionResource {
    /// <summary>
    /// The unix timestamp in seconds of the transaction
    /// </summary>
    /// <value>The unix timestamp in seconds of the transaction</value>
    [DataMember(Name="create_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_date")]
    public long? CreateDate { get; set; }

    /// <summary>
    /// The code of the currency for the transaction
    /// </summary>
    /// <value>The code of the currency for the transaction</value>
    [DataMember(Name="currency_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The specific details of the transaction, such as a message from the admin that created it
    /// </summary>
    /// <value>The specific details of the transaction, such as a message from the admin that created it</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public string Details { get; set; }

    /// <summary>
    /// The id of the transaction
    /// </summary>
    /// <value>The id of the transaction</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The id of the invoice that spawned the transaction, if any
    /// </summary>
    /// <value>The id of the invoice that spawned the transaction, if any</value>
    [DataMember(Name="invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_id")]
    public int? InvoiceId { get; set; }

    /// <summary>
    /// Whether the transaction has been refunded
    /// </summary>
    /// <value>Whether the transaction has been refunded</value>
    [DataMember(Name="is_refunded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_refunded")]
    public bool? IsRefunded { get; set; }

    /// <summary>
    /// The response
    /// </summary>
    /// <value>The response</value>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public string _Response { get; set; }

    /// <summary>
    /// The root source of the transaction
    /// </summary>
    /// <value>The root source of the transaction</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// If the transaction was successful
    /// </summary>
    /// <value>If the transaction was successful</value>
    [DataMember(Name="successful", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successful")]
    public bool? Successful { get; set; }

    /// <summary>
    /// The payment gateway (external) transaction ID
    /// </summary>
    /// <value>The payment gateway (external) transaction ID</value>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_id")]
    public string TransactionId { get; set; }

    /// <summary>
    /// The general type of the transaction
    /// </summary>
    /// <value>The general type of the transaction</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The table name of the subclass
    /// </summary>
    /// <value>The table name of the subclass</value>
    [DataMember(Name="type_hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_hint")]
    public string TypeHint { get; set; }

    /// <summary>
    /// The amount of the transaction, positive if a gain, negative if an expenditure
    /// </summary>
    /// <value>The amount of the transaction, positive if a gain, negative if an expenditure</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public double? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionResource {\n");
      sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
      sb.Append("  IsRefunded: ").Append(IsRefunded).Append("\n");
      sb.Append("  _Response: ").Append(_Response).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Successful: ").Append(Successful).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeHint: ").Append(TypeHint).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
