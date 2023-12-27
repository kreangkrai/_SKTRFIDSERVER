using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTDATABASE
{
    public static class DBPHASE1ConnectService
    {
        public static string data_source()
        {
            return "Data Source=DESKTOP-M6NATK6;Initial Catalog=SKT;User ID=sa;Password=contrologic;Trusted_Connection=False;MultipleActiveResultSets=true;integrated security=SSPI";
        }
    }
}
