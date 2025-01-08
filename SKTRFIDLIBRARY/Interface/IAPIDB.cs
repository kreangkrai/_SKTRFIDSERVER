using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface IAPIDB
    {
        string UpdateAPI(DataAPIModel data);
        DataAPIModel GetAPIByDump(string dump);
    }
}
