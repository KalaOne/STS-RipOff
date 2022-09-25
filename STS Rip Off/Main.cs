
using STS_Rip_Off.Character;
using STS_Rip_Off.Units.Enemies;

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

        Enemy enemy = new Enemy(1,1);

        enemy.SlimeEnemyBuilder(enemy, null);
        enemy.PopulateListOfEnemies();
        // build enemy
        //  list of enemies
        // rng enemies
        // for starter get two enemies and let user decide which enemy to face
        // initiate battle

    }
}



