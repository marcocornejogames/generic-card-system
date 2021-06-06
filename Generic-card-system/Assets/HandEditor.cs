using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Marco, June 6th 2021 ________________________________________

[ExecuteInEditMode]
public class HandEditor : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private Hand _hand;
    [SerializeField] private HandOrganizer _handOrganizer;
    [SerializeField] private HorizontalLayoutGroup _layoutGroup;

    private void Awake()
    {
        _hand = GetComponentInParent<Hand>();
        _handOrganizer = GetComponent<HandOrganizer>();
        _layoutGroup = GetComponent<HorizontalLayoutGroup>();
    }

    private void Update()
    {
        UpdateCardParenting();
        _layoutGroup.spacing = _handOrganizer.SpaceBetweenCards;
    }

    private void UpdateCardParenting()
    {
        foreach (Card card in _hand.Cards)
        {
            if (card != null)
            {
                card.gameObject.transform.SetParent(this.transform, false);
            }
        }
    }
}
