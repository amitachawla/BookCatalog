using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Web.Models
{
    public class BookViewModel
    {
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
    }
}
