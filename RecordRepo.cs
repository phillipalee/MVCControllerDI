using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCControllerDI
{
    public class RecordRepo : IRecordRepo
    {
        private RecordContext _context = new RecordContext();
        public IEnumerable<Record> GetRecords()
        {
     
            
                return _context.Records;
            
        }
    }
}
