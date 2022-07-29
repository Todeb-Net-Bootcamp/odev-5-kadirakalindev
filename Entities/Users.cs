using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Users
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID { get; set; }
        [StringLength(50)]
        public string userNameSurname { get; set; }

        [StringLength(11)]
        public string userTcNo { get; set; }

        [StringLength(50)]
        public string userMail { get; set; }
        [StringLength(11)]
        public string userPhone { get; set; }
        [StringLength(50)]
        public string userCarInfo { get; set; }
        [StringLength(50)]
        public string userRole { get; set; }
    }
}
