using UnityEngine;
using UnityEngine.UI; 

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthbar;

    private bool isDead;

    public GameManagerCode gameManager;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }

    // Method to apply a health buff
    public void ApplyHealthBuff(float amount)
    {
        health += amount;
        // Ensure health doesn't exceed max health
        health = Mathf.Clamp(health, 0, maxHealth);
    }
}
