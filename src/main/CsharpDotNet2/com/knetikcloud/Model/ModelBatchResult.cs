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
  public class ModelBatchResult {
    /// <summary>
    /// List of batch responses.  Returns in the order requested
    /// </summary>
    /// <value>List of batch responses.  Returns in the order requested</value>
    [DataMember(Name="batch_return", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batch_return")]
    public List<ModelBatchReturn> BatchReturn { get; set; }

    /// <summary>
    /// The date the batch call started processing
    /// </summary>
    /// <value>The date the batch call started processing</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The token to use at the /batch/{token} endpoint if the request times out
    /// </summary>
    /// <value>The token to use at the /batch/{token} endpoint if the request times out</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The date the batch call finished processing
    /// </summary>
    /// <value>The date the batch call finished processing</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelBatchResult {\n");
      sb.Append("  BatchReturn: ").Append(BatchReturn).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
