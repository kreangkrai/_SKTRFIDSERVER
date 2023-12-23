﻿using SKTRFIDTAG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDTAG.Interface
{
    interface ITagLog
    {
        List<TagLogModel> GetTagLogByRFID(string rfid);
    }
}
