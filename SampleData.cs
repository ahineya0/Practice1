using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = Practice_1.Form.File;

namespace Practice_1.SampleData
{
    public static class Data
    {
        public static List<File> LeftData = new()
        {
            new File("Ajaccgd0", "exe", 0, new DateTime()),
            new File("nc", "cfg", 0, new DateTime()),
            new File("nc_exit", "com", 0, new DateTime()),
            new File("telemax", "dat", 0, new DateTime()),
            new File("nc_exit", "doc", 0, new DateTime()),
            new File("123view", "exe", 0, new DateTime()),
            new File("arcview", "exe", 0, new DateTime()),
            new File("bitmap", "exe", 0, new DateTime()),
            new File("clp2dib", "exe", 0, new DateTime()),
            new File("dbview", "exe", 0, new DateTime()),
            new File("draw2wmf", "exe", 0, new DateTime()),
            new File("ico2dib", "exe", 0, new DateTime()),
            new File("msp2dib", "exe", 0, new DateTime()),
            new File("nc2view", "exe", 0, new DateTime()),
            new File("ncclean", "exe", 0, new DateTime()),
            new File("ncdedit", "exe", 0, new DateTime()),
            new File("ncff", "exe", 0, new DateTime()),
            new File("nclabel", "exe", 0, new DateTime()),
            new File("ncmain", "exe", 0, new DateTime()),
            new File("ncmnet", "exe", 0, new DateTime()),
            new File("ncsf", "exe", 0, new DateTime()),
            new File("ncsi", "exe", 0, new DateTime()),
            new File("nczip", "exe", 0, new DateTime()),
            new File("packer", "exe", 0, new DateTime()),
            new File("paraview", "exe", 0, new DateTime()),
            new File("pct2dib", "exe", 0, new DateTime()),
            new File("playwave", "exe", 0, new DateTime()),
            new File("qaview", "exe", 0, new DateTime()),
            new File("rbview", "exe", 0, new DateTime()),
            new File("rfview", "exe", 0, new DateTime()),
            new File("saver", "exe", 0, new DateTime()),
            new File("telemax", "exe", 0, new DateTime()),
            new File("tif2dib", "exe", 0, new DateTime()),
            new File("vector", "exe", 0, new DateTime()),
            new File("wpb2dib", "exe", 0, new DateTime()),
            new File("wpv2wmf", "exe", 0, new DateTime()),
        };

        public static List<File> RightData = new()
        {
            new("123view", "exe", 128330, default(DateTime)),
            new("4372ansi", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("8502ansi", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("8623ansi", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("8652ansi", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("8662ansi", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("Ajaccgdo", "exe", 4173902, new DateTime(2005,5,25,9,02, 0)),
            new("ansi2437", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("ansi2850", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("ansi2863", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("ansi2865", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("ansi2866", "set", 255, new DateTime(2005,5,25,9,55, 0)),
            new("arcview", "exe", 81738, new DateTime(2005,5,25,9,55, 0)),
            new("ansi2437", "exe", 255, new DateTime(2005,5,25,9,55, 0)),
            new("arc", "nss", 644, new DateTime(2005,5,25,9,55, 0)),
            new("bitmap", "exe", 54805, new DateTime(2005,5,25,9,55, 0)),
            new("bug", "nss", 16133, new DateTime(2005,5,25,9,55, 0)),
            new("bungee", "nss",41914, new DateTime(2005,5,25,9,55, 0)),
        };
    }
}
