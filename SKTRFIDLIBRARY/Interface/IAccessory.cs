using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface IAccessory
    {
        string decodeLicensePlate(string code);
        string LicensePlateEngToTh(string code);
        RFIDModel ReadRFIDCard(string tag);
        DataModel ReadDataRFIDCard(string tag);
    }
}
