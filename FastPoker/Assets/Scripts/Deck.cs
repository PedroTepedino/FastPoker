using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Deck
{
    public List<Card> Cards { get; }

    public Deck()
    {
        Cards = CreateFreshCards();
    }

    public Card GetRandomCard()
    {
        var aux = Cards[Random.Range(0, Cards.Count - 1)];
        Cards.Remove(aux);
        return aux;
    }

    public void InsertCard(Card card)
    {
        Cards.Add(card);
    }

    private List<Card> CreateFreshCards()
    {
        var cardsList = new List<Card>();

        foreach (Suite suite in Enum.GetValues(typeof(Suite)))
        {
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                cardsList.Add(new Card(suite, value));
            }
        }

        return cardsList;
    }
}