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
  public class TemplateSMSResource {
    /// <summary>
    /// The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.
    /// </summary>
    /// <value>The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public string From { get; set; }

    /// <summary>
    /// Gets or Sets Localizer
    /// </summary>
    [DataMember(Name="localizer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localizer")]
    public Localizer Localizer { get; set; }

    /// <summary>
    /// A list of user ids to send the message to.
    /// </summary>
    /// <value>A list of user ids to send the message to.</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<int?> Recipients { get; set; }

    /// <summary>
    /// The key for the template.
    /// </summary>
    /// <value>The key for the template.</value>
    [DataMember(Name="template_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_key")]
    public string TemplateKey { get; set; }

    /// <summary>
    /// A list of values to fill in the template. Order matters.
    /// </summary>
    /// <value>A list of values to fill in the template. Order matters.</value>
    [DataMember(Name="template_vars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_vars")]
    public List<string> TemplateVars { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TemplateSMSResource {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  Localizer: ").Append(Localizer).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  TemplateKey: ").Append(TemplateKey).Append("\n");
      sb.Append("  TemplateVars: ").Append(TemplateVars).Append("\n");
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
