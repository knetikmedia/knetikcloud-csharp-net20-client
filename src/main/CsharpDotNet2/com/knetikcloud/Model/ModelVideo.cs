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
  public class ModelVideo {
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public ModelArtist Author { get; set; }

    /// <summary>
    /// Gets or Sets Authored
    /// </summary>
    [DataMember(Name="authored", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authored")]
    public long? Authored { get; set; }

    /// <summary>
    /// Gets or Sets Banned
    /// </summary>
    [DataMember(Name="banned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "banned")]
    public bool? Banned { get; set; }

    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public string CategoryId { get; set; }

    /// <summary>
    /// Gets or Sets CategoryName
    /// </summary>
    [DataMember(Name="category_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_name")]
    public string CategoryName { get; set; }

    /// <summary>
    /// Gets or Sets Contributors
    /// </summary>
    [DataMember(Name="contributors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contributors")]
    public ModelCollectionVideoContribution Contributors { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public long? Created { get; set; }

    /// <summary>
    /// Gets or Sets Embed
    /// </summary>
    [DataMember(Name="embed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "embed")]
    public string Embed { get; set; }

    /// <summary>
    /// Gets or Sets Extension
    /// </summary>
    [DataMember(Name="extension", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension")]
    public string Extension { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public int? Height { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Length
    /// </summary>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public int? Length { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Gets or Sets LongDescription
    /// </summary>
    [DataMember(Name="long_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long_description")]
    public string LongDescription { get; set; }

    /// <summary>
    /// Gets or Sets MimeType
    /// </summary>
    [DataMember(Name="mime_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mime_type")]
    public string MimeType { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets Privacy
    /// </summary>
    [DataMember(Name="privacy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privacy")]
    public string Privacy { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// Gets or Sets ShortDescription
    /// </summary>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public long? Size { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<ModelVideoTag> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public string Thumbnail { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public long? Updated { get; set; }

    /// <summary>
    /// Gets or Sets Uploader
    /// </summary>
    [DataMember(Name="uploader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploader")]
    public ModelUser Uploader { get; set; }

    /// <summary>
    /// Gets or Sets Views
    /// </summary>
    [DataMember(Name="views", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "views")]
    public long? Views { get; set; }

    /// <summary>
    /// Gets or Sets Whitelist
    /// </summary>
    [DataMember(Name="whitelist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whitelist")]
    public List<ModelUser> Whitelist { get; set; }

    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public int? Width { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVideo {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Authored: ").Append(Authored).Append("\n");
      sb.Append("  Banned: ").Append(Banned).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
      sb.Append("  Contributors: ").Append(Contributors).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Embed: ").Append(Embed).Append("\n");
      sb.Append("  Extension: ").Append(Extension).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Privacy: ").Append(Privacy).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      sb.Append("  Uploader: ").Append(Uploader).Append("\n");
      sb.Append("  Views: ").Append(Views).Append("\n");
      sb.Append("  Whitelist: ").Append(Whitelist).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
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
