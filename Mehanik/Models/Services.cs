using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehanik.Models
{
    internal class Services
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Part {  get; set; }
        public double WholePrice { get; set; }
        public double PartPrice { get; set; }
        public double ServicesPrice {  get; set; }
        
        
    }
}
