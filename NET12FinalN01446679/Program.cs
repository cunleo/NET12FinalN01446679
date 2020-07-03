using System;

namespace NET12FinalN01446679
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[] { new Adult(), new Child() };


           foreach(Person operson in person)
            {
                Console.WriteLine(operson.firstName);
                Console.WriteLine(operson.lastName);
                Console.ReadLine();
            }

        }
        class Person
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
        }
        class Adult: Person
        {
            public String firstName { get; set; }
            public String lastName { get; set; }


            public Adult() //string firstname, String lastname)
            {
                base.firstName = "Smith";
                base.lastName = "James";
            }

        }
        class Child: Person
        {
            public String firstName { get; set; }
            public String lastName { get; set; }

            public Child() //string firstname, String lastname)
            {
                base.firstName = "Adams";
                base.lastName = "Jack";
            }
        }
    }
}
