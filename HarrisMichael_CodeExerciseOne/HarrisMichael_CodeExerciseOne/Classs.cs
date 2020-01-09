using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisMichael_CodeExerciseOne
{
    public class Classs
    {
        string name;
        bool type;

        public string Name { get => name; set => name = value; }
        public bool Type { get => type; set => type = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
