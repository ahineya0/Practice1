using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Form
{
    public class File
    {
        public File(string name, string typ, int size, DateTime dt)
        {
            Name = name;
            Typ = typ;
            Size = size;
            Dt = dt;
        }

        public string Name { get; set; }
        public string Typ { get; set; }
        public int Size { get; set; }
        public DateTime Dt { get; set; }
    }
}
