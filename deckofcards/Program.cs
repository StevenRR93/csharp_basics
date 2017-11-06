using System;
using System.Collections.Generic;
namespace deckofcards
{
    public class Card{
        public string stringval = "Ace";
        public string suit = "Clubs";
        public int val = 0;
        public Card(string sv, string s, int v)
        {
            stringval = sv;
            suit = s;
            val = v;
        }
        public void show(){
            Console.WriteLine("Stringval: " + stringval + " Suit: " + suit + " Val: " + val);
        }
    }
    public class Deck{
        //public Card[] cards = new Card[52];
        List<Card> cards = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 4; i++){
                for (int j = 0; j < 13; j++){
                    string suit = "";
                    string val = "";
                    if (i == 0){
                        suit = "Clubs";
                    }
                    else if(i == 1){
                        suit = "Spades";
                    }
                    else if(i == 2){
                        suit = "Hearts";
                    }
                    else {
                        suit = "Diamonds";
                    }
                    if (j == 0){
                        val = "Ace";
                    }
                    else if(j == 10){
                        val = "Jack";
                    }
                    else if(j == 11){
                        val = "Queen";
                    }
                    else if(j == 12){
                        val = "King";
                    }
                    else {
                        val = j.ToString();
                    }
                    Card temp = new Card(val, suit, j );
                    cards.Add(temp);
                }

            }
        }
        public List<Card> getCards(){
            return cards;
        }
        public Card top_most(){
            Card temp = cards[cards.Count-1];
            cards.RemoveAt(cards.Count-1);
            return temp;
        }
        public void reset(){
            List<Card> newdeck = new List<Card>();
            for (int i = 0; i < 4; i++){
                for (int j = 0; j < 13; j++){
                    string suit = "";
                    string val = "";
                    if (i == 0){
                        suit = "Clubs";
                    }
                    else if(i == 1){
                        suit = "Spades";
                    }
                    else if(i == 2){
                        suit = "Hearts";
                    }
                    else {
                        suit = "Diamonds";
                    }
                    if (j == 0){
                        val = "Ace";
                    }
                    else if(j == 10){
                        val = "Jack";
                    }
                    else if(j == 11){
                        val = "Queen";
                    }
                    else if(j == 12){
                        val = "King";
                    }
                    else {
                        val = j.ToString();
                    }
                    Card temp = new Card(val, suit, j );
                    newdeck.Add(temp);
                    newdeck[(i*13)+(j+1)-1].show();
                }

            }
            cards = newdeck;
        }

        public void shuffle(){
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++){
                int rnd = rand.Next(i, cards.Count-1);
                Card temp = cards[i];
                cards[i] = cards[rnd];
                cards[rnd] = temp;
                cards[i].show();
            }
        }
    }
    class Player
    {
        public static string name;
        public static List<Card> hand;
        public Player(string n){
            name = n;
             hand = new List<Card>();
        }
        public Card draw(Deck currentdeck){
            Card drawn = currentdeck.top_most();
            Console.WriteLine("You drew: ");
            drawn.show();
            hand.Add(drawn);
            return drawn;
        }
        public Card discard(int loc){
            if (loc < hand.Count){
                Card temp = hand[loc];
                hand.RemoveAt(loc);
                Console.WriteLine("You discarded: ");
                temp.show();
                return temp;
            }
            return null;

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Deck playingcards = new Deck();
            playingcards.shuffle();
            Console.WriteLine("*******************************************************");
            playingcards.reset();
            Player p = new Player("Player");
            p.draw(playingcards);
            p.discard(0);
        }
    }
}
