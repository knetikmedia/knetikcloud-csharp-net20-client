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
  public class NotificationTypeResource {
    /// <summary>
    /// The date the type was created, as a unix timestamp in seconds
    /// </summary>
    /// <value>The date the type was created, as a unix timestamp in seconds</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// Whether the email body should be resolved. If true, the external email delivery system will be expected to handle the templating (Mandrill/Mailchimp). default: false
    /// </summary>
    /// <value>Whether the email body should be resolved. If true, the external email delivery system will be expected to handle the templating (Mandrill/Mailchimp). default: false</value>
    [DataMember(Name="email_body_template_external", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_body_template_external")]
    public bool? EmailBodyTemplateExternal { get; set; }

    /// <summary>
    /// The id of a message template to resolve the email body. If null, no websocket message wil be sent
    /// </summary>
    /// <value>The id of a message template to resolve the email body. If null, no websocket message wil be sent</value>
    [DataMember(Name="email_body_template_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_body_template_id")]
    public string EmailBodyTemplateId { get; set; }

    /// <summary>
    /// The id of a message template to resolve the email subject. If null, no websocket message wil be sent
    /// </summary>
    /// <value>The id of a message template to resolve the email subject. If null, no websocket message wil be sent</value>
    [DataMember(Name="email_subject_template_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_subject_template_id")]
    public string EmailSubjectTemplateId { get; set; }

    /// <summary>
    /// The id of the notification type. Default: random
    /// </summary>
    /// <value>The id of the notification type. Default: random</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the notification type
    /// </summary>
    /// <value>The name of the notification type</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The id of a message template to resolve the SMS message. If null, no sms message wil be sent
    /// </summary>
    /// <value>The id of a message template to resolve the SMS message. If null, no sms message wil be sent</value>
    [DataMember(Name="sms_template_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sms_template_id")]
    public string SmsTemplateId { get; set; }

    /// <summary>
    /// The date the type was last updated, as a unix timestamp in seconds
    /// </summary>
    /// <value>The date the type was last updated, as a unix timestamp in seconds</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationTypeResource {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EmailBodyTemplateExternal: ").Append(EmailBodyTemplateExternal).Append("\n");
      sb.Append("  EmailBodyTemplateId: ").Append(EmailBodyTemplateId).Append("\n");
      sb.Append("  EmailSubjectTemplateId: ").Append(EmailSubjectTemplateId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SmsTemplateId: ").Append(SmsTemplateId).Append("\n");
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
