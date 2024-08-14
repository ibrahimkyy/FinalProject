using Business.Concrete;
using DataAccess.Concrete.İnMemory;
using System.Reflection;

namespace ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdactManager productManager = new ProdactManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll()) 
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}
