// File name: Ch10CardLib.cs
// Description: A demo for chapter 10, from 212 to 220.

using System;
using System.Collections.Generic;
using System.Text;

namespace Ch10CardLib {

	enum Suit {
		Club,
		Diamond,
		Heart,
		Spade
	};
	
	enum Rank {
		Ace,
		Deuce,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King
	};
	
	class Card {
		public readonly Suit suit;
		public readonly Rank rank;
		
		public Card(Suit newSuit, Rank newRank) {
			suit = newSuit;
			rank = newRank;
		}
		
		private Card() {
		}
		
		public override string ToString() {
			return "The " + rank + " of " + suit + "s";
		}
	} // end Card
	
	class Deck {
		private Card[] cards;
		
		public Deck() {
			cards = new Card[52];
			for (int suitVal=0; suitVal<4; suitVal++) {
				for (int rankVal=1; rankVal<14; rankVal++) {
					cards[suitVal*13+rankVal-1] = new Card((Suit)suitVal, (Rank)rankVal);
				}
			}
		}
		
		public Card GetCard(int cardNum) {
			if (cardNum >=0 && cardNum<= 51)
				return cards[cardNum];
			else
				throw (new System.ArgumentOutOfRangeException("CardNum",
					cardNum, "Value must be between 0 and 51."));
		}
		
		public void Shuffle() {
			Card[] newDeck = new Card[52];
			bool[] assigned = new bool[52];
			Random sourceGen = new Random();
			for(int i=0;i<52;i++)
			{
				int destCard = 0;
				bool foundCard = false;
				while(foundCard == false)
				{
					destCard = sourceGen.Next(52);
					if(assigned[destCard] == false)
						foundCard = true;
				}
				assigned[destCard] = true;
				newDeck[destCard] = cards[i];
			}
			newDeck.CopyTo(cards, 0);
		}
	} // end Deck
	
	public class Class1 {
		static void Main(string[] args) {
			Deck myDeck = new Deck();
			myDeck.Shuffle();
			for(int i=0; i<52; i++)
			{
				Card tempCard = myDeck.GetCard(i);
				Console.Write(tempCard.ToString());
				if (i != 51)
					Console.Write(", ");
				else
					Console.WriteLine();
			}
			Console.ReadKey();
		}
	} // end Class1
} // end namespace
