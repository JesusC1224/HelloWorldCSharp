using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HelloWorldExample
{
    internal class Car
    {
        public string make;
        public string model;
        int year;
        string VIN;
        string exteriorColor;
        string interiorColor;

        public Car(string make, string model, int year, string vIN, string exteriorColor, string interiorColor)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.VIN = vIN;
            this.exteriorColor = exteriorColor;
            this.interiorColor = interiorColor;
        }
    }
}
