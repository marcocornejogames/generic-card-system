using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Marco, June 5th 2021 ___________________________________________________
public class Card : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private SpriteRenderer _spriteRenderer;


    [Header("Customization")]
    public Sprite CardFront;
    public Sprite CardBack;
    public bool FrontFacing = true;

    [Header("Events")]
    [SerializeField] private UnityEvent<Card> _addToPlayerHandEvent;


    //_______________________________________________________UNITY METHODS
    private void Start()
    {
        _spriteRenderer.GetComponent<SpriteRenderer>();
    }

    public void Click()
    {
        _addToPlayerHandEvent.Invoke(this);
    }
}

