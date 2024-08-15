using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline.Processors
{
    public class GaussianBlurProcessor : IProcesable<ImageContext>
    {
        public void Process(ImageContext context)
        {
            if (!context.GaussianBlur) return;

            context.Image.Mutate(image => image.GaussianBlur(3,new Rectangle(10,10,context.Image.Width - 20, context.Image.Height - 20)));
        }
    }
}
