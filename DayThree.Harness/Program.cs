using System;
using System.IO;
using System.Reflection;

namespace DayFour.Harness
{
    internal class Program
    {
        private static PasswordValidator _passwordValidator = new PasswordValidator();

        private static void Main(string[] args)
        {
            Console.WriteLine("Day 4 Harness!");
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "DayThree.Harness.DayFour.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var oldPolicyValid = 0;
                var newPolicyValid = 0;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (_passwordValidator.Validate(line))
                    {
                        oldPolicyValid++;
                    }

                    if (_passwordValidator.ValidateAnagram(line))
                    {
                        newPolicyValid++;
                    }
                }
                Console.WriteLine("Old Policy Valid Passcodes");
                Console.WriteLine(oldPolicyValid);


                Console.WriteLine("New Policy Valid Passcodes");
                Console.WriteLine(newPolicyValid);
            }

            
            Console.ReadKey();
        }
    }
}