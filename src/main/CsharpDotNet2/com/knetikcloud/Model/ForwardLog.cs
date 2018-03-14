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
  public class ForwardLog {
    /// <summary>
    /// The end date of the forward log entry
    /// </summary>
    /// <value>The end date of the forward log entry</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public long? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMsg
    /// </summary>
    [DataMember(Name="error_msg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_msg")]
    public string ErrorMsg { get; set; }

    /// <summary>
    /// Gets or Sets EventId
    /// </summary>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public string EventId { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public string Headers { get; set; }

    /// <summary>
    /// The http status code the forward log entry
    /// </summary>
    /// <value>The http status code the forward log entry</value>
    [DataMember(Name="http_status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "http_status_code")]
    public int? HttpStatusCode { get; set; }

    /// <summary>
    /// The id of the forward log entry
    /// </summary>
    /// <value>The id of the forward log entry</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// The payload of the forward log entry
    /// </summary>
    /// <value>The payload of the forward log entry</value>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public Object Payload { get; set; }

    /// <summary>
    /// The response string of the forward log entry
    /// </summary>
    /// <value>The response string of the forward log entry</value>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public string Response { get; set; }

    /// <summary>
    /// The retry count of the forward log entry
    /// </summary>
    /// <value>The retry count of the forward log entry</value>
    [DataMember(Name="retry_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retry_count")]
    public int? RetryCount { get; set; }

    /// <summary>
    /// Gets or Sets Retryable
    /// </summary>
    [DataMember(Name="retryable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retryable")]
    public bool? Retryable { get; set; }

    /// <summary>
    /// Gets or Sets RuleId
    /// </summary>
    [DataMember(Name="rule_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule_id")]
    public string RuleId { get; set; }

    /// <summary>
    /// The start date of the forward log entry
    /// </summary>
    /// <value>The start date of the forward log entry</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public long? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public bool? Success { get; set; }

    /// <summary>
    /// The endpoint url of the forward log entry
    /// </summary>
    /// <value>The endpoint url of the forward log entry</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ForwardLog {\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
      sb.Append("  Retryable: ").Append(Retryable).Append("\n");
      sb.Append("  RuleId: ").Append(RuleId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
