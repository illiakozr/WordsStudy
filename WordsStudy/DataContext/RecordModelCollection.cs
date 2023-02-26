using System;
using System.Xml.Serialization;

namespace WordsStudy.DataContext
{
    /// <summary>
    /// This class represents model for storing words collection in xml file
    /// </summary>
    [Serializable()]
    [XmlRoot("RecordModelCollection")]
    public class RecordModelCollection
    {
        [XmlArray("RecordModels")]
        [XmlArrayItem("RecordModel", typeof(RecordModel))]
        public RecordModel[] RecordModel { get; set; }
    }
}
