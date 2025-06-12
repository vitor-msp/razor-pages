using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

[Table("movies")]
public class Movie
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [Required, StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }

    [Column("release_date")]
    [DataType(DataType.Date), Display(Name = "Release Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyyy}", ApplyFormatInEditMode = false)]
    public DateTime ReleaseDate { get; set; }

    [Column("genre")]
    [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Genre { get; set; }

    [Column("price", TypeName = "decimal(18, 2)")]
    [Range(1, 100), DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Column("rating")]
    [Required, StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    public string Rating { get; set; } = string.Empty;
}