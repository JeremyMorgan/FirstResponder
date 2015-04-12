using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace First_Responder.Areas.Admin.Models
{
    public class Rank
    {
        [Key]
        public int RankID { get; set; }
        public string RankName { get; set; }
        public string RankAbb { get; set; }

    }
}