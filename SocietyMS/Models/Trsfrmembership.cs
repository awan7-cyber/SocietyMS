using System.ComponentModel.DataAnnotations;

namespace SocietyMS.Models
{
    public class Trsfrmembership
    {

        [Key]

        public  int transfer_Id { get; set; }

        public int Date {  get; set; }

        public  int past_member_id { get; set; }
        public int new_member_id { get; set; }
    }
}
