using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public FloatVariable health, maxHealth;

   public void TakeDamage(float amount)
   {
    health.value -= amount;
    if(health.value <= 0)
    {
        health.value = 0;
        Debug.Log("You're Dead");
    }
   }
}
