using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface ISetting
    {
        SettingModel GetSetting();
        string UpdateSetting(SettingModel setting);
    }
}
