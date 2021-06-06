using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Marco, June 5th 2021 ___________________________________________________
public class Deck : MonoBehaviour
{
    [Header("References")]
    public List<Card> Cards;

    private void Awake()
    {
        Cards = new List<Card>();
    }
    public void AddToDeck(Card card)
    {
        Debug.Log($"Trying to add {card.gameObject.name} to {this.gameObject.name}");
        foreach (Card cardInList in Cards)
        {
            if (card == cardInList) return;
        }

        Cards.Add(card);
    }
}
