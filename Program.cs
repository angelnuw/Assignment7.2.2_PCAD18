using System;
using System.Linq;

namespace Assignment7._2._2
{
    internal class Program
    {
        static string ReverseVowles(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }
                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }
                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
        static void Main(string[] args)
        {
            // Example usage
            string input = ("Hippopotomus");
            string result = ReverseVowles(input);
            Console.WriteLine(result); // Output: "Holle Werld!"
        }
    }
}
