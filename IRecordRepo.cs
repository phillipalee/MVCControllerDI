using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCControllerDI
{
    public interface IRecordRepo
    {
        public IEnumerable<Record> GetRecords();

    }
}
