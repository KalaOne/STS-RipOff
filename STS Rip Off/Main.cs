
using STS_Rip_Off.Character;

class Program
{
    static void Main()
    {
        Console.WriteLine("Greetings user!");

        Console.WriteLine("Which character would you like to play?");

        var userInput = Console.ReadLine();

        Character character = new Character();

        character.GetChacater(userInput.ToLower());

        Console.WriteLine(character.ToString());



    }
}



