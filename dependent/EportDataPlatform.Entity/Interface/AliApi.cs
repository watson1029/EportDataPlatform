using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EportDataPlatform.Entity.Interface.AliApi
{
    [Serializable]
    public class Entry
    {
        public Entry()
        {
            EntryLists = new EntryLists();
        }
        [XmlElement(ElementName = "EntryHead")]
        public DataBase.ENTRY_HEAD EntryHead { get; set; }
        [XmlElement(ElementName = "EntryLists")]
        public EntryLists EntryLists { get; set; }
    }

    [Serializable]
    public class EntryLists
    {
        [XmlElement(ElementName = "EntryList")]
        public List<DataBase.ENTRY_LIST> EntryList { get; set; }
    }

    [ProtoContract]
    public class GetStatus_Response
    {
        [ProtoMember(1)]
        public string StatusText { get; set; }
        [ProtoMember(2)]
        public DateTime? DeclareDate { get; set; }
    }
}
