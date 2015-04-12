using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace First_Responder.Areas.Admin.Models
{
    public class RoleType
    {
        [Key]
        public int RoleTypeID { get; set; }
        public string RoleTypeName { get; set; }
    }
}