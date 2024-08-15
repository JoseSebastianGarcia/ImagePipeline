using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline
{
    public class ImageContext
    {
        public Image Image { get; set; } = null!;
        public bool Grayscale { set; get; }
        public bool Invert { set; get; }
        public bool GaussianBlur { set; get; }
        public string Destiny { set; get; } = null!;
    }
}
