using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Marco, June 5th 2021______________________________________________________

[ExecuteInEditMode]
public class CardEditor : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private Card _card;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    //_______________________________________________________UNITY METHODS
    private void Awake()
    {
        _card = GetComponent<Card>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        UpdateCardFace();
    }

    //_________________________________________________________CUSTOM METHODS
    private void UpdateCardFace()
    {
        _spriteRenderer.sprite = _card.FrontFacing ? _card.CardFront : _card.CardBack;
    }
}
