using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace Brady_N_PayRoll_Application.Models
{
    public class Employee
    {

        public int? EmployeeID { get; set; }

        [Required(ErrorMessage = "Please Enter A First Name")]
        public string? firstName { get; set; }

        [Required(ErrorMessage = "Please Enter A Last Name")]
        public string? lastName { get; set; }

        [Required(ErrorMessage = "Please Enter An Address")]
        public string? Address { get; set; }

        public string? email { get; set; }

        [Required(ErrorMessage = "Please Enter A Phone Number")]
        public string? phone  { get; set; }
        
        public int? hourlyRate { get; set; }

        public int? salary { get; set; }
        
        public int? hours { get; set; }


        [ForeignKey("position")]
        public int postionId { get; set; }

        public position? position { get; set; }
    }
}
