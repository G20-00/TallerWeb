using System.ComponentModel.DataAnnotations;
namespace TallerWeb.Models
{
    public class Users
    {
        [Key]
        public String userName
            { get; set; }
        public String password { get; set; }
        public String firtsName     { get; set; }
        public String lastName { get; set; }    
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
    }
}
