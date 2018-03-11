using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EportDataPlatform.DataAccess.DataBase
{
    public class EntRetDa : BaseDa
    {
        public List<Entity.DataBase.ENTRY_RETURN> GetBySaveRefID(string save_ref_id)
        {
            var linq = from t in _EntRetContext.ENTRY_RETURN
                       where t.PRE_ENTRY_ID ==
                           (from t1 in _EntRetContext.ENTRY_RETURN
                            where t1.CHANNEL == "7"
                            where t1.NOTE.StartsWith(save_ref_id)
                            select t1.PRE_ENTRY_ID).FirstOrDefault()
                       select t;
            return linq.ToList();
        }

        public List<Entity.DataBase.ENTRY_RETURN> GetByPreEntryID(string pre_entry_id)
        {
            var linq = from t in _EntRetContext.ENTRY_RETURN
                       where t.PRE_ENTRY_ID == pre_entry_id
                       select t;
            return linq.ToList();
        }

        public List<Entity.DataBase.ENTRY_RETURN> GetByEntryID(string entry_id)
        {
            var linq = from t in _EntRetContext.ENTRY_RETURN
                       where t.PRE_ENTRY_ID ==
                           (from t1 in _EntRetContext.ENTRY_RETURN
                            where t1.ENTRY_ID == entry_id
                            select t1.PRE_ENTRY_ID).FirstOrDefault()
                       select t;
            return linq.ToList();
        }

        public string GetSaveByPre(string pre_entry_id)
        {
            var linq = from t in _EntRetContext.ENTRY_RETURN
                       where t.PRE_ENTRY_ID == pre_entry_id
                       where t.CHANNEL == "7"
                       where t.NOTE.StartsWith("Z")
                       select t.NOTE.Substring(0, 18);
            return linq.FirstOrDefault();
        }

        public string GetSaveByEntry(string entry_id)
        {
            var linq = from t in _EntRetContext.ENTRY_RETURN
                       where t.PRE_ENTRY_ID ==
                           (from t1 in _EntRetContext.ENTRY_RETURN
                            where t1.ENTRY_ID == entry_id
                            select t1.PRE_ENTRY_ID).FirstOrDefault()
                       where t.CHANNEL == "7"
                       where t.NOTE.StartsWith("Z")
                       select t.NOTE.Substring(0, 18);
            return linq.FirstOrDefault();
        }
    }
}
