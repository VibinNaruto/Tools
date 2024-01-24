using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Attributes/GameEvent")]
public class GameEvent : ScriptableObject
{
    public UnityEvent onEventRaised;

    public void Raise()
    {
        onEventRaised.Invoke();
    }
}

[CreateAssetMenu(menuName = "Single Attributes/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [Header("Player Attributes")]
    public int maxHealth = 100;
    public int currentHealth;

    [Header("Player Progress")]
    public int score;

    [Header("Events")]
    public GameEvent onPlayerDamaged;
    public GameEvent onPlayerScored;
    public GameEvent onPlayerDied;

    public void InitializePlayer()
    {
        currentHealth = maxHealth;
        score = 0;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        onPlayerDamaged.Raise();

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            onPlayerDied.Raise();
        }
    }

    public void AddScore(int scoreAmount)
    {
        score += scoreAmount;
        onPlayerScored.Raise();
    }
}
