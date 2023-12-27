using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface IRFID
    {
        string UpdateRFID(DataModel data);
        string UpdateRFIDAllergenLog(DataModel data);
        string UpdateRFIDAllergen(DataModel data);
        string InsertRFIDLog(DataModel data);
    }
}
