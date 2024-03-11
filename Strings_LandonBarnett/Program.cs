namespace Strings_LandonBarnett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a character :)");
            char myChar = Console.ReadKey().KeyChar;
            bool isLetter = Char.IsLetter(myChar);
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            Console.WriteLine("Please write a sentence :)");
            string myString1 = Console.ReadLine();
            Console.WriteLine("Please search for a word :)");
            string myString2 = Console.ReadLine();
            
            bool isWithin = myString1.Contains(myString2);
            Console.WriteLine($"{myString2} exists in '{myString1}', {isWithin}");
          
            



        }
    }
}