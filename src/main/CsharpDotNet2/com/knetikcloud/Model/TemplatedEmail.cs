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
  public class TemplatedEmail {
    /// <summary>
    /// The external template ID used by the email provider
    /// </summary>
    /// <value>The external template ID used by the email provider</value>
    [DataMember(Name="external_template_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_template_id")]
    public string ExternalTemplateId { get; set; }

    /// <summary>
    /// The map of data used by the template
    /// </summary>
    /// <value>The map of data used by the template</value>
    [DataMember(Name="template_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_data")]
    public Object TemplateData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TemplatedEmail {\n");
      sb.Append("  ExternalTemplateId: ").Append(ExternalTemplateId).Append("\n");
      sb.Append("  TemplateData: ").Append(TemplateData).Append("\n");
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
