using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EportDataPlatform.DataAccess.DataBase
{
    public class AliDataCaptureDa : BaseDa
    {
        public List<string> GetOneTouchList()
        {
            var linq = from data in _EntDataContext.ENTRY_HEAD
                       where
                           (from ret in _EntRetContext.ENTRY_RETURN
                            where 
                                (from param in _EntDataContext.Para_YDTExport
                                 select param.CustomsCode).Contains(ret.TRADE_CO)
                            where new string[] { "A", "C", "D", "H", "R", "P" }.Contains(ret.CHANNEL)
                            where data.F_NAME.CompareTo(DateTime.Now.AddHours(-12).ToString("0000960001-yyyyMMddHH")) >= 0
                            where data.F_NAME.CompareTo(DateTime.Now.ToString("0000960001-yyyyMMddHH")) <= 0
                            select ret.PRE_ENTRY_ID).Distinct().Contains(data.PRE_ENTRY_ID)
                       select data.F_NAME;
            return linq.ToList();
        }

        public Entity.DataBase.ENTRY_HEAD GetEntryHead(string f_name)
        {
            var linq = from t in _EntDataContext.ENTRY_HEAD
                       where t.F_NAME == f_name
                       select t;
            return linq.FirstOrDefault();
        }

        public List<Entity.DataBase.ENTRY_LIST> GetEntryList(string f_name)
        {
            var linq = from t in _EntDataContext.ENTRY_LIST
                       where t.F_NAME == f_name
                       orderby t.G_NO ascending
                       select t;
            return linq.ToList();
        }
    }
}
