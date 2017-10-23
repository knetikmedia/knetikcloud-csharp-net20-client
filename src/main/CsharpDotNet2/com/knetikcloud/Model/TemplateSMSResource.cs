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
    /// A list of user ids to send the message to.
    /// </summary>
    /// <value>A list of user ids to send the message to.</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<int?> Recipients { get; set; }

    /// <summary>
    /// A mustache template
    /// </summary>
    /// <value>A mustache template</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// A map of values to fill in the template
    /// </summary>
    /// <value>A map of values to fill in the template</value>
    [DataMember(Name="template_vars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_vars")]
    public Object TemplateVars { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TemplateSMSResource {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
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
