using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace HarrisMichael_CodeExerciseOne
{
    class SaveXML
    {
        public void SaveAsXML(object obj, string fileName)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter w = new StreamWriter(fileName);
            sr.Serialize(w, obj);
            w.Close();
        }

    }
}
