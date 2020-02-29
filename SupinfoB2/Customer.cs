using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupinfoB2
{
   public class Customer
    {
        public int Id { set; get; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Wishlist { get; set; }
        public List<string> listSouhaits = new List<string> { "Velo ", "Scanner", "Ordinateur","Imprimante" ,"Ipad","ThinkPad","HP","MacBook","lenovo" };
     
        public void AddCustomer()
        {
            using (var db = new CustomerContext())
            {

                Console.WriteLine("Saisir les informations du Clients");
                Console.Write("\n Entre le full Name: ");
                string fullName = Console.ReadLine();
                Console.Write("\n Entrez votre numero de telephone: ");
                string  phone = Console.ReadLine();
                Console.Write("\n Entre votre Email: ");
                string email= Console.ReadLine();

                
               
                Random random = new Random();
                int rand2;
                int taille = listSouhaits.Count;
                int rand1 = random.Next(0, taille);
                rand2 = random.Next(0, taille);

                while ( rand1 == rand2)
                {
                    rand2 = random.Next(0, taille);

                }  
                string listS1 = listSouhaits[rand1];
                string listS2 = listSouhaits[rand2];
                string wishlist = listS1 + " " + listS2;
                try {
                    var customer= new Customer()
                    {
                        FullName = fullName,
                        Phone = phone,
                        Email = email,
                        Wishlist = wishlist
                        
                    };
                    db.SupCustomer.Add(customer);
                    db.SaveChanges();

                }
                catch ( Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }

            }
        }
       
        public void SearchCustomer(int id)
        {

            using (var db = new CustomerContext())
            {
                try
                {
                    var article = db.SupCustomer.Find(id);
                    if (article != null)
                    {
                        
                        Console.WriteLine("Id :" + article.Id + "  FullName : " + article.FullName + " Phone: " + article.Phone + " Email: " + article.Email + " Wishlist : " + article.Wishlist);

                    }
                    else
                    {
                        Console.WriteLine("Client Non Trouver !");
                    }

                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public void DisplayCustomer()
        {
            using (var db = new CustomerContext())
            {
               try {
                    foreach (var client in db.SupCustomer)
                    {
                        Console.WriteLine("Id :" + client.Id + "  FullName : " + client.FullName + " Phone: " + client.Phone + " Email: " + client.Email + " Wishlist : " + client.Wishlist);

                    }
                }
               catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public void UpdateCustomer() {
            using (var db = new CustomerContext())
            {
                DisplayCustomer();
                Console.Write(" Donner l'index de l'utilisateurs que vous voulez mettre à jour : ");
                var id  = int.Parse(Console.ReadLine());
                if (id >= 0 && id <= db.SupCustomer.Count())
                {
                    var custom = db.SupCustomer.ToList()[id-1];
                    Console.Write("Entrer un nouveau FullName: ");
                    string newFallName = Console.ReadLine();
                    Console.Write("Entrer un nouveau Email: ");
                    string newEmail = Console.ReadLine();
                    Console.Write("Entrer un nouveau Number Phone: ");
                    string newPhone = Console.ReadLine();
                    Random affiche = new Random();
                    int indexS2;
                    int cut = listSouhaits.Count;
                    int indexS1 = affiche.Next(0, cut);
                    indexS2 = affiche.Next(0, cut);

                    while (indexS1 == indexS2)
                    {
                        indexS2 = affiche.Next(0, cut);

                    }
                    string list1 = listSouhaits[indexS1];
                    string list2 = listSouhaits[indexS2];
                    string wishlist = list1 + " " + list2;
                    custom.FullName = newFallName;
                    custom.Email = newEmail;
                    custom.Phone = newPhone;
                    custom.Wishlist = wishlist;
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Index introuvable ..........");
                }
               


            }
        }
        public void DeleteCustomer(int id) {
            using (var db = new CustomerContext())
            {
                var customer = db.SupCustomer.Find(id);
                if (customer != null)
                {
                    db.SupCustomer.Remove(customer);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" Client pas trouver...");
                }
                
                
            }
            {

            }
        }
        public void WinnerCustomer() {

            using(var db = new CustomerContext())
            {
                var customers= db.SupCustomer;
                Random rd = new Random();
                int indexCustomer = rd.Next(0, customers.Count());
                int indexWish = rd.Next(0, 2);
                var cust = customers.ToList()[indexCustomer];
                var wish = cust.Wishlist.Split()[indexWish];
                Console.WriteLine("Id :" + cust.Id + "  FullName : " + cust.FullName + " Phone: " + cust.Phone + " Email: " + cust.Email + " Wishlist : " + wish);
                Console.WriteLine("               Felicitation au gagnant       "  );




            }
        }

    }
   

}
