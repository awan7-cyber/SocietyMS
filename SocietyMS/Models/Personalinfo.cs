using System.ComponentModel.DataAnnotations;

namespace SocietyMS.Models
{
    public class Personalinfo
    {
        [Key]
        public int member_id { get; set; }

        public string name { get; set; }

        public string Gender { get; set; }

        public int CnicNo { get; set; }
       
        public string Designation {  get; set; }    

        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }    // or DateOnly?

        public string postaladress { get; set; }

        public string permanentadress { get; set; }

        public string religion { get; set; }

        public string membercast { get; set; }

        public int phoneno { get; set; }

        public string Kin_name { get; set; }

        public string kin_Relation { get; set; }    

        public int kin_cnic { get; set; }   

        public string kin_adress { get; set; }  




    }
}
