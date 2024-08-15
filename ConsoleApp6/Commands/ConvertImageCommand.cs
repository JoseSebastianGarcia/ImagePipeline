using CommandMapper.Core.WithOptions;
using ConsoleApp6.Options;
using ConsoleApp6.ImagePipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using ConsoleApp6.ImagePipeline.Processors;

namespace ConsoleApp6.Commands
{
    public class ConvertImageCommand : CommandBaseWithOptions<ConvertImageOptions>
    {
        protected override void CommandScript(ConvertImageOptions options)
        {
            Pipeline pipeline = new Pipeline();
            pipeline.AddProcessor(new GrayscaleProcessor());
            pipeline.AddProcessor(new InvertProcessor());
            pipeline.AddProcessor(new GaussianBlurProcessor());
            pipeline.AddProcessor(new ExportProcessor());

            ImageContext context = new ImageContext() {
                Grayscale = options.Grayscale,
                Invert = options.Invert,
                Destiny = options.Destiny,
                GaussianBlur = options.GaussianBlur,
                Image = Image.Load(options.Source)
            };

            pipeline.Process(context);
        }
    }
}
