using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public JonID idObj;
    public UnityEvent startEvent;


    public void Start()
    {
        startEvent.Invoke();
    }
}
