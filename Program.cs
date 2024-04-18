namespace _0418_S4_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dictionary = [];

            dictionary['a'] = "Alaska";
            dictionary['b'] = "Belgium";
            dictionary['c'] = "China";
            DisplayDict(dictionary);

            Console.WriteLine("\nRemoving key 'c':");
            dictionary.Remove('c');
            DisplayDict(dictionary);
        }

        static void DisplayDict(Dictionary<char, string> dictionary)
        {
            foreach (KeyValuePair<char, string> kvp in dictionary)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
