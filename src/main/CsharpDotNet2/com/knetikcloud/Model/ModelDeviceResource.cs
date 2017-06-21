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
  public class ModelDeviceResource {
    /// <summary>
    /// The authorization code for the device
    /// </summary>
    /// <value>The authorization code for the device</value>
    [DataMember(Name="authorization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorization")]
    public string Authorization { get; set; }

    /// <summary>
    /// The current condition of the device (New, Defective, Reconditioned)
    /// </summary>
    /// <value>The current condition of the device (New, Defective, Reconditioned)</value>
    [DataMember(Name="condition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "condition")]
    public string Condition { get; set; }

    /// <summary>
    /// The date the device log was created
    /// </summary>
    /// <value>The date the device log was created</value>
    [DataMember(Name="created_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_date")]
    public long? CreatedDate { get; set; }

    /// <summary>
    /// The key/value pairs for extended data
    /// </summary>
    /// <value>The key/value pairs for extended data</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Dictionary<String, string> Data { get; set; }

    /// <summary>
    /// The description of the device
    /// </summary>
    /// <value>The description of the device</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The type of the device
    /// </summary>
    /// <value>The type of the device</value>
    [DataMember(Name="device_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device_type")]
    public string DeviceType { get; set; }

    /// <summary>
    /// The unique ID for this device. Cannot be changed once created
    /// </summary>
    /// <value>The unique ID for this device. Cannot be changed once created</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The location of the device
    /// </summary>
    /// <value>The location of the device</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// The MAC (media access control) address of the device
    /// </summary>
    /// <value>The MAC (media access control) address of the device</value>
    [DataMember(Name="mac_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mac_address")]
    public string MacAddress { get; set; }

    /// <summary>
    /// The make of the device
    /// </summary>
    /// <value>The make of the device</value>
    [DataMember(Name="make", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "make")]
    public string Make { get; set; }

    /// <summary>
    /// The model of the device
    /// </summary>
    /// <value>The model of the device</value>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string Model { get; set; }

    /// <summary>
    /// The name of the device
    /// </summary>
    /// <value>The name of the device</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The OS (operating system) on the device
    /// </summary>
    /// <value>The OS (operating system) on the device</value>
    [DataMember(Name="os", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os")]
    public string Os { get; set; }

    /// <summary>
    /// The serial number of the device
    /// </summary>
    /// <value>The serial number of the device</value>
    [DataMember(Name="serial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serial")]
    public string Serial { get; set; }

    /// <summary>
    /// The current status the device (Active, Pending Active, Inactive, Repair
    /// </summary>
    /// <value>The current status the device (Active, Pending Active, Inactive, Repair</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The date the device log was updated
    /// </summary>
    /// <value>The date the device log was updated</value>
    [DataMember(Name="updated_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_date")]
    public long? UpdatedDate { get; set; }

    /// <summary>
    /// The user that owns the device
    /// </summary>
    /// <value>The user that owns the device</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public ModelSimpleUserResource User { get; set; }

    /// <summary>
    /// The users currently using the device
    /// </summary>
    /// <value>The users currently using the device</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<ModelSimpleUserResource> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelDeviceResource {\n");
      sb.Append("  Authorization: ").Append(Authorization).Append("\n");
      sb.Append("  Condition: ").Append(Condition).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
      sb.Append("  Make: ").Append(Make).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Os: ").Append(Os).Append("\n");
      sb.Append("  Serial: ").Append(Serial).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
