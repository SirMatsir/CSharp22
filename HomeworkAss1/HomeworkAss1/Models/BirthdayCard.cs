using System.ComponentModel.DataAnnotations;

namespace HomeworkAssign1.Models
{
    public class BirthdayCard
    {
        [Required(ErrorMessage = "Please enter a From")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter a To")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }

    }
}
