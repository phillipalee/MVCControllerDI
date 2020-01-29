using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCControllerDI
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public int howMany { get; set; }
        public bool tooMany { get; set; }
        public string comments { get; set; }
    }
}
