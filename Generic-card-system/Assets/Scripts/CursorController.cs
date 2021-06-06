using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Marco, March 26 2021
//Marco, April 8th 2021
//Marco, April 11th 2021
public class CursorController : MonoBehaviour
{
    //Class Fields ________________________________________
    [Header("Survivor Movement")]
    [SerializeField] private LayerMask _groundMask;

    [Header("Interaction")]
    [SerializeField] private LayerMask _interactableMask;

    private Ray _mouseRay;

    //Unity Methods _______________________________________
    private void Update()
    {
        _mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

    }

    //Custom Methods _____________________________________
    public Vector3 GetMouseWorldPosition()
    {
        return GetWorldPosition(_mouseRay);
    }

    private Vector3 GetWorldPosition(Ray ray)
    {
        if(Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, _groundMask))
        {
            return hit.point;
        }

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        {
            if (groundPlane.Raycast(ray, out float distance))
            {
            return ray.GetPoint(distance);
            }
        }

        return Vector3.zero;
    }
}
