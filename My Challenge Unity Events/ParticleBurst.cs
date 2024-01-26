using UnityEngine;
using UnityEngine.Events;

public class ParticleBurst : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnEnable()
    {
        StartParticleBurst();
    }

    private void OnDisable()
    {
        StopParticleBurst();
    }

    private void StartParticleBurst()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
            var mainModule = particleSystem.main;
            mainModule.simulationSpeed = 1.0f;
        }
    }

    private void StopParticleBurst()
    {
        if (particleSystem != null)
        {
            var mainModule = particleSystem.main;
            mainModule.simulationSpeed = 0.0f;
            particleSystem.Stop();
        }
    }
}
