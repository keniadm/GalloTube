using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models;
[Table("VideoTag")]
public class VideoTag
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int VideoId { get; set; }
    [ForeignKey("VideoId")]
    public Video Video { get; set; } //propriedade de navegação

    [Required]
    public string UserId { get; set; } 
    [ForeignKey("UserId")]
    public AppUser User { get; set; }
}