using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandlerr : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;
  
    private void Start()
    {
        gameActionObj.raise += Raise;
    }

    
    private void Raise(object obj)
    {
        onRaiseEvent.Invoke();
    }
}
