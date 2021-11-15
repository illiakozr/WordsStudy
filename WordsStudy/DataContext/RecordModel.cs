using System;
using System.Xml.Serialization;

namespace WordsStudy.DataContext
{
    [Serializable()]
    public class RecordModel
    {
        [XmlElement("Number")]
        public int Number { get; set; }

        [XmlElement("Word")]
        public string Word { get; set; }

        [XmlElement("Translation")]
        public string Translation { get; set; }

        [XmlElement("Studied")]
        public bool Studied { get; set; }
    }
}
