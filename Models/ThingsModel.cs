using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCControllerDI.Models
{
    public class ThingsModel
    {
        public IEnumerable<Record> Things { get; set; }
        public string response { get; set; }
    }
}
