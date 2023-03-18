using System.ComponentModel.DataAnnotations;


namespace Brady_N_PayRoll_Application.Models
{
    public class position
    {
        [Key]
        public int positionId { get; set; }

        public string? positionName { get; set; }

    }
}
