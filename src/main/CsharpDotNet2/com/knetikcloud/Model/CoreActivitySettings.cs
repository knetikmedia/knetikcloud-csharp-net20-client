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
  public class CoreActivitySettings {
    /// <summary>
    /// Whether the host can boot a user while the status is PLAYING. Default false
    /// </summary>
    /// <value>Whether the host can boot a user while the status is PLAYING. Default false</value>
    [DataMember(Name="boot_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boot_in_play")]
    public bool? BootInPlay { get; set; }

    /// <summary>
    /// Restriction for whether the host creating an occurrence can specify a custom launch address (such as their own ip address). Default 'false'
    /// </summary>
    /// <value>Restriction for whether the host creating an occurrence can specify a custom launch address (such as their own ip address). Default 'false'</value>
    [DataMember(Name="custom_launch_address_allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_launch_address_allowed")]
    public bool? CustomLaunchAddressAllowed { get; set; }

    /// <summary>
    /// Restriction for who can host an occurrence. admin disallows regular users, player means the user must also be a player in the occurrence if not admin, non-player means the user has the option to host without being a player. Default 'player'
    /// </summary>
    /// <value>Restriction for who can host an occurrence. admin disallows regular users, player means the user must also be a player in the occurrence if not admin, non-player means the user has the option to host without being a player. Default 'player'</value>
    [DataMember(Name="host_option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_option")]
    public string HostOption { get; set; }

    /// <summary>
    /// Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Default 'false'
    /// </summary>
    /// <value>Restriction for whether the host has control of the status once the game launches. If false they can only manage the game before (when setup and open). Default 'false'</value>
    [DataMember(Name="host_status_control", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_status_control")]
    public bool? HostStatusControl { get; set; }

    /// <summary>
    /// Whether users can join while the status is PLAYING. Default false
    /// </summary>
    /// <value>Whether users can join while the status is PLAYING. Default false</value>
    [DataMember(Name="join_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "join_in_play")]
    public bool? JoinInPlay { get; set; }

    /// <summary>
    /// Whether users can leave while the status is PLAYING. Default false
    /// </summary>
    /// <value>Whether users can leave while the status is PLAYING. Default false</value>
    [DataMember(Name="leave_in_play", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leave_in_play")]
    public bool? LeaveInPlay { get; set; }

    /// <summary>
    /// The maximum number of players the game can hold
    /// </summary>
    /// <value>The maximum number of players the game can hold</value>
    [DataMember(Name="max_players", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_players")]
    public int? MaxPlayers { get; set; }

    /// <summary>
    /// The minimum number of players the game can hold
    /// </summary>
    /// <value>The minimum number of players the game can hold</value>
    [DataMember(Name="min_players", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_players")]
    public int? MinPlayers { get; set; }

    /// <summary>
    /// Restriction for who is able to report game end and results. Admin is always able to send results as well. Default 'none'
    /// </summary>
    /// <value>Restriction for who is able to report game end and results. Admin is always able to send results as well. Default 'none'</value>
    [DataMember(Name="results_trust", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results_trust")]
    public string ResultsTrust { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CoreActivitySettings {\n");
      sb.Append("  BootInPlay: ").Append(BootInPlay).Append("\n");
      sb.Append("  CustomLaunchAddressAllowed: ").Append(CustomLaunchAddressAllowed).Append("\n");
      sb.Append("  HostOption: ").Append(HostOption).Append("\n");
      sb.Append("  HostStatusControl: ").Append(HostStatusControl).Append("\n");
      sb.Append("  JoinInPlay: ").Append(JoinInPlay).Append("\n");
      sb.Append("  LeaveInPlay: ").Append(LeaveInPlay).Append("\n");
      sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
      sb.Append("  MinPlayers: ").Append(MinPlayers).Append("\n");
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
