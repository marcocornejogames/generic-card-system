using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Marco, March 26th 2021
public abstract class GameEventListener<T> : MonoBehaviour
{
    //Class Fields _______________________________________________
    [SerializeField] private GameEvent<T> _gameEvent;
    public UnityEvent<T> OnInvoke;
    
    //Unity Functions ____________________________________________
    private void OnEnable()
    {
        _gameEvent.OnInvoke.AddListener(GameEventInvoked);
    }

    private void OnDisable()
    {
        _gameEvent.OnInvoke.RemoveListener(GameEventInvoked);
    }

    //Custom Methods ___________________________________________
    private void GameEventInvoked(T param)
    {
        OnInvoke.Invoke(param);
    }
}
