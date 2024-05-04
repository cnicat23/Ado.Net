using AdoNet.Controllers;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            string check;
            do
            {
                Console.WriteLine("1. product elave et");
                Console.WriteLine("2. product update et");
                Console.WriteLine("3. product delete et");
                Console.WriteLine("4. product goster");
                Console.WriteLine("5. products goster");
                Console.WriteLine("0. proqramdan cix");
                Console.WriteLine("secim edin: ");
                check = Console.ReadLine();


                switch (check)
                {
                    case "1":
                        productController.AddProduct();
                        break;
                    case "2":
                        productController.UpdateProduct();
                        break;
                    case "3":
                        productController.DeleteProduct();
                        break;
                    case "4":
                        productController.GetProduct();
                        break;
                    case "5":
                        productController.GetAllProducts();
                        break;
                    default:
                        break;
                }

            } while (check != "0");


        }
    }
}
