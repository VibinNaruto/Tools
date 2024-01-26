using UnityEngine;
using UnityEngine.Events;

public class ImagePopUp : MonoBehaviour
{
    public UnityEvent onCollision;

    private bool hasCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided)
        {
            hasCollided = true;
            onCollision.Invoke();
        }
    }
}
