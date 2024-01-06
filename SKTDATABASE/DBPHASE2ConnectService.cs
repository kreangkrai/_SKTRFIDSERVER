using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTDATABASE
{
    public static class DBPHASE2ConnectService
    {
        public static string data_source()
        {
            return "Data Source=DESKTOP-6ODC3E6\\SQLEXPRESS;Initial Catalog=SKT;User ID=sa;Password=contrologic;Trusted_Connection=False;MultipleActiveResultSets=true;integrated security=SSPI";
        }
    }
}
