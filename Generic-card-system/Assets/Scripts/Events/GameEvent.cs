using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Marco, Marco 26th 2021
public abstract class GameEvent<T> : ScriptableObject
{
    //Class Fields ___________________________________________
    public UnityEvent<T> OnInvoke;


    //Custom Methods ________________________________________
    public void Invoke(T param)
    {
        OnInvoke.Invoke(param);
    }
}
