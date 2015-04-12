using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace First_Responder.Areas.Admin.Models
{
    public class Page
    {
       
        [Key]
        public int PageId { get; set; }
        public int AuthorId { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string OgImage { get; set; }
        public string Body { get; set; }
        public string Keywords { get; set; }
        public DateTime Published { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsNewsItem { get; set; }
    }
}