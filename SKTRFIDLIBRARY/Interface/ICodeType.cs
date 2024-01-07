using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface ICodeType
    {
        string CaneType(int n);
        string truckType(int n);
        string weightType(int n);
        string queueStatus(int n);
        string allergenType(string n);
    }
}
