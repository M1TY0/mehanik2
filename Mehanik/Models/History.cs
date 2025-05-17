using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehanik.Models
{
    internal class History
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double MechanicPrice { get; set; }
        public double ServicePrice { get; set; }
        public double PartPrice { get; set; }
        public double Hours{ get; set; }
        public string Mechanic { get; set; }
        public string Service { get; set; }
        public string Client { get; set; }
    }
}
