using OOPDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    interface ISqlStatements
    {
        List<object> GetAllRecords();
        object GetById(int id);

        object AddNewRecord(object newRecord);

        object DeleteRecord(int id);

        object UpdateRecord(int id, object updateRecord);
    }
}
