using System;
using System.ComponentModel.DataAnnotations;
namespace Project2.Models
{
    public class Appt
    {

        //[Required]
        //public long ApptId { get; set; }
        [Key]
        [Required]
        public string ApptDate { get; set; }
        //[Required]
        //public int ApptTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Groups must be between 1 and 15 people.")]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public long GroupPhone { get; set; }

    }
}



       
