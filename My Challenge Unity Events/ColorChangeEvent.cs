using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    [System.Serializable]
    public class ColorChangeEvent : UnityEvent<Color> { }

    public ColorChangeEvent onColorChange;

    private Renderer renderer;
    private Color originalColor;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    private void OnEnable()
    {
        ChangeColorRandom();
    }

    private void OnDisable()
    {
        renderer.material.color = originalColor;
    }

    private void ChangeColorRandom()
    {
        Color newColor = Random.ColorHSV();
        renderer.material.color = newColor;
        onColorChange.Invoke(newColor);
    }
}
