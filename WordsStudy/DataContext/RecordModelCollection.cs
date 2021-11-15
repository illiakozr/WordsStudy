using System;
using System.Xml.Serialization;

namespace WordsStudy.DataContext
{
    [Serializable()]
    [XmlRoot("RecordModelCollection")]
    public class RecordModelCollection
    {
        [XmlArray("RecordModels")]
        [XmlArrayItem("RecordModel", typeof(RecordModel))]
        public RecordModel[] RecordModel { get; set; }
    }
}
