using UnityEngine;
using UnityEngine.UI;

public class CardSlot : Image
{
    public Card Card { get; private set; } = null;
    public bool IsEmpty => Card == null;

    public void SetCard(Card card)
    {
        Card = card;
        
        this.Card.Reveal();

        Debug.Log($"{card} => {CardSkinManager.GetCardIndex(card)}");
        
        this.sprite = CardSkinManager.GetSpriteOfCard(card);
    }

    public Card RemoveCard()
    {
        this.sprite = null;

        this.Card.Hide();
        
        var aux = Card;
        Card = null;
        return aux;
    }
}