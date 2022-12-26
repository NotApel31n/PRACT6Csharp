using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp19
{
    public class Figure
    {
        public Figure() { }
        public Figure(string _name, int _width, int _height) { name = _name; width = _width; height = _height; }
        public string getStringed()
        {
            return $"{name}\n{width}\n{height}";
        }
        public string name;
        public int width;
        public int height;
    }
}