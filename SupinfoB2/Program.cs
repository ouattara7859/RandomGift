using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupinfoB2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer();

            Menu();
            string choice = Console.ReadLine();
            while (choice != "7")
            {
                switch (choice)
                {

                    case "1":
                        customer.AddCustomer();

                        break;
                    case "2":

                        Console.WriteLine("donner l'id du client que vous voulez rechechrer");
                        int id = int.Parse(Console.ReadLine());
                        customer.SearchCustomer(id);

                        break;
                    case "3":

                        customer.DisplayCustomer();

                        break;
                    case "4":

                        customer.UpdateCustomer();
                        break;
                    case "5":


                        Console.Write(" Enter id a supprimer : ");
                        int idenfiat = int.Parse(Console.ReadLine());
                        customer.DeleteCustomer(idenfiat);
                        break;
                    case "6":
                        customer.WinnerCustomer();

                        break;
                    


                    default:
                        Console.WriteLine("Vous devez choisir parmis les Options 1 et 6");
                        break;

                }
                Menu();
                choice = Console.ReadLine();

            }
            



        }
        public static void Menu()
        {
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("|------------------------|~~~~~~~~~~~~~~~~~~~~~~~~~~~|--------------------------------|");
            Console.WriteLine("|<<<<<<<<<<<<<<<<<<<<<<<<|  Menu Du Centre Commercial|>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|");
            Console.WriteLine("|------------------------|~~~~~~~~~~~~~~~~~~~~~~~~~~~|--------------------------------|");
            Console.WriteLine("|                             1---> Add Customer                                      |");
            Console.WriteLine("|                             2---> search  Customer                                  |");
            Console.WriteLine("|                             3---> Displays Customers                                |");
            Console.WriteLine("|                             4---> Update Customer                                   |");
            Console.WriteLine("|                             5---> Delete Customer                                   |");
            Console.WriteLine("|                             6---> winning customer                                  |");
            Console.WriteLine("|                             7---> Quit                                              |");
            Console.WriteLine("|-------------------------------------------------------------------------------------|");
            Console.WriteLine("|********************           Faites Un Choix                   ********************|");
            Console.WriteLine("|-------------------------------------------------------------------------------------|");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }
    }
}
