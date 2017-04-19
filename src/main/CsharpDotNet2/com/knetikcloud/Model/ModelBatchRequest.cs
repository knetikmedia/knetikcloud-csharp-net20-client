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
  public class ModelBatchRequest {
    /// <summary>
    /// The request body as would be passed to the URI
    /// </summary>
    /// <value>The request body as would be passed to the URI</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public Object Body { get; set; }

    /// <summary>
    /// Content type used, Ex:(application/json)
    /// </summary>
    /// <value>Content type used, Ex:(application/json)</value>
    [DataMember(Name="content_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// The HTTP method used, Ex: (GET)
    /// </summary>
    /// <value>The HTTP method used, Ex: (GET)</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Time in seconds before process will timeout.  Default is 60.  Range is 1-300
    /// </summary>
    /// <value>Time in seconds before process will timeout.  Default is 60.  Range is 1-300</value>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// The oauth token only
    /// </summary>
    /// <value>The oauth token only</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Full URI of REST call
    /// </summary>
    /// <value>Full URI of REST call</value>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelBatchRequest {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
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
