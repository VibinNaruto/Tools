using UnityEngine;

[CreateAssetMenu(fileName = "PlayerHealth", menuName = "Health/PlayerHealth")]
public class PlayerHealth : ScriptableObject
{
    public float currentHealth;
    public float maxHealth;
}
