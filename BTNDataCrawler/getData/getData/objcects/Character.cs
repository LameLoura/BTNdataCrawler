using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getData.objcects
{
    [Serializable]
    public class Character
    {

        //[System.Xml.Serialization.XmlElement("Link")]
        public string Link { get; set; }

        //[System.Xml.Serialization.XmlElement("Name")]
        public  string Name { get;  set; }

        public Character()
        {
        }

        public Character(string LinkInpu, string NameInp)
        {
            Link = LinkInpu;
            Name = NameInp;
        }
    }
}
