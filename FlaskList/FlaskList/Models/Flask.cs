using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlaskList.Models
{
    public class Flask
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int CapacityInML { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}