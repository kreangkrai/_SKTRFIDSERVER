using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface IAPI
    {
        Task<RFIDModel> CallAPI(DataModel data);
        Task<DataUpdateModel> InsertDataAPI(int areaid, string cropyear, string barcode, int phase, int dump, string type);
        Task<ResultUpdateAlledModel> UpdateAlled(string area_id, string crop_year, string barcode, string alled);
        bool checkInternet();
    }
}
