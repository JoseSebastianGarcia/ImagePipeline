using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline.Processors
{
    public class GrayscaleProcessor : IProcesable<ImageContext>
    {
        public void Process(ImageContext context)
        {
            if (!context.Grayscale) return;

            context.Image.Mutate(image => image.Grayscale());
        }
    }
}
