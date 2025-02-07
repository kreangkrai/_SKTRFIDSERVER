﻿using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Interface
{
    public interface ITagLog
    {
        string InsertTag(TagLogModel tag);
        List<TagLogModel> GetTags();
        List<TagLogModel> GetTagByRfid(string rfid);
        List<TagLogModel> GetTagLogByRFID(string rfid);
    }
}
