using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ImagePipeline
{
    public interface IProcesable<TContext> where TContext : class
    {
        void Process(TContext context);
    }
}
