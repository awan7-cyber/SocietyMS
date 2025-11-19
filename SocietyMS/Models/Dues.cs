using System.ComponentModel.DataAnnotations;

namespace SocietyMS.Models
{
    public class Dues
    {
        
        

        //Foriegn Key
        public int membershipId { get; set; }
        public Membershipinfo membershipinfo { get; set; }

        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public int Price { get; set; }

    }
}
