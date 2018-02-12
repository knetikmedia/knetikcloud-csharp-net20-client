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
  public class CoreActivityOccurrenceSettings {
    /// <summary>
    /// Whether the host can boot another user while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
    /// </summary>
    /// <value>Whether the host can boot another user while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
    [DataMember(Name="boot_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boot_in_play")]
    public bool? BootInPlay { get; set; }

    /// <summary>
    /// A custom address (url, ip or whatever is needed in your game) that users should connect to to play in this occurrence rather than the usual game server. Could be the ip address of the host for peer-to-peer play. Can only be set if the activity/challenge custom_launch_address_allowed is true. Max length: 255
    /// </summary>
    /// <value>A custom address (url, ip or whatever is needed in your game) that users should connect to to play in this occurrence rather than the usual game server. Could be the ip address of the host for peer-to-peer play. Can only be set if the activity/challenge custom_launch_address_allowed is true. Max length: 255</value>
    [DataMember(Name="custom_launch_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_launch_address")]
    public string CustomLaunchAddress { get; set; }

    /// <summary>
    /// Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Cannot be true if activity/challenge has it false. Null to inherit
    /// </summary>
    /// <value>Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Cannot be true if activity/challenge has it false. Null to inherit</value>
    [DataMember(Name="host_status_control", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_status_control")]
    public bool? HostStatusControl { get; set; }

    /// <summary>
    /// Whether users can join while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
    /// </summary>
    /// <value>Whether users can join while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
    [DataMember(Name="join_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "join_in_play")]
    public bool? JoinInPlay { get; set; }

    /// <summary>
    /// Whether users can leave while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit
    /// </summary>
    /// <value>Whether users can leave while the status is PLAYING. Must be false or null unless this setting is true in activity (or challenge if applicable). Null to inherit</value>
    [DataMember(Name="leave_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leave_in_play")]
    public bool? LeaveInPlay { get; set; }

    /// <summary>
    /// The maximum number of players the game can hold. Must be equal or less than activity (or must match challenge if applicable)
    /// </summary>
    /// <value>The maximum number of players the game can hold. Must be equal or less than activity (or must match challenge if applicable)</value>
    [DataMember(Name="max_players", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_players")]
    public int? MaxPlayers { get; set; }

    /// <summary>
    /// The minimum number of players the game can hold. Must be equal or greater than activity (or must match challenge if applicable)
    /// </summary>
    /// <value>The minimum number of players the game can hold. Must be equal or greater than activity (or must match challenge if applicable)</value>
    [DataMember(Name="min_players", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_players")]
    public int? MinPlayers { get; set; }

    /// <summary>
    /// Restriction for whether the non-host players can control of the status in place of the host. Default: false
    /// </summary>
    /// <value>Restriction for whether the non-host players can control of the status in place of the host. Default: false</value>
    [DataMember(Name="non_host_status_control", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "non_host_status_control")]
    public bool? NonHostStatusControl { get; set; }

    /// <summary>
    /// Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits
    /// </summary>
    /// <value>Restriction for who is able to report game end and results. Admin is always able to send results as well. Must be equal or more restrictive than activity (or must match challenge if applicable). Default inherits</value>
    [DataMember(Name="results_trust", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results_trust")]
    public string ResultsTrust { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CoreActivityOccurrenceSettings {\n");
      sb.Append("  BootInPlay: ").Append(BootInPlay).Append("\n");
      sb.Append("  CustomLaunchAddress: ").Append(CustomLaunchAddress).Append("\n");
      sb.Append("  HostStatusControl: ").Append(HostStatusControl).Append("\n");
      sb.Append("  JoinInPlay: ").Append(JoinInPlay).Append("\n");
      sb.Append("  LeaveInPlay: ").Append(LeaveInPlay).Append("\n");
      sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
      sb.Append("  MinPlayers: ").Append(MinPlayers).Append("\n");
      sb.Append("  NonHostStatusControl: ").Append(NonHostStatusControl).Append("\n");
      sb.Append("  ResultsTrust: ").Append(ResultsTrust).Append("\n");
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
