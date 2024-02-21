using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameActionn : ScriptableObject
{
  public UnityAction raise;

  public void RaiseAction()
  {
        raise?.Invoke();
  }
}
