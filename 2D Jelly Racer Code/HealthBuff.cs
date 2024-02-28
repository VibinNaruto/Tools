using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerupEffect
{
   public float amount;

   public override void Apply(GameObject target)
   {
        Health healthComponent = target.GetComponent<Health>();
        if (healthComponent != null)
        {
            healthComponent.health += amount; 
            healthComponent.health = Mathf.Clamp(healthComponent.health, 0, healthComponent.maxHealth);
        }
   }
}
