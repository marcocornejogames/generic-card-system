using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private RectTransform _transform;

    private void Start()
    {
        _transform = this.GetComponent<RectTransform>();
    }

    public void CursorOn()
    {
        _transform.localScale *= 1.5f;
    }

    public void CursorOff()
    {
        _transform.localScale = new Vector3(1, 1, 1);
    }
}
