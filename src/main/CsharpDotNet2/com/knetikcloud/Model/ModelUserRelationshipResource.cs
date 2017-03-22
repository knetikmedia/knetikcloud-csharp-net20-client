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
  public class ModelUserRelationshipResource {
    /// <summary>
    /// The child in the relationship
    /// </summary>
    /// <value>The child in the relationship</value>
    [DataMember(Name="child", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "child")]
    public ModelSimpleUserResource Child { get; set; }

    /// <summary>
    /// Context about the relationship or its type
    /// </summary>
    /// <value>Context about the relationship or its type</value>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public string Context { get; set; }

    /// <summary>
    /// A generated unique id. Read-Only
    /// </summary>
    /// <value>A generated unique id. Read-Only</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The parent in the relationship
    /// </summary>
    /// <value>The parent in the relationship</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public ModelSimpleUserResource Parent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelUserRelationshipResource {\n");
      sb.Append("  Child: ").Append(Child).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
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
