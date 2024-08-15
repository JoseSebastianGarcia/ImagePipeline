using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Options
{
    public class ConvertImageOptions 
    {
        [Option('s',"source", HelpText = "Imagen de origen", Required =true)]
        public required string Source { set; get; }

        [Option('g', "gs", HelpText = "Escala de grises")]
        public bool Grayscale { set; get; }
        
        [Option('i', "iv", HelpText = "Invertir colores")]
        public bool Invert { set; get; }

        [Option('b', "gb", HelpText = "Desenfoque de gauss")]
        public bool GaussianBlur { set; get; }


        [Option('d', "destiny", HelpText = "Imagen de destino", Required = true)]
        public required string Destiny { set; get; }

    }
}
