using System.ComponentModel.DataAnnotations;

namespace SocietyMS.Models
{
    public class Membershipinfo
    {
        [Key]
        public int Id { get; set; }
        //Foriegn Key
        public int  Personal_Id { get; set; }
        public Personalinfo Personalinfo { get; set; }
        public string Status { get; set; }

        public int Charges { get; set; }
    }
}
