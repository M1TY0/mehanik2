using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehanik.Models
{
    public class Clients
    {
 //       [Key]
        public int Id { get; set; }
        public string Names { get; set; }
        public string PhoneNum { get; set; }
        public string CarModel { get; set; }
        public string CarNum { get; set; }
    }
}
