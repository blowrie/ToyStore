using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] toyArray = { "action figure, doll, legos" };

            List<string> toyList = new List<string>() { "Action figure", "Stuffed animal", "Legos" };

            List<String> employeesNames = new List<string>();

            toyList.Add("Barbie");
            toyList.Add("Remote contol car");
            toyList.Add("Yo-yo");

            /*foreach(string toy in toyList) //instead of .Length Lists use .Count
            {
                Console.WriteLine(toy);
            }

            
             for (int i = 0; i < toyList.Count; i++) 
             {
                Console.WriteLine(toyList[i]);
            }
            

            Console.WriteLine(toyList[0]);

            //The properties and Methods whcih we will use the most are 
            //.Count
            //.Add()
            //.Insert()
            //.Remove()
            */

            Console.WriteLine(toyList.Count);

            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

            //Inset allows us to put a new element in the list 
            //AND
            //Specify which index we want for that element.

            toyList.Insert(0, "Kite");
            toyList.Insert(2, "Baby doll");
            toyList.Insert(1, "Plastic dinosaur");

            foreach (string toy in toyList)
            {
                Console.WriteLine(toy);
            }

            //Another method that we will often use is .Contains()
            //It returns a Boolean value

            if (toyList.Contains("Plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy the dino");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these toys");
            }
            List<string> employeeNames = new List<string>();

            


            
        }
    }
}
