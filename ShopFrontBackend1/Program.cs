using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFrontBackend
{
    public static class Program
    {
        public static void Main(string[] args) 
        {
            var data = Systems.FakeStoreAPI.FetchProducts();
            data.ForEach(x => Console.WriteLine(x.Id));
        }
    }
}
