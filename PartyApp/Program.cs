using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyApp
{
    public enum TypeOfGuest
    { 
        Family=1,
        Friend,
        Colleague,
        Other
    }

    public class Person
    {
        public string Name{ get; set; }
        public string SurName { get; set; }
        public TypeOfGuest GuestType { get; set; }
    }

    class Program
    {
        static int size = 1;
        static Person[] people = new Person[size];

        static void Main(string[] args)
        {
            string input = "";
            do
            {
                Person person = new Person();

                Console.Write("Enter the Firstname of the guest"+ "\n");
                person.Name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter the Lastname of the guest" + "\n");
                person.SurName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the relationship" + "\n");
                string value = Console.ReadLine();
                Console.WriteLine();

                TypeOfGuest relation = (TypeOfGuest)Enum.Parse(typeof(TypeOfGuest), value);
                person.GuestType = relation;
                people[size-1] = person;

                //foreach (var item in people)
                //{
                //    Console.WriteLine(item.Name);

                //}
                Console.WriteLine("More Guest? Y/N");
                input = Console.ReadLine();

                if (input=="y")
                {
                    size++;

                    Array.Resize(ref people, size);
                    Console.Clear();
                }

            } while (input.ToLower()=="y");
        }
    }
}
