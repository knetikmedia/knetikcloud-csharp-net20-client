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
  public class ServiceDeployedEvent : BroadcastableEvent {
    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public string _Client { get; set; }

    /// <summary>
    /// Gets or Sets Customer
    /// </summary>
    [DataMember(Name="customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer")]
    public string Customer { get; set; }

    /// <summary>
    /// Gets or Sets DoNotBroadcast
    /// </summary>
    [DataMember(Name="do_not_broadcast", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "do_not_broadcast")]
    public bool? DoNotBroadcast { get; set; }

    /// <summary>
    /// Gets or Sets Section
    /// </summary>
    [DataMember(Name="section", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "section")]
    public string Section { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public Object Source { get; set; }

    /// <summary>
    /// Gets or Sets Specifics
    /// </summary>
    [DataMember(Name="specifics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specifics")]
    public string Specifics { get; set; }

    /// <summary>
    /// Gets or Sets Synchronous
    /// </summary>
    [DataMember(Name="synchronous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synchronous")]
    public bool? Synchronous { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public long? Timestamp { get; set; }

    /// <summary>
    /// The type of the event. Used for polymorphic type recognition and thus must match an expected type
    /// </summary>
    /// <value>The type of the event. Used for polymorphic type recognition and thus must match an expected type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The events fired by this service
    /// </summary>
    /// <value>The events fired by this service</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<BreTriggerResource> Events { get; set; }

    /// <summary>
    /// The resources managed by this service
    /// </summary>
    /// <value>The resources managed by this service</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<ResourceTypeDescription> Resources { get; set; }

    /// <summary>
    /// The unique name for the service. This serves as the unique identifier. Cannot be changed after creation
    /// </summary>
    /// <value>The unique name for the service. This serves as the unique identifier. Cannot be changed after creation</value>
    [DataMember(Name="service_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// The url of the swagger doc
    /// </summary>
    /// <value>The url of the swagger doc</value>
    [DataMember(Name="swagger_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swagger_url")]
    public string SwaggerUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceDeployedEvent {\n");
      sb.Append("  _Client: ").Append(_Client).Append("\n");
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      sb.Append("  DoNotBroadcast: ").Append(DoNotBroadcast).Append("\n");
      sb.Append("  Section: ").Append(Section).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Specifics: ").Append(Specifics).Append("\n");
      sb.Append("  Synchronous: ").Append(Synchronous).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  SwaggerUrl: ").Append(SwaggerUrl).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
