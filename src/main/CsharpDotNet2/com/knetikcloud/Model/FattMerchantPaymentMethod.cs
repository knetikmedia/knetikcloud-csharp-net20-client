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
  public class FattMerchantPaymentMethod {
    /// <summary>
    /// Gets or Sets Address1
    /// </summary>
    [DataMember(Name="address1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or Sets AddressCity
    /// </summary>
    [DataMember(Name="address_city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_city")]
    public string AddressCity { get; set; }

    /// <summary>
    /// Gets or Sets AddressCountry
    /// </summary>
    [DataMember(Name="address_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_country")]
    public string AddressCountry { get; set; }

    /// <summary>
    /// Gets or Sets AddressState
    /// </summary>
    [DataMember(Name="address_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_state")]
    public string AddressState { get; set; }

    /// <summary>
    /// Gets or Sets AddressZip
    /// </summary>
    [DataMember(Name="address_zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_zip")]
    public string AddressZip { get; set; }

    /// <summary>
    /// Last four digits of the credit card
    /// </summary>
    /// <value>Last four digits of the credit card</value>
    [DataMember(Name="card_last_four", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card_last_four")]
    public string CardLastFour { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Unique FattMerchant customer ID
    /// </summary>
    /// <value>Unique FattMerchant customer ID</value>
    [DataMember(Name="customer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer_id")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets DeletedAt
    /// </summary>
    [DataMember(Name="deleted_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleted_at")]
    public string DeletedAt { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Nickname given to the FattMerchant payment method
    /// </summary>
    /// <value>Nickname given to the FattMerchant payment method</value>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FattMerchantPaymentMethod {\n");
      sb.Append("  Address1: ").Append(Address1).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  AddressState: ").Append(AddressState).Append("\n");
      sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
      sb.Append("  CardLastFour: ").Append(CardLastFour).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
