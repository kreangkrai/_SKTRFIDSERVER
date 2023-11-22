using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDCOMMON.Service
{
    public static class DBConnectService
    {
        public static string data_source()
        {
            return "Data Source=DESKTOP-6ODC3E6\\SQLEXPRESS;Initial Catalog=SKT;User ID=sa;Password=contrologic;Trusted_Connection=False;MultipleActiveResultSets=true;integrated security=SSPI";
        }
    }
}
