using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using First_Responder.Areas.Admin.Models;
using First_Responder.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace First_Responder.Areas.Member.Models
{
    public class Profile
    {
        [Key]
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rank { get; set; }
        public int RoleType { get; set; }
        public int DriverType { get; set; }
        public DateTime StartOfService { get; set; }
        public string ProfileImage { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int Zip { get; set; }
        public bool AllowInfoPublic { get; set; }
        

    }
}