using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class RentDetails
    {
        public int Id { get; set; }
        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public string Rent { get; set; }

        public string Terms { get; set; }
    }
}