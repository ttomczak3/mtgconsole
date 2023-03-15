class Program
{
    static void Main(string[] args)
    {
        var deck = new Deck();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add card to deck");
            Console.WriteLine("2. Display deck contents");
            Console.WriteLine("3. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter card name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter card type:");
                    var type = Console.ReadLine();
                    Console.WriteLine("Enter card detail:");
                    var detail = Console.ReadLine();
                    Console.WriteLine("Enter card rarity:");
                    var rarityChar = Console.ReadLine();
                    Console.WriteLine("Enter card mana cost:");
                    var manaCostStr = Console.ReadLine();
                    Console.WriteLine("Enter card set number");
                    var setNumber = Console.ReadLine();
                    if (int.TryParse(manaCostStr, out int manaCost) && char.TryParse(rarityChar, out char rarity))
                    {
                        var card = new Card { Name = name, Type = type, Detail = detail, Rarity = rarity, ManaCost = manaCost, SetNumber = setNumber };
                        deck.AddCard(card);
                    }
                    else
                    {
                        Console.WriteLine("Invalid mana cost or rarity.");
                    }
                    break;
                case "2":
                    deck.DisplayDeck();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
