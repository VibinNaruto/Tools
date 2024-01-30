using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
  public JonID idObj;
  public UnityEvent matchEvent, noMatchEvent;

  private void OnTriggerEnter(Collider other)
  {
    var tempObj = other.GetComponent<IDContainerBehavior>();
    if (tempObj == null) 
        return;
    
    var otherID = tempObj.idObj;
    if (otherID == idObj)
    {
        matchEvent.Invoke();
    }
    else
    {
        noMatchEvent.Invoke();
    }
  }

}
