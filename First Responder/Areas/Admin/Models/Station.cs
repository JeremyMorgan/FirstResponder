using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace First_Responder.Areas.Admin.Models
{
    public class Station
    {

        [Key]
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string Administrator { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int Zip { get; set; }

    }
}