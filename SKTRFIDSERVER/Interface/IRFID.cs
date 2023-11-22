using SKTRFIDSERVER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDSERVER.Interface
{
    interface IRFID
    {
        string UpdateRFID(DataModel data);
    }
}
