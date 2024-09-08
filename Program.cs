using System.Collections;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace productswidthobject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Products product = new Products();

        restart:
            Console.Clear();
            Console.WriteLine("Choose the section:\n" +
                "1.Add product\n" +
                "2.Show all product\n" +
                "3.Total price \n" +
                "4.Total price by category\n"+
                "5.Show products by category\n" +
                "6. Total quantity\n" +
                "7.Total quantity by category \n" +
                "8.Sell product");



            string temp = Console.ReadLine();



            if (temp == "1")
            {

                Console.Write("Brand:");
                string brand = Console.ReadLine();


                Console.Write("Model:");
                string model = Console.ReadLine();

                Console.Write("price:");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Category:");
                string category = Console.ReadLine();


                product.Add(brand, model, price, quantity, category);


                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }
            }
            else if (temp == "2")
            {
                product.Showproducts();

                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }
            }
            else if (temp == "3")
            {

                Console.WriteLine(product.ShowTotalPrices());
                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }
            }

            else if (temp == "4")
            {

                Console.WriteLine("Choose the category\n" +
                    "1.pc\n" +
                    "2.mobile");

                string category = Console.ReadLine();
                Console.WriteLine(product.TotalpriceBycategory(category));


                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }
            }


            else if (temp == "5")
            {

                Console.WriteLine("Pleace choose the category:\n" +
                    "1.PC\n" +
                    "2.Mobile");

                string categorysection = Console.ReadLine();
                product.ShowbyCategory(categorysection);


                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }

            }

            else if (temp == "6") {


                Console.WriteLine(product.Totalquantity());

                Console.WriteLine("Do you want to continue?y/n");

                string restart = Console.ReadLine();

                if (restart == "y")
                {
                    goto restart;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("The process is finished!");
                }
            }
            else if(temp == "7")
            {
                Console.WriteLine(" Which total quantity of category do you want to see?\n" +
                    "1.pc\n" +
                    "2.mobile");

                string category= Console.ReadLine();

                if (category == "1")
                {
                    Console.WriteLine(product.Totalquantitipc());
                }
                else if (category == "2") {
                    Console.WriteLine(product.Totalquantitimobile());
                }
                else
                {
                    Console.WriteLine("Wrong value!");

                    Console.WriteLine("Do you want to continue?y/n");

                    string restart = Console.ReadLine();

                    if (restart == "y")
                    {
                        goto restart;
                    }
                    else if (restart == "n")
                    {
                        Console.WriteLine("The process is finished!");
                    }
                }
            }


            else if(temp == "8")
            {
                int countproduct = product.GetAllProducts().Count;
                Console.WriteLine("Which product do you want to change, please enter number ?");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number <= countproduct)
                {
                    product.Sell(number); 

                }
                else
                {
                    Console.WriteLine("No products to sell.");
                }

            }

        }
    }
}
