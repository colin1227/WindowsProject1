using SwedishFlashCards.Models;

namespace SwedishFlashCards.Services
{
    public class FlashCardService
    {
        private readonly List<FlashCard> _cards = new()
        {
            // Basic words
            new FlashCard { Swedish = "Hej", English = "Hello" },
            new FlashCard { Swedish = "Tack", English = "Thank you" },
            new FlashCard { Swedish = "Ja", English = "Yes" },
            new FlashCard { Swedish = "Nej", English = "No" },
            new FlashCard { Swedish = "God morgon", English = "Good morning" },
            new FlashCard { Swedish = "God natt", English = "Good night" },
            new FlashCard { Swedish = "Hej då", English = "Goodbye" },
            new FlashCard { Swedish = "Förlåt", English = "Sorry" },
            new FlashCard { Swedish = "Ursäkta", English = "Excuse me" },
            new FlashCard { Swedish = "Varsågod", English = "You're welcome" },
            
            // Numbers
            new FlashCard { Swedish = "Ett", English = "One" },
            new FlashCard { Swedish = "Två", English = "Two" },
            new FlashCard { Swedish = "Tre", English = "Three" },
            new FlashCard { Swedish = "Fyra", English = "Four" },
            new FlashCard { Swedish = "Fem", English = "Five" },
            
            // Common nouns
            new FlashCard { Swedish = "Vatten", English = "Water" },
            new FlashCard { Swedish = "Mat", English = "Food" },
            new FlashCard { Swedish = "Hus", English = "House" },
            new FlashCard { Swedish = "Bil", English = "Car" },
            new FlashCard { Swedish = "Bok", English = "Book" },
            
            // Colors
            new FlashCard { Swedish = "Röd", English = "Red" },
            new FlashCard { Swedish = "Blå", English = "Blue" },
            new FlashCard { Swedish = "Grön", English = "Green" },
            new FlashCard { Swedish = "Gul", English = "Yellow" },
            new FlashCard { Swedish = "Svart", English = "Black" },
            new FlashCard { Swedish = "Vit", English = "White" },
            
            // Family
            new FlashCard { Swedish = "Familj", English = "Family" },
            new FlashCard { Swedish = "Mamma", English = "Mother" },
            new FlashCard { Swedish = "Pappa", English = "Father" },
            new FlashCard { Swedish = "Barn", English = "Child" },
        };

        public List<FlashCard> GetAllCards()
        {
            return _cards;
        }

        public FlashCard GetCard(int index)
        {
            if (index < 0 || index >= _cards.Count)
                return _cards[0];
            
            return _cards[index];
        }

        public int GetTotalCards()
        {
            return _cards.Count;
        }
    }
}
