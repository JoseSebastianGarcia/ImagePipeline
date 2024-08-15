using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline
{
    public class Pipeline : IProcesable<ImageContext>
    {
        private readonly List<IProcesable<ImageContext>> _processors = new List<IProcesable<ImageContext>>();

        public void AddProcessor(IProcesable<ImageContext> processor) 
        {
            _processors.Add(processor);
        }
        
        public void Process(ImageContext context)
        {
            _processors.ForEach(processor => processor.Process(context));
        }
    }
}
