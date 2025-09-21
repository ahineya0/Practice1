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

        public string GetName(int maxLength)
        {
            if (string.IsNullOrEmpty(Name) || maxLength <= 0)
                return string.Empty;
            if (maxLength == 1)
                return "~";

            if (Name.Length <= maxLength)
                return Name;

            return Name.Substring(0, maxLength - 1) + "~";
        }
    }
}
