using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Marco, June 5th 2021 ___________________________________________________
public class Card : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private SpriteRenderer _spriteRenderer;


    [Header("Customization")]
    public Sprite CardFront;
    public Sprite CardBack;
    public bool FrontFacing = true;


    //_______________________________________________________UNITY METHODS
    private void Start()
    {
        _spriteRenderer.GetComponent<SpriteRenderer>();
    }
}

