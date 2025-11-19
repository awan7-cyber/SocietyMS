using System.ComponentModel.DataAnnotations;

namespace SocietyMS.Models
{
    public class Charges
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
         public int Price { get; set; }

    }
}
