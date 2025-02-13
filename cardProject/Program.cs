using Cards2;

Card card1 = new Card(Rank.Jack, Suit.Diamonds);
card1.FlipOver();
Console.WriteLine(card1.FaceUp);
Deck deck = new Deck();
deck.Print();


Deck deck2 = new Deck();
deck2.Shuffle();

Card topCard = new deck2.DrawCard();
Console.WriteLine($"Top card :  {topCard.Rank} of {topCard.Suit}");

Console.WriteLine("\nRemaining cards in the deck:");
foreach (var card in deck2)
{
    Console.WriteLine($"{card.Rank} of {card.Suit}");
}

