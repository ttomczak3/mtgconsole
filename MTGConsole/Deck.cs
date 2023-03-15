public class Deck
{
    private List<Card> _cards = new List<Card>();

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public void DisplayDeck()
    {
        Console.WriteLine("Deck contents:");
        foreach (var card in _cards)
        {
            Console.WriteLine("- {0} ({1}): {2} Rarity: {3} Mana: {4} #{5}", card.Name, card.Type, card.Detail, card.Rarity, card.ManaCost, card.SetNumber);
        }
    }
}
