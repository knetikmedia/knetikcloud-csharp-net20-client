using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TemplateEmailResource {
    /// <summary>
    /// Address to attribute the outgoing message to. Optional if the config email.out_address is set.
    /// </summary>
    /// <value>Address to attribute the outgoing message to. Optional if the config email.out_address is set.</value>
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
    /// The key for the template
    /// </summary>
    /// <value>The key for the template</value>
    [DataMember(Name="template_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_key")]
    public string TemplateKey { get; set; }

    /// <summary>
    /// A list of variables to fill in the template
    /// </summary>
    /// <value>A list of variables to fill in the template</value>
    [DataMember(Name="template_vars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_vars")]
    public List<KeyValuePairstringstring> TemplateVars { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TemplateEmailResource {\n");
      sb.Append("  From: ").Append(From).Append("\n");
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
