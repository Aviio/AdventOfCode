using System;
using System.Linq;

namespace DayFour
{
    public class PasswordValidator
    {
        public bool Validate(string input)
        {
            var split = input.Split(" ");
            return split.Distinct().Count() == split.Count();
        }

        public bool ValidateAnagram(string input)
        {
            var split = input.Split(" ");
            //work out some magic to do this more elegantly - im sure theres a way
            for (var i = 0; i < split.Length; i++)
            {
                split[i] = String.Concat(split[i].OrderBy(o => o));
            }
            return split.Count() == split.Distinct().Count();
        }
    }
}