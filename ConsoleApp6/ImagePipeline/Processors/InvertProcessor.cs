using SixLabors.ImageSharp.Memory;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline.Processors
{
    public class InvertProcessor : IProcesable<ImageContext>
    {
        public void Process(ImageContext context)
        {
            if (!context.Invert) return;

            context.Image.Mutate(img=> img.Invert());
        }
    }
}
