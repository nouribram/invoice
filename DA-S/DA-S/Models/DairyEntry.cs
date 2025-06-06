using System.ComponentModel.DataAnnotations;

namespace DA_S.Models
{
    public class DairyEntry
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage ="title must be between 3 and 100")]
        public  string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty ;

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
