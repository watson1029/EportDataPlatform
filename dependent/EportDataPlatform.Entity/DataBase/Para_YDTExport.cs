using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace EportDataPlatform.Entity.DataBase
{
    [Serializable]
    public partial class Para_YDTExport
    {
        public Para_YDTExport()
        { }
        private string _customscode;
        private string _customsname;
        public string CustomsCode
        {
            set { _customscode = value; }
            get { return _customscode; }
        }
        public string CustomsName
        {
            set { _customsname = value; }
            get { return _customsname; }
        }
    }
}
