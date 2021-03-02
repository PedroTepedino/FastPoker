using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.UI;

public class CardChooser : MonoBehaviour
{
    private Deck _deck;

    [SerializeField] private CardSlot _slot;

    private void Awake()
    {
        _deck = new Deck();
        
        Debug.Log(_deck.Cards.Count);
    }

    private void Start()
    {
        CardSkinManager.GameControls.Controls.ChangeCard.started += ChangeCard;
    }

    private void ChangeCard(InputAction.CallbackContext context)
    {
        Card previousCard = null;
        if (!_slot.IsEmpty)
        {
            previousCard = _slot.RemoveCard();
        }
        
        _slot.SetCard(_deck.GetRandomCard());

        if (previousCard != null)
        {
            _deck.InsertCard(previousCard);
        }
        
        Debug.Log(_deck.Cards.Count);
    }
}