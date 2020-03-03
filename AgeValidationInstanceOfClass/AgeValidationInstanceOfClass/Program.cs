using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeValidationInstanceOfClass
{
    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }

        public void amIOld()
        {
            if (age < 13 && age >= 0)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            age++;
            // age = age + 1;
        }

        static void Main(string[] args)
            {

            Console.WriteLine("Enter number of people");

            int T = int.Parse(Console.In.ReadLine());

                for (int i = 0; i < T; i++)
                {

                Console.WriteLine("Enter age of person.");

                int age = int.Parse(Console.In.ReadLine());

                // this pre-written code creates the instance of Person and runs some functions with it
                Person p = new Person(age);

                p.amIOld();

                    for (int j = 0; j < 3; j++)
                        {
                            p.yearPasses();
                        }

                p.amIOld();

                    Console.WriteLine();
                }
            }
    }
}