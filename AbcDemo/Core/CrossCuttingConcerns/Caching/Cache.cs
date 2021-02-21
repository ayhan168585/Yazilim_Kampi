using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public class CacheService:ICache
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
