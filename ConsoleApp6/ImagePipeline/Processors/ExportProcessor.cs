using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline.Processors
{
    public class ExportProcessor : IProcesable<ImageContext>
    {
        public void Process(ImageContext context)
        {
            if (!Path.HasExtension(context.Destiny)) 
            {
                Console.WriteLine("El path no cuenta con extension");
                return;
            }

            if(Path.GetExtension(context.Destiny).ToUpper() == ".PNG")
                context.Image.SaveAsPng(context.Destiny);

            if (Path.GetExtension(context.Destiny).ToUpper() == ".JPG")
                context.Image.SaveAsJpeg(context.Destiny);
        }
    }
}
