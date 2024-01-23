using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthbar;

    private bool isDead;

    public GameManagerCode gameManager;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }
}
